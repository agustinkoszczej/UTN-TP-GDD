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
        public RegistroPagoForm()
        {
            InitializeComponent();
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
            Utils.limpiar_controles((new List<Control>() { txtDNICliente, txtNroFactura}));
            //iniciar_formulario();
        }
    }
}
