using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistroPagoForm : Form
    {
        private List<Factura> facturas_a_pagar;
        private List<Control> campos_obligatorios;

        private Sucursal sucursal_actual;

        public RegistroPagoForm(Sucursal _sucursal_actual)
        {
            this.sucursal_actual = _sucursal_actual;
            InitializeComponent();
        }

        private void RegistroPagoForm_Load(object sender, EventArgs e)
        {
            this.campos_obligatorios = new List<Control>() {cboFormasPago};
            iniciar_formulario();
            cargar_formas_pago();
        }

        private void cargar_formas_pago()
        {
            List<Forma_Pago> formas_de_pago = Forma_PagoDAO.obtener_formas_de_pago();
            foreach (Forma_Pago forma in formas_de_pago)
            {
                cboFormasPago.Items.Add(forma);
                cboFormasPago.DisplayMember = "descripcion";
                cboFormasPago.ValueMember = "id";
            }
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }
        private void txtNroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }

        private void cmdQuitarFiltros_Click(object sender, EventArgs e)
        {
            Utils.limpiar_controles((new List<Control>() { txtDNICliente, txtNroFactura, chkSoloPosibles}));
            dgdFacturas.DataSource = null;
            actualizar_facturas_a_pagar();
        }

        public void iniciar_formulario()
        {
            lblTotalCalculado.Text = "";
            this.facturas_a_pagar = new List<Factura>();
            this.Enabled = true;
            this.Focus();
            Utils.limpiar_controles(new List<Control> { txtDNICliente, txtNroFactura });
        }

        private void filtrar()
        {
            string query_pagos_disponibles = null, join_empresas = null;

            if (chkSoloPosibles.Checked)
            {
                join_empresas = " JOIN LORDS_OF_THE_STRINGS_V2.Empresa E ON (F.Factura_empresa = E.Empresa_codigo)";
                query_pagos_disponibles = string.Format(@" AND (SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Pago
		                                                WHERE Pago_factura = F.Factura_codigo) <=
		                                                (SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Devolucion WHERE Devolucion_factura = F.Factura_codigo)
                                                        AND F.Factura_fecha_venc > GETDATE() AND E.Empresa_habilitada = 1 AND F.Factura_rendicion IS NULL");
            }

            if (string.IsNullOrEmpty(txtDNICliente.Text) && string.IsNullOrEmpty(txtNroFactura.Text))
            {
                dgdFacturas.DataSource = null; return;
            }
           string query_nro_factura = null, query_dni = null, query_final = null;
           
            if (!string.IsNullOrEmpty(txtDNICliente.Text))
            {
                query_dni = " AND C.Cliente_dni LIKE @dni";
            }
            if (!string.IsNullOrEmpty(txtNroFactura.Text))
            {
                query_nro_factura = " AND F.Factura_codigo LIKE @nro_factura";
            }
            query_final = string.Format(@"SELECT Factura_codigo Código, Factura_fecha Fecha, Factura_total Total, Factura_fecha_venc Fecha_Vencimiento, Factura_cliente Codigo_Cliente, Cliente_dni DNI_Cliente, Factura_empresa Empresa 
                                           FROM LORDS_OF_THE_STRINGS_V2.Factura F
                                           JOIN LORDS_OF_THE_STRINGS_V2.Cliente C ON (F.Factura_cliente = C.Cliente_codigo)"+join_empresas+
                                           "WHERE Factura_habilitada = 1 AND Cliente_habilitado = 1" + query_pagos_disponibles + query_dni + query_nro_factura);
            PagoDAO.buscar_factura(dgdFacturas, query_final, txtNroFactura.Text, txtDNICliente.Text);
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

        private Factura get_factura_a_pagar_seleccionada_grilla()
        {
            if (facturas_a_pagar.Count != 0)
            {
                return (Factura) dgdFacturasAPagar.CurrentRow.DataBoundItem;
            }
            return null;
        }

        private int get_id_factura_a_pagar_seleccionada_grilla()
        {
            int id = int.Parse(dgdFacturasAPagar.SelectedCells[0].Value.ToString());
            return id;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void cmdAgregarFactura_Click(object sender, EventArgs e)
        {
            if (dgdFacturas.DataSource == null || dgdFacturas.RowCount == 0)
            {
                return;
            }
            Factura factura = get_factura_seleccionada_grilla();

            if (validar_factura(factura) || (chkSoloPosibles.Checked))
            {
                facturas_a_pagar.Add(factura);
                actualizar_facturas_a_pagar();
            }    
        }

        private bool validar_factura(Factura factura)
        {
            int estado = FacturaDAO.estado_factura(factura.id);
            if (estado != 1)
            {
                if (estado == 2 || estado == 3)
                {
                    MessageBox.Show("Esta factura ya se encuentra pagada!", "Error pagar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return false;
            }
            if (!factura.empresa.habilitada)
            {
                MessageBox.Show("Lo sentimos la Empresa de esta Factura se encuentra inactiva!", "Error agregar Factura para pagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (facturas_a_pagar.Any(f => f.id == factura.id))
            {
                MessageBox.Show("Esa Factura ya se encuentra en las Facturas a pagar!", "Error agregar Factura para pagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (factura.fecha_venc < DateTime.Now)
            {
                MessageBox.Show("Lo sentimos esa factura está vencida!", "Error pagar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private double calcular_total()
        {
            return facturas_a_pagar.Sum(f => f.total);
        }

        private void dgdFacturasAPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizar_items();
        }

        private void actualizar_facturas_a_pagar()
        {
            if (calcular_total() == 0)
            {
                lblTotalCalculado.Text = "";
            }
            else
            {
                lblTotalCalculado.Text = "" + calcular_total();
            }
            dgdFacturasAPagar.DataSource = null;
            dgdFacturasAPagar.DataSource = facturas_a_pagar;
            dgdFacturasAPagar.Refresh();
            set_name_grilla_facts_pagar();
            actualizar_items();
        }
        private void actualizar_items()
        {
            dgdItemsFactura.DataSource = null;
            Factura fact_pagar_selec = get_factura_a_pagar_seleccionada_grilla();
            if(fact_pagar_selec == null){
                return;
            }
            List<Item_Factura> items = FacturaDAO.obtener_items_factura(fact_pagar_selec);  
            dgdItemsFactura.DataSource = items;
            set_name_grilla_items();
        }
        
        private void set_name_grilla_items(){
            dgdItemsFactura.Columns[0].HeaderCell.Value = "Código";
            dgdItemsFactura.Columns[1].HeaderCell.Value = "Monto";
            dgdItemsFactura.Columns[2].HeaderCell.Value = "Cantidad";

            dgdItemsFactura.Columns[3].Visible = false;
            dgdItemsFactura.Columns[4].Visible = false;
        }

        private void set_name_grilla_facts_pagar()
        {
            dgdFacturasAPagar.Columns[0].HeaderCell.Value = "Código";
            dgdFacturasAPagar.Columns[1].HeaderCell.Value = "Fecha";
            dgdFacturasAPagar.Columns[2].HeaderCell.Value = "Total";
            dgdFacturasAPagar.Columns[3].HeaderCell.Value = "Fecha_Vencimiento";

            dgdFacturasAPagar.Columns[4].Visible = false;
            dgdFacturasAPagar.Columns[5].Visible = false;
            dgdFacturasAPagar.Columns[6].Visible = false;
            dgdFacturasAPagar.Columns[7].Visible = false;
        }

        private void cmdQuitarFactura_Click(object sender, EventArgs e)
        {
            facturas_a_pagar.RemoveAll(f => f.id == get_id_factura_a_pagar_seleccionada_grilla());
            actualizar_facturas_a_pagar();
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
                if (facturas_a_pagar.Count <= 0)
                {
                    MessageBox.Show("Seleccione al menos una factura a pagar.", "Error registro de pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
                {
                    List<Pago> pagos = new List<Pago>();
                    foreach (Factura f in facturas_a_pagar)
                    {
                        pagos.Add(convert_to_pago(f));
                    }
                    if (MessageBox.Show("¿Está ud. seguro de querer efectuar el pago de $" + lblTotalCalculado.Text + " en PagoAgilFrba?", "Confirmar pago", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (PagoDAO.agregar_pagos(pagos))
                        {
                            MessageBox.Show("Pago/s efectuados correctamente!", "Registro de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
        }

        private Pago convert_to_pago(Factura _factura)
        {
            return new Pago(_factura.total, sucursal_actual.id, ((Forma_Pago) cboFormasPago.SelectedItem).id, _factura.id);
        }

        private void lnlCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.cerrar_sesion();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
