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
        public static void llenarDataGrid(DataGridView grid, string queryCompleta)
        {
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(queryCompleta, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource source = new BindingSource();

            source.DataSource = table;
            grid.DataSource = source;
            adapter.Update(table);

        }

        public static List<Factura> obtenerNoRendidasYCargarGrid(DataGridView grid, Empresa selec)
        {
            string query = string.Format(@"SELECT DISTINCT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_cliente 
                                            FROM LORDS_OF_THE_STRINGS_V2.Factura F
                                            join LORDS_OF_THE_STRINGS_V2.Pago P on F.Factura_codigo = P.Pago_factura
                                            WHERE Factura_empresa = @idEmpresa AND MONTH(P.Pago_fecha) = MONTH(GETDATE()) AND F.Factura_rendicion IS NULL");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add("@idEmpresa", SqlDbType.Int);
            command.Parameters["@idEmpresa"].Value = selec.id;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource source = new BindingSource();

            source.DataSource = table;
            grid.DataSource = source;
            adapter.Update(table);
            
            List<Factura> facts = new List<Factura>();

            foreach(DataGridViewRow row in grid.Rows){
                if (row.Cells[0].Value != null)
                {
                    Factura f = new Factura(
                        int.Parse(row.Cells[0].Value.ToString()),
                        DateTime.Parse(row.Cells[1].Value.ToString()),
                        double.Parse(row.Cells[2].Value.ToString()),
                        DateTime.Parse(row.Cells[3].Value.ToString()),
                        selec,
                        new Cliente(int.Parse(row.Cells[4].Value.ToString()), "", "", 0, DateTime.Now, "", "", "", "", true),  //genero cualquier cliente, total no me importan aca
                        null);

                    facts.Add(f);
                }
            }

            return facts;

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
            catch (SqlException ex)
            {
                return 0;
            }
        }

    }
}
