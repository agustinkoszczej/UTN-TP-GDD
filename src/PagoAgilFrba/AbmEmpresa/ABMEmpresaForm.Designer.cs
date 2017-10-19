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
            ((System.ComponentModel.ISupportInitialize)(this.dgdRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdRubros
            // 
            this.dgdRubros.AllowUserToAddRows = false;
            this.dgdRubros.AllowUserToDeleteRows = false;
            this.dgdRubros.AllowUserToResizeColumns = false;
            this.dgdRubros.AllowUserToResizeRows = false;
            this.dgdRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdRubros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdRubros.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdRubros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdRubros.Location = new System.Drawing.Point(308, 39);
            this.dgdRubros.MultiSelect = false;
            this.dgdRubros.Name = "dgdRubros";
            this.dgdRubros.ReadOnly = true;
            this.dgdRubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdRubros.Size = new System.Drawing.Size(272, 320);
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
            this.groupBoxAcciones.Location = new System.Drawing.Point(586, 39);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(200, 203);
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
            this.dgdEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdEmpresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdEmpresas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdEmpresas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdEmpresas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdEmpresas.Location = new System.Drawing.Point(12, 39);
            this.dgdEmpresas.MultiSelect = false;
            this.dgdEmpresas.Name = "dgdEmpresas";
            this.dgdEmpresas.ReadOnly = true;
            this.dgdEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdEmpresas.Size = new System.Drawing.Size(272, 320);
            this.dgdEmpresas.TabIndex = 13;
            this.dgdEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdRoles_CellContentClick);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCerrar.Location = new System.Drawing.Point(621, 309);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(121, 35);
            this.cmdCerrar.TabIndex = 12;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
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
            this.lblRubros.Location = new System.Drawing.Point(361, 12);
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
            this.chkQuitarDeshabilitados.Location = new System.Drawing.Point(119, 17);
            this.chkQuitarDeshabilitados.Name = "chkQuitarDeshabilitados";
            this.chkQuitarDeshabilitados.Size = new System.Drawing.Size(133, 16);
            this.chkQuitarDeshabilitados.TabIndex = 22;
            this.chkQuitarDeshabilitados.Text = "Quitar Deshabilitados";
            this.chkQuitarDeshabilitados.UseVisualStyleBackColor = true;
            this.chkQuitarDeshabilitados.CheckedChanged += new System.EventHandler(this.chkQuitarDeshabilitados_CheckedChanged);
            // 
            // ABMEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 371);
            this.Controls.Add(this.chkQuitarDeshabilitados);
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

    }
}