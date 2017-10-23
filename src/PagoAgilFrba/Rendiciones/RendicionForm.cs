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

namespace PagoAgilFrba.Rendicion
{
    public partial class RendicionForm : Form
    {
        Empresa seleccionada = null;
        List<Factura> facturas = null;
        double sumaCobrada;
        double porcentajeComision; //OBTENER DE CONFIG
        double valorComision;
        double totalRendido;

        public RendicionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select Empresa_codigo, Empresa_nombre, Empresa_cuit, Empresa_direccion, Empresa_habilitada from LORDS_OF_THE_STRINGS_V2.Empresa E join LORDS_OF_THE_STRINGS_V2.Factura F on E.Empresa_codigo = F.Factura_empresa join LORDS_OF_THE_STRINGS_V2.Pago P on F.Factura_codigo = P.Pago_factura where MONTH(P.Pago_fecha) = MONTH(GETDATE()) AND F.Factura_rendicion IS NULL";
            RendicionDAO.llenarDataGrid(dataGridEmpresas, query);
            porcentajeComision = 0.1;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            seleccionada = getEmpresaSelec();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una empresa");
            }
            else
            {
                panelEmpresas.Visible = false;
                panelFacturas.Visible = true;
                lblEmpresaSelec.Text = "Empresa Seleccionada: " + seleccionada.nombre;
                facturas = RendicionDAO.obtenerNoRendidasYCargarGrid(dataGridFacturas, seleccionada);
                lblFacturasARendir.Text = facturas.Count.ToString();
                sumaCobrada = obtenerSumaFacturas();
                lblSumaCobrada.Text = "$" + sumaCobrada.ToString();
                lblPorcentajeComision.Text = (100*porcentajeComision).ToString() + "%";
                valorComision = porcentajeComision * sumaCobrada;
                lblValorComision.Text = "$" + valorComision.ToString();
                totalRendido = sumaCobrada - valorComision;
                lblTotalRendido.Text = "$" + totalRendido.ToString();
            }
        }

        private double obtenerSumaFacturas()
        {
            double total = 0;
            foreach (Factura f in facturas)
            {
                total = total + f.total;
            }
            return total;
        }

        private Empresa getEmpresaSelec()
        {
            try
            {
                int empresa_id = int.Parse(dataGridEmpresas.SelectedCells[0].Value.ToString());
                string empresa_nombre = dataGridEmpresas.SelectedCells[1].Value.ToString();
                string empresa_cuit = dataGridEmpresas.SelectedCells[2].Value.ToString();
                string empresa_direccion = dataGridEmpresas.SelectedCells[3].Value.ToString();
                bool empresa_habilitada = bool.Parse(dataGridEmpresas.SelectedCells[4].Value.ToString());

                return new Empresa(empresa_id, empresa_cuit, empresa_nombre, empresa_direccion, empresa_habilitada);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void dataGridEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //int index = e.RowIndex;
            //this.selectedRow = dataGridClientes.Rows[index];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRendir_Click(object sender, EventArgs e)
        {
            Model.Rendicion rend = new Model.Rendicion(0, DateTime.Now, totalRendido);
            int idR = RendicionDAO.nuevaRendicion(rend);

            if (idR == 0)
            {
                MessageBox.Show("Error al generar la rendicion");
            }
            else
            {
                foreach (Factura f in facturas)
                {
                    try
                    {
                        rend.id = idR;
                        f.rendicion = rend;
                        FacturaDAO.modificarFactura(f);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la factura Nº " + f.id); 
                    }
                }
            }
        }
    }
}
