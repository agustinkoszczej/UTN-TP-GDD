using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.AbmCliente
{
    public partial class NuevoClienteForm : Form
    {

        List<Control> camposObligatorios;
        Cliente cargado = null;
        ABMClienteForm backForm;

        private UInt32 dni_viejo;
        private string mail_viejo;

        public NuevoClienteForm(ABMClienteForm back)
        {
            InitializeComponent();
            this.Text = "PagoAgilFrba | Alta Cliente";
            btnCrear.Text = "Crear Cliente";
            backForm = back;
            lblClientes.Text = "Alta Cliente";
        }

        public NuevoClienteForm(Cliente aModificar, ABMClienteForm back)
        {
            InitializeComponent();
            cargarCliente(aModificar);
            this.Text = "PagoAgilFrba | Modificar Cliente";
            btnCrear.Text = "Guardar Cliente";
            backForm = back;
            lblClientes.Text = "Modificar Cliente";
            this.dni_viejo = aModificar.dni;
            this.mail_viejo = aModificar.mail;
        }

        private void cargarCliente(Cliente cli)
        {
            cargado = cli;
            txtNombre.Text = cargado.nombre;
            txtApellido.Text = cargado.apellido;
            txtDNI.Text = cargado.dni.ToString();
            txtMail.Text = cargado.mail;
            txtTelefono.Text = cargado.telefono;
            txtDireccion.Text = cargado.direccion;
            txtCP.Text = cargado.cod_postal;
            datePickerFNAC.Value = cargado.fecha_nacimiento;
        }

        private void NuevoClienteForm_Load(object sender, System.EventArgs e)
        {
            camposObligatorios = new List<Control>() { txtNombre, txtApellido, txtDNI, txtMail, txtDireccion, txtCP };
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
            cargado = null;
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
                    MessageBox.Show("DNI Invalido", "Error en el ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cliente cli = new Cliente(0, txtNombre.Text, txtApellido.Text, dni, datePickerFNAC.Value, txtDireccion.Text, txtCP.Text, txtMail.Text, txtTelefono.Text, true);
                int ex = ClienteDAO.nuevoCliente(cli);

                switch (ex)
                {
                    case 0:
                        MessageBox.Show("Error al crear Cliente", "Error en el ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                        errorProvider.SetError(txtMail, "Mail existente");
                        break;
                    case 2:
                        errorProvider.SetError(txtDNI, "DNI existente");
                        break;
                    case 3:
                        errorProvider.SetError(txtMail, "Mail existente");
                        errorProvider.SetError(txtDNI, "DNI existente");
                        break;
                    default:
                        limpiarCampos();
                        MessageBox.Show("Cliente agregado correctamente!", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        backForm.Enabled = true;
                        backForm.filtrar();
                        this.Close();
                        backForm.Focus();
                        return;
                }
            }

            if (datePickerFNAC.Value > DateTime.Now)
            {
                MessageBox.Show("Fecha inválida", "Error en el ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(datePickerFNAC, "Fecha inválida");
            }
            else
            {
                errorProvider.SetError(datePickerFNAC, null);
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
                    MessageBox.Show("DNI Invalido", "Error en el ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                Cliente cli = new Cliente(cargado.id, txtNombre.Text, txtApellido.Text, uint.Parse(txtDNI.Text), datePickerFNAC.Value, txtDireccion.Text, txtCP.Text, txtMail.Text, txtTelefono.Text, cargado.habilitado);
                    int ex = ClienteDAO.modificarCliente(cli, dni_viejo, mail_viejo);

                    switch (ex)
                    {
                        case 0:
                            MessageBox.Show("Error al modificar Cliente", "Error en el ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            errorProvider.SetError(txtMail, "Mail existente");
                            break;
                        case 2:
                            errorProvider.SetError(txtDNI, "DNI existente");
                            break;
                        case 3:
                            errorProvider.SetError(txtMail, "Mail existente");
                            errorProvider.SetError(txtDNI, "DNI existente");
                            break;
                        default:
                            MessageBox.Show("Cliente " + cargado.id + " modificado correctamente!", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                            backForm.Enabled = true;
                            backForm.filtrar();
                            this.Close();
                            backForm.Focus();
                            return;
                    }
                }
            if (datePickerFNAC.Value > DateTime.Now)
            {
                MessageBox.Show("Fecha inválida", "Error en el ABM Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(datePickerFNAC, "Fecha inválida");
            }
            else
            {
                errorProvider.SetError(datePickerFNAC, null);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Enabled = true;
            backForm.Focus();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }
        private void IngresoEmpresaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            backForm.Enabled = true;
            backForm.Focus();
        }

    }
}
