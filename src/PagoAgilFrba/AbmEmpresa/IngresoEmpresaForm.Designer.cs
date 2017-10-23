namespace PagoAgilFrba.AbmEmpresa
{
    partial class IngresoEmpresaForm
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
            this.groupBoxIngresoEmpresas = new System.Windows.Forms.GroupBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.lblDireccionEmpresa = new System.Windows.Forms.Label();
            this.lblCuitEmpresa = new System.Windows.Forms.Label();
            this.txtCuitEmpresa = new System.Windows.Forms.TextBox();
            this.lblRubros = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.chkLstRubros = new System.Windows.Forms.CheckedListBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxIngresoEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIngresoEmpresas
            // 
            this.groupBoxIngresoEmpresas.Controls.Add(this.txtDireccionEmpresa);
            this.groupBoxIngresoEmpresas.Controls.Add(this.lblDireccionEmpresa);
            this.groupBoxIngresoEmpresas.Controls.Add(this.lblCuitEmpresa);
            this.groupBoxIngresoEmpresas.Controls.Add(this.txtCuitEmpresa);
            this.groupBoxIngresoEmpresas.Controls.Add(this.lblRubros);
            this.groupBoxIngresoEmpresas.Controls.Add(this.cmdCancelar);
            this.groupBoxIngresoEmpresas.Controls.Add(this.cmdAceptar);
            this.groupBoxIngresoEmpresas.Controls.Add(this.chkLstRubros);
            this.groupBoxIngresoEmpresas.Controls.Add(this.txtNombreEmpresa);
            this.groupBoxIngresoEmpresas.Controls.Add(this.lblNombreEmpresa);
            this.groupBoxIngresoEmpresas.Location = new System.Drawing.Point(12, 9);
            this.groupBoxIngresoEmpresas.Name = "groupBoxIngresoEmpresas";
            this.groupBoxIngresoEmpresas.Size = new System.Drawing.Size(382, 312);
            this.groupBoxIngresoEmpresas.TabIndex = 5;
            this.groupBoxIngresoEmpresas.TabStop = false;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(6, 101);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(155, 20);
            this.txtDireccionEmpresa.TabIndex = 3;
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(6, 86);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(122, 13);
            this.lblDireccionEmpresa.TabIndex = 24;
            this.lblDireccionEmpresa.Text = "Dirección de la Empresa";
            // 
            // lblCuitEmpresa
            // 
            this.lblCuitEmpresa.AutoSize = true;
            this.lblCuitEmpresa.Location = new System.Drawing.Point(6, 48);
            this.lblCuitEmpresa.Name = "lblCuitEmpresa";
            this.lblCuitEmpresa.Size = new System.Drawing.Size(95, 13);
            this.lblCuitEmpresa.TabIndex = 23;
            this.lblCuitEmpresa.Text = "Cuit de la Empresa";
            // 
            // txtCuitEmpresa
            // 
            this.txtCuitEmpresa.Location = new System.Drawing.Point(6, 63);
            this.txtCuitEmpresa.Name = "txtCuitEmpresa";
            this.txtCuitEmpresa.Size = new System.Drawing.Size(155, 20);
            this.txtCuitEmpresa.TabIndex = 2;
            this.txtCuitEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuitEmpresa_KeyPress);
            // 
            // lblRubros
            // 
            this.lblRubros.AutoSize = true;
            this.lblRubros.Location = new System.Drawing.Point(6, 123);
            this.lblRubros.Name = "lblRubros";
            this.lblRubros.Size = new System.Drawing.Size(41, 13);
            this.lblRubros.TabIndex = 21;
            this.lblRubros.Text = "Rubros";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCancelar.Location = new System.Drawing.Point(249, 190);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(121, 34);
            this.cmdCancelar.TabIndex = 6;
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
            this.cmdAceptar.TabIndex = 5;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // chkLstRubros
            // 
            this.chkLstRubros.CheckOnClick = true;
            this.chkLstRubros.FormattingEnabled = true;
            this.chkLstRubros.Location = new System.Drawing.Point(6, 143);
            this.chkLstRubros.MultiColumn = true;
            this.chkLstRubros.Name = "chkLstRubros";
            this.chkLstRubros.Size = new System.Drawing.Size(222, 169);
            this.chkLstRubros.TabIndex = 4;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(6, 26);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(155, 20);
            this.txtNombreEmpresa.TabIndex = 1;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(6, 11);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(114, 13);
            this.lblNombreEmpresa.TabIndex = 1;
            this.lblNombreEmpresa.Text = "Nombre de la Empresa";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IngresoEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 333);
            this.Controls.Add(this.groupBoxIngresoEmpresas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IngresoEmpresaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Ingreso Empresa";
            this.groupBoxIngresoEmpresas.ResumeLayout(false);
            this.groupBoxIngresoEmpresas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngresoEmpresas;
        private System.Windows.Forms.Label lblRubros;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.CheckedListBox chkLstRubros;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.Label lblDireccionEmpresa;
        private System.Windows.Forms.Label lblCuitEmpresa;
        private System.Windows.Forms.TextBox txtCuitEmpresa;

    }
}