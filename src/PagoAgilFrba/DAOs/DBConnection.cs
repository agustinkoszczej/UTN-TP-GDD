﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace PagoAgilFrba.DAOs
{
    public static class DBConnection
    {
        private static string server = ConfigurationManager.AppSettings["server"].ToString();
        private static string user = ConfigurationManager.AppSettings["user"].ToString();
        private static string password = ConfigurationManager.AppSettings["password"].ToString();

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "SERVER=" + server + "\\SQLSERVER2012; DATABASE = GD2C2017;UID=" + user + ";PASSWORD=" + password + ";";
            conn.Open();
            return conn;
        }

        public static void llenar_grilla(DataGridView dataGridView, string consulta)
        {
            DataTable dataTable;
            SqlDataAdapter dataAdapter;

            SqlConnection conn = DBConnection.getConnection();
            try
            {
                dataAdapter = new SqlDataAdapter(consulta, conn);
                dataTable = new DataTable();

                dataGridView.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo realizar la consulta:\n" + e.Message);

            }
            conn.Close();
        }

        public static void llenar_grilla_command(DataGridView dataGrid, SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource source = new BindingSource();

            source.DataSource = table;
            dataGrid.DataSource = source;
            adapter.Update(table);
        }

        public static void llenar_grilla_ejecutando_SP(string sp, DataGridView grilla, Dictionary<String, int> parametros, string mensaje)
        {
            DataTable dataTable;
            SqlDataAdapter dataAdapter;

            try
            {
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(sp, conn);
                foreach (KeyValuePair<string, int> parametro in parametros)
                {
                    cmd.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value));
                }
                cmd.CommandType = CommandType.StoredProcedure;

                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No existen resultados para esta consulta", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    grilla.DataSource = dataTable;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
