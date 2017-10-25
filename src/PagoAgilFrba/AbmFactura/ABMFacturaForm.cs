using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using PagoAgilFrba.Model;
using PagoAgilFrba.DAOs;
using PagoAgilFrba.Utilidades;

namespace PagoAgilFrba.AbmFactura
{
    public partial class ABMFacturaForm : Form
    {
        private double totalSS;
        private List<Empresa> empresas;
        private List<Item_Factura> items;

        private Factura selectedBM;

        private List<Control> campos_obligatorios_ALTA;
        private List<Control> campos_obligatorios_ITEM;

        private bool filtrando = false;
        private string filtro = "";
        int idFiltro = 0;

        public ABMFacturaForm()
        {
            InitializeComponent();
        }

        private void ABMFacturaForm_Load(object sender, EventArgs e)
        {
            this.campos_obligatorios_ALTA = new List<Control>() { txtCliente, txtFactura, txtCliente, vencimientoDateTimePicker };
            this.campos_obligatorios_ITEM = new List<Control>() {txtCantidad, txtMonto};

            listEmpresas.Items.Clear();

            listEmpresas.Columns.Add("", 25);
            listEmpresas.Columns.Add("Empresa", 100);
            listEmpresas.Columns.Add("Direccion", 100);
            listEmpresas.Columns.Add("CUIT", 100);

            listEmpresas.View = View.Details;
            listEmpresas.FullRowSelect = true;
            listEmpresas.LabelEdit = false;
            listEmpresas.AllowColumnReorder = false;
            listEmpresas.GridLines = true;

            empresas = FacturaDAO.obtener_empresas(1);

            for (int i = 1; i <= empresas.Count; i++)
            {
                populateListEmpresas(i.ToString(), empresas[i - 1].nombre, empresas[i - 1].direccion, empresas[i - 1].cuit);
            }

            totalSS = 0;

            listDetalle.Items.Clear();

            listDetalle.Columns.Add("Item", 125);
            listDetalle.Columns.Add("Monto", 100);
            listDetalle.Columns.Add("Cantidad", 100);

            listDetalle.View = View.Details;
            listDetalle.FullRowSelect = true;
            listDetalle.LabelEdit = true;
            listDetalle.AllowColumnReorder = false;
            listDetalle.GridLines = true;

            //--------TAB BM
            
            cargarListFacturasBM();
           
        }

        private void cargarListFacturasBM()
        {
            string query;
            
            if (filtrando)
            {
                query = string.Format(@"SELECT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_habilitada  
            FROM LORDS_OF_THE_STRINGS_V2.Factura F 
            WHERE F.Factura_codigo NOT IN (select Pago_factura from LORDS_OF_THE_STRINGS_V2.Pago)" + filtro);
                FacturaDAO.cargarFacturasFiltrada(dataGridFacturasBM, idFiltro, query, "@idFiltro");
            }
            else
            {
                query = string.Format(@"SELECT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_habilitada  
            FROM LORDS_OF_THE_STRINGS_V2.Factura F 
            WHERE F.Factura_codigo NOT IN (select Pago_factura from LORDS_OF_THE_STRINGS_V2.Pago)");
                DBConnection.llenar_grilla(dataGridFacturasBM, query);
            }

            loadFacturaSeleccionada();
            cargarItemsFacturaSeleccionada();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreItem = txtItem.Text;
            double monto = 0;
            int cantidad = 0;
            bool error = false;
            if (Utilidades.Utils.cumple_campos_obligatorios(campos_obligatorios_ITEM, errorProvider))
            {
                try
                {
                    monto = Convert.ToDouble(txtMonto.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al convertir '" + txtMonto.Text + "'");
                    error = true;
                    txtMonto.Text = "";
                }

                try
                {
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                }
                catch (Exception)
                {
                    if (!error)
                    {
                        MessageBox.Show("Error al convertir '" + txtCantidad.Text + "'");
                        error = true;
                    }
                    txtCantidad.Text = "";
                }
                if (!error)
                {
                    totalSS = totalSS + monto * cantidad;
                    lblTotal.Text = "$" + totalSS.ToString();
                    populateListDetalle(nombreItem.ToString(), monto.ToString(), cantidad.ToString());
                    txtItem.Text = "";
                    txtMonto.Text = "";
                    txtCantidad.Text = "";
                }
            }       
        }

        private void populateListEmpresas(string pos, string nombre, string direcc, string cuit)
        {
            String[] row = { pos, nombre, direcc, cuit };
            listEmpresas.Items.Add(new ListViewItem(row));
        }

        private void populateListDetalle(string item, string monto, string cantidad)
        {
            String[] row = { item, monto, cantidad };
            listDetalle.Items.Add(new ListViewItem(row));
        }

        //private void populateListItems(string id, string monto, string cantidad)
        //{
        //    String[] row = { id, monto, cantidad };
        //    listItems.Items.Add(new ListViewItem(row));
        //}

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listDetalle.SelectedItems.Count > 0)
            {
                try
                {
                    double monto = Convert.ToDouble(listDetalle.SelectedItems[0].SubItems[1].Text.ToString());
                    int cantidad = Convert.ToInt32(listDetalle.SelectedItems[0].SubItems[2].Text.ToString());
                    totalSS = totalSS - (monto * cantidad);
                    lblTotal.Text = "$" + totalSS.ToString();
                    listDetalle.SelectedItems[0].Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utils.cumple_campos_obligatorios(campos_obligatorios_ALTA, errorProvider) && listEmpresas.SelectedItems.Count > 0)
            {
                lblMensaje.ForeColor = Color.Black;
                lblMensaje.Visible = true;
                lblMensaje.Text = "Espere por favor...";

                DateTime fecha = vencimientoDateTimePicker.Value;

                if (fecha < DateTime.Now)
                {
                    lblMensaje.ForeColor = Color.DarkRed;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "La fecha ingresada es anterior a la actual";
                }
                else
                {
                    Empresa empresaSelec = getEmpresaSeleccionada();

                    if (empresaSelec == null)
                    {
                        MessageBox.Show("Error al seleccionar empresa");
                    }
                    else
                    {
                        int idCliente = int.Parse(txtCliente.Text);

                        Factura nueva = new Factura(0, DateTime.Now, totalSS, fecha, empresaSelec, FacturaDAO.obtener_cliente_con_ID(idCliente), null);
                        generarListaItems();

                        int value = FacturaDAO.ingresar_factura_e_items(nueva, this.items);
                        if (value != 0)
                        {
                            exito(value);
                            
                        }
                        else
                        {
                            lblMensaje.ForeColor = Color.DarkRed;
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "Error al cargar los datos";
                        }
                    }
                }
            }
            else
            {
                lblMensaje.ForeColor = Color.DarkRed;
                lblMensaje.Visible = true;
                lblMensaje.Text = "Complete los Campos obligatorios";
            }
        }

        private void exito(int idFactura)
        {
            txtCliente.Text = "";
            txtFactura.Text = "";
            vencimientoDateTimePicker.Value = DateTime.Now;
            listEmpresas.SelectedItems.Clear();

            lblMensaje.ForeColor = Color.Black;
            lblMensaje.Visible = true;
            lblMensaje.Text = "Factura Nº " + idFactura + " Ingresada";

            listDetalle.Clear();
            totalSS = 0;
            lblTotal.Text = "$0";

            actualizarTabBM();
        }

        public void actualizarTabBM()
        {
            //--------ACTUALIZO LA LISTA EN TAB BM
            cargarItemsFacturaSeleccionada();
            cargarListFacturasBM();
        }

        private void generarListaItems()
        {
            items = new List<Item_Factura>();

            foreach (ListViewItem it in listDetalle.Items)
            {
                double monto = Convert.ToDouble(it.SubItems[1].Text.ToString());
                int cantidad = Convert.ToInt32(it.SubItems[2].Text.ToString());

                items.Add(new Item_Factura(0,monto, cantidad, null));
            }
        }

        private Empresa getEmpresaSeleccionada()
        {
            string cuitL = listEmpresas.SelectedItems[0].SubItems[3].Text.ToString();
            foreach (Empresa emp in empresas)
            {
                if (emp.cuit == cuitL)
                {
                    return emp;
                }
            }
            return null;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void loadFacturaSeleccionada()
        {
            try
            {
                //Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_rendicion, Factura_habilitada 

                string asd = dataGridFacturasBM.SelectedCells[0].Value.ToString();
                int factura_id = int.Parse(asd);
                DateTime fecha = DateTime.Parse(dataGridFacturasBM.SelectedCells[1].Value.ToString());
                double totalFactura = double.Parse(dataGridFacturasBM.SelectedCells[2].Value.ToString());
                DateTime fechaVenc = DateTime.Parse(dataGridFacturasBM.SelectedCells[3].Value.ToString());
                int idEmpresa = int.Parse(dataGridFacturasBM.SelectedCells[4].Value.ToString());
                int idCliente = int.Parse(dataGridFacturasBM.SelectedCells[5].Value.ToString());
                bool habilitada = bool.Parse(dataGridFacturasBM.SelectedCells[6].Value.ToString());

                selectedBM = new Factura(
                    factura_id,
                    fecha,
                    totalFactura,
                    fechaVenc,
                    new Empresa(idEmpresa, "", "", "", true),                                   //Ni empresa ni cliente me importan en esta seleccion
                    new Cliente(idCliente,"","",0,DateTime.Now,"","","","",true),
                    null,
                    habilitada
                    );
            }
            catch (Exception)
            {
                selectedBM = null;
            }
        }

        private void btnBorrarFactura_Click(object sender, EventArgs e)
        {
 
        }

        private void btnVerItems_Click(object sender, EventArgs e)
        {
           
        }

        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            loadFacturaSeleccionada();
            if (selectedBM != null)
            {
                ModificarFacturas form = new ModificarFacturas(selectedBM, this);
                form.Show();
            }
        }

        private void btnBorrarItem_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarItem_Click(object sender, EventArgs e)
        {
            if (selectedBM != null)
            {
                selectedBM.items = itemsEnGrid();
                ModificarItems form = new ModificarItems(selectedBM, this);
                form.Show();
            }
        }

        private List<Item_Factura> itemsEnGrid()
        {
            List<Item_Factura> ret = new List<Item_Factura>();
            foreach (DataGridViewRow fila in dataGridItems.Rows)
            {
                int idItem = int.Parse(fila.Cells[0].Value.ToString());
                double montoItem = double.Parse(fila.Cells[2].Value.ToString());
                int cantidadItem = int.Parse(fila.Cells[1].Value.ToString());
                Item_Factura it = new Item_Factura(
                           idItem,
                           montoItem,
                           cantidadItem,
                           selectedBM
                           );
                ret.Add(it);

            }
            return ret;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridFacturasBM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            loadFacturaSeleccionada();
            if (selectedBM != null)
            {
                if (selectedBM.habilitada)  //Si esta habilitada modifico
                {
                    selectedBM.habilitada = false;
                    if (FacturaDAO.modificarFactura(selectedBM) != 0)
                    {
                        MessageBox.Show("Factura Nº " + selectedBM.id + " inhabilitada");
                        cargarListFacturasBM();
                    }
                    else{
                        MessageBox.Show("Error al inhabilitar factura Nº " + selectedBM.id);
                    }
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            loadFacturaSeleccionada();
            if (selectedBM != null)
            {
                if (!selectedBM.habilitada)  //Si no esta habilitada modifico
                {
                    selectedBM.habilitada = true;
                    if (FacturaDAO.modificarFactura(selectedBM) != 0)
                    {
                        MessageBox.Show("Factura Nº " + selectedBM.id + " habilitada");
                        cargarListFacturasBM();
                    }
                    else
                    {
                        MessageBox.Show("Error al inhabilitar factura Nº " + selectedBM.id);
                    }
                }
            }
        }

        private void dataGridFacturasBM_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cargarItemsFacturaSeleccionada();
        }

        private void cargarItemsFacturaSeleccionada()
        {
            loadFacturaSeleccionada();
            dataGridItems.DataSource = null;
            dataGridItems.Rows.Clear();
            if (selectedBM != null)
            {
                FacturaDAO.cargarGridItemsFactura(dataGridItems, selectedBM);
            }
        }

        private void btnFiltrarIdFactura_Click(object sender, EventArgs e)
        {
            try
            {
                idFiltro = int.Parse(txtIdFacturaFiltro.Text.ToString());
            }
            catch (Exception)
            {
                string mensaje = txtIdFacturaFiltro.Text.ToString() + " no es un Nº de factura válido";
                if (txtIdFacturaFiltro.Text.ToString() == "")
                {
                    mensaje = "Debe ingresar un valor a buscar";
                }
                MessageBox.Show(mensaje);
                return;
            }

            filtro = " AND Factura_codigo = @idFiltro";
            filtrando = true;
            cargarListFacturasBM();
        }

        private void btnFiltrarIdCliente_Click(object sender, EventArgs e)
        {
            try
            {
                idFiltro = int.Parse(txtIdClienteFiltro.Text.ToString());
            }
            catch (Exception)
            {
                string mensaje = txtIdClienteFiltro.Text.ToString() + " no es un Nº de cliente válido";
                if (txtIdClienteFiltro.Text.ToString() == "")
                {
                    mensaje = "Debe ingresar un valor a buscar";
                }
                MessageBox.Show(mensaje);
                return;
            }

            filtro = " AND Factura_cliente = @idFiltro";
            filtrando = true;
            cargarListFacturasBM();
        }

        private void btnSinFiltros_Click(object sender, EventArgs e)
        {
            txtIdFacturaFiltro.Text = "";
            txtIdClienteFiltro.Text = "";
            filtro = "";
            filtrando = false;
            idFiltro = 0;
            cargarListFacturasBM();
        }

    }
}
