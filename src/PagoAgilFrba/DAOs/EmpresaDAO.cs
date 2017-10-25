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

        public static Empresa obtener_empresa_con_ID(int id)
        {
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Empresa WHERE Empresa_codigo=@id");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string nombre = reader["Empresa_nombre"].ToString();
            string cuit = reader["Empresa_cuit"].ToString();
            string direccion = reader["Empresa_direccion"].ToString();
            bool habilitada = Convert.ToBoolean(reader["Empresa_habilitada"].ToString());

            Empresa empresa = new Empresa(id, cuit, nombre, direccion, habilitada);

            reader.Close();
            reader.Dispose();
            conn.Close();
            return empresa;
        }

        public static void buscar_empresa(DataGridView _grillaEmpresas, string _query, string _nombre, string _cuit)
        {
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(_query, conn);

            cmd.Parameters.AddWithValue("@nombre", _nombre);
            cmd.Parameters.AddWithValue("@cuit", _cuit);

            DataTable dataTable;
            SqlDataAdapter dataAdapter;
            
            try
            {
                dataAdapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();

                _grillaEmpresas.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo realizar la consulta:\n" + e.Message);
            }
        }

        public static bool validar_cuit(string _cuit)
        {
            string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Empresa WHERE Empresa_cuit=@cuit");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cuit", _cuit);
            return cmd.ExecuteScalar() == null;
        }

        public static void cargar_grilla_empresas(DataGridView grillaEmpresas)
        {
            string query = string.Format(@"SELECT Empresa_codigo Código, Empresa_nombre Nombre, Empresa_cuit CUIT, Empresa_direccion Dirección, Empresa_habilitada Habilitada FROM LORDS_OF_THE_STRINGS_V2.Empresa");
            DBConnection.llenar_grilla(grillaEmpresas, query);
        }


        #region ABM Empresa

        public static bool agregar_empresa(Empresa empresa)
        {
            try
            {
                string query = string.Format(@"INSERT INTO LORDS_OF_THE_STRINGS_V2.Empresa(Empresa_cuit, Empresa_nombre, Empresa_direccion) VALUES (@cuit, @nombre, @direccion); SELECT SCOPE_IDENTITY()");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cuit", empresa.cuit);
                cmd.Parameters.AddWithValue("@nombre", empresa.nombre);
                cmd.Parameters.AddWithValue("@direccion", empresa.direccion);

                int empresa_cod_generado = Convert.ToInt32(cmd.ExecuteScalar());
                foreach (Rubro rubro in empresa.rubros)
                {
                    cmd = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Rubro_Empresa (RubroEmpr_empresa, RubroEmpr_rubro) VALUES (@empresa_id, @rubro_id)", conn);

                    cmd.Parameters.AddWithValue("@empresa_id", empresa_cod_generado);
                    cmd.Parameters.AddWithValue("@rubro_id", rubro.id);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool borrar_empresa(Empresa empresa)
        {
            try
            {
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand("LORDS_OF_THE_STRINGS_V2.sp_baja_empresa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_empresa", empresa.id);
                SqlParameter ret = new SqlParameter();
                ret.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(ret);
                cmd.ExecuteReader();
                conn.Close();
                return Convert.ToBoolean(ret.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al borrar empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                //Inserto rubros nuevos
                foreach (Rubro rubro in rubros_nuevos)
                {
                    cmd = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Rubro_Empresa (RubroEmpr_empresa, RubroEmpr_rubro) VALUES (@empresa, @rubro)", conn);
                    cmd.Parameters.AddWithValue("@empresa", empresa.id);
                    cmd.Parameters.AddWithValue("@rubro", rubro.id);
                    cmd.ExecuteNonQuery();
                }
                //Borro rubros quitados
                foreach (Rubro rubro in rubros_quitados)
                {
                    cmd = new SqlCommand("DELETE FROM LORDS_OF_THE_STRINGS_V2.Rubro_Empresa WHERE RubroEmpr_rubro=@rubro AND RubroEmpr_empresa=@empresa", conn);
                    cmd.Parameters.AddWithValue("@rubro", rubro.id);
                    cmd.Parameters.AddWithValue("@empresa", empresa.id);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        #endregion
    }
}