﻿using System;
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
        public static bool validar_dni(long _dni)
        {
                string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_dni=@dni");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dni", _dni);
                bool rta = cmd.ExecuteScalar() == null;
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return rta;
        }

        public static bool validar_mail(string _mail)
        {
                string query = string.Format(@"SELECT * FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE UPPER(Cliente_mail) LIKE UPPER(@mail)");
                SqlConnection conn = DBConnection.getConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mail", _mail.Trim());
                bool rta = cmd.ExecuteScalar() == null;
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return rta;
        }


        public static void llenarDataGrid(DataGridView grid, string queryParam, string filtroNombre, string filtroApellido, long filtroDNI)
        {
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand command = new SqlCommand(queryParam, conn);

            command.Parameters.AddWithValue("@nombre", filtroNombre);
            command.Parameters.AddWithValue("@apell", filtroApellido);

            command.Parameters.Add("@dni", SqlDbType.BigInt);
            command.Parameters["@dni"].Value = filtroDNI;

            DBConnection.llenar_grilla_command(grid, command);
            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static int nuevoCliente(Cliente cli)
        {
            //0 error bd
            //1 mail repetido
            //2 OK

            if (!validar_dni(Convert.ToInt64(cli.dni)))
            {
                MessageBox.Show("El DNI ingresado ya existe", "Error DNI existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!validar_mail(cli.mail))
                {
                    MessageBox.Show("El mail ingresado ya existe", "Error mail existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 3;
                }
                return 2;
            }
            if (!validar_mail(cli.mail))
            {
                MessageBox.Show("El mail ingresado ya existe", "Error mail existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }

            try
            {
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("INSERT INTO LORDS_OF_THE_STRINGS_V2.Cliente(Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono) values(@DNI, @nombre, @apell, CONVERT(datetime, @fnac, 121), @mail, @direc, @cp, @tel)", conn);

                comando.Parameters.Add("@DNI", SqlDbType.BigInt);
                comando.Parameters["@DNI"].Value = cli.dni;

                comando.Parameters.AddWithValue("@nombre", cli.nombre);

                comando.Parameters.AddWithValue("@apell", cli.apellido);

                comando.Parameters.AddWithValue("@fnac", cli.fecha_nacimiento);

                comando.Parameters.AddWithValue("@mail", cli.mail);

                comando.Parameters.AddWithValue("@direc", cli.direccion);

                comando.Parameters.AddWithValue("@cp", cli.cod_postal);

                comando.Parameters.AddWithValue("@tel", cli.telefono);

                comando.ExecuteNonQuery();

                comando.Dispose();
                conn.Close();
                conn.Dispose();
                return 4;
            }
            catch (SqlException)
            {
                return 0;
            }
        }

        public static int modificarCliente(Cliente cli, long old_dni, string old_mail)
        {
            //0 error bd
            //1 mail repetido
            //2 OK
            if (old_dni != cli.dni)
            {
                if (!validar_dni(Convert.ToInt64(cli.dni)))
                {
                    MessageBox.Show("El DNI ingresado ya existe", "Error DNI existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     if (old_mail.Trim().ToUpper() != cli.mail.Trim().ToUpper())
                     {
                    if (!validar_mail(cli.mail))
                    {
                        MessageBox.Show("El mail ingresado ya existe", "Error mail existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 3;
                    }
                     }
                    return 2;
                }
            }
            if (old_mail.Trim().ToUpper() != cli.mail.Trim().ToUpper())
            {
                if (!validar_mail(cli.mail))
                {
                    MessageBox.Show("El mail ingresado ya existe", "Error mail existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }

            try
            {
                var conn = DBConnection.getConnection();
                SqlCommand comando = new SqlCommand("UPDATE LORDS_OF_THE_STRINGS_V2.Cliente SET Cliente_dni = @DNI, Cliente_nombre = @nombre, Cliente_apellido = @apell, Cliente_fecha_nac = CONVERT(datetime, @fnac, 121), Cliente_mail = @mail, Cliente_direccion = @direc, Cliente_codigo_postal = @cp, Cliente_telefono = @tel WHERE Cliente_codigo = @ID", conn);

                comando.Parameters.Add("@ID", SqlDbType.Int);
                comando.Parameters["@ID"].Value = cli.id;

                comando.Parameters.Add("@DNI", SqlDbType.BigInt);
                comando.Parameters["@DNI"].Value = cli.dni;

                comando.Parameters.AddWithValue("@nombre", cli.nombre);

                comando.Parameters.AddWithValue("@apell", cli.apellido);

                comando.Parameters.AddWithValue("@fnac", cli.fecha_nacimiento);

                comando.Parameters.AddWithValue("@mail", cli.mail);

                comando.Parameters.AddWithValue("@direc", cli.direccion);

                comando.Parameters.AddWithValue("@cp", cli.cod_postal);

                comando.Parameters.AddWithValue("@tel", cli.telefono);

                comando.ExecuteNonQuery();

                comando.Dispose();
                conn.Close();
                conn.Dispose();
                return 4;
            }
            catch (SqlException)
            {
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

                comando.Dispose();
                conn.Close();
                conn.Dispose();
                return 1;
            }
            catch (SqlException)
            {
                return 0;
            }
        }


        public static void llenarGridBuscarCliente(DataGridView grid, string dniCliente)
        {
            string query = string.Format(@"SELECT Cliente_codigo Código, Cliente_dni DNI, Cliente_nombre Nombre, Cliente_apellido Apellido, Cliente_fecha_nac Fecha_Nacimiento, Cliente_mail Mail, Cliente_direccion Dirección, Cliente_codigo_postal Código_Postal, Cliente_telefono Teléfono
                                        FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_dni = @dni AND Cliente_habilitado = 1");
            
            SqlConnection conn = DBConnection.getConnection();
            SqlCommand comando = new SqlCommand(query, conn);
            comando.Parameters.AddWithValue("@dni", dniCliente);
            DBConnection.llenar_grilla_command(grid, comando);

            comando.Dispose();
            conn.Close();
            conn.Dispose();
        }


        public static Cliente obtener_cliente_con_ID(int id_cliente)
        {
            List<Empresa> empresas = new List<Empresa>();
            string query = string.Format(@"SELECT Cliente_codigo, Cliente_nombre, Cliente_apellido, Cliente_dni, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono, Cliente_habilitado FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_codigo = @idCliente");
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
                int idCli = int.Parse(reader.GetValue(0).ToString());
                string nombreCli = reader.GetValue(1).ToString();
                string apellCli = reader.GetValue(2).ToString();
                long dniCli = long.Parse(reader.GetValue(3).ToString());
                DateTime fnacCli = DateTime.Parse(reader.GetValue(4).ToString());
                string direcCli = reader.GetValue(6).ToString();
                string cpCli = reader.GetValue(7).ToString();
                string mailCli = reader.GetValue(5).ToString();
                string telCli = reader.GetValue(8).ToString();
                bool habilCli = bool.Parse(reader.GetValue(9).ToString());
                cli = new Cliente(
                    idCli,                                                      //id
                    nombreCli,                                                  //nombre
                    apellCli,                                                   //apellido
                    dniCli,                                                     //dni
                    fnacCli,                                                    //fnac
                    direcCli,                                                   //direccion
                    cpCli,                                                      //cp
                    mailCli,                                                    //mail
                    telCli,                                                     //tel
                    habilCli);                                                  //habilitado
            }
            catch (Exception)
            {
                return null;
            }
            reader.Close();
            reader.Dispose();
            command.Dispose();
            conn.Close();
            conn.Dispose();
            return cli;
        }
    }
}
