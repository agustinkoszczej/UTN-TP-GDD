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
    public static class PagoDAO
    {
        public static void buscar_factura(DataGridView _grillaFacturas, string _query, string _nro_factura, string _dni)
        {          
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(_query, conn);

            cmd.Parameters.AddWithValue("@nro_factura", _nro_factura);
            cmd.Parameters.AddWithValue("@dni", _dni);

            DataTable dataTable;
            SqlDataAdapter dataAdapter;

            try
            {
                dataAdapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();

                _grillaFacturas.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo realizar la consulta:\n" + e.Message);

            }
        }

    }
}