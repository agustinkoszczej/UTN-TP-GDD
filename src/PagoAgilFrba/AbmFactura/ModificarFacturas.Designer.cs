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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.vencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.altaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listEmpresas = new System.Windows.Forms.ListView();
            this.btnSeleccionarEmpresa = new System.Windows.Forms.Button();
            this.txtFacturaCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFacturaEmpresa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFacturaTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFacturaNro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelModificarFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModificarFactura
            // 
            this.panelModificarFactura.Controls.Add(this.btnCancelar);
            this.panelModificarFactura.Controls.Add(this.vencimientoDateTimePicker);
            this.panelModificarFactura.Controls.Add(this.altaDateTimePicker);
            this.panelModificarFactura.Controls.Add(this.listEmpresas);
            this.panelModificarFactura.Controls.Add(this.btnSeleccionarEmpresa);
            this.panelModificarFactura.Controls.Add(this.txtFacturaCliente);
            this.panelModificarFactura.Controls.Add(this.label15);
            this.panelModificarFactura.Controls.Add(this.txtFacturaEmpresa);
            this.panelModificarFactura.Controls.Add(this.label14);
            this.panelModificarFactura.Controls.Add(this.txtFacturaTotal);
            this.panelModificarFactura.Controls.Add(this.label13);
            this.panelModificarFactura.Controls.Add(this.button2);
            this.panelModificarFactura.Controls.Add(this.label9);
            this.panelModificarFactura.Controls.Add(this.label10);
            this.panelModificarFactura.Controls.Add(this.txtFacturaNro);
            this.panelModificarFactura.Controls.Add(this.label11);
            this.panelModificarFactura.Controls.Add(this.label12);
            this.panelModificarFactura.Location = new System.Drawing.Point(12, 12);
            this.panelModificarFactura.Name = "panelModificarFactura";
            this.panelModificarFactura.Size = new System.Drawing.Size(621, 309);
            this.panelModificarFactura.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(462, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // vencimientoDateTimePicker
            // 
            this.vencimientoDateTimePicker.Location = new System.Drawing.Point(12, 147);
            this.vencimientoDateTimePicker.Name = "vencimientoDateTimePicker";
            this.vencimientoDateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.vencimientoDateTimePicker.TabIndex = 19;
            // 
            // altaDateTimePicker
            // 
            this.altaDateTimePicker.Location = new System.Drawing.Point(12, 104);
            this.altaDateTimePicker.Name = "altaDateTimePicker";
            this.altaDateTimePicker.Size = new System.Drawing.Size(281, 20);
            this.altaDateTimePicker.TabIndex = 19;
            // 
            // listEmpresas
            // 
            this.listEmpresas.Location = new System.Drawing.Point(311, 62);
            this.listEmpresas.Name = "listEmpresas";
            this.listEmpresas.Size = new System.Drawing.Size(307, 207);
            this.listEmpresas.TabIndex = 18;
            this.listEmpresas.UseCompatibleStateImageBehavior = false;
            // 
            // btnSeleccionarEmpresa
            // 
            this.btnSeleccionarEmpresa.Location = new System.Drawing.Point(219, 232);
            this.btnSeleccionarEmpresa.Name = "btnSeleccionarEmpresa";
            this.btnSeleccionarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarEmpresa.TabIndex = 17;
            this.btnSeleccionarEmpresa.Text = "Seleccionar";
            this.btnSeleccionarEmpresa.UseVisualStyleBackColor = true;
            this.btnSeleccionarEmpresa.Click += new System.EventHandler(this.btnSeleccionarEmpresa_Click);
            // 
            // txtFacturaCliente
            // 
            this.txtFacturaCliente.Location = new System.Drawing.Point(13, 278);
            this.txtFacturaCliente.Name = "txtFacturaCliente";
            this.txtFacturaCliente.Size = new System.Drawing.Size(280, 20);
            this.txtFacturaCliente.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Cliente";
            // 
            // txtFacturaEmpresa
            // 
            this.txtFacturaEmpresa.Enabled = false;
            this.txtFacturaEmpresa.Location = new System.Drawing.Point(13, 235);
            this.txtFacturaEmpresa.Name = "txtFacturaEmpresa";
            this.txtFacturaEmpresa.Size = new System.Drawing.Size(200, 20);
            this.txtFacturaEmpresa.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Empresa";
            // 
            // txtFacturaTotal
            // 
            this.txtFacturaTotal.Enabled = false;
            this.txtFacturaTotal.Location = new System.Drawing.Point(13, 192);
            this.txtFacturaTotal.Name = "txtFacturaTotal";
            this.txtFacturaTotal.Size = new System.Drawing.Size(281, 20);
            this.txtFacturaTotal.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Total:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fecha de Vencimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 88);
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
            this.txtFacturaNro.Size = new System.Drawing.Size(280, 20);
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ModificarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 329);
            this.Controls.Add(this.panelModificarFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Modificar Factura";
            this.Load += new System.EventHandler(this.ModificarFacturas_Load);
            this.panelModificarFactura.ResumeLayout(false);
            this.panelModificarFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarFactura;
        private System.Windows.Forms.ListView listEmpresas;
        private System.Windows.Forms.Button btnSeleccionarEmpresa;
        private System.Windows.Forms.TextBox txtFacturaCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFacturaEmpresa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFacturaTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFacturaNro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker vencimientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker altaDateTimePicker;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}