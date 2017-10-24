using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;

namespace PagoAgilFrba.DAOs
{
    class FacturaDAO
    {
        public static List<Empresa> obtener_empresas(int habilitadas)
        {
            //0 = TODAS
            //1 = SOLO HABILITADAS
            List<Empresa> empresas = new List<Empresa>();
            string query;
            if (habilitadas == 1)
            {
                query = string.Format(@"SELECT Empresa_codigo, Empresa_cuit, Empresa_nombre, Empresa_direccion FROM LORDS_OF_THE_STRINGS_V2.Empresa WHERE Empresa_habilitada = 1 ORDER BY Empresa_nombre");
            }
            else
            {
                query = string.Format(@"SELECT Empresa_codigo, Empresa_cuit, Empresa_nombre, Empresa_direccion FROM LORDS_OF_THE_STRINGS_V2.Empresa ORDER BY Empresa_nombre");
            }


            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Empresa emp = new Empresa(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), true);
                empresas.Add(emp);
            }
            conn.Close();
            return empresas;
        }

        public static int ingresar_factura_e_items(Factura factura, List<Item_Factura> items)
        {
            //0 = ERROR  
            //ID = OK
            try
            {

                var conn = DBConnection.getConnection();
                              
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Factura(Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_rendicion) values(" +
                            "CAST(GETDATE() AS DATE),@total,@fvenc,@idEmpresa,@idCliente,NULL);SELECT SCOPE_IDENTITY()");
                
                SqlCommand comando = new SqlCommand(query, conn);

                comando.Parameters.Add("@total", SqlDbType.Float);
                comando.Parameters["@total"].Value = factura.total;
                comando.Parameters.Add("@fvenc", SqlDbType.Date);
                comando.Parameters["@fvenc"].Value = factura.fecha_venc;
                comando.Parameters.Add("@idEmpresa", SqlDbType.Int);
                comando.Parameters["@idEmpresa"].Value = factura.empresa.id;
                comando.Parameters.Add("@idCliente", SqlDbType.Int);
                comando.Parameters["@idCliente"].Value = factura.cliente.id;

                          
                comando.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                int idFactura = int.Parse(reader.GetValue(0).ToString());
                reader.Close();

                foreach (Item_Factura fi in items)
                {
                    comando = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Item_Factura(ItemFactura_factura, ItemFactura_cantidad, ItemFactura_monto) values(" +
                             idFactura.ToString() + "," + fi.cantidad + "," + fi.monto + ");", conn);
                    comando.ExecuteNonQuery();
                }

                conn.Close();
                return idFactura;
            }
            catch (Exception)
            {
                //rollback
                return 0;
            }
        }

        public static Cliente obtener_cliente_con_ID(int id_cliente)
        {
            List<Empresa> empresas = new List<Empresa>();
            string query = string.Format(@"SELECT Cliente_codigo, Cliente_nombre, Cliente_apellido, Cliente_dni, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1 AND Cliente_codigo = @idCliente");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add("@idCliente", SqlDbType.Int);
            command.Parameters["@idCliente"].Value = id_cliente;

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            Cliente cli;
            try
            {
                reader.Read();
                cli = new Cliente(
                    int.Parse(reader.GetValue(0).ToString()),                   //id
                    reader.GetValue(1).ToString(),                              //nombre
                    reader.GetValue(2).ToString(),                              //apellido
                    uint.Parse(reader.GetValue(3).ToString()),                  //dni
                    DateTime.Parse(reader.GetValue(4).ToString()),              //fnac
                    reader.GetValue(6).ToString(),                              //direccion
                    reader.GetValue(7).ToString(),                              //cp
                    reader.GetValue(5).ToString(),                              //mail
                    reader.GetValue(8).ToString(),                              //tel
                    true);
            }
            catch (Exception)
            {
                return null;
            }
            conn.Close();
            return cli;
        }


        public static List<Factura> obtener_facturas_no_pagas()
        {
            List<Empresa> empresas = obtener_empresas(0);

            List<Factura> facturas = new List<Factura>();
            string query;
            query = string.Format(@"SELECT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente  
            FROM LORDS_OF_THE_STRINGS_V2.Factura F 
            WHERE F.Factura_codigo NOT IN (select Pago_factura from LORDS_OF_THE_STRINGS_V2.Pago)");
          
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Factura f = new Factura(
                                            int.Parse(reader.GetValue(0).ToString()),
                                            DateTime.Parse(reader.GetValue(1).ToString()),
                                            double.Parse(reader.GetValue(2).ToString()),
                                            DateTime.Parse(reader.GetValue(3).ToString()), 
                                            filtrarEmpresaConID(empresas, int.Parse(reader.GetValue(4).ToString())), 
                                            obtener_cliente_con_ID(int.Parse(reader.GetValue(5).ToString())), 
                                            null);
                facturas.Add(f);
            }
            conn.Close();

            foreach (Factura f in facturas)
            {
                f.items = obtener_items_factura(f);
            }

            return facturas;
        }

        public static List<Item_Factura> obtener_items_factura(Factura factura)
        {
            List<Item_Factura> items = new List<Item_Factura>();
            string query = string.Format(@"SELECT ItemFactura_codigo, ItemFactura_cantidad, ItemFactura_monto FROM LORDS_OF_THE_STRINGS_V2.Item_Factura WHERE ItemFactura_Factura = @idFactura;");

            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);
            //command.Parameters.AddWithValue("@idFactura", factura.id.ToString());
            command.Parameters.Add("@idFactura", SqlDbType.Int);
            command.Parameters["@idFactura"].Value = factura.id;
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader.GetValue(0).ToString());
                int cantidad = int.Parse(reader.GetValue(1).ToString());
                double monto = double.Parse(reader.GetValue(2).ToString());
                Item_Factura it = new Item_Factura(id,monto, cantidad, factura);
                items.Add(it);
            }
            conn.Close();
            return items;
        }

        private static DateTime crearDateTime(int anno, int mes, int dia)
        {
            return new DateTime(anno, mes, dia);
        }

        private static Empresa filtrarEmpresaConID(List<Empresa> lista, int idEmp)
        {
            foreach (Empresa emp in lista)
            {
                if (emp.id == idEmp)
                {
                    return emp;
                }
            }
            return null;
        }

        public static int borrar_factura_e_items(Factura factura)
        {
            //0 = ERROR
            //1 = OK
            SqlConnection conn;
            SqlCommand comando;
            try
            {
                foreach (Item_Factura it in factura.items)
                {
                    conn = DBConnection.getConnection();
                    comando = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Item_Factura WHERE ItemFactura_factura = @IDF", conn);
                    comando.Parameters.Add("@IDF", SqlDbType.Int);
                    comando.Parameters["@IDF"].Value = factura.id;
                    comando.ExecuteNonQuery();
                }

                conn = DBConnection.getConnection();
                comando = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Factura WHERE Factura_codigo = @IDF", conn);
                comando.Parameters.Add("@IDF", SqlDbType.Int);
                comando.Parameters["@IDF"].Value = factura.id;
                comando.ExecuteNonQuery();

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int modificarFactura(Factura modificada)
        {
            try
            {
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Factura SET Factura_fecha = @nvaFecha, Factura_total = @nvoTotal, Factura_fecha_venc = @nvoVenc, Factura_empresa = @nvaEmpresa, Factura_cliente = @nvoCliente, Factura_rendicion = @nvaRendicion WHERE Factura_codigo = @IDF", conn);

                comando.Parameters.AddWithValue("@nvaFecha", Utilidades.Utils.fechaACanonica(modificada.fecha));

                comando.Parameters.Add("@nvoTotal", SqlDbType.Float);
                comando.Parameters["@nvoTotal"].Value = modificada.total;

                comando.Parameters.AddWithValue("@nvoVenc", Utilidades.Utils.fechaACanonica(modificada.fecha_venc));

                comando.Parameters.Add("@nvaEmpresa", SqlDbType.Int);
                comando.Parameters["@nvaEmpresa"].Value = modificada.empresa.id;

                comando.Parameters.Add("@nvoCliente", SqlDbType.Int);
                comando.Parameters["@nvoCliente"].Value = modificada.cliente.id;

                if (modificada.rendicion != null)
                {
                    comando.Parameters.Add("@nvaRendicion", SqlDbType.Int);
                    comando.Parameters["@nvaRendicion"].Value = modificada.rendicion.id;
                }
                else
                {
                    comando.Parameters.Add("@nvaRendicion", SqlDbType.Int);
                    comando.Parameters["@nvaRendicion"].Value = DBNull.Value;
                }

                comando.Parameters.Add("@IDF", SqlDbType.Int);
                comando.Parameters["@IDF"].Value = modificada.id;
                comando.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int modificarItems(int idFactura, List<Item_Factura> modificadosYNuevos, List<Item_Factura> borrados, double total){
            try
            {
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand comando;

                
                foreach (Item_Factura it in modificadosYNuevos)
                {

                    //TODO: HACER ESTO EN TRANSACCION
                    if (it.nuevo) //INSERT A LOS NUEVOS
                    {
                        comando = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Item_Factura(ItemFactura_factura, ItemFactura_cantidad, ItemFactura_monto) VALUES(@nvaFactura, @nvaCantidad, @nvoMonto)", conn);

                    }
                    else  //UPDATE A LOS MODIFICADOS
                    {
                        comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Item_Factura SET ItemFactura_factura = @nvaFactura, ItemFactura_cantidad = @nvaCantidad, ItemFactura_monto = @nvoMonto WHERE ItemFactura_codigo = @IDIF", conn);

                        comando.Parameters.Add("@IDIF", SqlDbType.Int);
                        comando.Parameters["@IDIF"].Value = it.id;         
                    }
                    comando.Parameters.Add("@nvaFactura", SqlDbType.Int);
                    comando.Parameters["@nvaFactura"].Value = it.factura.id;

                    comando.Parameters.Add("@nvaCantidad", SqlDbType.Int);
                    comando.Parameters["@nvaCantidad"].Value = it.cantidad;

                    comando.Parameters.Add("@nvoMonto", SqlDbType.Float);
                    comando.Parameters["@nvoMonto"].Value = it.monto;

                    comando.ExecuteNonQuery();
                }

                //DELETE A LOS BORRADOS
                foreach (Item_Factura it in borrados)
                {
                    comando = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Item_Factura WHERE ItemFactura_codigo = @IDIF", conn);
                    comando.Parameters.Add("@IDIF", SqlDbType.Int);
                    comando.Parameters["@IDIF"].Value = it.id;
                    comando.ExecuteNonQuery();
                }

                //UPDATE AL TOTAL
                comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Factura SET Factura_total = @nvoTotal WHERE Factura_codigo = @IDF", conn);

                comando.Parameters.Add("@nvoTotal", SqlDbType.Float);
                comando.Parameters["@nvoTotal"].Value = total;

                comando.Parameters.Add("@IDF", SqlDbType.Int);
                comando.Parameters["@IDF"].Value = idFactura;
                comando.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}