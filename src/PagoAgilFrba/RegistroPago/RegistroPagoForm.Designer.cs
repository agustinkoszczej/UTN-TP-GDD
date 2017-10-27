namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPagoForm
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
            this.lblFacturas = new System.Windows.Forms.Label();
            this.dgdFacturas = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.cmdQuitarFiltros = new System.Windows.Forms.Button();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdAgregarFactura = new System.Windows.Forms.Button();
            this.cmdQuitarFactura = new System.Windows.Forms.Button();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.dgdFacturasAPagar = new System.Windows.Forms.DataGridView();
            this.dgdItemsFactura = new System.Windows.Forms.DataGridView();
            this.lblFacturasAPagar = new System.Windows.Forms.Label();
            this.lblItemsFactura = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.cboFormasPago = new System.Windows.Forms.ComboBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.chkSoloPosibles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            this.groupBoxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFacturasAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdItemsFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.Location = new System.Drawing.Point(8, 17);
            this.lblFacturas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(201, 24);
            this.lblFacturas.TabIndex = 16;
            this.lblFacturas.Text = "Seleccione Facturas";
            // 
            // dgdFacturas
            // 
            this.dgdFacturas.AllowUserToAddRows = false;
            this.dgdFacturas.AllowUserToDeleteRows = false;
            this.dgdFacturas.AllowUserToResizeColumns = false;
            this.dgdFacturas.AllowUserToResizeRows = false;
            this.dgdFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdFacturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdFacturas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdFacturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdFacturas.Location = new System.Drawing.Point(12, 44);
            this.dgdFacturas.MultiSelect = false;
            this.dgdFacturas.Name = "dgdFacturas";
            this.dgdFacturas.ReadOnly = true;
            this.dgdFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdFacturas.Size = new System.Drawing.Size(458, 222);
            this.dgdFacturas.TabIndex = 15;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.chkSoloPosibles);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdQuitarFiltros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblDNICliente);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtDNICliente);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblNroFactura);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtNroFactura);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdBuscar);
            this.groupBoxFiltrosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(490, 44);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(351, 123);
            this.groupBoxFiltrosBusqueda.TabIndex = 18;
            this.groupBoxFiltrosBusqueda.TabStop = false;
            this.groupBoxFiltrosBusqueda.Text = "Filtros de búsqueda";
            // 
            // cmdQuitarFiltros
            // 
            this.cmdQuitarFiltros.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdQuitarFiltros.Location = new System.Drawing.Point(184, 81);
            this.cmdQuitarFiltros.Name = "cmdQuitarFiltros";
            this.cmdQuitarFiltros.Size = new System.Drawing.Size(121, 35);
            this.cmdQuitarFiltros.TabIndex = 28;
            this.cmdQuitarFiltros.Text = "Quitar filtros";
            this.cmdQuitarFiltros.UseVisualStyleBackColor = false;
            this.cmdQuitarFiltros.Click += new System.EventHandler(this.cmdQuitarFiltros_Click);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(181, 21);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(72, 13);
            this.lblDNICliente.TabIndex = 25;
            this.lblDNICliente.Text = "DNI Cliente";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(184, 37);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(155, 20);
            this.txtDNICliente.TabIndex = 24;
            this.txtDNICliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNICliente_KeyPress);
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(10, 21);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(115, 13);
            this.lblNroFactura.TabIndex = 13;
            this.lblNroFactura.Text = "Número de Factura";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(13, 37);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(155, 20);
            this.txtNroFactura.TabIndex = 12;
            this.txtNroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroFactura_KeyPress);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.Orange;
            this.cmdBuscar.Location = new System.Drawing.Point(13, 81);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(121, 35);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdAgregarFactura
            // 
            this.cmdAgregarFactura.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdAgregarFactura.Location = new System.Drawing.Point(17, 19);
            this.cmdAgregarFactura.Name = "cmdAgregarFactura";
            this.cmdAgregarFactura.Size = new System.Drawing.Size(121, 35);
            this.cmdAgregarFactura.TabIndex = 19;
            this.cmdAgregarFactura.Text = "Agregar Factura Seleccionada";
            this.cmdAgregarFactura.UseVisualStyleBackColor = false;
            this.cmdAgregarFactura.Click += new System.EventHandler(this.cmdAgregarFactura_Click);
            // 
            // cmdQuitarFactura
            // 
            this.cmdQuitarFactura.BackColor = System.Drawing.Color.Red;
            this.cmdQuitarFactura.Location = new System.Drawing.Point(17, 63);
            this.cmdQuitarFactura.Name = "cmdQuitarFactura";
            this.cmdQuitarFactura.Size = new System.Drawing.Size(121, 35);
            this.cmdQuitarFactura.TabIndex = 20;
            this.cmdQuitarFactura.Text = "Quitar Factura Seleccionada";
            this.cmdQuitarFactura.UseVisualStyleBackColor = false;
            this.cmdQuitarFactura.Click += new System.EventHandler(this.cmdQuitarFactura_Click);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.cmdAgregarFactura);
            this.groupBoxAcciones.Controls.Add(this.cmdQuitarFactura);
            this.groupBoxAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAcciones.Location = new System.Drawing.Point(490, 173);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(156, 108);
            this.groupBoxAcciones.TabIndex = 21;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // dgdFacturasAPagar
            // 
            this.dgdFacturasAPagar.AllowUserToAddRows = false;
            this.dgdFacturasAPagar.AllowUserToDeleteRows = false;
            this.dgdFacturasAPagar.AllowUserToResizeColumns = false;
            this.dgdFacturasAPagar.AllowUserToResizeRows = false;
            this.dgdFacturasAPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdFacturasAPagar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdFacturasAPagar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdFacturasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdFacturasAPagar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdFacturasAPagar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdFacturasAPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdFacturasAPagar.Location = new System.Drawing.Point(12, 307);
            this.dgdFacturasAPagar.MultiSelect = false;
            this.dgdFacturasAPagar.Name = "dgdFacturasAPagar";
            this.dgdFacturasAPagar.ReadOnly = true;
            this.dgdFacturasAPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdFacturasAPagar.Size = new System.Drawing.Size(458, 201);
            this.dgdFacturasAPagar.TabIndex = 22;
            this.dgdFacturasAPagar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdFacturasAPagar_CellContentClick);
            // 
            // dgdItemsFactura
            // 
            this.dgdItemsFactura.AllowUserToAddRows = false;
            this.dgdItemsFactura.AllowUserToDeleteRows = false;
            this.dgdItemsFactura.AllowUserToResizeColumns = false;
            this.dgdItemsFactura.AllowUserToResizeRows = false;
            this.dgdItemsFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdItemsFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdItemsFactura.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdItemsFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdItemsFactura.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdItemsFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdItemsFactura.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdItemsFactura.Location = new System.Drawing.Point(503, 307);
            this.dgdItemsFactura.MultiSelect = false;
            this.dgdItemsFactura.Name = "dgdItemsFactura";
            this.dgdItemsFactura.ReadOnly = true;
            this.dgdItemsFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdItemsFactura.Size = new System.Drawing.Size(326, 201);
            this.dgdItemsFactura.TabIndex = 23;
            // 
            // lblFacturasAPagar
            // 
            this.lblFacturasAPagar.AutoSize = true;
            this.lblFacturasAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturasAPagar.Location = new System.Drawing.Point(8, 281);
            this.lblFacturasAPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacturasAPagar.Name = "lblFacturasAPagar";
            this.lblFacturasAPagar.Size = new System.Drawing.Size(166, 24);
            this.lblFacturasAPagar.TabIndex = 24;
            this.lblFacturasAPagar.Text = "Facturas a pagar";
            // 
            // lblItemsFactura
            // 
            this.lblItemsFactura.AutoSize = true;
            this.lblItemsFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsFactura.Location = new System.Drawing.Point(499, 281);
            this.lblItemsFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsFactura.Name = "lblItemsFactura";
            this.lblItemsFactura.Size = new System.Drawing.Size(187, 24);
            this.lblItemsFactura.TabIndex = 25;
            this.lblItemsFactura.Text = "Items de la Factura";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(320, 532);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(140, 39);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total: $";
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalculado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalCalculado.Location = new System.Drawing.Point(450, 532);
            this.lblTotalCalculado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(148, 39);
            this.lblTotalCalculado.TabIndex = 27;
            this.lblTotalCalculado.Text = "123.456";
            // 
            // cmdPagar
            // 
            this.cmdPagar.BackColor = System.Drawing.Color.Transparent;
            this.cmdPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPagar.Location = new System.Drawing.Point(621, 528);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(171, 51);
            this.cmdPagar.TabIndex = 21;
            this.cmdPagar.Text = "PAGAR";
            this.cmdPagar.UseVisualStyleBackColor = false;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // cboFormasPago
            // 
            this.cboFormasPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormasPago.FormattingEnabled = true;
            this.cboFormasPago.Location = new System.Drawing.Point(12, 539);
            this.cboFormasPago.Name = "cboFormasPago";
            this.cboFormasPago.Size = new System.Drawing.Size(261, 32);
            this.cboFormasPago.TabIndex = 28;
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(8, 512);
            this.lblFormaDePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(265, 24);
            this.lblFormaDePago.TabIndex = 29;
            this.lblFormaDePago.Text = "Seleccione Forma de Pago";
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlCerrarSesion.Location = new System.Drawing.Point(749, 17);
            this.lnlCerrarSesion.Name = "lnlCerrarSesion";
            this.lnlCerrarSesion.Size = new System.Drawing.Size(95, 18);
            this.lnlCerrarSesion.TabIndex = 30;
            this.lnlCerrarSesion.TabStop = true;
            this.lnlCerrarSesion.Text = "cerrar sesión";
            this.lnlCerrarSesion.Visible = false;
            this.lnlCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlCerrarSesion_LinkClicked);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.Transparent;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(713, 196);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(128, 38);
            this.cmdSalir.TabIndex = 31;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // chkSoloPosibles
            // 
            this.chkSoloPosibles.AutoSize = true;
            this.chkSoloPosibles.Location = new System.Drawing.Point(17, 63);
            this.chkSoloPosibles.Name = "chkSoloPosibles";
            this.chkSoloPosibles.Size = new System.Drawing.Size(221, 17);
            this.chkSoloPosibles.TabIndex = 29;
            this.chkSoloPosibles.Text = "Sólo Facturas disponibles de pago";
            this.chkSoloPosibles.UseVisualStyleBackColor = true;
            // 
            // RegistroPagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 592);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.cboFormasPago);
            this.Controls.Add(this.cmdPagar);
            this.Controls.Add(this.lblTotalCalculado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItemsFactura);
            this.Controls.Add(this.lblFacturasAPagar);
            this.Controls.Add(this.dgdItemsFactura);
            this.Controls.Add(this.dgdFacturasAPagar);
            this.Controls.Add(this.groupBoxAcciones);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.dgdFacturas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroPagoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Registro de Pago";
            this.Load += new System.EventHandler(this.RegistroPagoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
            this.groupBoxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdFacturasAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdItemsFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.DataGridView dgdFacturas;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.Button cmdQuitarFiltros;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button cmdAgregarFactura;
        private System.Windows.Forms.Button cmdQuitarFactura;
        private System.Windows.Forms.Label lblItemsFactura;
        private System.Windows.Forms.Label lblFacturasAPagar;
        private System.Windows.Forms.DataGridView dgdItemsFactura;
        private System.Windows.Forms.DataGridView dgdFacturasAPagar;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdPagar;
        private System.Windows.Forms.ComboBox cboFormasPago;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.CheckBox chkSoloPosibles;
    }
}