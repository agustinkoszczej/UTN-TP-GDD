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
        Empresa empresaSelected =null;
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
            dataGridEmpresas.Enabled = false;
            this.Text = "Factura Nº " + f.id;
        }

        private void ModificarFacturas_Load(object sender, EventArgs e)
        {
            this.camposObligatorios = new List<Control>() { txtFacturaNro, txtFacturaCliente, txtFacturaEmpresa, txtFacturaTotal, vencimientoDateTimePicker, altaDateTimePicker };
        }

        private void btnSeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            if (!dataGridEmpresas.Enabled)
            {
                Utilidades.Utils.clearDataGrid(dataGridEmpresas);
                dataGridEmpresas.Enabled = true;
                FacturaDAO.llenarGridConEmpresas(dataGridEmpresas,1);
            }
            else
            {
                loadEmpresaSeleccionada();
                if (empresaSelected != null)
                {
                    if (empresaSelected.nombre != txtFacturaEmpresa.Text)
                    {
                        factura.empresa = empresaSelected;
                        txtFacturaEmpresa.Text = factura.empresa.nombre;
                    }
                }
            }
        }

        private void loadEmpresaSeleccionada()
        {
            try
            {
                //Empresa_codigo, Empresa_cuit, Empresa_nombre, Empresa_direccion

                int empresa_id = int.Parse(dataGridEmpresas.SelectedCells[0].Value.ToString());
                string cuit = dataGridEmpresas.SelectedCells[1].Value.ToString();
                string nombre = dataGridEmpresas.SelectedCells[2].Value.ToString();
                string direccion = dataGridEmpresas.SelectedCells[3].Value.ToString();

                empresaSelected = new Empresa(
                    empresa_id,
                    cuit,
                    nombre,
                    direccion,
                    true
                    );
            }
            catch (Exception)
            {
                empresaSelected = null;
            }
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
