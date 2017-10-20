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
        {//TODO: HACER ESTO EN UN TRANSACCION
            //0 = ERROR  
            //ID = OK
            try
            {
                string fechaCanonica = Utilidades.Utils.fechaACanonica(factura.fecha_venc);
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Factura(Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_rendicion) values(" +
                            "CAST(GETDATE() AS DATE)," + factura.total.ToString() + ",'" + fechaCanonica + "'," + factura.empresa.id + "," + factura.cliente.id + ",NULL);", conn);
                comando.ExecuteNonQuery();

                string query = string.Format(@"SELECT SCOPE_IDENTITY()");

                //conn = DBConnection.getConnection();
                comando = new SqlCommand(query, conn);
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
            catch (Exception ex)
            {
                //rollback
                return 0;
            }
        }

        public static Cliente obtener_cliente_con_ID(int id_cliente)
        {
            List<Empresa> empresas = new List<Empresa>();
            string query = string.Format(@"SELECT Cliente_codigo, Cliente_nombre, Cliente_apellido, Cliente_dni, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1 AND Cliente_codigo = " + id_cliente);
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            Cliente cli;
            reader.Read();
            cli = new Cliente(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), uint.Parse(reader.GetValue(3).ToString()), DateTime.Parse(reader.GetValue(4).ToString()), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), true);
            conn.Close();
            return cli;
        }


        public static List<Factura> obtener_facturas_no_pagas()
        {
            //select Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente  
            //from LORDS_OF_THE_STRINGS_V2.Factura F 
            //where F.Factura_codigo NOT IN (select Pago_factura from LORDS_OF_THE_STRINGS_V2.Pago)

            List<Empresa> empresas = obtener_empresas(0);

            List<Factura> facturas = new List<Factura>();
            string query;
            query = string.Format(@"select Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente  
            from LORDS_OF_THE_STRINGS_V2.Factura F 
            where F.Factura_codigo NOT IN (select Pago_factura from LORDS_OF_THE_STRINGS_V2.Pago)");
          
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Factura f = new Factura(int.Parse(reader.GetValue(0).ToString()), parseDate("dd-MM-yyyy s:HH:mm", reader.GetValue(1).ToString()), double.Parse(reader.GetValue(2).ToString()), parseDate("dd-MM-yyyy H:mm:ss", reader.GetValue(3).ToString()), filtrarEmpresaConID(empresas, int.Parse(reader.GetValue(4).ToString())), obtener_cliente_con_ID(int.Parse(reader.GetValue(5).ToString())), null);
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

        private static DateTime parseDate(string format, string date)
        {
            try
            {
                return DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                return DateTime.Now; //Tratando de parsear las fechas
            }
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
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}