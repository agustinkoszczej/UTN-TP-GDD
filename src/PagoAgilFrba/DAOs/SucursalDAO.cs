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
        public static List<Sucursal> obtener_todas_sucursales()
        {
                List<Sucursal> sucursales = new List<Sucursal>();
                string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Sucursal WHERE Sucursal_habilitada = 1");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Sucursal_codigo"].ToString());
                    string nombre = reader["Sucursal_nombre"].ToString();
                    string direccion = reader["Sucursal_direccion"].ToString();
                    int cod_postal = int.Parse(reader["Sucursal_codigo_postal"].ToString());

                    Sucursal suc = new Sucursal(id, nombre, direccion, cod_postal, true);
                    sucursales.Add(suc);
                }
                reader.Close();
                reader.Dispose();
                conn.Close();
                return sucursales;         
        }
        public static void cargar_funcionalidades_asignadas(Rol rol)
        {
            try
            {

                string query = string.Format(@"SELECT Func_codigo, Func_nombre FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad
                                         JOIN LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol ON (Func_codigo = FuncRol_func) 
                                         JOIN LORDS_OF_THE_STRINGS_V2.Rol ON (Rol_codigo = FuncRol_rol)
                                         WHERE Rol_codigo = @rol_id");

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