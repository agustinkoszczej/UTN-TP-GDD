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
    public static class RolDAO
    {

        public static bool validar_nombre(string _nombre)
        {
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Rol WHERE Rol_nombre=@nombre");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nombre", _nombre);
            return (cmd.ExecuteScalar() == null);
        }

        public static void cargar_grilla_roles(DataGridView grillaRoles, bool habilitado)
        {
            string query = string.Format(@"SELECT Rol_codigo Código, Rol_nombre Nombre, Rol_habilitado Habilitado FROM LORDS_OF_THE_STRINGS_V2.Rol");
            if (habilitado)
            {
                query += " WHERE Rol_habilitado = 1";
            }
                DBConnection.llenar_grilla(grillaRoles, query);
        }


        #region ABM Roles
        /// ABM Roles
        public static bool agregar_rol(Rol rol)
        {
            try
            {
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Rol(Rol_nombre) VALUES (@rol_nombre); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rol_nombre", rol.nombre);

                int rol_cod_generado = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (Funcionalidad func in rol.funcionalidades)
                {
                    cmd = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol (FuncRol_rol, FuncRol_func) VALUES (@rol_id, @func_id)", conn);

                    cmd.Parameters.AddWithValue("@rol_id", rol_cod_generado);
                    cmd.Parameters.AddWithValue("@func_id", func.id);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool borrar_rol(Rol rol)
        {
            try
            {
                string query = string.Format(@"UPDATE LORDS_OF_THE_STRINGS_V2.Rol SET Rol_habilitado = @rol_hab WHERE Rol_codigo=@rol_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@rol_hab", Convert.ToInt32(!rol.habilitado));
                cmd.Parameters.AddWithValue("@rol_id", rol.id);

                cmd.ExecuteNonQuery();
                //TODO ver
                if (rol.habilitado)
                {
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Rol_Usuario WHERE RolUsua_rol=@rol_id", conn);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);
                    
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol WHERE FuncRol_rol=@rol_id", conn);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);
                    
                    cmd.ExecuteNonQuery();
                }
                //TODO ver
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public static bool modificar_rol(Rol rol, List<Funcionalidad> funcionalidades_anteriores)
        {
            try
            {
                List<Funcionalidad> funcionalidades_nuevas = rol.funcionalidades.Where(func_a => !funcionalidades_anteriores.Any(func_b => func_a.id == func_b.id)).ToList();
                List<Funcionalidad> funcionalidades_quitadas = funcionalidades_anteriores.Where(func_b => !rol.funcionalidades.Any(func_a => func_b.id == func_a.id)).ToList();
                string query = string.Format(@"UPDATE LORDS_OF_THE_STRINGS_V2.Rol SET Rol_nombre=@rol_nombre WHERE Rol_codigo=@rol_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rol_nombre", rol.nombre);
                cmd.Parameters.AddWithValue("@rol_id", rol.id);

                cmd.ExecuteNonQuery();
                //Inserto funcionalidades nuevas
                foreach (Funcionalidad func in funcionalidades_nuevas)
                {
                    cmd = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol (FuncRol_rol, FuncRol_func) VALUES (@rol_id, @func_id)", conn);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);
                    cmd.Parameters.AddWithValue("@func_id", func.id);
                    
                    cmd.ExecuteNonQuery();
                }
                //Borro funcionalidades quitadas
                foreach (Funcionalidad func in funcionalidades_quitadas)
                {
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol WHERE FuncRol_func=@func_id AND FuncRol_rol=@rol_id", conn);
                    cmd.Parameters.AddWithValue("@func_id", func.id);
                    cmd.Parameters.AddWithValue("@rol_id", rol.id);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        #endregion
    }
}