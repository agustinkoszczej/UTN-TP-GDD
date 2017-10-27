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
        //private List<Empresa> empresas;
        private List<Item_Factura> items;

        private Factura facturaSelectedBM;
        private Empresa empresaSelectedAlta;
        private Cliente clienteSelectedAlta;

        private List<Control> campos_obligatorios_ALTA;
        private List<Control> campos_obligatorios_ITEM;

        private bool filtrando = false;
        private string filtroWhere = "";
        private string filtroJoin = "";
        int idFiltro = 0;

        int itemsIngresados = 0;

        public ABMFacturaForm()
        {
            InitializeComponent();
        }

        private void ABMFacturaForm_Load(object sender, EventArgs e)
        {
            this.campos_obligatorios_ALTA = new List<Control>() {dataGridCliente, dataGridEmpresas, vencimientoDateTimePicker };
            this.campos_obligatorios_ITEM = new List<Control>() {txtCantidad, txtMonto};

            FacturaDAO.llenarGridConEmpresas(dataGridEmpresas,1);

            totalSS = 0;

            inicializarListDetalleAlta();

            //--------TAB BM
            
            cargarListFacturasBM();
           
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------ALTA DE FACTURAS----------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        private void inicializarListDetalleAlta(){
            listDetalle.Items.Clear();

            listDetalle.Columns.Add("Item", 125);
            listDetalle.Columns.Add("Monto", 100);
            listDetalle.Columns.Add("Cantidad", 100);

            listDetalle.View = View.Details;
            listDetalle.FullRowSelect = true;
            listDetalle.LabelEdit = true;
            listDetalle.AllowColumnReorder = false;
            listDetalle.GridLines = true;
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreItem = txtItem.Text;
            double monto = 0;
            int cantidad = 0;
            if (Utilidades.Utils.cumple_campos_obligatorios(campos_obligatorios_ITEM, errorProvider))
            {
                try
                {
                    monto = double.Parse(txtMonto.Text.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("'" + txtMonto.Text + "' no es un monto válido");
                    txtMonto.Text = "";
                    return;
                }

                try
                {
                    cantidad = int.Parse(txtCantidad.Value.ToString());
                }
                catch (Exception)
                {

                    MessageBox.Show("'" + txtCantidad.Text + "' no es una cantidad válida");
                    txtCantidad.Text = "";
                    return;
                }

                if (monto <= 0 || cantidad <= 0)
                {
                    MessageBox.Show("Ni las cantidades ni los montos pueden ser nulos o negativos");
                }
                else
                {
                    totalSS = totalSS + monto * cantidad;
                    lblTotal.Text = "$" + totalSS.ToString();
                    populateListDetalle(nombreItem.ToString(), monto.ToString(), cantidad.ToString());
                    txtItem.Text = "";
                    txtMonto.Text = "";
                    txtCantidad.Text = "";
                    itemsIngresados++;
                }
            }       
        }

        private void populateListDetalle(string item, string monto, string cantidad)
        {
            String[] row = { item, monto, cantidad };
            listDetalle.Items.Add(new ListViewItem(row));
        }

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
                    itemsIngresados--;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utils.cumple_campos_obligatorios(campos_obligatorios_ALTA, errorProvider) && dataGridEmpresas.SelectedRows.Count > 0 && dataGridCliente.SelectedRows.Count > 0)
            {
                lblMensaje.ForeColor = Color.Black;
                lblMensaje.Visible = true;
                lblMensaje.Text = "Espere por favor...";

                DateTime fecha = vencimientoDateTimePicker.Value;

                if (fecha < DateTime.Now)
                {
                    lblMensaje.ForeColor = Color.DarkRed;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "La fecha ingresada es inválida";
                    return;
                }

                if (itemsIngresados < 1)
                {
                    lblMensaje.ForeColor = Color.DarkRed;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "No se pueden generar facturas vacias";
                    return;
                }

                    loadEmpresaSeleccionada();

                    if (empresaSelectedAlta == null)
                    {
                        MessageBox.Show("Error al seleccionar empresa");
                        return;
                    }
                    else
                    {
                        loadClienteSeleccionado();
                        if (clienteSelectedAlta != null)
                        {
                            Factura nueva = new Factura(0, DateTime.Now, totalSS, fecha, empresaSelectedAlta, clienteSelectedAlta, null);
                            generarListaItems();

                            int value = FacturaDAO.ingresar_factura_e_items(nueva, this.items);
                            if (value != 0)
                            {
                                exito(value);
                                return;
                            }
                            else
                            {
                                lblMensaje.ForeColor = Color.DarkRed;
                                lblMensaje.Visible = true;
                                lblMensaje.Text = "Error al cargar los datos";
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al seleccionar cliente");
                            return;
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
            vencimientoDateTimePicker.Value = DateTime.Now;
            
            lblMensaje.ForeColor = Color.Black;
            lblMensaje.Visible = true;
            lblMensaje.Text = "Factura Nº " + idFactura + " Ingresada";

            listDetalle.Clear();
            totalSS = 0;
            lblTotal.Text = "$0";

            actualizarTabBM();
            inicializarListDetalleAlta();
            Utils.clearDataGrid(dataGridCliente);
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

                empresaSelectedAlta = new Empresa(
                    empresa_id,
                    cuit,
                    nombre,
                    direccion,
                    true
                    );
            }
            catch (Exception)
            {
                empresaSelectedAlta = null;
            }
        }

        private void loadClienteSeleccionado()
        {
            try
            {
                int cliente_id = int.Parse(dataGridCliente.SelectedCells[0].Value.ToString());
                uint dni = uint.Parse(dataGridCliente.SelectedCells[1].Value.ToString());
                string nombre = dataGridCliente.SelectedCells[2].Value.ToString();
                string apellido = dataGridCliente.SelectedCells[3].Value.ToString();
                DateTime fnac = DateTime.Parse(dataGridCliente.SelectedCells[4].Value.ToString());
                string mail = dataGridCliente.SelectedCells[5].Value.ToString();
                string direccion = dataGridCliente.SelectedCells[6].Value.ToString();
                string cp = dataGridCliente.SelectedCells[7].Value.ToString();
                string telefono = dataGridCliente.SelectedCells[8].Value.ToString();
                

                clienteSelectedAlta = new Cliente(
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
                clienteSelectedAlta = null;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }















        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------MODIFICACION DE FACTURAS--------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        private void cargarListFacturasBM()
        {

            Utils.clearDataGrid(dataGridFacturasBM);
            Utils.clearDataGrid(dataGridItems);

            if (filtrando)
            {
                string query = string.Format(@"SELECT Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_habilitada  
            FROM LORDS_OF_THE_STRINGS_V2.Factura F " + filtroJoin + 
            " WHERE F.Factura_codigo NOT IN (select Pago_factura from LORDS_OF_THE_STRINGS_V2.Pago)" + filtroWhere);
                FacturaDAO.cargarFacturasFiltrada(dataGridFacturasBM, idFiltro, query, "@idFiltro");
                //loadFacturaSeleccionada();
                cargarItemsFacturaSeleccionada();
            }
        }

        private void btnSinFiltros_Click(object sender, EventArgs e)
        {
            txtIdFacturaFiltro.Text = "";
            txtIdClienteFiltro.Text = "";
            filtroWhere = "";
            filtrando = false;
            idFiltro = 0;
            cargarListFacturasBM();
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
                txtIdFacturaFiltro.Text = "";
                return;
            }
            filtroJoin = "";
            filtroWhere = " AND Factura_codigo = @idFiltro";
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
                txtIdClienteFiltro.Text = "";
                return;
            }
            filtroJoin = " JOIN LORDS_OF_THE_STRINGS_V2.Cliente C ON F.Factura_cliente = C.Cliente_codigo ";
            filtroWhere = " AND C.Cliente_dni = @idFiltro";
            filtrando = true;
            cargarListFacturasBM();
        }


        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            loadFacturaSeleccionada();
            if (facturaSelectedBM != null)
            {
                if (facturaSelectedBM.habilitada)  //Si esta habilitada modifico
                {
                    facturaSelectedBM.habilitada = false;
                    if (FacturaDAO.modificarFactura(facturaSelectedBM) != 0)
                    {
                        MessageBox.Show("Factura Nº " + facturaSelectedBM.id + " inhabilitada");
                        cargarListFacturasBM();
                    }
                    else
                    {
                        MessageBox.Show("Error al inhabilitar factura Nº " + facturaSelectedBM.id);
                    }
                }
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            loadFacturaSeleccionada();
            if (facturaSelectedBM != null)
            {
                if (!facturaSelectedBM.habilitada)  //Si no esta habilitada modifico
                {
                    facturaSelectedBM.habilitada = true;
                    if (FacturaDAO.modificarFactura(facturaSelectedBM) != 0)
                    {
                        MessageBox.Show("Factura Nº " + facturaSelectedBM.id + " habilitada");
                        cargarListFacturasBM();
                    }
                    else
                    {
                        MessageBox.Show("Error al inhabilitar factura Nº " + facturaSelectedBM.id);
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
            Utilidades.Utils.clearDataGrid(dataGridItems);
            if (facturaSelectedBM != null)
            {
                FacturaDAO.cargarGridItemsFactura(dataGridItems, facturaSelectedBM);
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
                           facturaSelectedBM
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

        private void loadFacturaSeleccionada()
        {
            try
            {
                //Factura_codigo, Factura_fecha, Factura_total, Factura_fecha_venc, Factura_empresa, Factura_cliente, Factura_rendicion, Factura_habilitada 
                int factura_id = int.Parse(dataGridFacturasBM.SelectedCells[0].Value.ToString());
                DateTime fecha = DateTime.Parse(dataGridFacturasBM.SelectedCells[1].Value.ToString());
                double totalFactura = double.Parse(dataGridFacturasBM.SelectedCells[2].Value.ToString());
                DateTime fechaVenc = DateTime.Parse(dataGridFacturasBM.SelectedCells[3].Value.ToString());
                int idEmpresa = int.Parse(dataGridFacturasBM.SelectedCells[4].Value.ToString());
                int idCliente = int.Parse(dataGridFacturasBM.SelectedCells[5].Value.ToString());
                bool habilitada = bool.Parse(dataGridFacturasBM.SelectedCells[6].Value.ToString());

                facturaSelectedBM = new Factura(
                    factura_id,
                    fecha,
                    totalFactura,
                    fechaVenc,
                    EmpresaDAO.obtener_empresa_con_ID(idEmpresa),
                    ClienteDAO.obtener_cliente_con_ID(idCliente),
                    null,
                    habilitada
                    );
            }
            catch (Exception)
            {
                facturaSelectedBM = null;
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
            if (facturaSelectedBM != null)
            {
                ModificarFacturas form = new ModificarFacturas(facturaSelectedBM, this);
                form.Show();
            }
        }

        private void btnBorrarItem_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarItem_Click(object sender, EventArgs e)
        {
            if (facturaSelectedBM != null)
            {
                facturaSelectedBM.items = itemsEnGrid();
                ModificarItems form = new ModificarItems(facturaSelectedBM, this);
                form.Show();
            }
        }


        private void generarListaItems()
        {
            items = new List<Item_Factura>();

            foreach (ListViewItem it in listDetalle.Items)
            {
                double monto = Convert.ToDouble(it.SubItems[1].Text.ToString());
                int cantidad = Convert.ToInt32(it.SubItems[2].Text.ToString());

                items.Add(new Item_Factura(0, monto, cantidad, null));
            }
        }


        public void actualizarTabBM()
        {
            cargarItemsFacturaSeleccionada();
            cargarListFacturasBM();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                ClienteDAO.llenarGridBuscarCliente(dataGridCliente, txtCliente.Text.ToString());
            }

        }

        private void dataGridFacturasBM_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //loadFacturaSeleccionada();
            cargarItemsFacturaSeleccionada();
        }
    }
}
