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

        public static bool agregar_pagos(List<Pago> _pagos)
        {
            try
            {
                SqlConnection conn = DBConnection.getConnection();
                string fecha_act = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                foreach (Pago pago in _pagos)
                {
                    string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Pago(Pago_fecha, Pago_importe, Pago_sucursal, Pago_forma_pago, Pago_factura) VALUES (CONVERT(datetime, @fecha_act, 121), @importe, @sucursal, @forma_pago, @factura)");
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@fecha_act", fecha_act); 
                    cmd.Parameters.AddWithValue("@importe", pago.importe);
                    cmd.Parameters.AddWithValue("@sucursal", pago.sucursal);
                    cmd.Parameters.AddWithValue("@forma_pago", pago.forma_pago);
                    cmd.Parameters.AddWithValue("@factura", pago.factura);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}