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
        Cliente clienteSelected = null;

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
            txtClienteSeleccionado.Text = f.cliente.nombre + " " + f.cliente.apellido;
            clienteSelected = f.cliente;
            dataGridEmpresas.Enabled = false;
            this.Text = "Factura Nº " + f.id;
        }

        private void ModificarFacturas_Load(object sender, EventArgs e)
        {
            this.camposObligatorios = new List<Control>() { txtFacturaNro, txtFiltroCliente, txtFacturaEmpresa, txtFacturaTotal, vencimientoDateTimePicker, altaDateTimePicker };
        }

        private void btnSeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            if (!dataGridEmpresas.Enabled)
            {
                Utilidades.Utils.clearDataGrid(dataGridEmpresas);
                dataGridEmpresas.Enabled = true;
                FacturaDAO.llenarGridConEmpresas(dataGridEmpresas,1);
                btnSeleccionarEmpresa.Text = "Seleccionar";
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
                        btnSeleccionarEmpresa.Text = "Cambiar";
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void enableCambiarCliente(Boolean enabled)
        {
            txtFiltroCliente.Enabled = enabled;
            btnBuscarPorDNI.Enabled = enabled;
            dataGridClientes.Enabled = enabled;
        }

        private void btnCambiarCliente_Click(object sender, EventArgs e)
        {
            if (!dataGridClientes.Enabled)
            {
                Utilidades.Utils.clearDataGrid(dataGridClientes);
                enableCambiarCliente(true);
                btnSeleccionarEmpresa.Text = "Seleccionar";
            }
            else
            {
                loadClienteSeleccionado();
                if (clienteSelected != null)
                {
                    if (clienteSelected.nombre != txtClienteSeleccionado.Text)
                    {
                        factura.cliente = clienteSelected;
                        txtClienteSeleccionado.Text = factura.cliente.nombre + " " + factura.cliente.apellido;
                        btnCambiarCliente.Text = "Cambiar";
                    }
                }
            }
        }

        private void btnBuscarPorDNI_Click(object sender, EventArgs e)
        {
            if (txtFiltroCliente.Text != "" && txtFiltroCliente.Enabled)
            {
                ClienteDAO.llenarGridBuscarCliente(dataGridClientes, txtFiltroCliente.Text.ToString());
            }
        }

        private void loadClienteSeleccionado()
        {
            try
            {
                int cliente_id = int.Parse(dataGridClientes.SelectedCells[0].Value.ToString());
                uint dni = uint.Parse(dataGridClientes.SelectedCells[1].Value.ToString());
                string nombre = dataGridClientes.SelectedCells[2].Value.ToString();
                string apellido = dataGridClientes.SelectedCells[3].Value.ToString();
                DateTime fnac = DateTime.Parse(dataGridClientes.SelectedCells[4].Value.ToString());
                string mail = dataGridClientes.SelectedCells[5].Value.ToString();
                string direccion = dataGridClientes.SelectedCells[6].Value.ToString();
                string cp = dataGridClientes.SelectedCells[7].Value.ToString();
                string telefono = dataGridClientes.SelectedCells[8].Value.ToString();


                clienteSelected = new Cliente(
                    cliente_id,
                    nombre,
                    apellido,
                    dni,
                    fnac,
                    direccion,
                    cp,
                    mail,
                    telefono,
                    true
                    );
            }
            catch (Exception)
            {
                clienteSelected = null;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                Factura modificada = new Factura(factura.id, altaDateTimePicker.Value, factura.total, vencimientoDateTimePicker.Value, factura.empresa, clienteSelected, null);

                if (FacturaDAO.modificarFactura(modificada) != 0)
                {
                    this.Close();
                    MessageBox.Show("Factura Nº " + factura.id + " modificada");
                    this.backForm.actualizarTabBM();
                }
                else
                {
                    MessageBox.Show("Error al modificar Factura " + factura.id);
                }
            
        }

    }
}
