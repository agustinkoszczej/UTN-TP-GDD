using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PagoAgilFrba.Model;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace PagoAgilFrba.DAOs
{
    class ClienteDAO
    {
        public static List<Cliente> obtener_clientes(int habilitadas)
        {
            //0 = TODOS
            //1 = SOLO HABILITADOS
            List<Cliente> clientes = new List<Cliente>();
            string inic = "SELECT Cliente_codigo, Cliente_nombre, Cliente_apellido, YEAR(Cliente_fecha_nac), MONTH(Cliente_fecha_nac), DAY(Cliente_fecha_nac), Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono, Cliente_habilitado FROM LORDS_OF_THE_STRINGS_V2.Cliente";
           
            if (habilitadas == 1)
            {
                inic = inic + " WHERE Cliente_habilitado = 1 ORDER BY Cliente_nombre";
            }

            string query = string.Format(@inic);

            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                bool habil = false;
                if(reader.GetValue(8).ToString() == "1"){
                    habil = true;
                }

                Cliente cli = new Cliente(
                    int.Parse(reader.GetValue(0).ToString()), //id
                    reader.GetValue(1).ToString(), //nombre
                    reader.GetValue(2).ToString(), //apellido
                    uint.Parse(reader.GetValue(3).ToString()), //dni
                    new DateTime(int.Parse(reader.GetValue(3).ToString()),int.Parse(reader.GetValue(4).ToString()),int.Parse(reader.GetValue(5).ToString())),
                    reader.GetValue(6).ToString(),
                    reader.GetValue(7).ToString(),
                    habil);
                clientes.Add(cli);
            }
            conn.Close();
            return clientes;
        }

        public static void llenarDataGrid(DataGridView grid, string queryCompleta){
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
    }
}
