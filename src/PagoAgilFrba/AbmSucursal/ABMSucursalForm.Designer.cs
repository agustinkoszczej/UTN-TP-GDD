namespace PagoAgilFrba.AbmSucursal
{
    partial class ABMSucursalForm
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
            this.cmdAltaSucursal = new System.Windows.Forms.Button();
            this.cmdModificarSucursal = new System.Windows.Forms.Button();
            this.cmdBorrarSucursal = new System.Windows.Forms.Button();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.dgdSucursales = new System.Windows.Forms.DataGridView();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.lblSucursales = new System.Windows.Forms.Label();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.chkQuitarDeshabilitados = new System.Windows.Forms.CheckBox();
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.txtCodPostalSucursal = new System.Windows.Forms.TextBox();
            this.cmdQuitarFiltros = new System.Windows.Forms.Button();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblDireccionSucursal = new System.Windows.Forms.Label();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSucursales)).BeginInit();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmdAltaSucursal
            // 
            this.cmdAltaSucursal.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdAltaSucursal.Location = new System.Drawing.Point(16, 19);
            this.cmdAltaSucursal.Name = "cmdAltaSucursal";
            this.cmdAltaSucursal.Size = new System.Drawing.Size(121, 35);
            this.cmdAltaSucursal.TabIndex = 9;
            this.cmdAltaSucursal.Text = "Nueva Sucursal";
            this.cmdAltaSucursal.UseVisualStyleBackColor = false;
            this.cmdAltaSucursal.Click += new System.EventHandler(this.cmdAltaSucursal_Click);
            // 
            // cmdModificarSucursal
            // 
            this.cmdModificarSucursal.BackColor = System.Drawing.Color.Gold;
            this.cmdModificarSucursal.Location = new System.Drawing.Point(16, 101);
            this.cmdModificarSucursal.Name = "cmdModificarSucursal";
            this.cmdModificarSucursal.Size = new System.Drawing.Size(121, 35);
            this.cmdModificarSucursal.TabIndex = 10;
            this.cmdModificarSucursal.Text = "Modificar";
            this.cmdModificarSucursal.UseVisualStyleBackColor = false;
            this.cmdModificarSucursal.Click += new System.EventHandler(this.cmdModificarSucursal_Click);
            // 
            // cmdBorrarSucursal
            // 
            this.cmdBorrarSucursal.BackColor = System.Drawing.Color.Red;
            this.cmdBorrarSucursal.Location = new System.Drawing.Point(16, 60);
            this.cmdBorrarSucursal.Name = "cmdBorrarSucursal";
            this.cmdBorrarSucursal.Size = new System.Drawing.Size(121, 35);
            this.cmdBorrarSucursal.TabIndex = 11;
            this.cmdBorrarSucursal.Text = "Habilitar/Deshabilitar";
            this.cmdBorrarSucursal.UseVisualStyleBackColor = false;
            this.cmdBorrarSucursal.Click += new System.EventHandler(this.cmdBorrarSucursal_Click);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.cmdAltaSucursal);
            this.groupBoxAcciones.Controls.Add(this.cmdModificarSucursal);
            this.groupBoxAcciones.Controls.Add(this.cmdBorrarSucursal);
            this.groupBoxAcciones.Location = new System.Drawing.Point(352, 345);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(153, 149);
            this.groupBoxAcciones.TabIndex = 12;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // dgdSucursales
            // 
            this.dgdSucursales.AllowUserToAddRows = false;
            this.dgdSucursales.AllowUserToDeleteRows = false;
            this.dgdSucursales.AllowUserToResizeColumns = false;
            this.dgdSucursales.AllowUserToResizeRows = false;
            this.dgdSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdSucursales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdSucursales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdSucursales.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdSucursales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdSucursales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdSucursales.Location = new System.Drawing.Point(12, 36);
            this.dgdSucursales.MultiSelect = false;
            this.dgdSucursales.Name = "dgdSucursales";
            this.dgdSucursales.ReadOnly = true;
            this.dgdSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdSucursales.Size = new System.Drawing.Size(631, 282);
            this.dgdSucursales.TabIndex = 13;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCerrar.Location = new System.Drawing.Point(511, 405);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(121, 35);
            this.cmdCerrar.TabIndex = 12;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursales.Location = new System.Drawing.Point(11, 9);
            this.lblSucursales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(113, 24);
            this.lblSucursales.TabIndex = 14;
            this.lblSucursales.Text = "Sucursales";
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Location = new System.Drawing.Point(576, 9);
            this.lnlCerrarSesion.Name = "lnlCerrarSesion";
            this.lnlCerrarSesion.Size = new System.Drawing.Size(67, 13);
            this.lnlCerrarSesion.TabIndex = 21;
            this.lnlCerrarSesion.TabStop = true;
            this.lnlCerrarSesion.Text = "cerrar sesión";
            this.lnlCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlCerrarSesion_LinkClicked);
            // 
            // chkQuitarDeshabilitados
            // 
            this.chkQuitarDeshabilitados.AutoSize = true;
            this.chkQuitarDeshabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuitarDeshabilitados.Location = new System.Drawing.Point(195, 76);
            this.chkQuitarDeshabilitados.Name = "chkQuitarDeshabilitados";
            this.chkQuitarDeshabilitados.Size = new System.Drawing.Size(133, 16);
            this.chkQuitarDeshabilitados.TabIndex = 22;
            this.chkQuitarDeshabilitados.Text = "Quitar Deshabilitados";
            this.chkQuitarDeshabilitados.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtCodPostalSucursal);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdQuitarFiltros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.chkQuitarDeshabilitados);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblCodPostal);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblDireccionSucursal);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtDireccionSucursal);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblNombreSucursal);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtNombreSucursal);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdBuscar);
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(12, 324);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(334, 196);
            this.groupBoxFiltrosBusqueda.TabIndex = 13;
            this.groupBoxFiltrosBusqueda.TabStop = false;
            this.groupBoxFiltrosBusqueda.Text = "Filtros de búsqueda";
            // 
            // txtCodPostalSucursal
            // 
            this.txtCodPostalSucursal.Location = new System.Drawing.Point(13, 119);
            this.txtCodPostalSucursal.Name = "txtCodPostalSucursal";
            this.txtCodPostalSucursal.Size = new System.Drawing.Size(155, 20);
            this.txtCodPostalSucursal.TabIndex = 29;
            // 
            // cmdQuitarFiltros
            // 
            this.cmdQuitarFiltros.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdQuitarFiltros.Location = new System.Drawing.Point(196, 149);
            this.cmdQuitarFiltros.Name = "cmdQuitarFiltros";
            this.cmdQuitarFiltros.Size = new System.Drawing.Size(121, 35);
            this.cmdQuitarFiltros.TabIndex = 28;
            this.cmdQuitarFiltros.Text = "Quitar filtros";
            this.cmdQuitarFiltros.UseVisualStyleBackColor = false;
            this.cmdQuitarFiltros.Click += new System.EventHandler(this.cmdQuitarFiltros_Click);
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(10, 99);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 27;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblDireccionSucursal
            // 
            this.lblDireccionSucursal.AutoSize = true;
            this.lblDireccionSucursal.Location = new System.Drawing.Point(10, 60);
            this.lblDireccionSucursal.Name = "lblDireccionSucursal";
            this.lblDireccionSucursal.Size = new System.Drawing.Size(122, 13);
            this.lblDireccionSucursal.TabIndex = 25;
            this.lblDireccionSucursal.Text = "Dirección de la Sucursal";
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(13, 76);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(155, 20);
            this.txtDireccionSucursal.TabIndex = 24;
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Location = new System.Drawing.Point(10, 21);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(114, 13);
            this.lblNombreSucursal.TabIndex = 13;
            this.lblNombreSucursal.Text = "Nombre de la Sucursal";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(13, 37);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(155, 20);
            this.txtNombreSucursal.TabIndex = 12;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.Orange;
            this.cmdBuscar.Location = new System.Drawing.Point(22, 149);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(121, 35);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.Text = "Aplicar filtros";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // ABMSucursalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 532);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.lblSucursales);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.dgdSucursales);
            this.Controls.Add(this.groupBoxAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMSucursalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | ABM Sucursal";
            this.Load += new System.EventHandler(this.ABMSucursalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdSucursales)).EndInit();
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cmdAltaSucursal;
        private System.Windows.Forms.Button cmdBorrarSucursal;
        private System.Windows.Forms.Button cmdModificarSucursal;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.DataGridView dgdSucursales;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label lblSucursales;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
        private System.Windows.Forms.CheckBox chkQuitarDeshabilitados;
        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.Label lblDireccionSucursal;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Button cmdQuitarFiltros;
        private System.Windows.Forms.TextBox txtCodPostalSucursal;

    }
}