using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using PagoAgilFrba.DAOs;
using PagoAgilFrba.Model;
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.Devolucion
{
    public partial class DevolucionForm : Form
    {

        public DevolucionForm()
        {
            InitializeComponent();
            rbErrorCobro.Checked = true;
            lblTotalDevolver.Text = "";
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }
        private void filtrar()
        {
            if (string.IsNullOrEmpty(txtDNICliente.Text) && string.IsNullOrEmpty(txtNroFactura.Text))
            {
                dgdFacturas.DataSource = null; return;
            }
            string query_nro_factura = null, query_dni = null, query_final = null;

            if (!string.IsNullOrEmpty(txtDNICliente.Text))
            {
                query_dni = " AND Cliente_dni LIKE @dni";
            }
            if (!string.IsNullOrEmpty(txtNroFactura.Text))
            {
                query_nro_factura = " AND Factura_codigo LIKE @nro_factura";
            }
            query_final = string.Format(@"SELECT Factura_codigo Código, Factura_fecha Fecha, Factura_total Total, Factura_fecha_venc Fecha_Vencimiento, Factura_cliente Codigo_Cliente, Cliente_dni DNI_Cliente, Factura_empresa Empresa FROM LORDS_OF_THE_STRINGS_V2.Factura 
                                           JOIN LORDS_OF_THE_STRINGS_V2.Cliente ON (Factura_cliente = Cliente_codigo)
                                           WHERE Factura_habilitada = 1 AND Cliente_habilitado = 1" + query_dni + query_nro_factura);
            PagoDAO.buscar_factura(dgdFacturas, query_final, txtNroFactura.Text, txtDNICliente.Text);

            if (dgdFacturas.DataSource != null || dgdFacturas.RowCount != 0)
            {
                Factura factura = get_factura_seleccionada_grilla();
                  lblTotalDevolver.Text = "-"+factura.total;
            }
        }
        private Factura get_factura_seleccionada_grilla()
        {
            int id = int.Parse(dgdFacturas.SelectedCells[0].Value.ToString());
            string fecha = dgdFacturas.SelectedCells[1].Value.ToString();
            double total = Convert.ToDouble(dgdFacturas.SelectedCells[2].Value.ToString());
            string fecha_venc = dgdFacturas.SelectedCells[3].Value.ToString();
            int cliente = int.Parse(dgdFacturas.SelectedCells[4].Value.ToString());
            int empresa = int.Parse(dgdFacturas.SelectedCells[6].Value.ToString());

            return new Factura(id, DateTime.Parse(fecha), total, DateTime.Parse(fecha_venc), EmpresaDAO.obtener_empresa_con_ID(empresa), ClienteDAO.obtener_cliente_con_ID(cliente));
        }

        private void cmdQuitarFiltros_Click(object sender, EventArgs e)
        {
            Utils.limpiar_controles((new List<Control>() { txtDNICliente, txtNroFactura}));
            dgdFacturas.DataSource = null;
            lblTotalDevolver.Text = "";
        }

        private void cmdDevolver_Click(object sender, EventArgs e)
        {
            if (dgdFacturas.DataSource == null || dgdFacturas.RowCount == 0)
            {
                return;
            }
            Factura factura = get_factura_seleccionada_grilla();

            if (validar_factura(factura))
            {
                if (validar_campos())
                {
                   string motivo = get_motivo();
                   if (MessageBox.Show("¿Está ud. seguro de querer devolver el pago de $" + lblTotalDevolver.Text + " en PagoAgilFrba?", "Confirmar devolución", MessageBoxButtons.YesNo) == DialogResult.Yes)
                   {
                       if (DevolucionDAO.agregar_devolucion(motivo, factura))
                       {
                           MessageBox.Show("Devolución efectuada correctamente!", "Devolución de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           this.Close();
                       }
                   }
                }
            }   
        }
        private string get_motivo()
        {
            if (rbErrorCobro.Checked)
            {
                return rbErrorCobro.Text;
            }
            if (rbRetraerPago.Checked)
            {
                return rbRetraerPago.Text;
            }
            else
            {
                return rtxtOtro.Text;
            }
        }

        private bool validar_factura(Factura factura)
        {
            int estado = FacturaDAO.estado_factura(factura.id);
            if (estado == 1)
            {
                MessageBox.Show("Esta factura no se encuentra pagada o ya fue devuelta!", "Error devolver Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (factura.rendicion != null || estado == 3)
            {
                MessageBox.Show("Esta factura ya se encuentra rendida!", "Error devolver Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!factura.empresa.habilitada)
            {
                MessageBox.Show("Lo sentimos la Empresa de esta Factura se encuentra inactiva!", "Error devolver Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (factura.fecha_venc < DateTime.Now)
            {
                MessageBox.Show("Lo sentimos esa factura está vencida!", "Error devolver Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool validar_campos(){
            if (rbOtro.Checked)
            {
                if (string.IsNullOrEmpty(rtxtOtro.Text))
                {
                    MessageBox.Show("Hay campos incompletos.", "Error campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.SetError(rtxtOtro, "Campo obligatorio");
                    return false;
                }
            }
            return true;
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked)
            {
                rtxtOtro.Enabled = true;
            }
        }

        private void rbRetraerPago_CheckedChanged(object sender, EventArgs e)
        {
            rtxtOtro.Enabled = false;
        }

        private void rbErrorCobro_CheckedChanged(object sender, EventArgs e)
        {
            rtxtOtro.Enabled = false;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }
        private void txtNroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }


    }
}
