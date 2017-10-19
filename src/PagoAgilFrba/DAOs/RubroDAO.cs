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
    public static class RubroDAO
    {
        public static List<Rubro> obtener_todos_rubros()
        {
                List<Rubro> rubros = new List<Rubro>();
                string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Rubro");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Rubro_codigo"].ToString());
                    string descripcion = reader["Rubro_descripcion"].ToString();

                    Rubro rubro = new Rubro(id, descripcion);
                    rubros.Add(rubro);
                }
                reader.Close();
                reader.Dispose();
                conn.Close();
                return rubros;         
        }
 
        public static void cargar_grilla_rubros(DataGridView grillaRubros, Empresa empresa)
        {
            string query = string.Format(@"SELECT Rubro_codigo Código, Rubro_descripcion Descripcion FROM LORDS_OF_THE_STRINGS_V2.Rubro 
                                    JOIN LORDS_OF_THE_STRINGS_V2.Rubro_Empresa ON (Rubro_codigo = RubroEmpr_rubro)
                                    WHERE RubroEmpr_empresa = '" + empresa.id + "'");

            DBConnection.llenar_grilla(grillaRubros, query);
        }
    }
}