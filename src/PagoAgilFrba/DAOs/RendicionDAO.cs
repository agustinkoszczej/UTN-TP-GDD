using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;

namespace PagoAgilFrba.DAOs
{
    class RendicionDAO
    {

        public static bool fn_empresa_rendida_este_mes(int idEmpresa)
        {
            string query = string.Format(@"SELECT LORDS_OF_THE_STRINGS_V2.fn_es_empresa_rendida_este_mes(@idEmpresa)");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            bool ret = bool.Parse(reader[0].ToString());
            
            reader.Close();
            reader.Dispose();
            conn.Close();

            return ret;
        }

        public static bool fn_empresa_rendida_mes_especifico(int idEmpresa, int mes, int anio)
        {
            string query = string.Format(@"SELECT LORDS_OF_THE_STRINGS_V2.fn_es_empresa_rendida_mes_especifico(@idEmpresa, @mes, @anio)");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
            cmd.Parameters.AddWithValue("@mes", mes);
            cmd.Parameters.AddWithValue("@anio", anio);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            bool ret = bool.Parse(reader[0].ToString());

            reader.Close();
            reader.Dispose();
            conn.Close();

            return ret;
        }

        public static void cargarGridFacturasPagadasEsteMes(DataGridView grid, Empresa selec)
        {
            string query = string.Format(@"SELECT DISTINCT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_cliente 
                                            FROM LORDS_OF_THE_STRINGS_V2.Factura F
                                            JOIN LORDS_OF_THE_STRINGS_V2.Pago P ON F.Factura_codigo = P.Pago_factura
                                            WHERE Factura_empresa = @idEmpresa AND F.Factura_rendicion IS NULL AND F.Factura_habilitada = 1 
                                            AND MONTH(P.Pago_fecha) = MONTH(GETDATE()) AND YEAR(P.Pago_fecha) = YEAR(GETDATE())");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add("@idEmpresa", SqlDbType.Int);
            command.Parameters["@idEmpresa"].Value = selec.id;

            DBConnection.llenar_grilla_command(grid, command);
        }

        public static void cargarGridFacturasPagadasMesEspecificado(DataGridView grid, Empresa selec, int mes, int anio)
        {
            string query = string.Format(@"SELECT DISTINCT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_cliente 
                                            FROM LORDS_OF_THE_STRINGS_V2.Factura F
                                            JOIN LORDS_OF_THE_STRINGS_V2.Pago P ON F.Factura_codigo = P.Pago_factura
                                            WHERE Factura_empresa = @idEmpresa AND F.Factura_rendicion IS NULL AND F.Factura_habilitada = 1 
                                            AND MONTH(P.Pago_fecha) = @mes AND YEAR(P.Pago_fecha) = @anio");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add("@idEmpresa", SqlDbType.Int);
            command.Parameters["@idEmpresa"].Value = selec.id;

            command.Parameters.Add("@mes", SqlDbType.Int);
            command.Parameters["@mes"].Value = mes;

            command.Parameters.Add("@anio", SqlDbType.Int);
            command.Parameters["@anio"].Value = anio;

            DBConnection.llenar_grilla_command(grid, command);
        }


        public static int nuevaRendicion(Model.Rendicion rend)
        {
            //0 error bd
            //ID OK                 

            try
            {
                var conn = DBConnection.getConnection();
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Rendicion(Rendicion_fecha, Rendicion_importe) VALUES (@fecha, @importe); SELECT SCOPE_IDENTITY();");

                SqlCommand comando = new SqlCommand(query, conn);

                comando.Parameters.Add("@fecha", SqlDbType.Date);
                comando.Parameters["@fecha"].Value = rend.fecha;

                comando.Parameters.Add("@importe", SqlDbType.Float);
                comando.Parameters["@importe"].Value = rend.importe;

                comando.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                string asd = reader.GetValue(0).ToString();
                int idRendicion = int.Parse(asd);
                reader.Close();

                conn.Close();
                return idRendicion;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

    }
}
