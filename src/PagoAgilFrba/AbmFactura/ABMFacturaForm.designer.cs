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
            this.lblAnno = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAnno = new System.Windows.Forms.ComboBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabModif = new System.Windows.Forms.TabPage();
            this.tabBaja = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAlta.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlta);
            this.tabControl1.Controls.Add(this.tabModif);
            this.tabControl1.Controls.Add(this.tabBaja);
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
            this.panel1.Controls.Add(this.lblAnno);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Controls.Add(this.lblDia);
            this.panel1.Controls.Add(this.cmbDia);
            this.panel1.Controls.Add(this.cmbMes);
            this.panel1.Controls.Add(this.cmbAnno);
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
            // lblAnno
            // 
            this.lblAnno.AutoSize = true;
            this.lblAnno.Location = new System.Drawing.Point(203, 132);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(39, 13);
            this.lblAnno.TabIndex = 8;
            this.lblAnno.Text = "(*) Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(93, 132);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(40, 13);
            this.lblMes.TabIndex = 8;
            this.lblMes.Text = "(*) Mes";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(9, 132);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(36, 13);
            this.lblDia.TabIndex = 7;
            this.lblDia.Text = "(*) Dia";
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(12, 148);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(78, 21);
            this.cmbDia.TabIndex = 6;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(96, 148);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(104, 21);
            this.cmbMes.TabIndex = 6;
            // 
            // cmbAnno
            // 
            this.cmbAnno.BackColor = System.Drawing.Color.White;
            this.cmbAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnno.FormattingEnabled = true;
            this.cmbAnno.Location = new System.Drawing.Point(206, 148);
            this.cmbAnno.Name = "cmbAnno";
            this.cmbAnno.Size = new System.Drawing.Size(76, 21);
            this.cmbAnno.TabIndex = 6;
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
            // tabModif
            // 
            this.tabModif.Location = new System.Drawing.Point(4, 22);
            this.tabModif.Name = "tabModif";
            this.tabModif.Padding = new System.Windows.Forms.Padding(3);
            this.tabModif.Size = new System.Drawing.Size(686, 423);
            this.tabModif.TabIndex = 1;
            this.tabModif.Text = "Modificar Facturas";
            this.tabModif.UseVisualStyleBackColor = true;
            // 
            // tabBaja
            // 
            this.tabBaja.Location = new System.Drawing.Point(4, 22);
            this.tabBaja.Name = "tabBaja";
            this.tabBaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaja.Size = new System.Drawing.Size(686, 423);
            this.tabBaja.TabIndex = 2;
            this.tabBaja.Text = "Eliminar Facturas";
            this.tabBaja.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
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
        private System.Windows.Forms.Label lblAnno;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAnno;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabModif;
        private System.Windows.Forms.TabPage tabBaja;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}