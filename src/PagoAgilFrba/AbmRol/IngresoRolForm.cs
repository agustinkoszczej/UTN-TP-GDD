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

namespace PagoAgilFrba.AbmRol
{
    public partial class IngresoRolForm : Form
    {
        private List<Control> campos_obligatorios;
        private ABMRolForm rol_form;
        private string tipo_ingreso;
        private Rol rol_modificar;

        public IngresoRolForm(ABMRolForm _rol_form, string _tipo_ingreso, Rol _rol_modificar)
        {
            InitializeComponent();
                   
            this.rol_form = _rol_form;
            this.tipo_ingreso = _tipo_ingreso;
            this.rol_modificar = _rol_modificar;
            this.campos_obligatorios = new List<Control>() { txtNombreRol, chkLstFuncionalidades };

            groupBoxIngresoRoles.Text = tipo_ingreso;
            set_funcionalidades_chkLst();
        }
        private void set_funcionalidades_chkLst()
        {
            List<Funcionalidad> funcionalidades = FuncionalidadDAO.obtener_todas_funcionalidades();
            foreach (Funcionalidad func in funcionalidades)
            {
                if (rol_modificar != null && rol_modificar.funcionalidades.Any(f => f.id == func.id))
                {
                    chkLstFuncionalidades.Items.Add(func, CheckState.Checked);
                }
                else
                {
                    chkLstFuncionalidades.Items.Add(func, CheckState.Unchecked);
                }
                chkLstFuncionalidades.DisplayMember = "nombre";
                chkLstFuncionalidades.ValueMember = "id";
            }
            if (rol_modificar != null)
            {
                txtNombreRol.Text = rol_modificar.nombre;
            }
        }
        private List<Funcionalidad> get_funcionalidades_chkLst()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            foreach (Funcionalidad func in chkLstFuncionalidades.CheckedItems)
            {
                funcionalidades.Add(func);
            }
            return funcionalidades;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (rol_modificar == null)
            {
                alta_rol();
            }
            else
            {
                modificar_rol();
            }
        }
        private void alta_rol(){
            if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && validar_nombre())
            {
                Rol rol_nuevo = new Rol(txtNombreRol.Text, get_funcionalidades_chkLst());
                if (RolDAO.agregar_rol(rol_nuevo))
                {
                    MessageBox.Show("Rol agregado correctamente!", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    rol_form.iniciar_formulario();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el " + tipo_ingreso, "Error en el ABM Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!validar_nombre())
            {
                MessageBox.Show("El nombre ingresado ya existe.", "Error nombre existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificar_rol()
        {
            if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && validar_nombre())
            {
                Rol rol_nuevo = new Rol(txtNombreRol.Text, get_funcionalidades_chkLst());
                rol_nuevo.id = rol_modificar.id;
                if (RolDAO.modificar_rol(rol_nuevo, rol_modificar.funcionalidades))
                {
                    MessageBox.Show("Rol modificado correctamente!", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    rol_form.iniciar_formulario();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el " + tipo_ingreso, "Error en el ABM Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!validar_nombre())
            {
                MessageBox.Show("El nombre ingresado ya existe.", "Error nombre existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            rol_form.iniciar_formulario();
        }

        private bool validar_nombre()
        {
            if ((RolDAO.validar_nombre(txtNombreRol.Text)) || ((rol_modificar != null) && (rol_modificar.nombre.ToUpper() == txtNombreRol.Text.ToUpper())))
            {
                errorProvider.SetError(txtNombreRol, null);
            }
            else
            {
                    errorProvider.SetError(txtNombreRol, "Nombre ya existente");
                    return false;
            }
            return true;
        }
    }
}
