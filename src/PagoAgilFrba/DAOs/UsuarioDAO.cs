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
    public static class UsuarioDAO
    {

        public static int loguear_usuario(Usuario usuario)
        {
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand("LORDS_OF_THE_STRINGS_V2.sp_login_validate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", usuario.username);
            cmd.Parameters.AddWithValue("@password", usuario.password);
            SqlParameter ret = new SqlParameter();
            ret.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(ret);
            cmd.ExecuteReader();
            conn.Close();
            return (int) ret.Value;
        }

        public static void cargar_roles_asignados_usuario(Usuario usuario)
        {
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.fn_get_roles_usuario(@username)");

            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", usuario.username);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Rol_codigo"].ToString());
                string nombre = reader["Rol_nombre"].ToString();
                bool habilitado = Convert.ToBoolean(reader["Rol_habilitado"]);

                Rol rol = new Rol(id, nombre, habilitado);
                usuario.roles.Add(rol);
            }
            reader.Close();
            reader.Dispose();
            conn.Close();
        }
    }
}