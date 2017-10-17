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
                    Funcionalidad func = new Funcionalidad(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString());
                    funcionalidades.Add(func);
                }
                conn.Close();
            return funcionalidades;         
        }
        public static void cargar_funcionalidades_asignadas(Rol rol)
        {
            try
            {

                string query = string.Format(@"SELECT Func_codigo, Func_nombre FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad
                                         JOIN LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol ON (Func_codigo = FuncRol_func) 
                                         JOIN LORDS_OF_THE_STRINGS_V2.Rol ON (Rol_codigo = FuncRol_rol)
                                         WHERE Rol_codigo = '" + rol.id + "'");

                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Funcionalidad func = new Funcionalidad(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString());
                    rol.funcionalidades.Add(func);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar las funcionalidades asignadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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