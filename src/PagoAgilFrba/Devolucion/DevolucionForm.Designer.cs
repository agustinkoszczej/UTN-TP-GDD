namespace PagoAgilFrba.Devolucion
{
    partial class DevolucionForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.cmdQuitarFiltros = new System.Windows.Forms.Button();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.dgdFacturas = new System.Windows.Forms.DataGridView();
            this.cmdDevolver = new System.Windows.Forms.Button();
            this.rbErrorCobro = new System.Windows.Forms.RadioButton();
            this.groupBoxMotivos = new System.Windows.Forms.GroupBox();
            this.rtxtOtro = new System.Windows.Forms.RichTextBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbRetraerPago = new System.Windows.Forms.RadioButton();
            this.lblTotalDevolver = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFacturas)).BeginInit();
            this.groupBoxMotivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.Orange;
            this.cmdBuscar.Location = new System.Drawing.Point(13, 63);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(121, 35);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.Transparent;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(516, 36);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(119, 38);
            this.cmdSalir.TabIndex = 36;
            this.cmdSalir.Text = "Cerrar";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlCerrarSesion.Location = new System.Drawing.Point(526, 9);
            this.lnlCerrarSesion.Name = "lnlCerrarSesion";
            this.lnlCerrarSesion.Size = new System.Drawing.Size(95, 18);
            this.lnlCerrarSesion.TabIndex = 35;
            this.lnlCerrarSesion.TabStop = true;
            this.lnlCerrarSesion.Text = "cerrar sesión";
            this.lnlCerrarSesion.Visible = false;
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdQuitarFiltros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblDNICliente);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtDNICliente);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblNroFactura);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtNroFactura);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdBuscar);
            this.groupBoxFiltrosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(12, 284);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(351, 108);
            this.groupBoxFiltrosBusqueda.TabIndex = 34;
            this.groupBoxFiltrosBusqueda.TabStop = false;
            this.groupBoxFiltrosBusqueda.Text = "Filtros de búsqueda";
            // 
            // cmdQuitarFiltros
            // 
            this.cmdQuitarFiltros.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdQuitarFiltros.Location = new System.Drawing.Point(184, 63);
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
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.Location = new System.Drawing.Point(11, 5);
            this.lblFacturas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(294, 24);
            this.lblFacturas.TabIndex = 33;
            this.lblFacturas.Text = "Seleccione Factura a devolver";
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
            this.dgdFacturas.Location = new System.Drawing.Point(12, 32);
            this.dgdFacturas.MultiSelect = false;
            this.dgdFacturas.Name = "dgdFacturas";
            this.dgdFacturas.ReadOnly = true;
            this.dgdFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdFacturas.Size = new System.Drawing.Size(458, 246);
            this.dgdFacturas.TabIndex = 32;
            // 
            // cmdDevolver
            // 
            this.cmdDevolver.BackColor = System.Drawing.Color.Transparent;
            this.cmdDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDevolver.Location = new System.Drawing.Point(429, 341);
            this.cmdDevolver.Name = "cmdDevolver";
            this.cmdDevolver.Size = new System.Drawing.Size(192, 51);
            this.cmdDevolver.TabIndex = 29;
            this.cmdDevolver.Text = "DEVOLVER";
            this.cmdDevolver.UseVisualStyleBackColor = false;
            this.cmdDevolver.Click += new System.EventHandler(this.cmdDevolver_Click);
            // 
            // rbErrorCobro
            // 
            this.rbErrorCobro.AutoSize = true;
            this.rbErrorCobro.Location = new System.Drawing.Point(6, 33);
            this.rbErrorCobro.Name = "rbErrorCobro";
            this.rbErrorCobro.Size = new System.Drawing.Size(126, 20);
            this.rbErrorCobro.TabIndex = 37;
            this.rbErrorCobro.TabStop = true;
            this.rbErrorCobro.Text = "Error de cobro";
            this.rbErrorCobro.UseVisualStyleBackColor = true;
            this.rbErrorCobro.CheckedChanged += new System.EventHandler(this.rbErrorCobro_CheckedChanged);
            // 
            // groupBoxMotivos
            // 
            this.groupBoxMotivos.Controls.Add(this.rtxtOtro);
            this.groupBoxMotivos.Controls.Add(this.rbOtro);
            this.groupBoxMotivos.Controls.Add(this.rbRetraerPago);
            this.groupBoxMotivos.Controls.Add(this.rbErrorCobro);
            this.groupBoxMotivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMotivos.Location = new System.Drawing.Point(476, 80);
            this.groupBoxMotivos.Name = "groupBoxMotivos";
            this.groupBoxMotivos.Size = new System.Drawing.Size(189, 198);
            this.groupBoxMotivos.TabIndex = 38;
            this.groupBoxMotivos.TabStop = false;
            this.groupBoxMotivos.Text = "Seleccione Motivo";
            // 
            // rtxtOtro
            // 
            this.rtxtOtro.Enabled = false;
            this.rtxtOtro.Location = new System.Drawing.Point(15, 111);
            this.rtxtOtro.Name = "rtxtOtro";
            this.rtxtOtro.Size = new System.Drawing.Size(156, 71);
            this.rtxtOtro.TabIndex = 39;
            this.rtxtOtro.Text = "";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(6, 85);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(55, 20);
            this.rbOtro.TabIndex = 39;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbRetraerPago
            // 
            this.rbRetraerPago.AutoSize = true;
            this.rbRetraerPago.Location = new System.Drawing.Point(6, 59);
            this.rbRetraerPago.Name = "rbRetraerPago";
            this.rbRetraerPago.Size = new System.Drawing.Size(118, 20);
            this.rbRetraerPago.TabIndex = 38;
            this.rbRetraerPago.TabStop = true;
            this.rbRetraerPago.Text = "Retraer pago";
            this.rbRetraerPago.UseVisualStyleBackColor = true;
            this.rbRetraerPago.CheckedChanged += new System.EventHandler(this.rbRetraerPago_CheckedChanged);
            // 
            // lblTotalDevolver
            // 
            this.lblTotalDevolver.AutoSize = true;
            this.lblTotalDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDevolver.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalDevolver.Location = new System.Drawing.Point(476, 289);
            this.lblTotalDevolver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDevolver.Name = "lblTotalDevolver";
            this.lblTotalDevolver.Size = new System.Drawing.Size(137, 33);
            this.lblTotalDevolver.TabIndex = 40;
            this.lblTotalDevolver.Text = "-123.456";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(365, 289);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 33);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "Total: $";
            // 
            // DevolucionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 407);
            this.Controls.Add(this.lblTotalDevolver);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBoxMotivos);
            this.Controls.Add(this.cmdDevolver);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.dgdFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DevolucionForm";
            this.Text = "PagoAgilFrba | Devolución";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFacturas)).EndInit();
            this.groupBoxMotivos.ResumeLayout(false);
            this.groupBoxMotivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.Button cmdQuitarFiltros;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.DataGridView dgdFacturas;
        private System.Windows.Forms.Button cmdDevolver;
        private System.Windows.Forms.GroupBox groupBoxMotivos;
        private System.Windows.Forms.RichTextBox rtxtOtro;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbRetraerPago;
        private System.Windows.Forms.RadioButton rbErrorCobro;
        private System.Windows.Forms.Label lblTotalDevolver;
        private System.Windows.Forms.Label lblTotal;
    }
}