using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;

namespace PagoAgilFrba.DAOs
{
    class FacturaDAO
    {
        public static List<Empresa> obtener_empresas_habilitadas()
        {
            List<Empresa> empresas = new List<Empresa>();
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Empresa WHERE Empresa_habilitada = 1 ORDER BY Empresa_nombre");
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
            //0 = OK
            //1 = ERROR
            try
            {
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Factura(Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_rendicion) values(" +
                            "CAST(GETDATE() AS DATE)," + factura.total.ToString() + ",'" + factura.fechaCanonica + "'," + factura.empresa.id + "," + factura.cliente.id + ",NULL);", conn);
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
                return 0;
            }
            catch (Exception ex)
            {
                //rollback
                return 1;
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
            cli = new Cliente(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), uint.Parse(reader.GetValue(3).ToString()), DateTime.Parse(reader.GetValue(4).ToString()),reader.GetValue(5).ToString(),reader.GetValue(6).ToString(), true);
            conn.Close();
            return cli;
        }
    }
}
