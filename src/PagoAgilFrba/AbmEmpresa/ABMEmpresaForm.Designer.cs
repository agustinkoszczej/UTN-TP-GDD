namespace PagoAgilFrba.AbmEmpresa
{
    partial class ABMEmpresaForm
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
            this.dgdRubros = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdAltaEmpresa = new System.Windows.Forms.Button();
            this.cmdModificarEmpresa = new System.Windows.Forms.Button();
            this.cmdBorrarEmpresa = new System.Windows.Forms.Button();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.dgdEmpresas = new System.Windows.Forms.DataGridView();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.lblEmpresas = new System.Windows.Forms.Label();
            this.lblRubros = new System.Windows.Forms.Label();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.chkQuitarDeshabilitados = new System.Windows.Forms.CheckBox();
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.cmdQuitarFiltros = new System.Windows.Forms.Button();
            this.lblRubrosBuscar = new System.Windows.Forms.Label();
            this.chkLstRubros = new System.Windows.Forms.CheckedListBox();
            this.lblCuitEmpresa = new System.Windows.Forms.Label();
            this.txtCuitEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmpresas)).BeginInit();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdRubros
            // 
            this.dgdRubros.AllowUserToAddRows = false;
            this.dgdRubros.AllowUserToDeleteRows = false;
            this.dgdRubros.AllowUserToResizeColumns = false;
            this.dgdRubros.AllowUserToResizeRows = false;
            this.dgdRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdRubros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdRubros.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdRubros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdRubros.Location = new System.Drawing.Point(381, 39);
            this.dgdRubros.MultiSelect = false;
            this.dgdRubros.Name = "dgdRubros";
            this.dgdRubros.ReadOnly = true;
            this.dgdRubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdRubros.Size = new System.Drawing.Size(220, 320);
            this.dgdRubros.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmdAltaEmpresa
            // 
            this.cmdAltaEmpresa.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdAltaEmpresa.Location = new System.Drawing.Point(35, 30);
            this.cmdAltaEmpresa.Name = "cmdAltaEmpresa";
            this.cmdAltaEmpresa.Size = new System.Drawing.Size(121, 35);
            this.cmdAltaEmpresa.TabIndex = 9;
            this.cmdAltaEmpresa.Text = "Nueva Empresa";
            this.cmdAltaEmpresa.UseVisualStyleBackColor = false;
            this.cmdAltaEmpresa.Click += new System.EventHandler(this.cmdAltaRol_Click);
            // 
            // cmdModificarEmpresa
            // 
            this.cmdModificarEmpresa.BackColor = System.Drawing.Color.Gold;
            this.cmdModificarEmpresa.Location = new System.Drawing.Point(35, 146);
            this.cmdModificarEmpresa.Name = "cmdModificarEmpresa";
            this.cmdModificarEmpresa.Size = new System.Drawing.Size(121, 35);
            this.cmdModificarEmpresa.TabIndex = 10;
            this.cmdModificarEmpresa.Text = "Modificar";
            this.cmdModificarEmpresa.UseVisualStyleBackColor = false;
            this.cmdModificarEmpresa.Click += new System.EventHandler(this.cmdModificarRol_Click);
            // 
            // cmdBorrarEmpresa
            // 
            this.cmdBorrarEmpresa.BackColor = System.Drawing.Color.Red;
            this.cmdBorrarEmpresa.Location = new System.Drawing.Point(35, 88);
            this.cmdBorrarEmpresa.Name = "cmdBorrarEmpresa";
            this.cmdBorrarEmpresa.Size = new System.Drawing.Size(121, 35);
            this.cmdBorrarEmpresa.TabIndex = 11;
            this.cmdBorrarEmpresa.Text = "Habilitar/Deshabilitar";
            this.cmdBorrarEmpresa.UseVisualStyleBackColor = false;
            this.cmdBorrarEmpresa.Click += new System.EventHandler(this.cmdBorrarRol_Click);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.cmdAltaEmpresa);
            this.groupBoxAcciones.Controls.Add(this.cmdModificarEmpresa);
            this.groupBoxAcciones.Controls.Add(this.cmdBorrarEmpresa);
            this.groupBoxAcciones.Location = new System.Drawing.Point(610, 39);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(176, 203);
            this.groupBoxAcciones.TabIndex = 12;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // dgdEmpresas
            // 
            this.dgdEmpresas.AllowUserToAddRows = false;
            this.dgdEmpresas.AllowUserToDeleteRows = false;
            this.dgdEmpresas.AllowUserToResizeColumns = false;
            this.dgdEmpresas.AllowUserToResizeRows = false;
            this.dgdEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdEmpresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdEmpresas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdEmpresas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdEmpresas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdEmpresas.Location = new System.Drawing.Point(12, 36);
            this.dgdEmpresas.MultiSelect = false;
            this.dgdEmpresas.Name = "dgdEmpresas";
            this.dgdEmpresas.ReadOnly = true;
            this.dgdEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdEmpresas.Size = new System.Drawing.Size(342, 323);
            this.dgdEmpresas.TabIndex = 13;
            this.dgdEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdRoles_CellContentClick);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCerrar.Location = new System.Drawing.Point(645, 293);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(121, 35);
            this.cmdCerrar.TabIndex = 12;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblEmpresas
            // 
            this.lblEmpresas.AutoSize = true;
            this.lblEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresas.Location = new System.Drawing.Point(11, 9);
            this.lblEmpresas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresas.Name = "lblEmpresas";
            this.lblEmpresas.Size = new System.Drawing.Size(103, 24);
            this.lblEmpresas.TabIndex = 14;
            this.lblEmpresas.Text = "Empresas";
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubros.Location = new System.Drawing.Point(382, 12);
            this.lblRubros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(77, 24);
            this.lblRubros.TabIndex = 15;
            this.lblRubros.Text = "Rubros";
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Location = new System.Drawing.Point(719, 12);
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
            this.chkQuitarDeshabilitados.Location = new System.Drawing.Point(13, 73);
            this.chkQuitarDeshabilitados.Name = "chkQuitarDeshabilitados";
            this.chkQuitarDeshabilitados.Size = new System.Drawing.Size(133, 16);
            this.chkQuitarDeshabilitados.TabIndex = 22;
            this.chkQuitarDeshabilitados.Text = "Quitar Deshabilitados";
            this.chkQuitarDeshabilitados.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdQuitarFiltros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.chkQuitarDeshabilitados);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblRubrosBuscar);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.chkLstRubros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblCuitEmpresa);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtCuitEmpresa);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblNombreEmpresa);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtNombreEmpresa);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdBuscar);
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(15, 374);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(771, 158);
            this.groupBoxFiltrosBusqueda.TabIndex = 13;
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
            // lblRubrosBuscar
            // 
            this.lblRubrosBuscar.AutoSize = true;
            this.lblRubrosBuscar.Location = new System.Drawing.Point(350, 17);
            this.lblRubrosBuscar.Name = "lblRubrosBuscar";
            this.lblRubrosBuscar.Size = new System.Drawing.Size(41, 13);
            this.lblRubrosBuscar.TabIndex = 27;
            this.lblRubrosBuscar.Text = "Rubros";
            // 
            // chkLstRubros
            // 
            this.chkLstRubros.CheckOnClick = true;
            this.chkLstRubros.FormattingEnabled = true;
            this.chkLstRubros.Location = new System.Drawing.Point(350, 37);
            this.chkLstRubros.MultiColumn = true;
            this.chkLstRubros.Name = "chkLstRubros";
            this.chkLstRubros.Size = new System.Drawing.Size(403, 109);
            this.chkLstRubros.TabIndex = 26;
            // 
            // lblCuitEmpresa
            // 
            this.lblCuitEmpresa.AutoSize = true;
            this.lblCuitEmpresa.Location = new System.Drawing.Point(181, 21);
            this.lblCuitEmpresa.Name = "lblCuitEmpresa";
            this.lblCuitEmpresa.Size = new System.Drawing.Size(95, 13);
            this.lblCuitEmpresa.TabIndex = 25;
            this.lblCuitEmpresa.Text = "Cuit de la Empresa";
            // 
            // txtCuitEmpresa
            // 
            this.txtCuitEmpresa.Location = new System.Drawing.Point(184, 37);
            this.txtCuitEmpresa.Name = "txtCuitEmpresa";
            this.txtCuitEmpresa.Size = new System.Drawing.Size(155, 20);
            this.txtCuitEmpresa.TabIndex = 24;
            this.txtCuitEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuitEmpresa_KeyPress);
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(10, 21);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(114, 13);
            this.lblNombreEmpresa.TabIndex = 13;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(13, 37);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(155, 20);
            this.txtNombreEmpresa.TabIndex = 12;
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
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // ABMEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 564);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.lblRubros);
            this.Controls.Add(this.lblEmpresas);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.dgdEmpresas);
            this.Controls.Add(this.groupBoxAcciones);
            this.Controls.Add(this.dgdRubros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMEmpresaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | ABM Empresa";
            this.Load += new System.EventHandler(this.ABMEmpresaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmpresas)).EndInit();
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdRubros;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cmdAltaEmpresa;
        private System.Windows.Forms.Button cmdBorrarEmpresa;
        private System.Windows.Forms.Button cmdModificarEmpresa;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.DataGridView dgdEmpresas;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.Label lblEmpresas;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
        private System.Windows.Forms.CheckBox chkQuitarDeshabilitados;
        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblCuitEmpresa;
        private System.Windows.Forms.TextBox txtCuitEmpresa;
        private System.Windows.Forms.Label lblRubrosBuscar;
        private System.Windows.Forms.CheckedListBox chkLstRubros;
        private System.Windows.Forms.Button cmdQuitarFiltros;

    }
}