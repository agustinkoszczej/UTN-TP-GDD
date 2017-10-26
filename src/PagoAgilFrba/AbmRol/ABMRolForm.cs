using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.DAOs;
using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;

using PagoAgilFrba.Login;

namespace PagoAgilFrba.AbmRol
{
    public partial class ABMRolForm : Form
    {
        private Rol rol_logueado;

        public ABMRolForm(Rol _rol)
        {
            InitializeComponent();
            this.rol_logueado = _rol;
        }

        private void ABMRolForm_Load(object sender, EventArgs e)
        {
            iniciar_formulario();
        }

        public void iniciar_formulario()
        {
            this.Enabled = true;
            this.Focus();
            RolDAO.cargar_grilla_roles(dgdRoles, chkQuitarDeshabilitados.Checked);
            if (dgdRoles.RowCount != 0)
            {
                FuncionalidadDAO.cargar_grilla_funcionalidades(dgdFuncionalidades, get_rol_seleccionado_grilla());
                cmdBorrarRol.Enabled = true;
                cmdModificarRol.Enabled = true;
            }
            else
            {
                cmdBorrarRol.Enabled = false;
                cmdModificarRol.Enabled = false;
                dgdFuncionalidades.DataSource = null;
            }
        }

        private void dgdRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FuncionalidadDAO.cargar_grilla_funcionalidades(dgdFuncionalidades, get_rol_seleccionado_grilla());
        }
        private Rol get_rol_seleccionado_grilla()
        {
            int rol_id = int.Parse(dgdRoles.SelectedCells[0].Value.ToString());
            string rol_nombre = dgdRoles.SelectedCells[1].Value.ToString();
            bool rol_habilitado = bool.Parse(dgdRoles.SelectedCells[2].Value.ToString());

            return new Rol(rol_id, rol_nombre, rol_habilitado);
        }

        private void cmdAltaRol_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            IngresoRolForm frm = new IngresoRolForm(this, "Alta Rol", null);
            frm.Show();
        }

        private void cmdModificarRol_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Rol rol_modif = get_rol_seleccionado_grilla();
            rol_modif.funcionalidades = get_funcionalidades_from_grid();
            IngresoRolForm frm = new IngresoRolForm(this, "Modificar Rol", rol_modif);
            frm.Show();
        }

        private List<Funcionalidad> get_funcionalidades_from_grid()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (DataGridViewRow row in dgdFuncionalidades.Rows)
            {
                int func_id = int.Parse(row.Cells[0].Value.ToString());
                string func_nombre = row.Cells[1].Value.ToString();
                Funcionalidad func = new Funcionalidad(func_id, func_nombre);
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }

        private void cmdBorrarRol_Click(object sender, EventArgs e)
        {
            string mensaje;
            Rol rol = get_rol_seleccionado_grilla();
                if (rol.habilitado)
                {
                    mensaje = "¿Está ud. seguro de querer deshabilitar el Rol " + rol.nombre + "? (Se perderán todas las funcionalidades y usuarios asociados)";
                }
                else
                {
                    mensaje = "¿Está ud. seguro de querer habilitar el Rol " + rol.nombre + "?";
                }
            if (MessageBox.Show(mensaje, "PagoAgilFrba | ABM Rol", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (rol.id == rol_logueado.id) 
                {
                    if (MessageBox.Show("¿Está a punto de inhabilitar el Rol en el que se encuentra logueado, se cerrará la sesión al finalizar, desea continuar?", "PagoAgilFrba | ABM Rol", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RolDAO.borrar_rol(rol);
                        Application.Exit();
                        Application.Restart();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                RolDAO.borrar_rol(rol);
                iniciar_formulario();
            }
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void chkQuitarDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            iniciar_formulario();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
