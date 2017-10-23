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
            string query = string.Format(@"SELECT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_cliente FROM LORDS_OF_THE_STRINGS_V2.Factura WHERE Factura_empresa = @idEmpresa AND Factura_rendicion IS NULL;");
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
                Factura f = new Factura(
                    int.Parse(row.Cells[0].Value.ToString()),
                    DateTime.ParseExact(row.Cells[1].Value.ToString(), "dd/MM/yyyy 0:00:00", CultureInfo.InvariantCulture),
                    double.Parse(row.Cells[2].Value.ToString()),
                    DateTime.ParseExact(row.Cells[3].Value.ToString(), "dd/MM/yyyy 0:00:00", CultureInfo.InvariantCulture),
                    selec,
                    new Cliente(int.Parse(row.Cells[4].Value.ToString()), "", "", 0, DateTime.Now, "", "", "", "", true),  //genero cualquier empresa y cliente, total no me importan aca
                    null);

                facts.Add(f);
            }

            return facts;

        }

    }
}
