namespace PagoAgilFrba.AbmSucursal
{
    partial class IngresoSucursalForm
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
            this.groupBoxIngresoSucursales = new System.Windows.Forms.GroupBox();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.lblDireccionSucursal = new System.Windows.Forms.Label();
            this.lblCodPostalSucursal = new System.Windows.Forms.Label();
            this.txtCodPostalSucursal = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxIngresoSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIngresoSucursales
            // 
            this.groupBoxIngresoSucursales.Controls.Add(this.txtDireccionSucursal);
            this.groupBoxIngresoSucursales.Controls.Add(this.lblDireccionSucursal);
            this.groupBoxIngresoSucursales.Controls.Add(this.lblCodPostalSucursal);
            this.groupBoxIngresoSucursales.Controls.Add(this.txtCodPostalSucursal);
            this.groupBoxIngresoSucursales.Controls.Add(this.cmdCancelar);
            this.groupBoxIngresoSucursales.Controls.Add(this.cmdAceptar);
            this.groupBoxIngresoSucursales.Controls.Add(this.txtNombreSucursal);
            this.groupBoxIngresoSucursales.Controls.Add(this.lblNombreSucursal);
            this.groupBoxIngresoSucursales.Location = new System.Drawing.Point(12, 9);
            this.groupBoxIngresoSucursales.Name = "groupBoxIngresoSucursales";
            this.groupBoxIngresoSucursales.Size = new System.Drawing.Size(382, 132);
            this.groupBoxIngresoSucursales.TabIndex = 5;
            this.groupBoxIngresoSucursales.TabStop = false;
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(6, 101);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(155, 20);
            this.txtDireccionSucursal.TabIndex = 3;
            // 
            // lblDireccionSucursal
            // 
            this.lblDireccionSucursal.AutoSize = true;
            this.lblDireccionSucursal.Location = new System.Drawing.Point(6, 86);
            this.lblDireccionSucursal.Name = "lblDireccionSucursal";
            this.lblDireccionSucursal.Size = new System.Drawing.Size(122, 13);
            this.lblDireccionSucursal.TabIndex = 24;
            this.lblDireccionSucursal.Text = "Dirección de la Sucursal";
            // 
            // lblCodPostalSucursal
            // 
            this.lblCodPostalSucursal.AutoSize = true;
            this.lblCodPostalSucursal.Location = new System.Drawing.Point(6, 48);
            this.lblCodPostalSucursal.Name = "lblCodPostalSucursal";
            this.lblCodPostalSucursal.Size = new System.Drawing.Size(142, 13);
            this.lblCodPostalSucursal.TabIndex = 23;
            this.lblCodPostalSucursal.Text = "Código Postal de la Sucursal";
            // 
            // txtCodPostalSucursal
            // 
            this.txtCodPostalSucursal.Location = new System.Drawing.Point(6, 63);
            this.txtCodPostalSucursal.Name = "txtCodPostalSucursal";
            this.txtCodPostalSucursal.Size = new System.Drawing.Size(155, 20);
            this.txtCodPostalSucursal.TabIndex = 2;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCancelar.Location = new System.Drawing.Point(249, 87);
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
            this.cmdAceptar.Location = new System.Drawing.Point(249, 19);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(121, 35);
            this.cmdAceptar.TabIndex = 5;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(6, 26);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(155, 20);
            this.txtNombreSucursal.TabIndex = 1;
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Location = new System.Drawing.Point(6, 11);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(114, 13);
            this.lblNombreSucursal.TabIndex = 1;
            this.lblNombreSucursal.Text = "Nombre de la Sucursal";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IngresoSucursalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 156);
            this.Controls.Add(this.groupBoxIngresoSucursales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IngresoSucursalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Ingreso Sucursal";
            this.groupBoxIngresoSucursales.ResumeLayout(false);
            this.groupBoxIngresoSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngresoSucursales;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label lblNombreSucursal;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.Label lblDireccionSucursal;
        private System.Windows.Forms.Label lblCodPostalSucursal;
        private System.Windows.Forms.TextBox txtCodPostalSucursal;

    }
}