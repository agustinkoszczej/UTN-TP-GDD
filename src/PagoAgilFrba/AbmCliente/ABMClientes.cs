using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using PagoAgilFrba.DAOs;
using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.AbmCliente
{
    public partial class ABMClientes : Form
    {
        DataGridViewRow selectedRow = null;
        Cliente cargado = null;
        bool filtrando = false;
        string filtroNombre = "";
        string filtroApellido = ""; 
        string filtroDNI = "";

        List<Control> camposObligatorios;

        public ABMClientes()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cargado != null)
            {
                modificarCliente();
            }
            else
            {
                nuevoCliente();
            }
        }

        private void nuevoCliente()
        {
            if (Utils.cumple_campos_obligatorios(camposObligatorios, errorProvider) && datePickerFNAC.Value < DateTime.Now)
            {
                uint dni;
                try
                {
                    dni = uint.Parse(txtDNI.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dni invalido");
                    return;
                }

                Cliente cli = new Cliente(0, txtNombre.Text, txtApellido.Text, dni, datePickerFNAC.Value, txtDireccion.Text, txtCP.Text, txtMail.Text, txtTelefono.Text, true);
                int ex = ClienteDAO.nuevoCliente(cli);

                switch (ex)
                {
                    case 0:
                        MessageBox.Show("Error al crear cliente");
                    break;
                    case 1:
                        MessageBox.Show("Ya existe un cliente con ese mail");
                    break;
                    default:
                        limpiarCampos();
                        MessageBox.Show("Cliente generado");
                    break;
                }
            }
        }

        private void modificarCliente()
        {
            if (Utils.cumple_campos_obligatorios(camposObligatorios, errorProvider) && datePickerFNAC.Value < DateTime.Now)
            {
                uint dni;
                try
                {
                    dni = uint.Parse(txtDNI.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dni invalido");
                    return;
                }

                Cliente cli = new Cliente(cargado.id, txtNombre.Text, txtApellido.Text, uint.Parse(txtDNI.Text), datePickerFNAC.Value, txtDireccion.Text, txtCP.Text, txtMail.Text, txtTelefono.Text, cargado.habilitado);
                int ex = ClienteDAO.modificarCliente(cli);

                switch (ex)
                {
                    case 0:
                        MessageBox.Show("Error al crear cliente");
                        break;
                    case 1:
                        MessageBox.Show("Ya existe un cliente con ese mail");
                        break;
                    default:
                        limpiarCampos();
                        MessageBox.Show("Cliente generado");
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCP.Text = "";
            datePickerFNAC.Value = DateTime.Now;
            btnCrear.Text = "Nuevo Cliente";
            cargado = null;
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            camposObligatorios = new List<Control>() {txtNombre, txtApellido, txtDNI, txtMail, txtDireccion, txtCP};
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                bool habil = false;
                if (selectedRow.Cells[9].Value.ToString() == "1") habil = true;

                cargado = new Cliente(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),                                                                       //ID
                    selectedRow.Cells[2].Value.ToString(),                                                                                  //NOMBRE        
                    selectedRow.Cells[3].Value.ToString(),                                                                                  //APELLIDO
                    uint.Parse(selectedRow.Cells[1].Value.ToString()),                                                                      //DNI
                    DateTime.ParseExact(selectedRow.Cells[4].Value.ToString(), "dd/MM/yyyy 0:00:00", CultureInfo.InvariantCulture),         //FNAC
                    selectedRow.Cells[6].Value.ToString(),                                                                                  //DIREACÇAO
                    selectedRow.Cells[7].Value.ToString(),                                                                                  //CP
                    selectedRow.Cells[5].Value.ToString(),                                                                                  //MAIL
                    selectedRow.Cells[8].Value.ToString(),                                                                                  //TELEFONO
                    habil);                                                                                                                 //HABILITADO


                txtNombre.Text = cargado.nombre;
                txtApellido.Text = cargado.apellido;
                txtDNI.Text = cargado.dni.ToString();
                txtMail.Text = cargado.mail;
                txtTelefono.Text = cargado.telefono;
                txtDireccion.Text = cargado.direccion;
                txtCP.Text = cargado.cod_postal;
                datePickerFNAC.Value = cargado.fecha_nacimiento;


                btnCrear.Text = "Guardar Cambios";


            }
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            this.selectedRow = dataGridClientes.Rows[index];
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtroNombre = txtFiltroNombre.Text.ToString();
            filtroApellido = txtFiltroApellido.Text.ToString();
            filtroDNI = txtFiltroDNI.Text.ToString();
            filtrar();
        }


        private void filtrar()
        {
            string miFiltroNomb = "";
            string miFiltroApell = "";
            string miFiltroDNI = "";
            string miFiltroHabil = "";


            //miFiltroNomb = " WHERE Cliente_nombre LIKE '%" + this.filtroNombre + "%'";
            miFiltroNomb = " WHERE UPPER(Cliente_nombre) LIKE UPPER('%' + @nombre + '%')";

            //miFiltroApell = " AND Cliente_apellido LIKE '%" + this.filtroApellido + "%'";
            miFiltroApell = " AND UPPER(Cliente_apellido) LIKE UPPER('%' + @apell + '%')";
            //SI EL CAMPO ESTA VACIO, QUEDA LIKE '%%', Y ES LO MISMO QUE NO PODER EL WHERE

            int dni = -1;

            if (txtFiltroDNI.Text != "")
            {
                try{
                    dni = int.Parse(txtFiltroDNI.Text.ToString());
                }
                catch(Exception){
                    MessageBox.Show("Dni ingresado inválido");
                    return;
                }
                miFiltroDNI = " AND Cliente_dni = @dni";
            }

            if (chkHabilitado.Checked)
            {
                miFiltroHabil = " AND Cliente_habilitado = 1";
            }

            string busqueda = string.Format(@"SELECT Cliente_codigo, Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono, Cliente_habilitado FROM LORDS_OF_THE_STRINGS_V2.Cliente" + miFiltroNomb + miFiltroApell + miFiltroDNI + miFiltroHabil);

            ClienteDAO.llenarDataGrid(dataGridClientes, busqueda, this.filtroNombre, this.filtroApellido, dni);

            filtrando = true;
            if (this.selectedRow != null) this.selectedRow = dataGridClientes.Rows[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargarGridSinFiltros()
        {
            DBConnection.llenar_grilla(dataGridClientes, "SELECT Cliente_codigo, Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono, Cliente_habilitado FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1");
            if (this.selectedRow != null) this.selectedRow = dataGridClientes.Rows[0];
        }

        private void btnSinFiltros_Click(object sender, EventArgs e)
        {
            chkHabilitado.Checked = true;
            txtFiltroApellido.Text = "";
            txtFiltroNombre.Text = "";
            txtFiltroDNI.Text = "";
            cargarGridSinFiltros();
            filtroNombre = "";
            filtroApellido = "";
            filtroDNI = "";
            filtrando = false;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (selectedRow.Cells[9].Value.ToString() == "False")   //SI NO ESTA HABILITADO
            {
                if (ClienteDAO.habilitarClienteConID(int.Parse(selectedRow.Cells[0].Value.ToString()), true) != 0)
                {
                    MessageBox.Show("Cliente Nº " + selectedRow.Cells[0].Value.ToString() + " habilitado");
                    if (filtrando)
                    {
                        filtrar();
                    }
                    else
                    {
                        cargarGridSinFiltros();
                    }
                }
                else
                {
                    MessageBox.Show("Error al habilitar Cliente Nº " + selectedRow.Cells[0].Value.ToString());
                }
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

            if (selectedRow.Cells[9].Value.ToString() == "True")   //SI  ESTA HABILITADO
            {
                if (ClienteDAO.habilitarClienteConID(int.Parse(selectedRow.Cells[0].Value.ToString()), false) != 0)
                {
                    MessageBox.Show("Cliente Nº " + selectedRow.Cells[0].Value.ToString() + " inhabilitado");
                    if (filtrando)
                    {
                        filtrar();
                    }
                    else{
                        cargarGridSinFiltros();
                    }
                }
                else
                {
                    MessageBox.Show("Error al inhabilitar Cliente Nº " + selectedRow.Cells[0].Value.ToString());
                }
            }
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
