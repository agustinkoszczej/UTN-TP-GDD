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
    public partial class IngresoEmpresaForm : Form
    {
        private List<Control> campos_obligatorios;
        private ABMEmpresaForm empresa_form;
        private string tipo_ingreso;
        private Empresa empresa_modificar;

        public IngresoEmpresaForm(ABMEmpresaForm _empresa_form, string _tipo_ingreso, Empresa _empresa_modificar)
        {
            InitializeComponent();

            this.empresa_form = _empresa_form;
            this.tipo_ingreso = _tipo_ingreso;
            this.empresa_modificar = _empresa_modificar;
            this.campos_obligatorios = new List<Control>() { txtNombreEmpresa, txtCuitEmpresa, txtDireccionEmpresa, chkLstRubros };

            groupBoxIngresoEmpresas.Text = tipo_ingreso;
            set_rubros_chkLst();
        }

        private void txtCuitEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void set_rubros_chkLst()
        {
            List<Rubro> rubros = RubroDAO.obtener_todos_rubros();
            foreach (Rubro rubro in rubros)
            {
                if (empresa_modificar != null && empresa_modificar.rubros.Any(r => r.id == rubro.id))
                {
                    chkLstRubros.Items.Add(rubro, CheckState.Checked);
                }
                else
                {
                    chkLstRubros.Items.Add(rubro, CheckState.Unchecked);
                }
                chkLstRubros.DisplayMember = "descripcion";
                chkLstRubros.ValueMember = "id";
            }
            if (empresa_modificar != null)
            {
                txtNombreEmpresa.Text = empresa_modificar.nombre;
                txtCuitEmpresa.Text = empresa_modificar.cuit;
                txtDireccionEmpresa.Text = empresa_modificar.direccion;
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

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (empresa_modificar == null)
            {
                alta_empresa();
            }
            else
            {
                modificar_empresa();
            }
        }
        private void alta_empresa()
        {
           if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && validar_cuit())
            {
               Empresa empresa_nueva = new Empresa(txtCuitEmpresa.Text, txtNombreEmpresa.Text, txtDireccionEmpresa.Text, get_rubros_chkLst());
                if (EmpresaDAO.agregar_empresa(empresa_nueva))
                {
                    MessageBox.Show("Empresa agregada correctamente!", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    empresa_form.iniciar_formulario();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el " + tipo_ingreso, "Error en el ABM Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!validar_cuit())
            {
                MessageBox.Show("El cuit ingresado ya existe.", "Error cuit existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificar_empresa()
        {
            if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && validar_cuit())
            {
                Empresa empresa_nueva = new Empresa(txtCuitEmpresa.Text, txtNombreEmpresa.Text, txtDireccionEmpresa.Text, get_rubros_chkLst());
                empresa_nueva.id = empresa_modificar.id;
                if (EmpresaDAO.modificar_empresa(empresa_nueva, empresa_modificar.rubros))
                {
                    MessageBox.Show("Empresa modificada correctamente!", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    empresa_form.iniciar_formulario();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el " + tipo_ingreso, "Error en el ABM Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!validar_cuit())
            {
                MessageBox.Show("El cuit ingresado ya existe.", "Error cuit existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            empresa_form.iniciar_formulario();
        }

        private bool validar_cuit()
        {
            if ((EmpresaDAO.validar_cuit(txtCuitEmpresa.Text)) || ((empresa_modificar != null) && (empresa_modificar.cuit.ToUpper() == txtCuitEmpresa.Text.ToUpper())))
            {
                errorProvider.SetError(txtCuitEmpresa, null);
            }
            else
            {
                    errorProvider.SetError(txtCuitEmpresa, "Cuit ya existente");
                    return false;
            }
            return true;
        }
    }
}
