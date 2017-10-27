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

        public NuevoClienteForm(ABMClienteForm back)
        {
            InitializeComponent();
            this.Text = "PagoAgilFrba | Nuevo Cliente";
            btnCrear.Text = "Nuevo Cliente";
            backForm = back;
        }

        public NuevoClienteForm(Cliente aModificar, ABMClienteForm back)
        {
            InitializeComponent();
            cargarCliente(aModificar);
            this.Text = "PagoAgilFrba | Modificar Cliente";
            btnCrear.Text = "Guardar";
            backForm = back;
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
                    MessageBox.Show("DNI invalido");
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
                        backForm.filtrar();
                        this.Close();
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
                    MessageBox.Show("DNI invalido");
                    return;
                }

                Cliente cli = new Cliente(cargado.id, txtNombre.Text, txtApellido.Text, uint.Parse(txtDNI.Text), datePickerFNAC.Value, txtDireccion.Text, txtCP.Text, txtMail.Text, txtTelefono.Text, cargado.habilitado);
                int ex = ClienteDAO.modificarCliente(cli);

                switch (ex)
                {
                    case 0:
                        MessageBox.Show("Error al modificar cliente");
                        break;
                    case 1:
                        MessageBox.Show("Ya existe un cliente con ese mail");
                        break;
                    default:
                        MessageBox.Show("Cliente " + cargado.id  + " modificado");
                        backForm.filtrar();
                        limpiarCampos();
                        this.Close();
                        break;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_texto(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_texto(e);
        }

        private void txtFiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_texto(e);
        }

        private void txtFiltroApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_texto(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }

    }
}
