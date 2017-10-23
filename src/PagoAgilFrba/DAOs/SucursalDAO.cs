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
    public static class SucursalDAO
    {
        public static void buscar_sucursal(DataGridView _grillaSucursales, string _query, string _nombre, string _direccion, string _cod_postal)
        {
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(_query, conn);

            cmd.Parameters.AddWithValue("@nombre", _nombre);
            cmd.Parameters.AddWithValue("@direccion", _direccion);
            cmd.Parameters.AddWithValue("@cod_postal", _cod_postal);

            DataTable dataTable;
            SqlDataAdapter dataAdapter;

            try
            {
                dataAdapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();

                _grillaSucursales.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo realizar la consulta:\n" + e.Message);

            }
        }

        public static void cargar_grilla_sucursales(DataGridView grillaSucursales)
        {
            string query = string.Format(@"SELECT Sucursal_codigo Código, Sucursal_nombre Nombre, Sucursal_direccion Dirección, Sucursal_codigo_postal Código_Postal, Sucursal_habilitada Habilitada FROM LORDS_OF_THE_STRINGS_V2.Sucursal");
            DBConnection.llenar_grilla(grillaSucursales, query);
        }

        public static bool validar_cod_postal(int _cod_postal)
        {
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Sucursal WHERE Sucursal_codigo_postal=@cod_postal");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cod_postal", _cod_postal);
            return cmd.ExecuteScalar() == null;
        }

        #region ABM Sucursal

        public static bool agregar_sucursal(Sucursal sucursal)
        {
            try
            {
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Sucursal(Sucursal_nombre, Sucursal_direccion, Sucursal_codigo_postal) VALUES (@nombre, @direccion, @cod_postal); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
  
                cmd.Parameters.AddWithValue("@nombre", sucursal.nombre);
                cmd.Parameters.AddWithValue("@direccion", sucursal.direccion);
                cmd.Parameters.AddWithValue("@cod_postal", sucursal.cod_postal);

                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool borrar_sucursal(Sucursal sucursal)
        {
            try
            {
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand("LORDS_OF_THE_STRINGS_V2.sp_baja_sucursal", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_sucursal", sucursal.id);
                SqlParameter ret = new SqlParameter();
                ret.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(ret);
                cmd.ExecuteReader();
                conn.Close();
                return Convert.ToBoolean(ret.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool modificar_sucursal(Sucursal sucursal)
        {
            try
            {
                string query = string.Format(@"UPDATE LORDS_OF_THE_STRINGS_V2.Sucursal SET Sucursal_nombre=@nombre, Sucursal_direccion=@direccion, Sucursal_codigo_postal=@cod_postal WHERE Sucursal_codigo=@sucursal_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre", sucursal.nombre);
                cmd.Parameters.AddWithValue("@direccion", sucursal.direccion);
                cmd.Parameters.AddWithValue("@cod_postal", sucursal.cod_postal);
                cmd.Parameters.AddWithValue("@sucursal_id", sucursal.id);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        #endregion
    }
}