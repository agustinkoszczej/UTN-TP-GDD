namespace PagoAgilFrba.AbmRol
{
    partial class ABMRolForm
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
            this.dgdFuncionalidades = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdAltaRol = new System.Windows.Forms.Button();
            this.cmdModificarRol = new System.Windows.Forms.Button();
            this.cmdBorrarRol = new System.Windows.Forms.Button();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.dgdRoles = new System.Windows.Forms.DataGridView();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.chkQuitarDeshabilitados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdFuncionalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdFuncionalidades
            // 
            this.dgdFuncionalidades.AllowUserToAddRows = false;
            this.dgdFuncionalidades.AllowUserToDeleteRows = false;
            this.dgdFuncionalidades.AllowUserToResizeColumns = false;
            this.dgdFuncionalidades.AllowUserToResizeRows = false;
            this.dgdFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdFuncionalidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdFuncionalidades.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdFuncionalidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdFuncionalidades.Location = new System.Drawing.Point(360, 39);
            this.dgdFuncionalidades.MultiSelect = false;
            this.dgdFuncionalidades.Name = "dgdFuncionalidades";
            this.dgdFuncionalidades.ReadOnly = true;
            this.dgdFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdFuncionalidades.Size = new System.Drawing.Size(220, 320);
            this.dgdFuncionalidades.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmdAltaRol
            // 
            this.cmdAltaRol.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdAltaRol.Location = new System.Drawing.Point(35, 30);
            this.cmdAltaRol.Name = "cmdAltaRol";
            this.cmdAltaRol.Size = new System.Drawing.Size(121, 35);
            this.cmdAltaRol.TabIndex = 9;
            this.cmdAltaRol.Text = "Nuevo Rol";
            this.cmdAltaRol.UseVisualStyleBackColor = false;
            this.cmdAltaRol.Click += new System.EventHandler(this.cmdAltaRol_Click);
            // 
            // cmdModificarRol
            // 
            this.cmdModificarRol.BackColor = System.Drawing.Color.Gold;
            this.cmdModificarRol.Location = new System.Drawing.Point(35, 146);
            this.cmdModificarRol.Name = "cmdModificarRol";
            this.cmdModificarRol.Size = new System.Drawing.Size(121, 35);
            this.cmdModificarRol.TabIndex = 10;
            this.cmdModificarRol.Text = "Modificar";
            this.cmdModificarRol.UseVisualStyleBackColor = false;
            this.cmdModificarRol.Click += new System.EventHandler(this.cmdModificarRol_Click);
            // 
            // cmdBorrarRol
            // 
            this.cmdBorrarRol.BackColor = System.Drawing.Color.Red;
            this.cmdBorrarRol.Location = new System.Drawing.Point(35, 88);
            this.cmdBorrarRol.Name = "cmdBorrarRol";
            this.cmdBorrarRol.Size = new System.Drawing.Size(121, 35);
            this.cmdBorrarRol.TabIndex = 11;
            this.cmdBorrarRol.Text = "Habilitar/Deshabilitar";
            this.cmdBorrarRol.UseVisualStyleBackColor = false;
            this.cmdBorrarRol.Click += new System.EventHandler(this.cmdBorrarRol_Click);
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.cmdAltaRol);
            this.groupBoxAcciones.Controls.Add(this.cmdModificarRol);
            this.groupBoxAcciones.Controls.Add(this.cmdBorrarRol);
            this.groupBoxAcciones.Location = new System.Drawing.Point(586, 39);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(200, 203);
            this.groupBoxAcciones.TabIndex = 12;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // dgdRoles
            // 
            this.dgdRoles.AllowUserToAddRows = false;
            this.dgdRoles.AllowUserToDeleteRows = false;
            this.dgdRoles.AllowUserToResizeColumns = false;
            this.dgdRoles.AllowUserToResizeRows = false;
            this.dgdRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgdRoles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgdRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdRoles.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgdRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgdRoles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgdRoles.Location = new System.Drawing.Point(12, 39);
            this.dgdRoles.MultiSelect = false;
            this.dgdRoles.Name = "dgdRoles";
            this.dgdRoles.ReadOnly = true;
            this.dgdRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdRoles.Size = new System.Drawing.Size(327, 320);
            this.dgdRoles.TabIndex = 13;
            this.dgdRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdRoles_CellContentClick);
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
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.Location = new System.Drawing.Point(11, 9);
            this.lblRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(63, 24);
            this.lblRoles.TabIndex = 14;
            this.lblRoles.Text = "Roles";
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionalidades.Location = new System.Drawing.Point(361, 12);
            this.lblFuncionalidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(165, 24);
            this.lblFuncionalidades.TabIndex = 15;
            this.lblFuncionalidades.Text = "Funcionalidades";
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
            this.chkQuitarDeshabilitados.Location = new System.Drawing.Point(79, 17);
            this.chkQuitarDeshabilitados.Name = "chkQuitarDeshabilitados";
            this.chkQuitarDeshabilitados.Size = new System.Drawing.Size(133, 16);
            this.chkQuitarDeshabilitados.TabIndex = 22;
            this.chkQuitarDeshabilitados.Text = "Quitar Deshabilitados";
            this.chkQuitarDeshabilitados.UseVisualStyleBackColor = true;
            this.chkQuitarDeshabilitados.CheckedChanged += new System.EventHandler(this.chkQuitarDeshabilitados_CheckedChanged);
            // 
            // ABMRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 371);
            this.Controls.Add(this.chkQuitarDeshabilitados);
            this.Controls.Add(this.lnlCerrarSesion);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.dgdRoles);
            this.Controls.Add(this.groupBoxAcciones);
            this.Controls.Add(this.dgdFuncionalidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | ABM Rol";
            this.Load += new System.EventHandler(this.ABMRolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdFuncionalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdFuncionalidades;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cmdAltaRol;
        private System.Windows.Forms.Button cmdBorrarRol;
        private System.Windows.Forms.Button cmdModificarRol;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.DataGridView dgdRoles;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
        private System.Windows.Forms.CheckBox chkQuitarDeshabilitados;

    }
}