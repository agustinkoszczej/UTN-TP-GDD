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
    public partial class ABMSucursalForm : Form
    {
        private Sucursal sucursal_logueada;

        public ABMSucursalForm(Sucursal _sucursal)
        {
            this.sucursal_logueada = _sucursal;
            InitializeComponent();
        }

        private void ABMSucursalForm_Load(object sender, EventArgs e)
        {
            iniciar_formulario();
        }

        public void iniciar_formulario()
        {
            this.Enabled = true;
            this.Focus();
            SucursalDAO.cargar_grilla_sucursales(dgdSucursales);
            Utils.limpiar_controles(new List<Control> { txtDireccionSucursal, txtNombreSucursal, txtCodPostalSucursal, chkQuitarDeshabilitados });
        }

        private Sucursal get_sucursal_seleccionada_grilla()
        {
            int sucursal_id = int.Parse(dgdSucursales.SelectedCells[0].Value.ToString());
            string sucursal_nombre = dgdSucursales.SelectedCells[1].Value.ToString();
            string sucursal_direccion = dgdSucursales.SelectedCells[2].Value.ToString();
            string sucursal_cod_postal = dgdSucursales.SelectedCells[3].Value.ToString();
            bool sucursal_habilitada = bool.Parse(dgdSucursales.SelectedCells[4].Value.ToString());

            return new Sucursal(sucursal_id, sucursal_nombre, sucursal_direccion, sucursal_cod_postal, sucursal_habilitada);
        }

        private void cmdAltaSucursal_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            IngresoSucursalForm frm = new IngresoSucursalForm(this, "Alta Sucursal", null);
            frm.Show();
        }

        private void cmdModificarSucursal_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Sucursal sucursal_modif = get_sucursal_seleccionada_grilla();
            IngresoSucursalForm frm = new IngresoSucursalForm(this, "Modificar Sucursal", sucursal_modif);
            frm.Show();
        }

        private void cmdBorrarSucursal_Click(object sender, EventArgs e)
        {
            string mensaje;
            Sucursal sucursal = get_sucursal_seleccionada_grilla();
            if (sucursal.habilitada)
            {
                mensaje = "¿Está ud. seguro de querer deshabilitar la Sucursal " + sucursal.nombre + "? (Se perderán todos los usuarios asociados)";
            }
            else
            {
                mensaje = "¿Está ud. seguro de querer habilitar la Sucursal " + sucursal.nombre + "?";
            }
            if (MessageBox.Show(mensaje, "PagoAgilFrba | ABM Sucursal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (sucursal.id == sucursal_logueada.id)
                {
                    if (MessageBox.Show("¿Está a punto de inhabilitar la Sucursal en la que se encuentra logueado, se cerrará la sesión al finalizar, desea continuar?", "PagoAgilFrba | ABM Sucursal", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SucursalDAO.borrar_sucursal(sucursal);
                        Application.Exit();
                        Application.Restart();
                    }
                    else
                    {
                        return;
                    }
                }
                SucursalDAO.borrar_sucursal(sucursal);
                iniciar_formulario();
            }
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void filtrar()
        {
            string _nombre = txtNombreSucursal.Text, _direccion = txtDireccionSucursal.Text, _cod_postal = txtCodPostalSucursal.Text;

            string query_nombre = null, query_direccion = null, query_cod_postal = null, query_habilitados = null, query_final = null, query_where = null;

            if (!string.IsNullOrEmpty(_nombre))
            {
                query_nombre = "UPPER(Sucursal_nombre) LIKE UPPER('%' + @nombre + '%') ";
                query_where = " WHERE ";
            }
            if (!string.IsNullOrEmpty(_direccion))
            {
                query_direccion = "UPPER(Sucursal_direccion) LIKE UPPER('%' + @direccion + '%')";
                if (!string.IsNullOrEmpty(_nombre))
                {
                    query_direccion = "AND " + query_direccion;
                }
                query_where = " WHERE ";
            }
            if (!string.IsNullOrEmpty(_cod_postal))
            {
                query_cod_postal = "Sucursal_codigo_postal LIKE @cod_postal"; //'%' + @cod_postal + '%' -> si quiero exacto
                if (!string.IsNullOrEmpty(_nombre) || (!string.IsNullOrEmpty(_direccion)))
                {
                    query_cod_postal = "AND " + query_cod_postal;
                }
                query_where = " WHERE ";
            }

            if (chkQuitarDeshabilitados.Checked)
            {
                query_habilitados = "Sucursal_habilitada = 1";
                if (string.IsNullOrEmpty(_nombre) && string.IsNullOrEmpty(_direccion) && string.IsNullOrEmpty(_cod_postal))
                {
                    query_habilitados = " WHERE " + query_habilitados;
                }
                else
                {
                    query_habilitados = " AND " + query_habilitados;
                }
            }
            query_final = string.Format(@"SELECT Sucursal_codigo Código, Sucursal_nombre Nombre, Sucursal_direccion Dirección, Sucursal_codigo_postal Código_Postal, Sucursal_habilitada Habilitada FROM LORDS_OF_THE_STRINGS_V2.Sucursal" + query_where + query_nombre + query_direccion + query_cod_postal + query_habilitados);

            //MessageBox.Show(query_final);
            SucursalDAO.buscar_sucursal(dgdSucursales, query_final, _nombre, _direccion, _cod_postal);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void cmdQuitarFiltros_Click(object sender, EventArgs e)
        {
            Utils.limpiar_controles((new List<Control>() { txtDireccionSucursal, txtNombreSucursal, txtCodPostalSucursal }));
            iniciar_formulario();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
