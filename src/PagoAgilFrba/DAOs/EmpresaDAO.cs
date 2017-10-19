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
    public static class EmpresaDAO
    {

        public static List<Empresa> obtener_todas_empresas()
        {
            List<Empresa> empresas = new List<Empresa>();
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Empresa");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Empresa_codigo"].ToString());
                string cuit = reader["Empresa_cuit"].ToString();
                string nombre = reader["Empresa_nombre"].ToString();
                string direccion =  reader["Empresa_direccion"].ToString();
                bool habilitada = bool.Parse(reader["Empresa_habilitada"].ToString());

                Empresa empresa = new Empresa(id, cuit, nombre, direccion, habilitada);
                empresas.Add(empresa);
            }
            reader.Close();
            reader.Dispose();
            conn.Close();
            return empresas;
        }

        public static void cargar_grilla_empresas(DataGridView grillaEmpresas, bool habilitado)
        {
            string query = string.Format(@"SELECT Empresa_codigo Código, Empresa_cuit CUIT, Empresa_nombre Nombre, Empresa_direccion Dirección, Empresa_habilitada Habilitada FROM LORDS_OF_THE_STRINGS_V2.Empresa");
            if (habilitado)
            {
                query += " WHERE Empresa_habilitada = 1";
            }
            DBConnection.llenar_grilla(grillaEmpresas, query);
        }


        #region ABM Empresa

        public static bool agregar_empresa(Empresa empresa)
        {/*
            try
            {
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Rol(Rol_nombre) VALUES ('" + rol.nombre + "'); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.ExecuteNonQuery();
                int rol_cod_generado = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (Funcionalidad func in rol.funcionalidades)
                {
                    cmd = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol (FuncRol_rol, FuncRol_func) VALUES (" + rol_cod_generado + ", " + func.id + ")", conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            return false;
        }

        public static bool borrar_empresa(Empresa empresa)
        {/*
            try
            {
                string query = string.Format(@"UPDATE LORDS_OF_THE_STRINGS_V2.Rol SET Rol_habilitado = " + Convert.ToInt32(!rol.habilitado)+" WHERE Rol_codigo ='" + rol.id + "'");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                //TODO ver
                if (rol.habilitado)
                {
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Rol_Usuario WHERE RolUsua_rol=" + rol.id, conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Funcionalidad_Rol WHERE FuncRol_rol=" + rol.id, conn);
                    cmd.ExecuteNonQuery();
                }
                //TODO ver
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            return false;
        }
        public static bool modificar_empresa(Empresa empresa, List<Rubro> rubros_anteriores)
        {
            try
            {
                List<Rubro> rubros_nuevos = empresa.rubros.Where(emp_a => !rubros_anteriores.Any(emp_b => emp_a.id == emp_b.id)).ToList();
                List<Rubro> rubros_quitados = rubros_anteriores.Where(emp_b => !empresa.rubros.Any(emp_a => emp_b.id == emp_a.id)).ToList();

                string query = string.Format(@"UPDATE LORDS_OF_THE_STRINGS_V2.Empresa SET Empresa_cuit=@empresa_cuit, Empresa_nombre=@empresa_nombre, Empresa_direccion=@empresa_direccion WHERE Empresa_codigo=@empresa_id");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@empresa_cuit", empresa.cuit);
                cmd.Parameters.AddWithValue("@empresa_nombre", empresa.nombre);
                cmd.Parameters.AddWithValue("@empresa_direccion", empresa.direccion);
                cmd.Parameters.AddWithValue("@empresa_id", empresa.id);

                cmd.ExecuteNonQuery();
                //Inserto funcionalidades nuevas
                foreach (Rubro rubro in rubros_nuevos)
                {
                    cmd = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Rubro_Empresa (RubroEmpr_empresa, RubroEmpr_rubro) VALUES (@empresa, @rubro)", conn);
                    cmd.Parameters.AddWithValue("@empresa", empresa.id);
                    cmd.Parameters.AddWithValue("@rubro", rubro.id);
                    cmd.ExecuteNonQuery();
                }
                //Borro funcionalidades quitadas
                foreach (Rubro rubro in rubros_quitados)
                {
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Rubro_Empresa WHERE RubroEmpr_rubro=@rubro", conn);
                    cmd.Parameters.AddWithValue("@rubro", rubro.id);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        #endregion
    }
}