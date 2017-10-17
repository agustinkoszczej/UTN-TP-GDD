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

namespace PagoAgilFrba.AbmFactura
{
    public partial class ABMFacturaForm : Form
    {
        private double totalSS;
        private List<Empresa> empresas;
        private List<Item_Factura> items;
        private List<Control> campos_obligatorios;

        public ABMFacturaForm()
        {
            InitializeComponent();
        }

        private void ABMFacturaForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                string num = i.ToString();
                if (i < 10)
                {
                    num = "0" + num;
                }
                cmbDia.Items.Add(num);
            }

            for (int i = 1; i <= 12; i++)
            {
                string num = i.ToString();
                if (i < 10)
                {
                    num = "0" + num;
                }
                cmbMes.Items.Add(num);
            }

            for (int i = 2017; i >= 1900; i--)
            {
                cmbAnno.Items.Add(i.ToString());
            }

            listEmpresas.Items.Clear();

            listEmpresas.Columns.Add("", 25);
            listEmpresas.Columns.Add("Empresa", 100);
            listEmpresas.Columns.Add("Direccion", 100);
            listEmpresas.Columns.Add("CUIT", 100);

            listEmpresas.View = View.Details;
            listEmpresas.FullRowSelect = true;
            listEmpresas.LabelEdit = false;
            listEmpresas.AllowColumnReorder = false;
            listEmpresas.GridLines = true;

            empresas = FacturaDAO.obtener_empresas_habilitadas();

            for (int i = 1; i <= empresas.Count; i++)
            {
                populateListEmpresas(i.ToString(), empresas[i - 1].nombre, empresas[i - 1].direccion, empresas[i - 1].cuit);
            }

            totalSS = 0;

            listDetalle.Items.Clear();

            listDetalle.Columns.Add("Item", 125);
            listDetalle.Columns.Add("Monto", 100);
            listDetalle.Columns.Add("Cantidad", 100);

            listDetalle.View = View.Details;
            listDetalle.FullRowSelect = true;
            listDetalle.LabelEdit = true;
            listDetalle.AllowColumnReorder = false;
            listDetalle.GridLines = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreItem = txtItem.Text;
            double monto = 0;
            int cantidad = 0;
            bool error = false;
            if (txtMonto.Text != "" && txtCantidad.Text != "")
            {
                try
                {
                    monto = Convert.ToDouble(txtMonto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al convertir '" + txtMonto.Text + "'");
                    error = true;
                    txtMonto.Text = "";
                }

                try
                {
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                }
                catch (Exception ex)
                {
                    if (!error)
                    {
                        MessageBox.Show("Error al convertir '" + txtCantidad.Text + "'");
                        error = true;
                    }
                    txtCantidad.Text = "";
                }
                if (!error)
                {
                    totalSS = totalSS + monto * cantidad;
                    lblTotal.Text = "$" + totalSS.ToString();
                    populateListDetalle(nombreItem.ToString(), monto.ToString(), cantidad.ToString());
                    txtItem.Text = "";
                    txtMonto.Text = "";
                    txtCantidad.Text = "";
                }
            }       
        }

        private void populateListEmpresas(string pos, string nombre, string direcc, string cuit)
        {
            String[] row = { pos, nombre, direcc, cuit };
            listEmpresas.Items.Add(new ListViewItem(row));
        }

        private void populateListDetalle(string item, string monto, string cantidad)
        {
            String[] row = { item, monto, cantidad };
            listDetalle.Items.Add(new ListViewItem(row));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listDetalle.SelectedItems.Count > 0)
            {
                try
                {
                    double monto = Convert.ToDouble(listDetalle.SelectedItems[0].SubItems[1].Text.ToString());
                    int cantidad = Convert.ToInt32(listDetalle.SelectedItems[0].SubItems[2].Text.ToString());
                    totalSS = totalSS - (monto * cantidad);
                    lblTotal.Text = "$" + totalSS.ToString();
                    listDetalle.SelectedItems[0].Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.campos_obligatorios = new List<Control>() { txtCliente, txtFactura, txtCliente, cmbDia, cmbMes, cmbAnno};

            if (Utilidades.Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider) && listEmpresas.SelectedItems.Count > 0)
            {
                lblMensaje.ForeColor = Color.Black;
                lblMensaje.Visible = true;
                lblMensaje.Text = "Espere por favor...";

                Empresa empresaSelec = getEmpresaSeleccionada();

                if (empresaSelec == null)
                {
                    MessageBox.Show("Error al seleccionar empresa");
                }
                else
                {
                    int idCliente = int.Parse(txtCliente.Text);
                    
                    Factura nueva = new Factura(0,DateTime.Now,totalSS, DateTime.Now,empresaSelec, FacturaDAO.obtener_cliente_con_ID(idCliente),null);
                    nueva.fechaCanonica = cmbAnno.SelectedItem.ToString() + cmbMes.SelectedItem.ToString() + cmbDia.SelectedItem.ToString();
                    generarListaItems();
                    
                    
                    if (FacturaDAO.ingresar_factura_e_items(nueva, this.items) == 0)
                    {
                                exito();
                    }
                    else
                    {
                        lblMensaje.ForeColor = Color.DarkRed;
                        lblMensaje.Visible = true;
                        lblMensaje.Text = "Error al cargar los datos";
                    }
                }
            }
            else
            {
                lblMensaje.ForeColor = Color.DarkRed;
                lblMensaje.Visible = true;
                lblMensaje.Text = "Complete los Campos obligatorios";
            }

        }

        private void exito()
        {
            txtCliente.Text = "";
            txtFactura.Text = "";
            cmbAnno.SelectedItem = null;
            cmbDia.SelectedItem = null;
            cmbMes.SelectedItem = null;
            listEmpresas.SelectedItems.Clear();

            lblMensaje.ForeColor = Color.Black;
            lblMensaje.Visible = true;
            lblMensaje.Text = "Factura Ingresada";

            listDetalle.Clear();
            totalSS = 0;
            lblTotal.Text = "$0";
        }

        private void generarListaItems()
        {
            items = new List<Item_Factura>();

            foreach (ListViewItem it in listDetalle.Items)
            {
                double monto = Convert.ToDouble(it.SubItems[1].Text.ToString());
                int cantidad = Convert.ToInt32(it.SubItems[2].Text.ToString());

                items.Add(new Item_Factura(0,monto, cantidad, null));
            }
        }

        private Empresa getEmpresaSeleccionada()
        {
            string cuitL = listEmpresas.SelectedItems[0].SubItems[3].Text.ToString();
            foreach (Empresa emp in empresas)
            {
                if (emp.cuit == cuitL)
                {
                    return emp;
                }
            }
            return null;
        }

    }
}
