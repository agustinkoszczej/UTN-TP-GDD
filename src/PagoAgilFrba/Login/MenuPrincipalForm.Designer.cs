namespace PagoAgilFrba
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdListadoEstadistico = new System.Windows.Forms.Button();
            this.cmdRegistrarPago = new System.Windows.Forms.Button();
            this.cmdRendirFacturas = new System.Windows.Forms.Button();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmdABMRol = new System.Windows.Forms.Button();
            this.cmdABMCliente = new System.Windows.Forms.Button();
            this.cmdABMSucursal = new System.Windows.Forms.Button();
            this.cmdABMFactura = new System.Windows.Forms.Button();
            this.groupBoxABMs = new System.Windows.Forms.GroupBox();
            this.cmdABMEmpresa = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.groupBoxAcciones.SuspendLayout();
            this.groupBoxABMs.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdListadoEstadistico
            // 
            this.cmdListadoEstadistico.Enabled = false;
            this.cmdListadoEstadistico.Location = new System.Drawing.Point(189, 21);
            this.cmdListadoEstadistico.Margin = new System.Windows.Forms.Padding(2);
            this.cmdListadoEstadistico.Name = "cmdListadoEstadistico";
            this.cmdListadoEstadistico.Size = new System.Drawing.Size(112, 27);
            this.cmdListadoEstadistico.TabIndex = 6;
            this.cmdListadoEstadistico.Text = "Listado Estadistico";
            this.cmdListadoEstadistico.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrarPago
            // 
            this.cmdRegistrarPago.Enabled = false;
            this.cmdRegistrarPago.Location = new System.Drawing.Point(30, 21);
            this.cmdRegistrarPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRegistrarPago.Name = "cmdRegistrarPago";
            this.cmdRegistrarPago.Size = new System.Drawing.Size(112, 27);
            this.cmdRegistrarPago.TabIndex = 5;
            this.cmdRegistrarPago.Text = "Registrar Pago";
            this.cmdRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // cmdRendirFacturas
            // 
            this.cmdRendirFacturas.Enabled = false;
            this.cmdRendirFacturas.Location = new System.Drawing.Point(105, 61);
            this.cmdRendirFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRendirFacturas.Name = "cmdRendirFacturas";
            this.cmdRendirFacturas.Size = new System.Drawing.Size(112, 27);
            this.cmdRendirFacturas.TabIndex = 4;
            this.cmdRendirFacturas.Text = "Rendir Facturas";
            this.cmdRendirFacturas.UseVisualStyleBackColor = true;
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.cmdRendirFacturas);
            this.groupBoxAcciones.Controls.Add(this.cmdListadoEstadistico);
            this.groupBoxAcciones.Controls.Add(this.cmdRegistrarPago);
            this.groupBoxAcciones.Location = new System.Drawing.Point(1, 36);
            this.groupBoxAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAcciones.Size = new System.Drawing.Size(333, 104);
            this.groupBoxAcciones.TabIndex = 9;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(83, 19);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(63, 13);
            this.lblBienvenido.TabIndex = 11;
            this.lblBienvenido.Text = "Bienvenido,";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(142, 19);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 13);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "username";
            // 
            // cmdABMRol
            // 
            this.cmdABMRol.Enabled = false;
            this.cmdABMRol.Location = new System.Drawing.Point(189, 59);
            this.cmdABMRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmdABMRol.Name = "cmdABMRol";
            this.cmdABMRol.Size = new System.Drawing.Size(112, 27);
            this.cmdABMRol.TabIndex = 16;
            this.cmdABMRol.Text = "ABM Rol";
            this.cmdABMRol.UseVisualStyleBackColor = true;
            this.cmdABMRol.Click += new System.EventHandler(this.cmdABMRol_Click);
            // 
            // cmdABMCliente
            // 
            this.cmdABMCliente.Enabled = false;
            this.cmdABMCliente.Location = new System.Drawing.Point(190, 162);
            this.cmdABMCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmdABMCliente.Name = "cmdABMCliente";
            this.cmdABMCliente.Size = new System.Drawing.Size(112, 27);
            this.cmdABMCliente.TabIndex = 15;
            this.cmdABMCliente.Text = "ABM Cliente";
            this.cmdABMCliente.UseVisualStyleBackColor = true;
            // 
            // cmdABMSucursal
            // 
            this.cmdABMSucursal.Enabled = false;
            this.cmdABMSucursal.Location = new System.Drawing.Point(30, 59);
            this.cmdABMSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.cmdABMSucursal.Name = "cmdABMSucursal";
            this.cmdABMSucursal.Size = new System.Drawing.Size(112, 27);
            this.cmdABMSucursal.TabIndex = 14;
            this.cmdABMSucursal.Text = "ABM Sucursal";
            this.cmdABMSucursal.UseVisualStyleBackColor = true;
            // 
            // cmdABMFactura
            // 
            this.cmdABMFactura.Enabled = false;
            this.cmdABMFactura.Location = new System.Drawing.Point(30, 18);
            this.cmdABMFactura.Margin = new System.Windows.Forms.Padding(2);
            this.cmdABMFactura.Name = "cmdABMFactura";
            this.cmdABMFactura.Size = new System.Drawing.Size(112, 27);
            this.cmdABMFactura.TabIndex = 13;
            this.cmdABMFactura.Text = "ABM Factura";
            this.cmdABMFactura.UseVisualStyleBackColor = true;
            this.cmdABMFactura.Click += new System.EventHandler(this.cmdABMFactura_Click);
            // 
            // groupBoxABMs
            // 
            this.groupBoxABMs.Controls.Add(this.cmdABMEmpresa);
            this.groupBoxABMs.Controls.Add(this.cmdABMRol);
            this.groupBoxABMs.Controls.Add(this.cmdABMSucursal);
            this.groupBoxABMs.Controls.Add(this.cmdABMFactura);
            this.groupBoxABMs.Location = new System.Drawing.Point(1, 144);
            this.groupBoxABMs.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxABMs.Name = "groupBoxABMs";
            this.groupBoxABMs.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxABMs.Size = new System.Drawing.Size(333, 146);
            this.groupBoxABMs.TabIndex = 17;
            this.groupBoxABMs.TabStop = false;
            this.groupBoxABMs.Text = "ABMs";
            // 
            // cmdABMEmpresa
            // 
            this.cmdABMEmpresa.Enabled = false;
            this.cmdABMEmpresa.Location = new System.Drawing.Point(105, 103);
            this.cmdABMEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.cmdABMEmpresa.Name = "cmdABMEmpresa";
            this.cmdABMEmpresa.Size = new System.Drawing.Size(112, 27);
            this.cmdABMEmpresa.TabIndex = 11;
            this.cmdABMEmpresa.Text = "ABM Empresa";
            this.cmdABMEmpresa.UseVisualStyleBackColor = true;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCerrar.Location = new System.Drawing.Point(253, 296);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Location = new System.Drawing.Point(261, 19);
            this.lnlCerrarSesion.Name = "lnlCerrarSesion";
            this.lnlCerrarSesion.Size = new System.Drawing.Size(67, 13);
            this.lnlCerrarSesion.TabIndex = 20;
            this.lnlCerrarSesion.TabStop = true;
            this.lnlCerrarSesion.Text = "cerrar sesión";
            this.lnlCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlCerrarSesion_LinkClicked);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 324);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdABMCliente);
            this.Controls.Add(this.groupBoxABMs);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.groupBoxAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Menu";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.groupBoxAcciones.ResumeLayout(false);
            this.groupBoxABMs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListadoEstadistico;
        private System.Windows.Forms.Button cmdRegistrarPago;
        private System.Windows.Forms.Button cmdRendirFacturas;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button cmdABMRol;
        private System.Windows.Forms.Button cmdABMCliente;
        private System.Windows.Forms.Button cmdABMSucursal;
        private System.Windows.Forms.Button cmdABMFactura;
        private System.Windows.Forms.GroupBox groupBoxABMs;
        private System.Windows.Forms.Button cmdABMEmpresa;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
    }
}

