using PagoAgilFrba.DAOs;
using PagoAgilFrba.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        private List<Control> campos_obligatorios;

        public ListadoEstadisticoForm()
        {
            InitializeComponent();

            cboTrimestre.Items.Add("1° Trimestre: Enero-Abril");
            cboTrimestre.Items.Add("2° Trimestre: Mayo-Agosto");
            cboTrimestre.Items.Add("3° Trimestre: Septiembre-Diciembre");

            cboListados.Items.Add("Porcentaje de facturas cobradas por empresa");
            cboListados.Items.Add("Empresas con mayor monto rendido");
            cboListados.Items.Add("Clientes con más pagos");
            cboListados.Items.Add("Clientes con mayor porcentaje de facturas pagadas (Clientes cumplidores)");

            this.campos_obligatorios = new List<Control>() { txtAño, cboListados, cboTrimestre };

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (Utils.cumple_campos_obligatorios(campos_obligatorios, errorProvider))
            {
                switch (cboListados.SelectedIndex)
                {
                    case 0:
                        ListadoEstadisticoDAO.cargar_grilla_porcentaje_de_facturas(dtgListado, cboTrimestre.SelectedIndex, txtAño.Text);
                        break;
                    case 1:
                        ListadoEstadisticoDAO.cargar_grilla_empresas_mayor_monto(dtgListado, cboTrimestre.SelectedIndex, txtAño.Text);
                        break;
                    case 2:
                        ListadoEstadisticoDAO.cargar_grilla_clientes_mas_pagos(dtgListado, cboTrimestre.SelectedIndex, txtAño.Text);
                        break;
                    case 3:
                        ListadoEstadisticoDAO.cargar_grilla_clientes_cumplidores(dtgListado, cboTrimestre.SelectedIndex, txtAño.Text);
                        break;
                }

                if (chkArchivo.Checked)
                {
                    //Exportar archivo
                }
            }
        }

        private void cmdQuitarFiltros_Click(object sender, EventArgs e)
        {
            Utils.limpiar_controles((new List<Control>() { txtAño, cboTrimestre, cboListados, dtgListado, chkArchivo }));
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }
    }
}
