namespace PagoAgilFrba.AbmFactura
{
    partial class ModificarFacturas
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
            this.panelModificarFactura = new System.Windows.Forms.Panel();
            this.vencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.altaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtFacturaTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFacturaNro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridEmpresas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionarEmpresa = new System.Windows.Forms.Button();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFacturaEmpresa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCambiarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarPorDNI = new System.Windows.Forms.Button();
            this.txtClienteSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelModificarFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModificarFactura
            // 
            this.panelModificarFactura.Controls.Add(this.vencimientoDateTimePicker);
            this.panelModificarFactura.Controls.Add(this.altaDateTimePicker);
            this.panelModificarFactura.Controls.Add(this.txtFacturaTotal);
            this.panelModificarFactura.Controls.Add(this.label13);
            this.panelModificarFactura.Controls.Add(this.label9);
            this.panelModificarFactura.Controls.Add(this.label10);
            this.panelModificarFactura.Controls.Add(this.txtFacturaNro);
            this.panelModificarFactura.Controls.Add(this.label11);
            this.panelModificarFactura.Controls.Add(this.label12);
            this.panelModificarFactura.Location = new System.Drawing.Point(12, 12);
            this.panelModificarFactura.Name = "panelModificarFactura";
            this.panelModificarFactura.Size = new System.Drawing.Size(772, 139);
            this.panelModificarFactura.TabIndex = 14;
            // 
            // vencimientoDateTimePicker
            // 
            this.vencimientoDateTimePicker.Location = new System.Drawing.Point(388, 101);
            this.vencimientoDateTimePicker.Name = "vencimientoDateTimePicker";
            this.vencimientoDateTimePicker.Size = new System.Drawing.Size(360, 20);
            this.vencimientoDateTimePicker.TabIndex = 19;
            // 
            // altaDateTimePicker
            // 
            this.altaDateTimePicker.Location = new System.Drawing.Point(389, 62);
            this.altaDateTimePicker.Name = "altaDateTimePicker";
            this.altaDateTimePicker.Size = new System.Drawing.Size(359, 20);
            this.altaDateTimePicker.TabIndex = 19;
            // 
            // txtFacturaTotal
            // 
            this.txtFacturaTotal.Enabled = false;
            this.txtFacturaTotal.Location = new System.Drawing.Point(13, 101);
            this.txtFacturaTotal.Name = "txtFacturaTotal";
            this.txtFacturaTotal.Size = new System.Drawing.Size(351, 20);
            this.txtFacturaTotal.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fecha de Vencimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Fecha de Alta";
            // 
            // txtFacturaNro
            // 
            this.txtFacturaNro.Enabled = false;
            this.txtFacturaNro.Location = new System.Drawing.Point(13, 62);
            this.txtFacturaNro.Name = "txtFacturaNro";
            this.txtFacturaNro.Size = new System.Drawing.Size(351, 20);
            this.txtFacturaNro.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Factura Numero:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Modificar Factura";
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
            this.dataGridEmpresas.Location = new System.Drawing.Point(13, 44);
            this.dataGridEmpresas.MultiSelect = false;
            this.dataGridEmpresas.Name = "dataGridEmpresas";
            this.dataGridEmpresas.ReadOnly = true;
            this.dataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresas.Size = new System.Drawing.Size(351, 175);
            this.dataGridEmpresas.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(0, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarEmpresa
            // 
            this.btnSeleccionarEmpresa.Location = new System.Drawing.Point(289, 17);
            this.btnSeleccionarEmpresa.Name = "btnSeleccionarEmpresa";
            this.btnSeleccionarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarEmpresa.TabIndex = 17;
            this.btnSeleccionarEmpresa.Text = "Cambiar";
            this.btnSeleccionarEmpresa.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpresa.Click += new System.EventHandler(this.btnSeleccionarEmpresa_Click);
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Enabled = false;
            this.txtFiltroCliente.Location = new System.Drawing.Point(469, 199);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(198, 20);
            this.txtFiltroCliente.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Cliente";
            // 
            // txtFacturaEmpresa
            // 
            this.txtFacturaEmpresa.Enabled = false;
            this.txtFacturaEmpresa.Location = new System.Drawing.Point(13, 18);
            this.txtFacturaEmpresa.Name = "txtFacturaEmpresa";
            this.txtFacturaEmpresa.Size = new System.Drawing.Size(270, 20);
            this.txtFacturaEmpresa.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Empresa";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCambiarCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscarPorDNI);
            this.panel1.Controls.Add(this.txtClienteSeleccionado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.dataGridClientes);
            this.panel1.Controls.Add(this.dataGridEmpresas);
            this.panel1.Controls.Add(this.txtFiltroCliente);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtFacturaEmpresa);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnSeleccionarEmpresa);
            this.panel1.Location = new System.Drawing.Point(12, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 257);
            this.panel1.TabIndex = 23;
            // 
            // btnCambiarCliente
            // 
            this.btnCambiarCliente.Location = new System.Drawing.Point(673, 17);
            this.btnCambiarCliente.Name = "btnCambiarCliente";
            this.btnCambiarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarCliente.TabIndex = 29;
            this.btnCambiarCliente.Text = "Cambiar";
            this.btnCambiarCliente.UseVisualStyleBackColor = true;
            this.btnCambiarCliente.Click += new System.EventHandler(this.btnCambiarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buscar por DNI";
            // 
            // btnBuscarPorDNI
            // 
            this.btnBuscarPorDNI.Enabled = false;
            this.btnBuscarPorDNI.Location = new System.Drawing.Point(673, 197);
            this.btnBuscarPorDNI.Name = "btnBuscarPorDNI";
            this.btnBuscarPorDNI.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorDNI.TabIndex = 27;
            this.btnBuscarPorDNI.Text = "Buscar";
            this.btnBuscarPorDNI.UseVisualStyleBackColor = true;
            this.btnBuscarPorDNI.Click += new System.EventHandler(this.btnBuscarPorDNI_Click);
            // 
            // txtClienteSeleccionado
            // 
            this.txtClienteSeleccionado.Enabled = false;
            this.txtClienteSeleccionado.Location = new System.Drawing.Point(524, 19);
            this.txtClienteSeleccionado.Name = "txtClienteSeleccionado";
            this.txtClienteSeleccionado.Size = new System.Drawing.Size(143, 20);
            this.txtClienteSeleccionado.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cliente Seleccionado: ";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AllowUserToResizeColumns = false;
            this.dataGridClientes.AllowUserToResizeRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridClientes.Enabled = false;
            this.dataGridClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridClientes.Location = new System.Drawing.Point(389, 44);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(359, 142);
            this.dataGridClientes.TabIndex = 24;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(697, 234);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ModificarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelModificarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Modificar Factura";
            this.Load += new System.EventHandler(this.ModificarFacturas_Load);
            this.panelModificarFactura.ResumeLayout(false);
            this.panelModificarFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarFactura;
        private System.Windows.Forms.Button btnSeleccionarEmpresa;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFacturaEmpresa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFacturaTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFacturaNro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker vencimientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker altaDateTimePicker;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dataGridEmpresas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarPorDNI;
        private System.Windows.Forms.TextBox txtClienteSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarCliente;
        private System.Windows.Forms.Button btnGuardar;
    }
}