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
    public partial class ABMClienteForm : Form
    {
        DataGridViewRow selectedRow = null;
        Cliente cargado = null;
        bool filtrando = false;
        string filtroNombre = "";
        string filtroApellido = ""; 
        string filtroDNI = "";

        public ABMClienteForm()
        {
            InitializeComponent();
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                bool habil = false;
                if (selectedRow.Cells[9].Value.ToString() == "1") habil = true;

                cargado = new Cliente(
                    int.Parse(selectedRow.Cells[0].Value.ToString()),          //ID
                    selectedRow.Cells[2].Value.ToString(),                     //NOMBRE        
                    selectedRow.Cells[3].Value.ToString(),                     //APELLIDO
                    uint.Parse(selectedRow.Cells[1].Value.ToString()),         //DNI
                    DateTime.Parse(selectedRow.Cells[4].Value.ToString()),     //FECHA NACIMIENTO
                    selectedRow.Cells[6].Value.ToString(),                     //DIRECCION
                    selectedRow.Cells[7].Value.ToString(),                     //CODIGO POSTAL
                    selectedRow.Cells[5].Value.ToString(),                     //MAIL
                    selectedRow.Cells[8].Value.ToString(),                     //TELEFONO
                    habil);                                                    //HABILITADO
                NuevoClienteForm frm = new NuevoClienteForm(cargado, this);
                frm.Show();
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


        public void filtrar()
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
                    MessageBox.Show("DNI Ingresado inválido", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                miFiltroDNI = " AND Cliente_dni = @dni";
            }

            if (chkHabilitado.Checked)
            {
                miFiltroHabil = " AND Cliente_habilitado = 1";
            }

            string busqueda = string.Format(@"SELECT Cliente_codigo Código, Cliente_dni DNI, Cliente_nombre Nombre, Cliente_apellido Apellido, Cliente_fecha_nac Fecha_Nacimiento, Cliente_mail Mail, Cliente_direccion Dirección, Cliente_codigo_postal Código_Postal, Cliente_telefono Teléfono, Cliente_habilitado Habilitado FROM LORDS_OF_THE_STRINGS_V2.Cliente" + miFiltroNomb + miFiltroApell + miFiltroDNI + miFiltroHabil);

            ClienteDAO.llenarDataGrid(dataGridClientes, busqueda, this.filtroNombre, this.filtroApellido, dni);

            filtrando = true;
            if (dataGridClientes.Rows.Count > 0)
            {
                this.selectedRow = dataGridClientes.Rows[0];
            }
        }

        private void cargarGridSinFiltros()
        {
            DBConnection.llenar_grilla(dataGridClientes, "SELECT Cliente_codigo Código, Cliente_dni DNI, Cliente_nombre Nombre, Cliente_apellido Apellido, Cliente_fecha_nac Fecha_Nacimiento, Cliente_mail Mail, Cliente_direccion Dirección, Cliente_codigo_postal Código_Postal, Cliente_telefono Teléfono, Cliente_habilitado Habilitado FROM LORDS_OF_THE_STRINGS_V2.Cliente WHERE Cliente_habilitado = 1");
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
            if (dataGridClientes.RowCount != 0)
            {
                if (selectedRow.Cells[9].Value.ToString() == "False")   //SI NO ESTA HABILITADO
                {
                    if (MessageBox.Show("¿Está ud. seguro de querer habilitar el Cliente seleccionado?", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                    if (ClienteDAO.habilitarClienteConID(int.Parse(selectedRow.Cells[0].Value.ToString()), true) != 0)
                    {
                        MessageBox.Show("Cliente Nº " + selectedRow.Cells[0].Value.ToString() + " habilitado correctamente!", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("El Cliente seleccionado ya se encuentra habilitado!", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.RowCount != 0)
            {
                if (selectedRow.Cells[9].Value.ToString() == "True")   //SI  ESTA HABILITADO
                {
                    if (MessageBox.Show("¿Está ud. seguro de querer deshabilitar el Cliente seleccionado?", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (ClienteDAO.habilitarClienteConID(int.Parse(selectedRow.Cells[0].Value.ToString()), false) != 0)
                        {
                            MessageBox.Show("Cliente Nº " + selectedRow.Cells[0].Value.ToString() + " deshabilitado correctamente!", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            MessageBox.Show("Error al inhabilitar Cliente Nº " + selectedRow.Cells[0].Value.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Cliente seleccionado ya se encuentra deshabilitado!", "PagoAgilFrba | ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoClienteForm frm = new NuevoClienteForm(this);
            frm.Show();
        }

        private void txtFiltroDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }

        private void cmdQuitarFiltros_Click(object sender, EventArgs e)
        {
            Utils.limpiar_controles((new List<Control>() { txtFiltroApellido, txtFiltroDNI, txtFiltroNombre }));
            Utils.clearDataGrid(dataGridClientes);
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
