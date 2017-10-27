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
            this.components = new System.ComponentModel.Container();
            this.cmdListadoEstadistico = new System.Windows.Forms.Button();
            this.cmdRegistrarPago = new System.Windows.Forms.Button();
            this.cmdRendirFacturas = new System.Windows.Forms.Button();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.cmdDevolucion = new System.Windows.Forms.Button();
            this.cmdSeleccionarSucursal = new System.Windows.Forms.Button();
            this.cboSucursales = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.cmdABMRol = new System.Windows.Forms.Button();
            this.cmdABMCliente = new System.Windows.Forms.Button();
            this.cmdABMSucursal = new System.Windows.Forms.Button();
            this.cmdABMFactura = new System.Windows.Forms.Button();
            this.groupBoxABMs = new System.Windows.Forms.GroupBox();
            this.cmdABMEmpresa = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.lblSucursalSeleccionada = new System.Windows.Forms.Label();
            this.lblSeleccioneSucursal = new System.Windows.Forms.Label();
            this.lnlCambiarSucursal = new System.Windows.Forms.LinkLabel();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblRolSeleccionado = new System.Windows.Forms.Label();
            this.lblSuRolActualEs = new System.Windows.Forms.Label();
            this.groupBoxAcciones.SuspendLayout();
            this.groupBoxABMs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.cmdListadoEstadistico.Click += new System.EventHandler(this.cmdListadoEstadistico_Click);
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
            this.cmdRegistrarPago.Click += new System.EventHandler(this.cmdRegistrarPago_Click);
            // 
            // cmdRendirFacturas
            // 
            this.cmdRendirFacturas.Enabled = false;
            this.cmdRendirFacturas.Location = new System.Drawing.Point(30, 61);
            this.cmdRendirFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.cmdRendirFacturas.Name = "cmdRendirFacturas";
            this.cmdRendirFacturas.Size = new System.Drawing.Size(112, 27);
            this.cmdRendirFacturas.TabIndex = 4;
            this.cmdRendirFacturas.Text = "Rendir Facturas";
            this.cmdRendirFacturas.UseVisualStyleBackColor = true;
            this.cmdRendirFacturas.Click += new System.EventHandler(this.cmdRendirFacturas_Click);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.cmdDevolucion);
            this.groupBoxAcciones.Controls.Add(this.cmdRendirFacturas);
            this.groupBoxAcciones.Controls.Add(this.cmdListadoEstadistico);
            this.groupBoxAcciones.Controls.Add(this.cmdRegistrarPago);
            this.groupBoxAcciones.Location = new System.Drawing.Point(1, 113);
            this.groupBoxAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAcciones.Size = new System.Drawing.Size(333, 104);
            this.groupBoxAcciones.TabIndex = 9;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            this.groupBoxAcciones.Visible = false;
            // 
            // cmdDevolucion
            // 
            this.cmdDevolucion.Enabled = false;
            this.cmdDevolucion.Location = new System.Drawing.Point(189, 61);
            this.cmdDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDevolucion.Name = "cmdDevolucion";
            this.cmdDevolucion.Size = new System.Drawing.Size(112, 27);
            this.cmdDevolucion.TabIndex = 7;
            this.cmdDevolucion.Text = "Devolución Factura";
            this.cmdDevolucion.UseVisualStyleBackColor = true;
            this.cmdDevolucion.Click += new System.EventHandler(this.cmdDevolucion_Click);
            // 
            // cmdSeleccionarSucursal
            // 
            this.cmdSeleccionarSucursal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdSeleccionarSucursal.Location = new System.Drawing.Point(169, 89);
            this.cmdSeleccionarSucursal.Name = "cmdSeleccionarSucursal";
            this.cmdSeleccionarSucursal.Size = new System.Drawing.Size(75, 23);
            this.cmdSeleccionarSucursal.TabIndex = 23;
            this.cmdSeleccionarSucursal.Text = "Seleccionar";
            this.cmdSeleccionarSucursal.UseVisualStyleBackColor = false;
            this.cmdSeleccionarSucursal.Click += new System.EventHandler(this.cmdSeleccionarSucursal_Click);
            // 
            // cboSucursales
            // 
            this.cboSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursales.FormattingEnabled = true;
            this.cboSucursales.Location = new System.Drawing.Point(6, 89);
            this.cboSucursales.Name = "cboSucursales";
            this.cboSucursales.Size = new System.Drawing.Size(150, 21);
            this.cboSucursales.TabIndex = 17;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(0, 1);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(91, 20);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Bienvenido:";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(3, 17);
            this.lblUsuarioLogueado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(88, 20);
            this.lblUsuarioLogueado.TabIndex = 12;
            this.lblUsuarioLogueado.Text = "username";
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
            this.cmdABMCliente.Location = new System.Drawing.Point(189, 18);
            this.cmdABMCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmdABMCliente.Name = "cmdABMCliente";
            this.cmdABMCliente.Size = new System.Drawing.Size(112, 27);
            this.cmdABMCliente.TabIndex = 15;
            this.cmdABMCliente.Text = "ABM Cliente";
            this.cmdABMCliente.UseVisualStyleBackColor = true;
            this.cmdABMCliente.Click += new System.EventHandler(this.cmdABMCliente_Click);
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
            this.cmdABMSucursal.Click += new System.EventHandler(this.cmdABMSucursal_Click);
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
            this.groupBoxABMs.Controls.Add(this.cmdABMCliente);
            this.groupBoxABMs.Location = new System.Drawing.Point(1, 221);
            this.groupBoxABMs.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxABMs.Name = "groupBoxABMs";
            this.groupBoxABMs.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxABMs.Size = new System.Drawing.Size(333, 144);
            this.groupBoxABMs.TabIndex = 17;
            this.groupBoxABMs.TabStop = false;
            this.groupBoxABMs.Text = "ABMs";
            this.groupBoxABMs.Visible = false;
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
            this.cmdABMEmpresa.Click += new System.EventHandler(this.cmdABMEmpresa_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCerrar.Location = new System.Drawing.Point(255, 89);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCerrar.TabIndex = 19;
            this.cmdCerrar.Text = "Salir";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Location = new System.Drawing.Point(258, 6);
            this.lnlCerrarSesion.Name = "lnlCerrarSesion";
            this.lnlCerrarSesion.Size = new System.Drawing.Size(67, 13);
            this.lnlCerrarSesion.TabIndex = 20;
            this.lnlCerrarSesion.TabStop = true;
            this.lnlCerrarSesion.Text = "cerrar sesión";
            this.lnlCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlCerrarSesion_LinkClicked);
            // 
            // lblSucursalSeleccionada
            // 
            this.lblSucursalSeleccionada.AutoSize = true;
            this.lblSucursalSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalSeleccionada.Location = new System.Drawing.Point(1, 89);
            this.lblSucursalSeleccionada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursalSeleccionada.Name = "lblSucursalSeleccionada";
            this.lblSucursalSeleccionada.Size = new System.Drawing.Size(66, 16);
            this.lblSucursalSeleccionada.TabIndex = 22;
            this.lblSucursalSeleccionada.Text = "sucursal";
            this.lblSucursalSeleccionada.Visible = false;
            // 
            // lblSeleccioneSucursal
            // 
            this.lblSeleccioneSucursal.AutoSize = true;
            this.lblSeleccioneSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneSucursal.Location = new System.Drawing.Point(4, 73);
            this.lblSeleccioneSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccioneSucursal.Name = "lblSeleccioneSucursal";
            this.lblSeleccioneSucursal.Size = new System.Drawing.Size(152, 13);
            this.lblSeleccioneSucursal.TabIndex = 24;
            this.lblSeleccioneSucursal.Text = "Seleccione una Sucursal:";
            // 
            // lnlCambiarSucursal
            // 
            this.lnlCambiarSucursal.AutoSize = true;
            this.lnlCambiarSucursal.Location = new System.Drawing.Point(239, 24);
            this.lnlCambiarSucursal.Name = "lnlCambiarSucursal";
            this.lnlCambiarSucursal.Size = new System.Drawing.Size(86, 13);
            this.lnlCambiarSucursal.TabIndex = 25;
            this.lnlCambiarSucursal.TabStop = true;
            this.lnlCambiarSucursal.Text = "cambiar sucursal";
            this.lnlCambiarSucursal.Visible = false;
            this.lnlCambiarSucursal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlCambiarSucursal_LinkClicked);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(0, 70);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(177, 16);
            this.lblSucursal.TabIndex = 21;
            this.lblSucursal.Text = "Se encuentra en la Sucursal:";
            this.lblSucursal.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblRolSeleccionado
            // 
            this.lblRolSeleccionado.AutoSize = true;
            this.lblRolSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolSeleccionado.Location = new System.Drawing.Point(4, 54);
            this.lblRolSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolSeleccionado.Name = "lblRolSeleccionado";
            this.lblRolSeleccionado.Size = new System.Drawing.Size(26, 16);
            this.lblRolSeleccionado.TabIndex = 27;
            this.lblRolSeleccionado.Text = "rol";
            // 
            // lblSuRolActualEs
            // 
            this.lblSuRolActualEs.AutoSize = true;
            this.lblSuRolActualEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuRolActualEs.Location = new System.Drawing.Point(3, 38);
            this.lblSuRolActualEs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuRolActualEs.Name = "lblSuRolActualEs";
            this.lblSuRolActualEs.Size = new System.Drawing.Size(108, 16);
            this.lblSuRolActualEs.TabIndex = 26;
            this.lblSuRolActualEs.Text = "Su Rol actual es:";
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 368);
            this.Controls.Add(this.lblRolSeleccionado);
            this.Controls.Add(this.lblSuRolActualEs);
            this.Controls.Add(this.lblSucursalSeleccionada);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lnlCambiarSucursal);
            this.Controls.Add(this.cboSucursales);
            this.Controls.Add(this.lblSeleccioneSucursal);
            this.Controls.Add(this.cmdSeleccionarSucursal);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.groupBoxABMs);
            this.Controls.Add(this.lblUsuarioLogueado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.groupBoxAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Menú Principal";
            this.Load += new System.EventHandler(this.MenuPrincipalForm_Load);
            this.groupBoxAcciones.ResumeLayout(false);
            this.groupBoxABMs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListadoEstadistico;
        private System.Windows.Forms.Button cmdRegistrarPago;
        private System.Windows.Forms.Button cmdRendirFacturas;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Button cmdABMRol;
        private System.Windows.Forms.Button cmdABMCliente;
        private System.Windows.Forms.Button cmdABMSucursal;
        private System.Windows.Forms.Button cmdABMFactura;
        private System.Windows.Forms.GroupBox groupBoxABMs;
        private System.Windows.Forms.Button cmdABMEmpresa;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
        private System.Windows.Forms.ComboBox cboSucursales;
        private System.Windows.Forms.Label lblSucursalSeleccionada;
        private System.Windows.Forms.Button cmdSeleccionarSucursal;
        private System.Windows.Forms.Label lblSeleccioneSucursal;
        private System.Windows.Forms.LinkLabel lnlCambiarSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Button cmdDevolucion;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRolSeleccionado;
        private System.Windows.Forms.Label lblSuRolActualEs;
    }
}

