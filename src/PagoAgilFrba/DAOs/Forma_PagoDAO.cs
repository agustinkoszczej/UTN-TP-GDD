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
    public static class Forma_PagoDAO
    {
        public static List<Forma_Pago> obtener_formas_de_pago()
        {
            List<Forma_Pago> formas_pago = new List<Forma_Pago>();
                string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Forma_Pago");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["FormaPago_codigo"].ToString());
                    string descripcion = reader["FormaPago_descripcion"].ToString();

                    Forma_Pago forma = new Forma_Pago(id, descripcion);
                    formas_pago.Add(forma);
                }
                reader.Close();
                reader.Dispose();
                conn.Close();
                return formas_pago;         
        }
    }
}