using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.AbmCliente;
using PagoAgilFrba.AbmEmpresa;
using PagoAgilFrba.AbmFactura;
using PagoAgilFrba.AbmRol;
using PagoAgilFrba.AbmSucursal;
using PagoAgilFrba.ListadoEstadistico;
using PagoAgilFrba.RegistroPago;
using PagoAgilFrba.Rendicion;
using PagoAgilFrba.Devolucion;

using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;
using PagoAgilFrba.DAOs;

using System.Configuration;
using System.Data.SqlClient;

namespace PagoAgilFrba
{
    public partial class MenuPrincipalForm : Form
    {
        public Usuario usuario_logueado;
        public Rol rol_seleccionado;
        public Sucursal sucursal_seleccionada;

        public MenuPrincipalForm(Usuario _usuario, Rol _rol_seleccionado)
        {
            InitializeComponent();
            this.usuario_logueado = _usuario;
            this.rol_seleccionado = _rol_seleccionado;
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            this.Height = 155;
            cargar_sucursales();
            FuncionalidadDAO.cargar_funcionalidades_asignadas(rol_seleccionado);
            validar_permisos();
        }

        private void cargar_sucursales()
        {
            usuario_logueado.sucursales = new List<Sucursal>();
            UsuarioDAO.cargar_sucursales_asignadas(usuario_logueado);
            if (usuario_logueado.sucursales.Count == 0)
            {
                MessageBox.Show("Al parecer no tiene Sucursales asignadas, porfavor contáctese con el Administrador", "Error Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            foreach (Sucursal suc in usuario_logueado.sucursales)
            {
                cboSucursales.Items.Add(suc);
                cboSucursales.DisplayMember = "nombre";
                cboSucursales.ValueMember = "id";

            }
        }

        //Función del sistema que chequea el Rol y permisos del usuario
        private void validar_permisos()
        {
            lblUsuarioLogueado.Text = usuario_logueado.username;
            lblRolSeleccionado.Text = rol_seleccionado.nombre;
              foreach (Funcionalidad func in rol_seleccionado.funcionalidades)
                    {
                        switch (func.nombre)
                        {
                            case "REGISTRO_PAGOS":
                                cmdRegistrarPago.Enabled = true;
                                //cmdRegistrarPago.Visible = true;
                                break;
                            case "RENDICION_FACTURAS":
                                cmdRendirFacturas.Enabled = true;
                                //cmdRendirFacturas.Visible = true;
                                break;
                            case "LISTADO_ESTADISTICO":
                                cmdListadoEstadistico.Enabled = true;
                                //cmdListadoEstadistico.Visible = true;
                                break;
                            case "ABM_CLIENTE":
                                cmdABMCliente.Enabled = true;
                                //cmdABMCliente.Visible = true;
                                break;
                            case "ABM_FACTURAS":
                                cmdABMFactura.Enabled = true;
                                //cmdABMFactura.Visible = true;
                                break;
                            case "ABM_ROL":
                                cmdABMRol.Enabled = true;
                                //cmdABMRol.Visible = true;
                                break;
                            case "ABM_SUCURSAL":
                                cmdABMSucursal.Enabled = true;
                                //cmdABMSucursal.Visible = true;
                                break;
                            case "ABM_EMPRESA":
                                cmdABMEmpresa.Enabled = true;
                                //cmdABMEmpresa.Visible = true;
                                break;
                            case "DEVOLUCION_FACTURAS":
                                cmdDevolucion.Enabled = true;
                                //cmdDevolucion.Visible = true;
                                break;
                        }
                    }
                }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdABMRol_Click(object sender, EventArgs e)
        {
            ABMRolForm frm = new ABMRolForm(this.rol_seleccionado);
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdABMFactura_Click(object sender, EventArgs e)
        {
            ABMFacturaForm frm = new ABMFacturaForm();
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdABMEmpresa_Click(object sender, EventArgs e)
        {
            ABMEmpresaForm frm = new ABMEmpresaForm();
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdABMCliente_Click(object sender, EventArgs e)
        {
            ABMClienteForm frm = new ABMClienteForm();
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdABMSucursal_Click(object sender, EventArgs e)
        {
            ABMSucursalForm frm = new ABMSucursalForm(this.sucursal_seleccionada);
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdRendirFacturas_Click(object sender, EventArgs e)
        {
            RendicionForm frm = new RendicionForm();
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdDevolucion_Click(object sender, EventArgs e)
        {
            DevolucionForm frm = new DevolucionForm();
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdListadoEstadistico_Click(object sender, EventArgs e)
        {
            ListadoEstadisticoForm frm = new ListadoEstadisticoForm();
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdRegistrarPago_Click(object sender, EventArgs e)
        {
            RegistroPagoForm frm = new RegistroPagoForm(this.sucursal_seleccionada);
            frm.Show();
            //this.Enabled = false;
        }

        private void cmdSeleccionarSucursal_Click(object sender, EventArgs e)
        {
            if (Utils.cumple_campos_obligatorios(new List<Control>() { cboSucursales }, errorProvider))
            {
                this.sucursal_seleccionada = (Sucursal)cboSucursales.SelectedItem;
                lblSucursalSeleccionada.Text = sucursal_seleccionada.nombre;
                groupBoxABMs.Visible = true;
                groupBoxAcciones.Visible = true;
                lblSucursalSeleccionada.Visible = true;
                lblSucursal.Visible = true;
                lnlCambiarSucursal.Visible = true;
                this.Height = 406;

                cmdSeleccionarSucursal.Visible = false;
                cboSucursales.Visible = false;
                lblSeleccioneSucursal.Visible = false;
            }
        }

        private void lnlCambiarSucursal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Está ud. seguro de querer cambiar de Sucursal de PagoAgilFrba?", "Cambiar Sucursal de PagoAgilFrba", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                MenuPrincipalForm frm = new MenuPrincipalForm(usuario_logueado, rol_seleccionado);
                frm.Show();
            }
        }
    }
}
