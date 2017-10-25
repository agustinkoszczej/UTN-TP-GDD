namespace PagoAgilFrba.AbmFactura
{
    partial class ABMFacturaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAlta = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listDetalle = new System.Windows.Forms.ListView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTextTotal = new System.Windows.Forms.Label();
            this.lblListaDetalle = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabBM = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFiltrarIdCliente = new System.Windows.Forms.Button();
            this.btnFiltrarIdFactura = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.btnModificarItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSinFiltros = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.dataGridFacturasBM = new System.Windows.Forms.DataGridView();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnModificarFactura = new System.Windows.Forms.Button();
            this.txtIdClienteFiltro = new System.Windows.Forms.TextBox();
            this.txtIdFacturaFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridEmpresas = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabAlta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabBM.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturasBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlta);
            this.tabControl1.Controls.Add(this.tabBM);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAlta
            // 
            this.tabAlta.Controls.Add(this.panel3);
            this.tabAlta.Controls.Add(this.panel2);
            this.tabAlta.Controls.Add(this.panel1);
            this.tabAlta.Location = new System.Drawing.Point(4, 22);
            this.tabAlta.Name = "tabAlta";
            this.tabAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlta.Size = new System.Drawing.Size(686, 423);
            this.tabAlta.TabIndex = 0;
            this.tabAlta.Text = "Generar Facturas";
            this.tabAlta.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listDetalle);
            this.panel3.Controls.Add(this.lblMensaje);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Controls.Add(this.btnBorrar);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblTextTotal);
            this.panel3.Controls.Add(this.lblListaDetalle);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.lblCantidad);
            this.panel3.Controls.Add(this.txtMonto);
            this.panel3.Controls.Add(this.lblMonto);
            this.panel3.Controls.Add(this.txtItem);
            this.panel3.Controls.Add(this.lblItem);
            this.panel3.Controls.Add(this.lblDetalle);
            this.panel3.Location = new System.Drawing.Point(7, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 216);
            this.panel3.TabIndex = 3;
            // 
            // listDetalle
            // 
            this.listDetalle.Location = new System.Drawing.Point(324, 23);
            this.listDetalle.Name = "listDetalle";
            this.listDetalle.Size = new System.Drawing.Size(330, 138);
            this.listDetalle.TabIndex = 15;
            this.listDetalle.UseCompatibleStateImageBehavior = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensaje.Location = new System.Drawing.Point(5, 199);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(113, 13);
            this.lblMensaje.TabIndex = 14;
            this.lblMensaje.Text = "Espere por favor...";
            this.lblMensaje.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(592, 190);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(324, 167);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(205, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(55, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$";
            // 
            // lblTextTotal
            // 
            this.lblTextTotal.AutoSize = true;
            this.lblTextTotal.Location = new System.Drawing.Point(19, 167);
            this.lblTextTotal.Name = "lblTextTotal";
            this.lblTextTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTextTotal.TabIndex = 9;
            this.lblTextTotal.Text = "Total:";
            // 
            // lblListaDetalle
            // 
            this.lblListaDetalle.AutoSize = true;
            this.lblListaDetalle.Location = new System.Drawing.Point(321, 6);
            this.lblListaDetalle.Name = "lblListaDetalle";
            this.lblListaDetalle.Size = new System.Drawing.Size(99, 13);
            this.lblListaDetalle.TabIndex = 7;
            this.lblListaDetalle.Text = "Detalles Agregados";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(19, 130);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(262, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(16, 113);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(19, 84);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(262, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(16, 67);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(19, 40);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(262, 20);
            this.txtItem.TabIndex = 2;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(16, 23);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(5, 4);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Detalle";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridEmpresas);
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Location = new System.Drawing.Point(315, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 184);
            this.panel2.TabIndex = 2;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(13, 10);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(107, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Seleccionar Empresa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vencimientoDateTimePicker);
            this.panel1.Controls.Add(this.lblFechaVencimiento);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 184);
            this.panel1.TabIndex = 1;
            // 
            // vencimientoDateTimePicker
            // 
            this.vencimientoDateTimePicker.Location = new System.Drawing.Point(9, 66);
            this.vencimientoDateTimePicker.Name = "vencimientoDateTimePicker";
            this.vencimientoDateTimePicker.Size = new System.Drawing.Size(276, 20);
            this.vencimientoDateTimePicker.TabIndex = 9;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(6, 50);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(9, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(276, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "(*) ID Cliente";
            // 
            // tabBM
            // 
            this.tabBM.Controls.Add(this.panel4);
            this.tabBM.Location = new System.Drawing.Point(4, 22);
            this.tabBM.Name = "tabBM";
            this.tabBM.Padding = new System.Windows.Forms.Padding(3);
            this.tabBM.Size = new System.Drawing.Size(686, 423);
            this.tabBM.TabIndex = 2;
            this.tabBM.Text = "Modificar Facturas";
            this.tabBM.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFiltrarIdCliente);
            this.panel4.Controls.Add(this.btnFiltrarIdFactura);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnSinFiltros);
            this.panel4.Controls.Add(this.btnInhabilitar);
            this.panel4.Controls.Add(this.dataGridFacturasBM);
            this.panel4.Controls.Add(this.btnHabilitar);
            this.panel4.Controls.Add(this.btnModificarFactura);
            this.panel4.Controls.Add(this.txtIdClienteFiltro);
            this.panel4.Controls.Add(this.txtIdFacturaFiltro);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(7, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(673, 410);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnFiltrarIdCliente
            // 
            this.btnFiltrarIdCliente.Location = new System.Drawing.Point(442, 214);
            this.btnFiltrarIdCliente.Name = "btnFiltrarIdCliente";
            this.btnFiltrarIdCliente.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarIdCliente.TabIndex = 20;
            this.btnFiltrarIdCliente.Text = "Buscar";
            this.btnFiltrarIdCliente.UseVisualStyleBackColor = true;
            this.btnFiltrarIdCliente.Click += new System.EventHandler(this.btnFiltrarIdCliente_Click);
            // 
            // btnFiltrarIdFactura
            // 
            this.btnFiltrarIdFactura.Location = new System.Drawing.Point(180, 213);
            this.btnFiltrarIdFactura.Name = "btnFiltrarIdFactura";
            this.btnFiltrarIdFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarIdFactura.TabIndex = 19;
            this.btnFiltrarIdFactura.Text = "Buscar";
            this.btnFiltrarIdFactura.UseVisualStyleBackColor = true;
            this.btnFiltrarIdFactura.Click += new System.EventHandler(this.btnFiltrarIdFactura_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridItems);
            this.panel5.Controls.Add(this.btnModificarItem);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(661, 166);
            this.panel5.TabIndex = 1;
            // 
            // dataGridItems
            // 
            this.dataGridItems.AllowUserToAddRows = false;
            this.dataGridItems.AllowUserToDeleteRows = false;
            this.dataGridItems.AllowUserToResizeColumns = false;
            this.dataGridItems.AllowUserToResizeRows = false;
            this.dataGridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridItems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridItems.Location = new System.Drawing.Point(104, 11);
            this.dataGridItems.MultiSelect = false;
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.ReadOnly = true;
            this.dataGridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItems.Size = new System.Drawing.Size(554, 152);
            this.dataGridItems.TabIndex = 16;
            // 
            // btnModificarItem
            // 
            this.btnModificarItem.Location = new System.Drawing.Point(6, 73);
            this.btnModificarItem.Name = "btnModificarItem";
            this.btnModificarItem.Size = new System.Drawing.Size(95, 23);
            this.btnModificarItem.TabIndex = 10;
            this.btnModificarItem.Text = "Modificar Items";
            this.btnModificarItem.UseVisualStyleBackColor = true;
            this.btnModificarItem.Click += new System.EventHandler(this.btnModificarItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Items";
            // 
            // btnSinFiltros
            // 
            this.btnSinFiltros.Location = new System.Drawing.Point(592, 213);
            this.btnSinFiltros.Name = "btnSinFiltros";
            this.btnSinFiltros.Size = new System.Drawing.Size(75, 23);
            this.btnSinFiltros.TabIndex = 18;
            this.btnSinFiltros.Text = "Borrar Filtros";
            this.btnSinFiltros.UseVisualStyleBackColor = true;
            this.btnSinFiltros.Click += new System.EventHandler(this.btnSinFiltros_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(87, 27);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnInhabilitar.TabIndex = 16;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // dataGridFacturasBM
            // 
            this.dataGridFacturasBM.AllowUserToAddRows = false;
            this.dataGridFacturasBM.AllowUserToDeleteRows = false;
            this.dataGridFacturasBM.AllowUserToResizeColumns = false;
            this.dataGridFacturasBM.AllowUserToResizeRows = false;
            this.dataGridFacturasBM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridFacturasBM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridFacturasBM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridFacturasBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturasBM.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridFacturasBM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridFacturasBM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridFacturasBM.Location = new System.Drawing.Point(6, 56);
            this.dataGridFacturasBM.MultiSelect = false;
            this.dataGridFacturasBM.Name = "dataGridFacturasBM";
            this.dataGridFacturasBM.ReadOnly = true;
            this.dataGridFacturasBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacturasBM.Size = new System.Drawing.Size(661, 153);
            this.dataGridFacturasBM.TabIndex = 15;
            this.dataGridFacturasBM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFacturasBM_CellClick);
            this.dataGridFacturasBM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFacturasBM_CellContentClick);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(6, 27);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 10;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.Location = new System.Drawing.Point(595, 27);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Size = new System.Drawing.Size(75, 23);
            this.btnModificarFactura.TabIndex = 8;
            this.btnModificarFactura.Text = "Modificar";
            this.btnModificarFactura.UseVisualStyleBackColor = true;
            this.btnModificarFactura.Click += new System.EventHandler(this.btnModificarFactura_Click);
            // 
            // txtIdClienteFiltro
            // 
            this.txtIdClienteFiltro.Location = new System.Drawing.Point(334, 216);
            this.txtIdClienteFiltro.Name = "txtIdClienteFiltro";
            this.txtIdClienteFiltro.Size = new System.Drawing.Size(102, 20);
            this.txtIdClienteFiltro.TabIndex = 6;
            // 
            // txtIdFacturaFiltro
            // 
            this.txtIdFacturaFiltro.Location = new System.Drawing.Point(72, 215);
            this.txtIdFacturaFiltro.Name = "txtIdFacturaFiltro";
            this.txtIdFacturaFiltro.Size = new System.Drawing.Size(102, 20);
            this.txtIdFacturaFiltro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nº Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas no pagas";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridEmpresas
            // 
            this.dataGridEmpresas.AllowUserToAddRows = false;
            this.dataGridEmpresas.AllowUserToDeleteRows = false;
            this.dataGridEmpresas.AllowUserToResizeColumns = false;
            this.dataGridEmpresas.AllowUserToResizeRows = false;
            this.dataGridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEmpresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridEmpresas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpresas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridEmpresas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridEmpresas.Location = new System.Drawing.Point(16, 26);
            this.dataGridEmpresas.MultiSelect = false;
            this.dataGridEmpresas.Name = "dataGridEmpresas";
            this.dataGridEmpresas.ReadOnly = true;
            this.dataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresas.Size = new System.Drawing.Size(330, 153);
            this.dataGridEmpresas.TabIndex = 16;
            // 
            // ABMFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 460);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMFacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | ABM Factura";
            this.Load += new System.EventHandler(this.ABMFacturaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAlta.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabBM.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturasBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAlta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listDetalle;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTextTotal;
        private System.Windows.Forms.Label lblListaDetalle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabBM;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIdClienteFiltro;
        private System.Windows.Forms.TextBox txtIdFacturaFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker vencimientoDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridFacturasBM;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.Button btnSinFiltros;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnModificarFactura;
        private System.Windows.Forms.Button btnFiltrarIdFactura;
        private System.Windows.Forms.Button btnFiltrarIdCliente;
        private System.Windows.Forms.DataGridView dataGridEmpresas;
    }
}