using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;

namespace PagoAgilFrba.Rendicion
{
    public partial class RendicionForm : Form
    {
        Empresa seleccionada = null;
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
            cargarEmpresas();



            porcentajeComision = obtenerPorcentajeComision();
        }

        private double obtenerPorcentajeComision()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                return  double.Parse(appSettings["porcentajeComision"].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer App.config");
                return 0;
            }
        }

        private void cargarEmpresas()
        {

            string query = string.Format(@"SELECT Empresa_codigo, Empresa_nombre, Empresa_cuit, Empresa_direccion, Empresa_habilitada 
                                            FROM LORDS_OF_THE_STRINGS_V2.Empresa");
            DBConnection.llenar_grilla(dataGridEmpresas, query);
            //RendicionDAO.llenarDataGrid(dataGridEmpresas, query);
        }

        private void exito(int idRendicion)
        {
            string msj;
            if (idRendicion == 0)
            {
                msj = "No hay facturas que rendir";
            }
            else
            {
                msj = "Rendicion Nº " + idRendicion + " generada";
            }

            panelFacturas.Visible = false;
            panelEmpresas.Visible = true;
            lblMensaje.Text = msj;
            cargarEmpresas();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;
            seleccionada = getEmpresaSelec();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una empresa");
            }
            else
            {

                    if (chkSoloMesActual.Checked)
                    {
                        if (fueRendidaEsteMes(seleccionada.id))
                        {
                            MessageBox.Show("La empresa seleccionada ya fue rendida este mes");
                            return;
                        }
                        else
                        {
                            RendicionDAO.cargarGridFacturasPagadasEsteMes(dataGridFacturas, seleccionada);
                        }
                    }
                    else
                    {
                        bool error = false;
                        mes= 0;
                        anio = 0;
                        try
                        {
                            mes = int.Parse(txtMes.Text.ToString());
                        }
                        catch (Exception)
                        {
                            error = true;
                        }
                        if (mes < 1 || mes > 12) error = true;

                        if (error == true)
                        {
                            string mensaje = "";
                            if (txtMes.Text.ToString() == "")
                            {
                                mensaje = "Ingrese un mes válido";
                            }
                            else
                            {
                                mensaje = "'" + txtMes.Text.ToString() + "' no es un mes válido";
                            }
                            MessageBox.Show(mensaje);
                            return;
                        }

                        try
                        {
                            anio = int.Parse(txtAnio.Text.ToString());
                        }
                        catch (Exception)
                        {
                            error = true;
                        }
                        if (mes < 1) error = true;

                        if (error == true)
                        {
                            string mensaje = "";
                            if (txtAnio.Text.ToString() == "")
                            {
                                mensaje = "Ingrese un año válido";
                            }
                            else
                            {
                                mensaje = "'" + txtAnio.Text.ToString() + "' no es un año válido";
                            }
                            MessageBox.Show(mensaje);
                            return;
                        }
                        if (fueRendidaMesEspecifico(seleccionada.id,mes, anio))
                        {
                            MessageBox.Show("La empresa seleccionada ya fue rendida en el mes ingresado");
                        }
                        else
                        {
                            RendicionDAO.cargarGridFacturasPagadasMesEspecificado(dataGridFacturas, seleccionada, mes, anio);
                        }
                    }
                    txtMes.Text = "";
                    txtAnio.Text = "";
                    lblMesAnio.Text = mes.ToString() + "/" + anio.ToString(); 
                    panelEmpresas.Visible = false;
                    panelFacturas.Visible = true;
                    lblEmpresaSelec.Text = "Empresa Seleccionada: " + seleccionada.nombre;
                    lblFacturasARendir.Text = dataGridFacturas.Rows.Count.ToString();
                    if (dataGridFacturas.Rows.Count <= 0)
                    {
                        lblNoHayFacturas.Visible = true;
                    }
                    else
                    {
                        lblNoHayFacturas.Visible = false;
                    }
                    sumaCobrada = obtenerSumaFacturas();
                    lblSumaCobrada.Text = "$" + sumaCobrada.ToString();
                    lblPorcentajeComision.Text = (100*porcentajeComision).ToString() + "%";
                    valorComision = porcentajeComision * sumaCobrada;
                    lblValorComision.Text = "$" + valorComision.ToString();
                    totalRendido = sumaCobrada - valorComision;
                    lblTotalRendido.Text = "$" + totalRendido.ToString();
                }
            
        }

        private bool fueRendidaEsteMes(int idEmpresa)
        {
            return RendicionDAO.fn_empresa_rendida_este_mes(idEmpresa);
        }

        private bool fueRendidaMesEspecifico(int idEmpresa, int mes, int anio)
        {
            return RendicionDAO.fn_empresa_rendida_mes_especifico(idEmpresa, mes, anio);
        }

        private double obtenerSumaFacturas()
        {
            double total = 0;
            foreach (DataGridViewRow fila in dataGridFacturas.Rows)
            {
                total = total + double.Parse(fila.Cells[2].Value.ToString());
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
            catch (Exception)
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
            //HACER ESTO EN UNA TRANSACTION?

            if (dataGridFacturas.Rows.Count == 0)
            {
                exito(0);
            }
            else
            {
                
                Model.Rendicion rend = new Model.Rendicion(0, DateTime.Now, totalRendido);
                int idR = RendicionDAO.nuevaRendicion(rend);
                if (idR == 0)
                {
                    MessageBox.Show("Error al generar la rendicion");
                }
                else
                {
                    foreach (DataGridViewRow fila in dataGridFacturas.Rows)
                    {
                        string idFactura = fila.Cells[0].Value.ToString(); ///Para mostrar en el msgbox
                        try
                        {
                            rend.id = idR;
                            Factura f = new Factura(
                                    int.Parse(fila.Cells[0].Value.ToString()),
                                    DateTime.Parse(fila.Cells[1].Value.ToString()),
                                    double.Parse(fila.Cells[2].Value.ToString()),
                                    DateTime.Parse(fila.Cells[3].Value.ToString()),
                                    seleccionada,
                                    new Cliente(int.Parse(fila.Cells[4].Value.ToString()), "", "", 0, DateTime.Now, "", "", "", "", true),  //genero cualquier cliente, total solo importa el id en este update
                                    rend);
                            FacturaDAO.modificarFactura(f);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al actualizar la factura Nº " + idFactura);
                            return;
                        }
                    }
                    exito(idR);
                }
            }
        }

        private void panelEmpresas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkSoloMesActual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoloMesActual.Checked)
            {
                panelMesARendir.Enabled = false;
            }
            else
            {
                panelMesARendir.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelFacturas.Visible = false;
            panelEmpresas.Visible = true;
        }
    }
}
