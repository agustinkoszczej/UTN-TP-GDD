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

namespace PagoAgilFrba.AbmSucursal
{
    public partial class IngresoSucursalForm : Form
    {
        private List<Control> campos_obligatorios;
        private ABMSucursalForm sucursal_form;
        private string tipo_ingreso;
        private Sucursal sucursal_modificar;

        public IngresoSucursalForm(ABMSucursalForm _sucursal_form, string _tipo_ingreso, Sucursal _sucursal_modificar)
        {
            InitializeComponent();

            this.sucursal_form = _sucursal_form;
            this.tipo_ingreso = _tipo_ingreso;
            this.sucursal_modificar = _sucursal_modificar;
            this.campos_obligatorios = new List<Control>() { txtNombreSucursal, txtCodPostalSucursal, txtDireccionSucursal};

            groupBoxIngresoSucursales.Text = tipo_ingreso;

            if (sucursal_modificar != null)
            {
                txtNombreSucursal.Text = sucursal_modificar.nombre;
                txtCodPostalSucursal.Text = sucursal_modificar.cod_postal.ToString();
                txtDireccionSucursal.Text = sucursal_modificar.direccion;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (sucursal_modificar == null)
            {
                alta_sucursal();
            }
            else
            {
                modificar_sucursal();
            }
        }
        private void alta_sucursal()
        {
          if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && validar_cod_postal())
            {
                Sucursal sucursal_nueva = new Sucursal(txtNombreSucursal.Text, txtDireccionSucursal.Text, txtCodPostalSucursal.Text);
                if (SucursalDAO.agregar_sucursal(sucursal_nueva))
                {
                    MessageBox.Show("Sucursal agregada correctamente!", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    sucursal_form.iniciar_formulario();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el " + tipo_ingreso, "Error en el ABM Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!validar_cod_postal())
            {
                MessageBox.Show("El código postal ingresado ya existe.", "Error código postal existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificar_sucursal()
        {
            if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && validar_cod_postal())
            {
                Sucursal sucursal_nueva = new Sucursal(txtNombreSucursal.Text, txtDireccionSucursal.Text, txtCodPostalSucursal.Text);
                sucursal_nueva.id = sucursal_modificar.id;
                if (SucursalDAO.modificar_sucursal(sucursal_nueva))
                {
                    MessageBox.Show("Sucursal modificada correctamente!", tipo_ingreso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    sucursal_form.iniciar_formulario();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el " + tipo_ingreso, "Error en el ABM Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!validar_cod_postal())
            {
                MessageBox.Show("El código postal ingresado ya existe.", "Error código postal existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            sucursal_form.iniciar_formulario();
        }

        private bool validar_cod_postal()
        {
            if(string.IsNullOrEmpty(txtCodPostalSucursal.Text)){
                return true;
            }
            if ((SucursalDAO.validar_cod_postal(Convert.ToInt32(txtCodPostalSucursal.Text))) || ((sucursal_modificar != null) && (sucursal_modificar.cod_postal == txtCodPostalSucursal.Text)))
            {
                errorProvider.SetError(txtCodPostalSucursal, null);
            }
            else
            {
                errorProvider.SetError(txtCodPostalSucursal, "Código Postal ya existente");
                return false;
            }
            return true;
        }
    }
}
