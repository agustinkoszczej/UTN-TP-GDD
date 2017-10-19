﻿using System;
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

        public static List<Rol> obtener_todos_roles()
        {
            List<Rol> roles = new List<Rol>();
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Rol");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Rol_codigo"].ToString());
                string nombre = reader["Rol_nombre"].ToString();
                bool habilitada =  bool.Parse(reader["Rol_habilitado"].ToString());

                Rol rol = new Rol(id, nombre, habilitada);
                //Rol rol = new Rol(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), bool.Parse(reader.GetValue(2).ToString()));
                roles.Add(rol);
            }
            reader.Close();
            reader.Dispose();
            conn.Close();
            return roles;
        }

        public static void cargar_roles_asignados_usuario(Usuario usuario)
        {
            try
            {
                string query = string.Format(@"SELECT Rol_codigo, Rol_nombre FROM LORDS_OF_THE_STRINGS_V2.Rol
                                         JOIN LORDS_OF_THE_STRINGS_V2.Rol_Usuario ON (Rol_codigo = RolUsua_rol) 
                                         JOIN LORDS_OF_THE_STRINGS_V2.Usuario ON (Usuario_codigo = RolUsua_usuario)
                                         WHERE Usuario_username = @username AND Rol_habilitado = 1");

                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", usuario.username);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Rol_codigo"].ToString());
                    string nombre = reader["Rol_nombre"].ToString();

                    Rol rol = new Rol(id, nombre, true);
                    usuario.roles.Add(rol);
                }
                reader.Close();
                reader.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar Roles asignados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void cargar_grilla_roles(DataGridView grillaRoles, bool habilitado)
        {
            string query = string.Format(@"SELECT Rol_codigo Código, Rol_nombre Nombre, Rol_habilitado Habilitado FROM LORDS_OF_THE_STRINGS_V2.Rol");
            if (habilitado)
            {
                query += " WHERE Rol_habilitada = 1";
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
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol WHERE FuncRol_func=@func_id", conn);
                    cmd.Parameters.AddWithValue("@func_id", func.id);
                    
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