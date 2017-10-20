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
            this.listEmpresas = new System.Windows.Forms.ListView();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabBM = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelModificarItem = new System.Windows.Forms.Panel();
            this.btnSalirPanelItem = new System.Windows.Forms.Button();
            this.btnGuardarItem = new System.Windows.Forms.Button();
            this.txtItemCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemMonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemNro = new System.Windows.Forms.TextBox();
            this.lblItemNro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBorrarItem = new System.Windows.Forms.Button();
            this.btnModificarItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listItems = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBorrarFactura = new System.Windows.Forms.Button();
            this.btnModificarFactura = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listFacturasBM = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabAlta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabBM.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelModificarItem.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.panel2.Controls.Add(this.listEmpresas);
            this.panel2.Controls.Add(this.lblEmpresa);
            this.panel2.Location = new System.Drawing.Point(315, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 184);
            this.panel2.TabIndex = 2;
            // 
            // listEmpresas
            // 
            this.listEmpresas.Location = new System.Drawing.Point(16, 26);
            this.listEmpresas.MultiSelect = false;
            this.listEmpresas.Name = "listEmpresas";
            this.listEmpresas.Size = new System.Drawing.Size(330, 143);
            this.listEmpresas.TabIndex = 1;
            this.listEmpresas.UseCompatibleStateImageBehavior = false;
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
            this.panel1.Controls.Add(this.txtFactura);
            this.panel1.Controls.Add(this.lblFactura);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 184);
            this.panel1.TabIndex = 1;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(3, 115);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(6, 76);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(276, 20);
            this.txtFactura.TabIndex = 3;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(3, 59);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(56, 13);
            this.lblFactura.TabIndex = 2;
            this.lblFactura.Text = "(*) Factura";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(6, 27);
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
            this.tabBM.Controls.Add(this.panel5);
            this.tabBM.Controls.Add(this.panel4);
            this.tabBM.Location = new System.Drawing.Point(4, 22);
            this.tabBM.Name = "tabBM";
            this.tabBM.Padding = new System.Windows.Forms.Padding(3);
            this.tabBM.Size = new System.Drawing.Size(686, 423);
            this.tabBM.TabIndex = 2;
            this.tabBM.Text = "Modificar Facturas";
            this.tabBM.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelModificarItem);
            this.panel5.Controls.Add(this.btnBorrarItem);
            this.panel5.Controls.Add(this.btnModificarItem);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.listItems);
            this.panel5.Location = new System.Drawing.Point(413, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 410);
            this.panel5.TabIndex = 1;
            // 
            // panelModificarItem
            // 
            this.panelModificarItem.Controls.Add(this.btnSalirPanelItem);
            this.panelModificarItem.Controls.Add(this.btnGuardarItem);
            this.panelModificarItem.Controls.Add(this.txtItemCantidad);
            this.panelModificarItem.Controls.Add(this.label8);
            this.panelModificarItem.Controls.Add(this.txtItemMonto);
            this.panelModificarItem.Controls.Add(this.label7);
            this.panelModificarItem.Controls.Add(this.txtItemNro);
            this.panelModificarItem.Controls.Add(this.lblItemNro);
            this.panelModificarItem.Controls.Add(this.label6);
            this.panelModificarItem.Location = new System.Drawing.Point(6, 11);
            this.panelModificarItem.Name = "panelModificarItem";
            this.panelModificarItem.Size = new System.Drawing.Size(258, 204);
            this.panelModificarItem.TabIndex = 12;
            this.panelModificarItem.Visible = false;
            // 
            // btnSalirPanelItem
            // 
            this.btnSalirPanelItem.Font = new System.Drawing.Font("Modern No. 20", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPanelItem.Location = new System.Drawing.Point(241, 4);
            this.btnSalirPanelItem.Name = "btnSalirPanelItem";
            this.btnSalirPanelItem.Size = new System.Drawing.Size(14, 22);
            this.btnSalirPanelItem.TabIndex = 10;
            this.btnSalirPanelItem.Text = "_";
            this.btnSalirPanelItem.UseVisualStyleBackColor = true;
            // 
            // btnGuardarItem
            // 
            this.btnGuardarItem.Location = new System.Drawing.Point(170, 173);
            this.btnGuardarItem.Name = "btnGuardarItem";
            this.btnGuardarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarItem.TabIndex = 9;
            this.btnGuardarItem.Text = "Guardar";
            this.btnGuardarItem.UseVisualStyleBackColor = true;
            // 
            // txtItemCantidad
            // 
            this.txtItemCantidad.Location = new System.Drawing.Point(13, 147);
            this.txtItemCantidad.Name = "txtItemCantidad";
            this.txtItemCantidad.Size = new System.Drawing.Size(232, 20);
            this.txtItemCantidad.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad:";
            // 
            // txtItemMonto
            // 
            this.txtItemMonto.Location = new System.Drawing.Point(13, 104);
            this.txtItemMonto.Name = "txtItemMonto";
            this.txtItemMonto.Size = new System.Drawing.Size(232, 20);
            this.txtItemMonto.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Monto:";
            // 
            // txtItemNro
            // 
            this.txtItemNro.Enabled = false;
            this.txtItemNro.Location = new System.Drawing.Point(13, 62);
            this.txtItemNro.Name = "txtItemNro";
            this.txtItemNro.Size = new System.Drawing.Size(232, 20);
            this.txtItemNro.TabIndex = 2;
            // 
            // lblItemNro
            // 
            this.lblItemNro.AutoSize = true;
            this.lblItemNro.Location = new System.Drawing.Point(10, 46);
            this.lblItemNro.Name = "lblItemNro";
            this.lblItemNro.Size = new System.Drawing.Size(70, 13);
            this.lblItemNro.TabIndex = 1;
            this.lblItemNro.Text = "Item Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Modificar Item ";
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.Location = new System.Drawing.Point(6, 380);
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarItem.TabIndex = 11;
            this.btnBorrarItem.Text = "Borrar";
            this.btnBorrarItem.UseVisualStyleBackColor = true;
            // 
            // btnModificarItem
            // 
            this.btnModificarItem.Location = new System.Drawing.Point(189, 380);
            this.btnModificarItem.Name = "btnModificarItem";
            this.btnModificarItem.Size = new System.Drawing.Size(75, 23);
            this.btnModificarItem.TabIndex = 10;
            this.btnModificarItem.Text = "Modificar";
            this.btnModificarItem.UseVisualStyleBackColor = true;
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
            // listItems
            // 
            this.listItems.Location = new System.Drawing.Point(6, 28);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(258, 344);
            this.listItems.TabIndex = 0;
            this.listItems.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBorrarFactura);
            this.panel4.Controls.Add(this.btnModificarFactura);
            this.panel4.Controls.Add(this.btnFiltrar);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.listFacturasBM);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(7, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 410);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnBorrarFactura
            // 
            this.btnBorrarFactura.Location = new System.Drawing.Point(310, 28);
            this.btnBorrarFactura.Name = "btnBorrarFactura";
            this.btnBorrarFactura.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarFactura.TabIndex = 9;
            this.btnBorrarFactura.Text = "Borrar";
            this.btnBorrarFactura.UseVisualStyleBackColor = true;
            this.btnBorrarFactura.Click += new System.EventHandler(this.btnBorrarFactura_Click);
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.Location = new System.Drawing.Point(310, 57);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Size = new System.Drawing.Size(75, 23);
            this.btnModificarFactura.TabIndex = 8;
            this.btnModificarFactura.Text = "Modificar";
            this.btnModificarFactura.UseVisualStyleBackColor = true;
            this.btnModificarFactura.Click += new System.EventHandler(this.btnModificarFactura_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(310, 368);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nº Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtros:";
            // 
            // listFacturasBM
            // 
            this.listFacturasBM.Location = new System.Drawing.Point(6, 28);
            this.listFacturasBM.Name = "listFacturasBM";
            this.listFacturasBM.Size = new System.Drawing.Size(294, 301);
            this.listFacturasBM.TabIndex = 1;
            this.listFacturasBM.UseCompatibleStateImageBehavior = false;
            this.listFacturasBM.SelectedIndexChanged += new System.EventHandler(this.listFacturasBM_SelectedIndexChanged);
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
            // vencimientoDateTimePicker
            // 
            this.vencimientoDateTimePicker.Location = new System.Drawing.Point(6, 131);
            this.vencimientoDateTimePicker.Name = "vencimientoDateTimePicker";
            this.vencimientoDateTimePicker.Size = new System.Drawing.Size(276, 20);
            this.vencimientoDateTimePicker.TabIndex = 9;
            // 
            // ABMFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "ABMFacturaForm";
            this.Text = "Form1";
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
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelModificarItem.ResumeLayout(false);
            this.panelModificarItem.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.ListView listEmpresas;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabBM;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listFacturasBM;
        private System.Windows.Forms.Button btnBorrarItem;
        private System.Windows.Forms.Button btnModificarItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrarFactura;
        private System.Windows.Forms.Button btnModificarFactura;
        private System.Windows.Forms.Panel panelModificarItem;
        private System.Windows.Forms.Button btnSalirPanelItem;
        private System.Windows.Forms.Button btnGuardarItem;
        private System.Windows.Forms.TextBox txtItemCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemNro;
        private System.Windows.Forms.Label lblItemNro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker vencimientoDateTimePicker;
    }
}