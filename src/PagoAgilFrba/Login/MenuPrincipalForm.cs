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

using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;
using PagoAgilFrba.DAOs;

using System.Configuration;
using System.Data.SqlClient;

namespace PagoAgilFrba
{
    public partial class MenuPrincipalForm : Form
    {
        public Usuario usuario;
        public Rol rol_seleccionado; 

        public MenuPrincipalForm(Usuario _usuario, Rol _rol_seleccionado)
        {
            InitializeComponent();
            this.usuario = _usuario;
            this.rol_seleccionado = _rol_seleccionado;
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            FuncionalidadDAO.cargar_funcionalidades_asignadas(rol_seleccionado);
            validar_permisos();
        }

        //Función del sistema que chequea el Rol y permisos del usuario
        private void validar_permisos()
        {
            lblUser.Text = usuario.username;
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
            ABMRolForm frm = new ABMRolForm();
            frm.Show();
        }

        private void cmdABMFactura_Click(object sender, EventArgs e)
        {
            ABMFacturaForm frm = new ABMFacturaForm();
            frm.Show();
        }
    }
}
