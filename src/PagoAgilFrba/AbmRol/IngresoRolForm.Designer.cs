namespace PagoAgilFrba.AbmRol
{
    partial class IngresoRolForm
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
            this.groupBoxIngresoRoles = new System.Windows.Forms.GroupBox();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.chkLstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxIngresoRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIngresoRoles
            // 
            this.groupBoxIngresoRoles.Controls.Add(this.lblFuncionalidades);
            this.groupBoxIngresoRoles.Controls.Add(this.cmdCancelar);
            this.groupBoxIngresoRoles.Controls.Add(this.cmdAceptar);
            this.groupBoxIngresoRoles.Controls.Add(this.chkLstFuncionalidades);
            this.groupBoxIngresoRoles.Controls.Add(this.txtNombreRol);
            this.groupBoxIngresoRoles.Controls.Add(this.lblNombreRol);
            this.groupBoxIngresoRoles.Location = new System.Drawing.Point(12, 9);
            this.groupBoxIngresoRoles.Name = "groupBoxIngresoRoles";
            this.groupBoxIngresoRoles.Size = new System.Drawing.Size(382, 286);
            this.groupBoxIngresoRoles.TabIndex = 5;
            this.groupBoxIngresoRoles.TabStop = false;
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Location = new System.Drawing.Point(6, 63);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(84, 13);
            this.lblFuncionalidades.TabIndex = 21;
            this.lblFuncionalidades.Text = "Funcionalidades";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCancelar.Location = new System.Drawing.Point(249, 190);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(121, 34);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdAceptar.Location = new System.Drawing.Point(249, 134);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(121, 35);
            this.cmdAceptar.TabIndex = 3;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // chkLstFuncionalidades
            // 
            this.chkLstFuncionalidades.CheckOnClick = true;
            this.chkLstFuncionalidades.FormattingEnabled = true;
            this.chkLstFuncionalidades.Location = new System.Drawing.Point(6, 79);
            this.chkLstFuncionalidades.MultiColumn = true;
            this.chkLstFuncionalidades.Name = "chkLstFuncionalidades";
            this.chkLstFuncionalidades.Size = new System.Drawing.Size(222, 199);
            this.chkLstFuncionalidades.TabIndex = 2;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(6, 38);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(155, 20);
            this.txtNombreRol.TabIndex = 1;
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Location = new System.Drawing.Point(6, 24);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(78, 13);
            this.lblNombreRol.TabIndex = 1;
            this.lblNombreRol.Text = "Nombre de Rol";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IngresoRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 307);
            this.Controls.Add(this.groupBoxIngresoRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IngresoRolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Ingreso Rol";
            this.groupBoxIngresoRoles.ResumeLayout(false);
            this.groupBoxIngresoRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngresoRoles;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.CheckedListBox chkLstFuncionalidades;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider;

    }
}