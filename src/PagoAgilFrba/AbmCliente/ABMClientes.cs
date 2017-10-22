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

namespace PagoAgilFrba.AbmCliente
{
    public partial class ABMClientes : Form
    {
        DataGridViewRow selectedRow;

        public ABMClientes()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            //ClienteDAO.llenarDataGrid(dataGridClientes, "SELECT Cliente_codigo, Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1"); 
            cargarGridSinFiltros();
            this.selectedRow = dataGridClientes.Rows[0];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                txtNombre.Text = selectedRow.Cells[2].Value.ToString();
                txtApellido.Text = selectedRow.Cells[3].Value.ToString();
                txtDNI.Text = selectedRow.Cells[1].Value.ToString();
                txtMail.Text = selectedRow.Cells[5].Value.ToString();
                txtTelefono.Text = selectedRow.Cells[8].Value.ToString();
                txtDireccion.Text = selectedRow.Cells[6].Value.ToString();
                txtCP.Text = selectedRow.Cells[7].Value.ToString();

                string dat = selectedRow.Cells[4].Value.ToString();
                datePickerFNAC.Value = DateTime.ParseExact(dat, "dd/MM/yyyy 0:00:00", CultureInfo.InvariantCulture);


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
            string busqueda = "SELECT Cliente_codigo, Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono FROM LORDS_OF_THE_STRINGS_V2.Cliente";
            string filtroNomb = "";
            string filtroApell = "";
            string filtroDNI = "";
            string filtroHabil = "";


            filtroNomb = " WHERE Cliente_nombre LIKE '%" + txtFiltroNombre.Text.ToString() + "%'";
            
            filtroApell = " AND Cliente_apellido LIKE '%" + txtFiltroApellido.Text.ToString() + "%'";
            //SI EL CAMPO ESTA VACIO, QUEDA LIKE '%%', Y ES LO MISMO QUE NO PODER EL WHERE

            if (txtFiltroDNI.Text != "")
            {
                filtroDNI = " AND Cliente_dni = " + txtFiltroApellido.Text.ToString();
            }

            if (chkHabilitado.Checked)
            {
                filtroHabil = " AND Cliente_habilitado = 1";
            }

            busqueda = busqueda + filtroNomb + filtroApell + filtroDNI + filtroHabil;

            ClienteDAO.llenarDataGrid(dataGridClientes, busqueda);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargarGridSinFiltros()
        {
            ClienteDAO.llenarDataGrid(dataGridClientes, "SELECT Cliente_codigo, Cliente_dni, Cliente_nombre, Cliente_apellido, Cliente_fecha_nac, Cliente_mail, Cliente_direccion, Cliente_codigo_postal, Cliente_telefono FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1"); 
        }

        private void btnSinFiltros_Click(object sender, EventArgs e)
        {
            chkHabilitado.Checked = true;
            txtFiltroApellido.Text = "";
            txtFiltroNombre.Text = "";
            txtFiltroDNI.Text = "";
            cargarGridSinFiltros();
        }
    }
}
