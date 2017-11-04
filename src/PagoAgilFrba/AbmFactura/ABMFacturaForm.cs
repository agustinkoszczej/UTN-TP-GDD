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
        long idFiltro = 0;

        int itemsIngresados = 0;

        public ABMFacturaForm()
        {
            InitializeComponent();
        }

        private void ABMFacturaForm_Load(object sender, EventArgs e)
        {
            this.campos_obligatorios_ALTA = new List<Control>() {dataGridCliente, dataGridEmpresas, vencimientoDateTimePicker };
            this.campos_obligatorios_ITEM = new List<Control>() {txtCantidad, txtMonto};

            EmpresaDAO.llenarGridConEmpresas(dataGridEmpresas,1);

            totalSS = 0;
            vencimientoDateTimePicker.Value = Utils.obtenerFecha();
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
            listDetalle.Columns.Add("Total", 100);
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
                    MessageBox.Show("'" + txtMonto.Text + "' no es un monto válido", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Text = "";
                    return;
                }

                try
                {
                    cantidad = int.Parse(txtCantidad.Value.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("'" + txtCantidad.Text + "' no es una cantidad válida", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Text = "";
                    return;
                }

                if (monto <= 0 || cantidad <= 0)
                {
                    MessageBox.Show("Ni las cantidades ni los montos pueden ser nulos o negativos", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    totalSS = totalSS + monto * cantidad;
                    lblTotal.Text = "$" + totalSS.ToString();
                    populateListDetalle(nombreItem.ToString(), monto, cantidad);
                    txtItem.Text = "";
                    txtMonto.Text = "";
                    //txtCantidad.Text = "";
                    txtCantidad.Value = 1;
                    itemsIngresados++;
                }
            }       
        }

        private void populateListDetalle(string item, double monto, int cantidad)
        {
            String[] row = { item, (monto*cantidad).ToString(), cantidad.ToString() };
            listDetalle.Items.Add(new ListViewItem(row));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (listDetalle.SelectedItems.Count > 0)
            {
                try
                {
                    double monto = Convert.ToDouble(listDetalle.SelectedItems[0].SubItems[1].Text.ToString());
                    //int cantidad = Convert.ToInt32(listDetalle.SelectedItems[0].SubItems[2].Text.ToString());
                    totalSS = totalSS - monto;
                    lblTotal.Text = "$" + totalSS.ToString();
                    listDetalle.SelectedItems[0].Remove();
                    itemsIngresados--;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (fecha <= Utils.obtenerFecha())
                {
                    lblMensaje.ForeColor = Color.DarkRed;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Fecha ingresada es inválida";
                    MessageBox.Show("La fecha ingresada es inválida, no se pueden generar facturas vencidas", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (itemsIngresados < 1)
                {
                    lblMensaje.ForeColor = Color.DarkRed;
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Agregue al menos un item";
                    MessageBox.Show("No ha agregado ningun item, no se puede generar facturas vacias", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                    loadEmpresaSeleccionada();

                    if (empresaSelectedAlta == null)
                    {
                        lblMensaje.ForeColor = Color.DarkRed;
                        lblMensaje.Visible = true;
                        lblMensaje.Text = "Empresa no seleccionada";
                        MessageBox.Show("Error al seleccionar empresa", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        loadClienteSeleccionado();
                        if (clienteSelectedAlta != null)
                        {
                            Factura nueva = new Factura(0, Utils.obtenerFecha(), totalSS, fecha, empresaSelectedAlta, clienteSelectedAlta, null);
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
                            lblMensaje.ForeColor = Color.DarkRed;
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "Cliente no seleccionado";
                            MessageBox.Show("Error al seleccionar cliente", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            vencimientoDateTimePicker.Value = Utils.obtenerFecha();
            
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
                long dni = long.Parse(dataGridCliente.SelectedCells[1].Value.ToString());
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


        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------MODIFICACION DE FACTURAS--------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        private void cargarListFacturasBM()
        {

            Utils.clearDataGrid(dataGridFacturasBM);
            Utils.clearDataGrid(dataGridItems);

            if (filtrando)
            {
                string query = string.Format(@"SELECT Factura_codigo Codigo, Factura_fecha Alta, Factura_total Total, Factura_fecha_venc Vencimiento, Factura_empresa Empresa, Factura_cliente Cliente, Factura_habilitada Habilitada
            FROM LORDS_OF_THE_STRINGS_V2.Factura F " + filtroJoin + 
            " WHERE (SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Pago P2 WHERE P2.Pago_factura = F.Factura_codigo) <= (SELECT COUNT(*) FROM LORDS_OF_THE_STRINGS_V2.Devolucion D WHERE D.Devolucion_factura = F.Factura_codigo) " + filtroWhere);
                FacturaDAO.cargarFacturasFiltrada(dataGridFacturasBM, idFiltro, query, "@idFiltro");
                if (dataGridFacturasBM.Rows.Count < 1)
                {
                    MessageBox.Show("No se encontró ninguna factura habilitada no paga/rendida con esos datos", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cargarItemsFacturaSeleccionada();
                }
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
            facturaSelectedBM = null;
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
                MessageBox.Show(mensaje, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdFacturaFiltro.Text = "";
                return;
            }
            filtroJoin = "";
            filtroWhere = " AND Factura_codigo = @idFiltro";
            filtrando = true;
            cargarListFacturasBM();
            txtIdClienteFiltro.Text = "";
        }

        private void btnFiltrarIdCliente_Click(object sender, EventArgs e)
        {
            try
            {
                idFiltro = long.Parse(txtIdClienteFiltro.Text.ToString());
            }
            catch (Exception)
            {
                string mensaje = txtIdClienteFiltro.Text.ToString() + " no es un Nº de cliente válido";
                if (txtIdClienteFiltro.Text.ToString() == "")
                {
                    mensaje = "Debe ingresar un valor a buscar";
                }
                MessageBox.Show(mensaje, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdClienteFiltro.Text = "";
                return;
            }
            filtroJoin = " JOIN LORDS_OF_THE_STRINGS_V2.Cliente C ON F.Factura_cliente = C.Cliente_codigo ";
            filtroWhere = " AND C.Cliente_dni = @idFiltro";
            filtrando = true;
            cargarListFacturasBM();
            txtIdFacturaFiltro.Text = "";
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
                        MessageBox.Show("Factura Nº " + facturaSelectedBM.id + " inhabilitada", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListFacturasBM();
                    }
                    else
                    {
                        MessageBox.Show("Error al inhabilitar factura Nº " + facturaSelectedBM.id, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La Factura seleccionada ya se encuentra deshabilitada!", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Factura Nº " + facturaSelectedBM.id + " habilitada", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarListFacturasBM();
                    }
                    else
                    {
                        MessageBox.Show("Error al habilitar factura Nº " + facturaSelectedBM.id, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else{
                    MessageBox.Show("La Factura seleccionada ya se encuentra habilitada!", "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificarFactura_Click(object sender, EventArgs e)
        {
            loadFacturaSeleccionada();

            if (facturaSelectedBM == null)
            {
                return;
            }

            if (facturaSelectedBM.cliente == null)
            {
                MessageBox.Show("Se produjo un error al buscar el cliente dueño de la factura Nº" + facturaSelectedBM.id, "PagoAgilFrba | ABM Factura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ModificarFacturas form = new ModificarFacturas(facturaSelectedBM, this);
            form.Show();

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

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.solo_numeros(e);
        }
        private void txtNumerosCoNComa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
