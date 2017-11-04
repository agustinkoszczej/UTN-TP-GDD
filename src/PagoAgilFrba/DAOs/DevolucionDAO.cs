using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.DAOs
{
    class DevolucionDAO
    {

        public static bool agregar_devolucion(string motivo, Factura factura)
        {
            try
            {
                string fecha_act = Utils.obtenerFecha().ToString("yyyy-MM-dd HH:mm:ss");

                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Devolucion(Devolucion_motivo, Devolucion_monto, Devolucion_factura, Devolucion_fecha)
                                           VALUES (@motivo, @monto, @factura, CONVERT(datetime, @fecha_act, 121))");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@fecha_act", fecha_act); 
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@monto", factura.total);
                cmd.Parameters.AddWithValue("@factura", factura.id);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
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
