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

            cboTrimestre.Items.Add("1° Trimestre: Enero-Marzo");
            cboTrimestre.Items.Add("2° Trimestre: Abril-Junio");
            cboTrimestre.Items.Add("3° Trimestre: Julio-Septiembre");
            cboTrimestre.Items.Add("4° Trimestre: Octubre-Diciembre");

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
                Utils.clearDataGrid(dtgListado);
                Dictionary<string, int> dict = new Dictionary<string, int>();
                dict.Add("@trimestre", cboTrimestre.SelectedIndex);
                dict.Add("@año", Convert.ToInt32(txtAño.Text));

                switch (cboListados.SelectedIndex)
                {
                    case 0:
                        DBConnection.llenar_grilla_ejecutando_SP("LORDS_OF_THE_STRINGS_V2.sp_porcentaje_de_facturas",
                                                        dtgListado, dict,
                                                        "Error al generar el listado");
                        break;
                    case 1:
                        DBConnection.llenar_grilla_ejecutando_SP("LORDS_OF_THE_STRINGS_V2.sp_empresas_mayor_monto",
                                                        dtgListado, dict,
                                                        "Error al generar el listado");
                        break;
                    case 2:
                        DBConnection.llenar_grilla_ejecutando_SP("LORDS_OF_THE_STRINGS_V2.sp_clientes_mas_pagos",
                                                        dtgListado, dict,
                                                        "Error al generar el listado");
                        break;
                    case 3:
                        DBConnection.llenar_grilla_ejecutando_SP("LORDS_OF_THE_STRINGS_V2.sp_clientes_cumplidores",
                                                        dtgListado, dict,
                                                        "Error al generar el listado");
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