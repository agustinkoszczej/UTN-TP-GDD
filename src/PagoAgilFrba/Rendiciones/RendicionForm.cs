﻿using System;
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
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.Rendiciones
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

        private void Form_Load(object sender, EventArgs e)
        {
            cargarEmpresas();
            dateTimeMesAnio.Format = DateTimePickerFormat.Custom;
            dateTimeMesAnio.CustomFormat = "MM/yyyy";

            porcentajeComision = obtenerPorcentajeComision();
            seleccionada = getEmpresaSelec();
            dateTimeMesAnio.Value = Utils.obtenerFecha();
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
            EmpresaDAO.llenarGridConEmpresas(dataGridEmpresas, 1);
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
            lblEspere.Visible = false;
            lblMensaje.Text = msj;
            cargarEmpresas();
            seleccionada = getEmpresaSelec();
        }

     
        private void setPanelRendicion(int mes, int anio)
        {
            dateTimeMesAnio.Value = Utils.obtenerFecha();
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
            lblPorcentajeComision.Text = (100 * porcentajeComision).ToString() + "%";
            valorComision = Math.Round(porcentajeComision * sumaCobrada,2);
            lblValorComision.Text = "$" + valorComision.ToString();
            totalRendido = sumaCobrada - valorComision;
            lblTotalRendido.Text = "$" + totalRendido.ToString();
        }

        private void setPanelRendicion()
        {
            dateTimeMesAnio.Value = Utils.obtenerFecha();
            lblMesAnio.Text = "Todo hasta la fecha";
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
            lblPorcentajeComision.Text = (100 * porcentajeComision).ToString() + "%";
            valorComision = porcentajeComision * sumaCobrada;
            lblValorComision.Text = "$" + valorComision.ToString();
            totalRendido = sumaCobrada - valorComision;
            lblTotalRendido.Text = "$" + totalRendido.ToString();
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
                string empresa_cuit = dataGridEmpresas.SelectedCells[1].Value.ToString();
                string empresa_nombre = dataGridEmpresas.SelectedCells[2].Value.ToString();
                string empresa_direccion = dataGridEmpresas.SelectedCells[3].Value.ToString();

                return new Empresa(empresa_id, empresa_cuit, empresa_nombre, empresa_direccion, true);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRendir_Click(object sender, EventArgs e)
        {
            if (dataGridFacturas.Rows.Count == 0)
            {
                exito(0);
            }
            else
            {

                Model.Rendicion rend = new Model.Rendicion(0, Utils.obtenerFecha(), totalRendido, porcentajeComision);
                int idR = RendicionDAO.nuevaRendicion(rend);
                if (idR == 0)
                {
                    MessageBox.Show("Error al generar la rendicion", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                    new Cliente(int.Parse(fila.Cells[4].Value.ToString()), "", "", 0, Utils.obtenerFecha(), "", "", "", "", true),  //genero cualquier cliente, total solo importa el id en este update
                                    rend,
                                    true); //Se supone que ya busca las habilitadas
                            FacturaDAO.modificarFactura(f);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al actualizar la factura Nº " + idFactura, "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    exito(idR);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            lblEspere.Visible = false;
            panelFacturas.Visible = false;
            panelEmpresas.Visible = true;
        }


        private void btnRendirMesActual_Click(object sender, EventArgs e)
        {
            seleccionada = getEmpresaSelec();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una empresa", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (fueRendidaEsteMes(seleccionada.id))
            {
                MessageBox.Show("La empresa seleccionada ya fue rendida este mes, solo se permite una rendicion mensual por empresa", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                lblEspere.Visible = true;
                RendicionDAO.cargarGridFacturasPagadasEsteMes(dataGridFacturas, seleccionada);
                setPanelRendicion(Utils.obtenerFecha().Month, Utils.obtenerFecha().Year);
            }
        }

        private void btnRendirMesSeleccionado_Click(object sender, EventArgs e)
        {
            seleccionada = getEmpresaSelec();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una empresa", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            int mes = 0;
            int anio = 0;
            if (dateTimeMesAnio.Value > Utils.obtenerFecha())
            {
                MessageBox.Show("La fecha Seleccionada es superior a la actual", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            mes = dateTimeMesAnio.Value.Month;
            anio = dateTimeMesAnio.Value.Year;



            if (fueRendidaEsteMes(seleccionada.id))
            {
                MessageBox.Show("La empresa seleccionada ya fue rendida este mes, solo se permite una rendicion mensual por empresa", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                lblEspere.Visible = true;
                RendicionDAO.cargarGridFacturasPagadasMesEspecificado(dataGridFacturas, seleccionada, mes, anio);
                setPanelRendicion(mes, anio);
            }
        }

        private void btnRendirTodo_Click(object sender, EventArgs e)
        {
            seleccionada = getEmpresaSelec();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una empresa", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (fueRendidaEsteMes(seleccionada.id))
            {
                MessageBox.Show("La empresa seleccionada ya fue rendida este mes, solo se permite una rendicion mensual por empresa", "Error en Rendicion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                lblEspere.Visible = true;
                RendicionDAO.cargarGridFacturasPagadasTotal(dataGridFacturas, seleccionada);
                setPanelRendicion();
            }
        }

    }
}
