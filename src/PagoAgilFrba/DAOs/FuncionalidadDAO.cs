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
    public static class FuncionalidadDAO
    {
        public static List<Funcionalidad> obtener_todas_funcionalidades()
        {
                List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
                string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Func_codigo"].ToString());
                    string nombre = reader["Func_nombre"].ToString();

                    Funcionalidad func = new Funcionalidad(id, nombre);
                    funcionalidades.Add(func);
                }
                reader.Close();
                reader.Dispose();
                conn.Close();
            return funcionalidades;         
        }
        public static void cargar_funcionalidades_asignadas(Rol rol)
        {
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.fn_get_funcionalidades_rol(@rol_id)");

            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@rol_id", rol.id);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Func_codigo"].ToString());
                string nombre = reader["Func_nombre"].ToString();

                Funcionalidad func = new Funcionalidad(id, nombre);
                rol.funcionalidades.Add(func);
            }
            reader.Close();
            reader.Dispose();
            conn.Close();
        }

        public static void cargar_grilla_funcionalidades(DataGridView grillaFuncionalidades, Rol rol)
        {
            string query = string.Format(@"SELECT Func_codigo Código, Func_nombre Nombre FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad 
                                    JOIN LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol ON (Func_codigo = FuncRol_func)
                                    WHERE FuncRol_rol = '" + rol.id + "'");
            DBConnection.llenar_grilla(grillaFuncionalidades, query);
        }
    }
}