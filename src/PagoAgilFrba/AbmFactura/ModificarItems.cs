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
    public partial class ModificarItems : Form
    {
        private Factura factura;
        private double total;
        private List<Item_Factura> borrados;
        ABMFacturaForm backForm;
        
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
            txtItemCantidad.Text = "";
        }

        private void ModificarItems_Load(object sender, EventArgs e)
        {
            borrados = new List<Item_Factura>();
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedItems.Count > 0)
            {
                int itemId = int.Parse(listItems.SelectedItems[0].SubItems[0].Text.ToString());
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
                    total = total + (it.monto * it.cantidad);

                    string identif;
                    if (it.nuevo) identif = "Nuevo";
                    else identif = it.id.ToString();

                    populateListItems(identif, it.monto.ToString(), it.cantidad.ToString(), factura.id.ToString());
                }
            }
            lblTotal.Text = "$" + total.ToString();
        }

        private void populateListItems(string id, string monto, string cantidad, string facturaID)
        {
            String[] row = { id, monto, cantidad, facturaID };
            listItems.Items.Add(new ListViewItem(row));
        }

        private void inicializarListItems()
        {
            listItems.Items.Clear();
            listItems.Columns.Clear();

            listItems.Columns.Add("Item Nº", 60);
            listItems.Columns.Add("Monto", 100);
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
            txtItemCantidad.Text = it.cantidad.ToString();
            txtItemMonto.Text = it.monto.ToString();

        }

        private void btnGuardarItem_Click(object sender, EventArgs e)
        {
            if (txtFacturaNumero.Text != "" && txtItemNro.Text != "" && txtItemCantidad.Text != "" && txtItemMonto.Text != "")
            {
                Item_Factura modificado = new Item_Factura(
                    int.Parse(txtItemNro.Text.ToString()),
                    double.Parse(txtItemMonto.Text.ToString()),
                    int.Parse(txtItemCantidad.Text.ToString()),
                    factura);
                modificarItemLocal(modificado);
                actualizarListItems();
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
            if (txtNuevoCantidad.Text != "" && txtNuevoMonto.Text != "")
            {
                Item_Factura nuevo = new Item_Factura(
                    obtenerIDNuevo(),
                    double.Parse(txtNuevoMonto.Text.ToString()),
                    int.Parse(txtNuevoCantidad.Text.ToString()),
                    factura);
                nuevo.nuevo = true;
                factura.items.Add(nuevo);
                actualizarListItems();
                txtNuevoMonto.Text = "";
                txtNuevoCantidad.Text = "";
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
                int itemID = int.Parse(listItems.SelectedItems[0].SubItems[0].Text.ToString());
                borrarItemSegunID(itemID);
                camposModifEnBlanco();
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
            if (FacturaDAO.modificarItems(factura.id, factura.items, borrados, total) != 0)
            {
                backForm.actualizarTabBM();
                this.Close();
                MessageBox.Show("Factura Nº " + factura.id + " actualizada");
            }
            else
            {
                MessageBox.Show("Error al actualizar Factura Nº " + factura.id);
            }
        }
    }
}
