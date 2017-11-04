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
    public partial class ModificarItems : Form
    {
        private Factura factura;
        private double total;
        private List<Item_Factura> borrados;
        ABMFacturaForm backForm;
        bool cambio = false;
        
        public ModificarItems(Factura f, ABMFacturaForm back)
        {
            InitializeComponent();
            factura = f;
            txtFacturaNumero.Text = f.id.ToString();
            this.Text = "PagoAgilFrba | Items de Factura Nº " + f.id.ToString();
            actualizarListItems();
            backForm = back;
        }

        private void camposModifEnBlanco(){
            txtItemNro.Text = "";
            txtItemMonto.Text = "";
            txtItemCantidad.Value = 0;
        }

        private void ModificarItems_Load(object sender, EventArgs e)
        {
            borrados = new List<Item_Factura>();
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedItems.Count > 0)
            {
                    int itemId = int.Parse(listItems.SelectedItems[0].SubItems[1].Text.ToString());
                    cargarCamposConItem(obtenerItemSegunID(itemId));
            }
        }

        private Item_Factura obtenerItemSegunID(int idItem)
        {
            foreach (Item_Factura it in factura.items)
            {
                if (it.id == idItem)
                {
                    return it;
                }
            }
            return null;
        }

        private void actualizarListItems()
        {
            inicializarListItems();
            total = 0;
            if (factura != null)
            {
                foreach (Item_Factura it in factura.items)
                {
                    total = total + it.monto;

                    string identif;
                    if (it.nuevo) identif = "Si";
                    else identif = "No";

                    populateListItems(it.id.ToString(), it.monto.ToString(), it.cantidad.ToString(), factura.id.ToString(), identif);
                }
            }
            lblTotal.Text = "$" + total.ToString();
        }

        private void populateListItems(string id, string monto, string cantidad, string facturaID, string nuevo)
        {
            String[] row = {nuevo, id, monto, cantidad, facturaID };
            listItems.Items.Add(new ListViewItem(row));
        }

        private void inicializarListItems()
        {
            listItems.Items.Clear();
            listItems.Columns.Clear();

            listItems.Columns.Add("Nuevo?", 60);
            listItems.Columns.Add("Item Nº", 60);
            listItems.Columns.Add("Total", 100);
            listItems.Columns.Add("Cantidad", 100);
            listItems.Columns.Add("Factura Nº", 100);

            listItems.View = View.Details;
            listItems.FullRowSelect = true;
            listItems.LabelEdit = false;
            listItems.AllowColumnReorder = false;
            listItems.GridLines = true;
        }

        private void cargarCamposConItem(Item_Factura it)
        {

            txtItemNro.Text = it.id.ToString();
            txtItemCantidad.Value = it.cantidad;
            txtItemMonto.Text = (it.monto/it.cantidad).ToString();

        }

        private void btnGuardarItem_Click(object sender, EventArgs e)
        {
            if (txtFacturaNumero.Text != "" && txtItemNro.Text != "" && txtItemCantidad.Value != 0 && txtItemMonto.Text != "")
            {
                if (txtItemCantidad.Value == 0)
                {
                    MessageBox.Show("No se puede almacenar items con cantidad nula", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                double monto = double.Parse(txtItemMonto.Text.ToString());
                if (monto == 0)
                {
                    MessageBox.Show("No se puede almacenar items con monto nulo", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int cantidad = int.Parse(txtItemCantidad.Text.ToString());
                Item_Factura modificado = new Item_Factura(
                    int.Parse(txtItemNro.Text.ToString()),
                    monto*cantidad,
                    cantidad,
                    factura);
                modificarItemLocal(modificado);
                actualizarListItems();
                cambio = true;
            }
        }

        private void modificarItemLocal(Item_Factura modificado)
        {
            foreach (Item_Factura it in factura.items)
            {
                if (modificado.id == it.id)
                {
                    it.monto = modificado.monto;
                    it.cantidad = modificado.cantidad;
                }
            }
        }

        private void btnGenerarItem_Click(object sender, EventArgs e)
        {
            if (txtNuevoCantidad.Value != 0 && txtNuevoMonto.Text != "")
            {

                double monto = double.Parse(txtNuevoMonto.Text.ToString());
                if (monto <= 0)
                {
                    MessageBox.Show("No es posible generar items con montos nulos", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int cantidad = int.Parse(txtNuevoCantidad.Value.ToString());
                Item_Factura nuevo = new Item_Factura(
                    obtenerIDNuevo(),
                    monto*cantidad,
                    cantidad,
                    factura);
                nuevo.nuevo = true;
                factura.items.Add(nuevo);
                actualizarListItems();
                txtNuevoMonto.Text = "";
                txtNuevoCantidad.Value = 1;
                cambio = true;
            }
        }

        private int obtenerIDNuevo() {
            int id = 1;
            while(idYaExiste(id)){
                id++;
            }
            return id;
        }

        private bool idYaExiste(int idNvo)
        {
            foreach (Item_Factura it in factura.items)
            {
                if (it.id == idNvo) return true;
            }
            return false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItems.Count > 0)
            {
                int itemID = int.Parse(listItems.SelectedItems[0].SubItems[1].Text.ToString());
                borrarItemSegunID(itemID);
                camposModifEnBlanco();
                cambio = true;
            }
            
        }

        private void borrarItemSegunID(int idItem)
        {
            foreach (Item_Factura it in factura.items) {
                if (it.id == idItem)
                {
                    if (!it.nuevo) borrados.Add(it);
                    factura.items.Remove(it);
                    break;
                }
            }
            actualizarListItems();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cambio)
            {
                if (factura.items.Count > 0)
                {
                    if (FacturaDAO.modificarItems(factura.id, factura.items, borrados, total) != 0)
                    {
                        backForm.actualizarTabBM();
                        this.Close();
                        MessageBox.Show("Factura Nº " + factura.id + " actualizada", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Factura Nº " + factura.id, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se permite almacenar una factura vacia", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtItemCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }
        private void txtItemMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
