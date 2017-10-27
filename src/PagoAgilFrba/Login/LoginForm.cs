using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;
using PagoAgilFrba.DAOs;
using System.Data.SqlClient;

namespace PagoAgilFrba.Login
{
    public partial class LoginForm : Form
    {
        private List<Control> campos_obligatorios;
        private Usuario usuario;

        public LoginForm()
        {   
            InitializeComponent();
            txtUsername.Select();
            this.CenterToScreen();
            this.AcceptButton = cmdIngresarButton;
            this.campos_obligatorios = new List<Control>() { txtUsername, txtPassword};
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            this.usuario = new Usuario(txtUsername.Text, txtPassword.Text);
            if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                int rta = UsuarioDAO.loguear_usuario(usuario);
                if (rta == -1)
                {
                    MessageBox.Show("El usuario o contraseña es incorrecto.", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rta == -2)
                {
                    MessageBox.Show("El usuario se encuentra bloqueado, contáctese con el Administrador.", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    usuario.id = rta;
                    usuario.password = ""; //limpio contraseña por seguridad
                    cargar_roles(usuario);
                }
            }
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void cargar_roles(Usuario usuario)
        {
                MessageBox.Show("Bienvenido " + usuario.username, "Login correctamente", MessageBoxButtons.OK);
                txtPassword.Visible = false;
                txtUsername.Visible = false;
                lblPassword.Visible = false;
                cmdIngresarButton.Visible = false;
                groupBoxLogin.Height = 108;
                this.Height = 255;
                cmdCancelarButton.Location = new System.Drawing.Point(159, 170);

                lnlCerrarSesion.Visible = true;
                cboRoles.Visible = true;
                cmdSeleccionarRol.Visible = true;
                lblUsername.Text = "Seleccione un Rol";
                UsuarioDAO.cargar_roles_asignados_usuario(usuario);
                foreach (Rol rol in usuario.roles)
                {
                    //cboRoles.Items.Add(new ComboBoxItem(rol.nombre, rol));
                    //cboRoles.Items.Add(rol.nombre);
                    cboRoles.Items.Add(rol);
                    cboRoles.DisplayMember = "nombre";
                    cboRoles.ValueMember = "id";

                }
                if (usuario.roles.Count == 0)
                {
                    MessageBox.Show("Al parecer no tiene Roles asignados, porfavor contáctese con el Administrador", "Error Roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    Application.Restart();
                    return;
                }
                if (usuario.roles.Count == 1)
                {
                    Form form = new MenuPrincipalForm(usuario, usuario.roles.First());
                    form.Show();
                    this.Hide();
                }
        }

        private void cmdSeleccionarRol_Click(object sender, EventArgs e)
        {
            if (Utils.campo_cumple(cboRoles, errorProvider))
            {
                Form form = new MenuPrincipalForm(usuario, (Rol) cboRoles.SelectedItem);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hay campos incompletos.", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   }
}
