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
            EmpresaDAO.cargar_grilla_empresas(dgdEmpresas);
            actualizar_rubros();
            set_rubros_chkLst();
            Utils.limpiar_controles(new List<Control> {txtCuitEmpresa, txtNombreEmpresa, chkLstRubros, chkQuitarDeshabilitados});
        }

        private void txtCuitEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void set_rubros_chkLst()
        {
            chkLstRubros.Items.Clear();
            List<Rubro> rubros = RubroDAO.obtener_todos_rubros();
            foreach (Rubro rubro in rubros)
            {
                chkLstRubros.Items.Add(rubro);
                chkLstRubros.DisplayMember = "descripcion";
                chkLstRubros.ValueMember = "id";
            }
        }
        private List<Rubro> get_rubros_chkLst()
        {
            List<Rubro> rubros = new List<Rubro>();
            foreach (Rubro rubro in chkLstRubros.CheckedItems)
            {
                rubros.Add(rubro);
            }
            return rubros;
        }

        private void actualizar_rubros()
        {
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
            string empresa_nombre = dgdEmpresas.SelectedCells[1].Value.ToString();
            string empresa_cuit = dgdEmpresas.SelectedCells[2].Value.ToString();
            string empresa_direccion = dgdEmpresas.SelectedCells[3].Value.ToString();
            bool empresa_habilitada = bool.Parse(dgdEmpresas.SelectedCells[4].Value.ToString());

            return new Empresa(empresa_id, empresa_cuit, empresa_nombre, empresa_direccion, empresa_habilitada);
        }

        private void cmdAltaRol_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            IngresoEmpresaForm frm = new IngresoEmpresaForm(this, "Alta Empresa", null);
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
                mensaje = "¿Está ud. seguro de querer deshabilitar la Empresa " + empresa.nombre + "?";
            }
            else
            {
                mensaje = "¿Está ud. seguro de querer habilitar la Empresa " + empresa.nombre + "?";
            }
            if (MessageBox.Show(mensaje, "PagoAgilFrba | ABM Empresa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!EmpresaDAO.borrar_empresa(empresa))
                {
                    MessageBox.Show("Existen facturas pendientes para la empresa " +empresa.nombre+", no se puede deshabilitar", "Error en el ABM Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                iniciar_formulario();
            }
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }
     
        private void filtrar(){
            string _nombre = txtNombreEmpresa.Text, _cuit = txtCuitEmpresa.Text;
            List<Rubro> _rubros = get_rubros_chkLst();

            string query_nombre = null, query_cuit = null, query_rubros = null, query_habilitados = null, query_final = null;

            if (!string.IsNullOrEmpty(_nombre))
            {
                query_nombre = "UPPER(Empresa_nombre) LIKE UPPER('%' + @nombre + '%') ";
                if (_rubros.Count != 0)
                {
                    query_nombre = "AND " + query_nombre;
                }
            }
            if (!string.IsNullOrEmpty(_cuit))
            {
                query_cuit = "UPPER(Empresa_cuit) LIKE UPPER('%' + @cuit + '%')";
                if (!string.IsNullOrEmpty(_nombre) || (_rubros.Count != 0))
                {
                    query_cuit = "AND " + query_cuit;
                }
            }
            if (_rubros.Count != 0)
            {
                query_rubros = " JOIN LORDS_OF_THE_STRINGS_V2.Rubro_Empresa ON (Empresa_codigo = RubroEmpr_empresa) WHERE RubroEmpr_rubro IN (";
                query_rubros = query_rubros + string.Join(",", _rubros.Select(rubro => rubro.id)) + ") ";
            }
            else
            {
                if (!string.IsNullOrEmpty(_nombre) || !string.IsNullOrEmpty(_cuit))
                {
                    query_rubros = " WHERE ";
                }
            }
            if (chkQuitarDeshabilitados.Checked)
            {
                query_habilitados = "Empresa_habilitada = 1";
                if (string.IsNullOrEmpty(_nombre) && string.IsNullOrEmpty(_cuit) && _rubros.Count == 0)
                {
                    query_habilitados = " WHERE " + query_habilitados;
                }
                else
                {
                    query_habilitados = " AND " + query_habilitados;
                }
            }
            query_final = string.Format(@"SELECT Empresa_codigo Código, Empresa_nombre Nombre, Empresa_cuit CUIT, Empresa_direccion Dirección, Empresa_habilitada Habilitada FROM LORDS_OF_THE_STRINGS_V2.Empresa" + query_rubros + query_nombre + query_cuit + query_habilitados);

            //MessageBox.Show(query_final);

            EmpresaDAO.buscar_empresa(dgdEmpresas, query_final, _nombre, _cuit);
            actualizar_rubros();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void cmdQuitarFiltros_Click(object sender, EventArgs e)
        {
            Utils.limpiar_controles((new List<Control>() { txtCuitEmpresa, txtNombreEmpresa, chkLstRubros }));
            iniciar_formulario();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
