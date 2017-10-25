using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.Model;

namespace PagoAgilFrba.DAOs
{
    class DevolucionDAO
    {

        public static bool agregar_devolucion(string motivo, Factura factura)
        {
            try
            {
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Devolucion(Devolucion_motivo, Devolucion_monto,Devolucion_factura )
                                           VALUES (@motivo, @monto, @factura)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@monto", factura.total);
                cmd.Parameters.AddWithValue("@factura", factura.id);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
