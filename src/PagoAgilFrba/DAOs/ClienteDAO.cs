using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PagoAgilFrba.Model;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace PagoAgilFrba.DAOs
{
    class ClienteDAO
    {
        public static void llenarDataGrid(DataGridView grid, string queryParam, string filtroNombre, string filtroApellido, int filtroDNI)
        {


            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(queryParam, conn);

            command.Parameters.AddWithValue("@nombre", filtroNombre);
            command.Parameters.AddWithValue("@apell", filtroApellido);

            command.Parameters.Add("@dni", SqlDbType.Int);
            command.Parameters["@dni"].Value = filtroDNI;

            DBConnection.llenar_grilla_command(grid, command);
        }

        public static int nuevoCliente(Cliente cli)
        {
            //0 error bd
            //1 mail repetido
            //2 OK

            try
            {
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Cliente(Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono) values(@DNI, @nombre, @apell, @fnac, @mail, @direc, @cp, @tel)", conn);

                comando.Parameters.Add("@DNI", SqlDbType.Int);
                comando.Parameters["@DNI"].Value = cli.dni;

                comando.Parameters.AddWithValue("@nombre", cli.nombre);

                comando.Parameters.AddWithValue("@apell", cli.apellido);

                comando.Parameters.Add("@fnac", SqlDbType.Date);
                comando.Parameters["@fnac"].Value = cli.fecha_nacimiento;

                comando.Parameters.AddWithValue("@mail", cli.mail);

                comando.Parameters.AddWithValue("@direc", cli.direccion);

                comando.Parameters.AddWithValue("@cp", cli.cod_postal);

                comando.Parameters.AddWithValue("@tel", cli.cod_postal);

                comando.ExecuteNonQuery();

                conn.Close();
                return 2;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    //error constraint unique
                    return 1;
                }

                return 0;
            }
        }

        public static int modificarCliente(Cliente cli)
        {
            //0 error bd
            //1 mail repetido
            //2 OK

            try
            {
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Cliente SET Cliente_dni = @DNI, Cliente_nombre = @nombre, Cliente_apellido = @apell, Cliente_fecha_nac = @fnac, Cliente_mail = @mail, Cliente_direccion = @direc, Cliente_codigo_postal = @cp, Cliente_telefono = @tel WHERE Cliente_codigo = @ID", conn);

                comando.Parameters.Add("@ID", SqlDbType.Int);
                comando.Parameters["@ID"].Value = cli.id;

                comando.Parameters.Add("@DNI", SqlDbType.Int);
                comando.Parameters["@DNI"].Value = cli.dni;

                comando.Parameters.AddWithValue("@nombre", cli.nombre);

                comando.Parameters.AddWithValue("@apell", cli.apellido);

                comando.Parameters.Add("@fnac", SqlDbType.Date);
                comando.Parameters["@fnac"].Value = cli.fecha_nacimiento;

                comando.Parameters.AddWithValue("@mail", cli.mail);

                comando.Parameters.AddWithValue("@direc", cli.direccion);

                comando.Parameters.AddWithValue("@cp", cli.cod_postal);

                comando.Parameters.AddWithValue("@tel", cli.telefono);

                comando.ExecuteNonQuery();

                conn.Close();
                return 2;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    //error constraint unique
                    return 1;
                }

                return 0;
            }
        }



        public static int habilitarClienteConID(int idCli, bool habilitado)
        {
            //0: error
            //1: OK
            try
            {
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Cliente SET Cliente_habilitado = @habil WHERE Cliente_codigo = @ID", conn);

                comando.Parameters.Add("@ID", SqlDbType.Int);
                comando.Parameters["@ID"].Value = idCli;
                comando.Parameters.Add("@habil", SqlDbType.Bit);
                comando.Parameters["@habil"].Value = habilitado;
                comando.ExecuteNonQuery();

                conn.Close();
                return 1;
            }
            catch (SqlException)
            {
                return 0;
            }
        }


        public static void llenarGridBuscarCliente(DataGridView grid, string dniCliente)
        {
            string query = string.Format(@"SELECT Cliente_codigo, Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono 
                                        FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_dni = @dni AND Cliente_habilitado = 1");
            
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conn);
            comando.Parameters.AddWithValue("@dni", dniCliente);
            DBConnection.llenar_grilla_command(grid, comando);
        }


        public static Cliente obtener_cliente_con_ID(int id_cliente)
        {
            List<Empresa> empresas = new List<Empresa>();
            string query = string.Format(@"SELECT Cliente_codigo, Cliente_nombre, Cliente_apellido, Cliente_dni, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1 AND Cliente_codigo = @idCliente");
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.Add("@idCliente", SqlDbType.Int);
            command.Parameters["@idCliente"].Value = id_cliente;

            command.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            Cliente cli;
            try
            {
                reader.Read();
                cli = new Cliente(
                    int.Parse(reader.GetValue(0).ToString()),                   //id
                    reader.GetValue(1).ToString(),                              //nombre
                    reader.GetValue(2).ToString(),                              //apellido
                    uint.Parse(reader.GetValue(3).ToString()),                  //dni
                    DateTime.Parse(reader.GetValue(4).ToString()),              //fnac
                    reader.GetValue(6).ToString(),                              //direccion
                    reader.GetValue(7).ToString(),                              //cp
                    reader.GetValue(5).ToString(),                              //mail
                    reader.GetValue(8).ToString(),                              //tel
                    true);
            }
            catch (Exception)
            {
                return null;
            }
            conn.Close();
            return cli;
        }
    }
}
