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
            this.lblPagos = new System.Windows.Forms.Label();
            this.dgdPagos = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lsvPagosARealizar = new System.Windows.Forms.ListView();
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.cmdQuitarFiltros = new System.Windows.Forms.Button();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(11, 13);
            this.lblPagos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(68, 24);
            this.lblPagos.TabIndex = 16;
            this.lblPagos.Text = "Pagos";
            // 
            // dgdPagos
            // 
            this.dgdPagos.AllowUserToAddRows = false;
            this.dgdPagos.AllowUserToDeleteRows = false;
            this.dgdPagos.AllowUserToResizeColumns = false;
            this.dgdPagos.AllowUserToResizeRows = false;
            this.dgdPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdPagos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdPagos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdPagos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdPagos.Location = new System.Drawing.Point(12, 40);
            this.dgdPagos.MultiSelect = false;
            this.dgdPagos.Name = "dgdPagos";
            this.dgdPagos.ReadOnly = true;
            this.dgdPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdPagos.Size = new System.Drawing.Size(342, 323);
            this.dgdPagos.TabIndex = 15;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lsvPagosARealizar
            // 
            this.lsvPagosARealizar.Location = new System.Drawing.Point(462, 89);
            this.lsvPagosARealizar.Name = "lsvPagosARealizar";
            this.lsvPagosARealizar.Size = new System.Drawing.Size(121, 97);
            this.lsvPagosARealizar.TabIndex = 17;
            this.lsvPagosARealizar.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdQuitarFiltros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblDNICliente);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtDNICliente);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblNroFactura);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtNroFactura);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdBuscar);
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(15, 369);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(771, 158);
            this.groupBoxFiltrosBusqueda.TabIndex = 18;
            this.groupBoxFiltrosBusqueda.TabStop = false;
            this.groupBoxFiltrosBusqueda.Text = "Filtros de búsqueda";
            // 
            // cmdQuitarFiltros
            // 
            this.cmdQuitarFiltros.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdQuitarFiltros.Location = new System.Drawing.Point(184, 105);
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
            this.lblDNICliente.Size = new System.Drawing.Size(61, 13);
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
            this.lblNroFactura.Size = new System.Drawing.Size(98, 13);
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
            this.cmdBuscar.Location = new System.Drawing.Point(13, 105);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(121, 35);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.Text = "Aplicar filtros";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            // 
            // RegistroPagoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 560);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.Controls.Add(this.lsvPagosARealizar);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.dgdPagos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "RegistroPagoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Registro de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.dgdPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.DataGridView dgdPagos;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListView lsvPagosARealizar;
        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.Button cmdQuitarFiltros;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Button cmdBuscar;
    }
}