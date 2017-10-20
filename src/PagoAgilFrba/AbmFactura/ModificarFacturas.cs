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

namespace PagoAgilFrba.AbmFactura
{
    public partial class ModificarFacturas : Form
    {
        Factura factura;
        ABMFacturaForm backForm;
        List<Empresa> empresas;
        int idCliente;

        List<Control> camposObligatorios;

        public ModificarFacturas(Factura f, ABMFacturaForm back)
        {
            InitializeComponent();
            backForm = back;
            factura = f;
            txtFacturaNro.Text = f.id.ToString();
            altaDateTimePicker.Value = f.fecha;
            vencimientoDateTimePicker.Value = f.fecha_venc;
            txtFacturaTotal.Text = f.total.ToString();
            txtFacturaEmpresa.Text = f.empresa.nombre;
            txtFacturaCliente.Text = f.cliente.id.ToString();
            idCliente = f.cliente.id;
            listEmpresas.Enabled = false;
            this.Text = "Factura Nº " + f.id;
        }

        private void ModificarFacturas_Load(object sender, EventArgs e)
        {
            this.camposObligatorios = new List<Control>() { txtFacturaNro, txtFacturaCliente, txtFacturaEmpresa, txtFacturaTotal, vencimientoDateTimePicker, altaDateTimePicker };
        }

        private void btnSeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            if (!listEmpresas.Enabled)
            {
                listEmpresas.Items.Clear();
                listEmpresas.Columns.Clear();

                listEmpresas.Columns.Add("", 25);
                listEmpresas.Columns.Add("Empresa", 100);
                listEmpresas.Columns.Add("Direccion", 100);
                listEmpresas.Columns.Add("CUIT", 100);

                listEmpresas.View = View.Details;
                listEmpresas.FullRowSelect = true;
                listEmpresas.LabelEdit = false;
                listEmpresas.AllowColumnReorder = false;
                listEmpresas.GridLines = true;

                listEmpresas.Enabled = true;

                empresas = FacturaDAO.obtener_empresas(1);

                for (int i = 1; i <= empresas.Count; i++)
                {
                    populateListEmpresas(i.ToString(), empresas[i - 1].nombre, empresas[i - 1].direccion, empresas[i - 1].cuit);
                }
            }
            else
            {
                Empresa empresaSelec = getEmpresaSeleccionada();
                if (empresaSelec.nombre != txtFacturaEmpresa.Text)
                {
                    factura.empresa = empresaSelec;
                    txtFacturaEmpresa.Text = factura.empresa.nombre;
                }
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

        private void populateListEmpresas(string pos, string nombre, string direcc, string cuit)
        {
            String[] row = { pos, nombre, direcc, cuit };
            listEmpresas.Items.Add(new ListViewItem(row));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente elegido;
            bool error = false;
            if(idCliente != int.Parse(txtFacturaCliente.Text)){
                elegido = FacturaDAO.obtener_cliente_con_ID(int.Parse(txtFacturaCliente.Text));
                if (elegido == null)
                {
                    MessageBox.Show("Id de cliente ingresado inexistente");
                    error = true;
                }
            }
            else{
                elegido = factura.cliente;
            }

            if (!error)
            {
                Factura modificada = new Factura(factura.id, altaDateTimePicker.Value, factura.total, vencimientoDateTimePicker.Value, factura.empresa, elegido, null);

                if (FacturaDAO.modificarFactura(modificada) != 0)
                {
                    this.Close();
                    MessageBox.Show("Factura " + factura.id + "modificada");
                    this.backForm.actualizarTabBM();
                }
                else
                {
                    MessageBox.Show("Error al modificar Factura " + factura.id);
                }
            }
        }
    }
}
