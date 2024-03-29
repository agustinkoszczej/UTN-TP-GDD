﻿using System;
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
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.DAOs
{
    class FacturaDAO
    {
        public static int estado_factura(int idFactura)
        {
            string query = string.Format(@"SELECT LORDS_OF_THE_STRINGS_V2.fn_estado_factura(@id_Factura)");

            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_Factura", idFactura);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int estado = int.Parse(reader.GetValue(0).ToString());
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return estado;
        }



        public static int ingresar_factura_e_items(Factura factura, List<Item_Factura> items)
        {
            //0 = ERROR  
            //ID = OK
            try
            {

                var conn = DBConnection.getConnection();
                string fecha_act = Utils.obtenerFecha().ToString("yyyy-MM-dd HH:mm:ss");   
        
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Factura(Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_rendicion) values(
                            CONVERT(datetime, @fecha_act, 121),@total,CONVERT(datetime, @fvenc, 121),@idEmpresa,@idCliente,NULL);SELECT SCOPE_IDENTITY()");
                
                SqlCommand comando = new SqlCommand(query, conn);

                comando.Parameters.Add("@total", SqlDbType.Float);
                comando.Parameters["@total"].Value = factura.total;

                comando.Parameters.AddWithValue("@fvenc", factura.fecha_venc);

                comando.Parameters.Add("@idEmpresa", SqlDbType.Int);
                comando.Parameters["@idEmpresa"].Value = factura.empresa.id;

                comando.Parameters.Add("@idCliente", SqlDbType.Int);
                comando.Parameters["@idCliente"].Value = factura.cliente.id;

                comando.Parameters.AddWithValue("@fecha_act", fecha_act); 

                          
                comando.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                int idFactura = int.Parse(reader.GetValue(0).ToString());
                reader.Close();
                reader.Dispose();

                foreach (Item_Factura fi in items)
                {
                    query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Item_Factura(ItemFactura_factura, ItemFactura_cantidad, ItemFactura_monto) values(@idFactura,@cantidad,@monto);");
                    comando = new SqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@idFactura", idFactura);
                    comando.Parameters.AddWithValue("@cantidad", fi.cantidad);
                    comando.Parameters.AddWithValue("@monto", fi.monto);
                    comando.ExecuteNonQuery();
                }

                comando.Dispose();
                conn.Close();
                conn.Dispose();
                return idFactura;
            }
            catch (Exception)
            {
                //rollback
                return 0;
            }
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
            reader.Close();
            reader.Dispose();
            command.Dispose();
            conn.Close();
            conn.Dispose();
            return items;
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
                conn = DBConnection.getConnection();
                foreach (Item_Factura it in factura.items)
                {
                    comando = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Item_Factura WHERE ItemFactura_factura = @IDF", conn);
                    comando.Parameters.Add("@IDF", SqlDbType.Int);
                    comando.Parameters["@IDF"].Value = factura.id;
                    comando.ExecuteNonQuery();
                }

                comando = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Factura WHERE Factura_codigo = @IDF", conn);
                comando.Parameters.Add("@IDF", SqlDbType.Int);
                comando.Parameters["@IDF"].Value = factura.id;
                comando.ExecuteNonQuery();
                comando.Dispose();
                conn.Close();
                conn.Dispose();
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
                SqlCommand comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Factura SET Factura_fecha = CONVERT(datetime, @nvaFecha, 121), Factura_total = @nvoTotal, Factura_fecha_venc = CONVERT(datetime, @nvoVenc, 121), Factura_empresa = @nvaEmpresa, Factura_cliente = @nvoCliente, Factura_rendicion = @nvaRendicion, Factura_habilitada = @habil WHERE Factura_codigo = @IDF", conn);

                comando.Parameters.AddWithValue("@nvaFecha", modificada.fecha); 

                comando.Parameters.Add("@nvoTotal", SqlDbType.Float);
                comando.Parameters["@nvoTotal"].Value = modificada.total;

                comando.Parameters.AddWithValue("@nvoVenc", modificada.fecha_venc); 

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

                comando.Parameters.Add("@habil", SqlDbType.Bit);
                comando.Parameters["@habil"].Value = modificada.habilitada;

                comando.Parameters.Add("@IDF", SqlDbType.Int);
                comando.Parameters["@IDF"].Value = modificada.id;
                comando.ExecuteNonQuery();
                comando.Dispose();
                conn.Close();
                conn.Dispose();
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
                comando.Dispose();
                conn.Close();
                conn.Dispose();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public static void cargarGridItemsFactura(DataGridView grid, Factura selec)
        {
            string query = string.Format(@"SELECT ItemFactura_codigo Codigo, ItemFactura_cantidad Cantidad, ItemFactura_monto Total
                                            FROM LORDS_OF_THE_STRINGS_V2.Item_Factura 
                                            WHERE ItemFactura_factura = @idFactura");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add("@idFactura", SqlDbType.Int);
            command.Parameters["@idFactura"].Value = selec.id;

            DBConnection.llenar_grilla_command(grid, command);

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static void cargarFacturasFiltrada(DataGridView grid, long idFiltro, string query, string nombreParam)
        {
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add(nombreParam, SqlDbType.BigInt);
            command.Parameters[nombreParam].Value = idFiltro;

            DBConnection.llenar_grilla_command(grid, command);

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

    }
}