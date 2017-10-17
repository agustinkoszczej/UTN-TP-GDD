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
            var conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand("LORDS_OF_THE_STRINGS_V2.Login_Procedure_Validate", conn);
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
    }
}