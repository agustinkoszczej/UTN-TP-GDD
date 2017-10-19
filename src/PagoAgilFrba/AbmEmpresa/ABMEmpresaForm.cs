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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ABMEmpresaForm : Form
    {

        public ABMEmpresaForm()
        {
            InitializeComponent();
        }

        private void ABMEmpresaForm_Load(object sender, EventArgs e)
        {
            iniciar_formulario();
        }

        public void iniciar_formulario()
        {
            this.Enabled = true;
            this.Focus();
            EmpresaDAO.cargar_grilla_empresas(dgdEmpresas, chkQuitarDeshabilitados.Checked);
            if (dgdEmpresas.RowCount != 0)
            {
                RubroDAO.cargar_grilla_rubros(dgdRubros, get_empresa_seleccionada_grilla());
                cmdBorrarEmpresa.Enabled = true;
                cmdModificarEmpresa.Enabled = true;
            }
            else
            {
                cmdBorrarEmpresa.Enabled = false;
                cmdModificarEmpresa.Enabled = false;
                dgdRubros.DataSource = null;
            }
        }

        private void dgdRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RubroDAO.cargar_grilla_rubros(dgdRubros, get_empresa_seleccionada_grilla());
        }
        private Empresa get_empresa_seleccionada_grilla()
        {
            int empresa_id = int.Parse(dgdEmpresas.SelectedCells[0].Value.ToString());
            string empresa_cuit = dgdEmpresas.SelectedCells[1].Value.ToString();
            string empresa_nombre = dgdEmpresas.SelectedCells[2].Value.ToString();
            string empresa_direccion = dgdEmpresas.SelectedCells[3].Value.ToString();
            bool empresa_habilitada = bool.Parse(dgdEmpresas.SelectedCells[4].Value.ToString());

            return new Empresa(empresa_id, empresa_cuit, empresa_nombre, empresa_direccion, empresa_habilitada);
        }

        private void cmdAltaRol_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            IngresoEmpresaForm frm = new IngresoEmpresaForm(this, "Alta Rol", null);
            frm.Show();
        }

        private void cmdModificarRol_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Empresa empresa_modif = get_empresa_seleccionada_grilla();
            empresa_modif.rubros = get_rubros_from_grid();
            IngresoEmpresaForm frm = new IngresoEmpresaForm(this, "Modificar Empresa", empresa_modif);
            frm.Show();
        }

        private List<Rubro> get_rubros_from_grid()
        {
            List<Rubro> rubros = new List<Rubro>();
            foreach (DataGridViewRow row in dgdRubros.Rows)
            {
                int rubro_id = int.Parse(row.Cells[0].Value.ToString());
                string rubro_descripcion = row.Cells[1].Value.ToString();

                Rubro rubro = new Rubro(rubro_id, rubro_descripcion);
                rubros.Add(rubro);
            }
            return rubros;
        }

        private void cmdBorrarRol_Click(object sender, EventArgs e)
        {
            string mensaje;
            Empresa empresa = get_empresa_seleccionada_grilla();
            if (empresa.habilitada)
            {
                mensaje = "¿Está ud. seguro de querer deshabilitar la Empresa " + empresa.nombre + "? (Se perderán todos los rubros asociados)";
            }
            else
            {
                mensaje = "¿Está ud. seguro de querer habilitar la Empresa " + empresa.nombre + "?";
            }
            if (MessageBox.Show(mensaje, "PagoAgilFrba | ABM Empresa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmpresaDAO.borrar_empresa(empresa);
                iniciar_formulario();
            }
            //Utils.posicionar_cursor_grilla_por_id(dgdRoles, rol.id);
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void chkQuitarDeshabilitados_CheckedChanged(object sender, EventArgs e)
        {
            iniciar_formulario();
        }
    }
}
