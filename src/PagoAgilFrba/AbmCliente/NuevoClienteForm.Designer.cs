namespace PagoAgilFrba.AbmCliente
{
    partial class NuevoClienteForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.datePickerFNAC = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblTitleFNac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionCalle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClientes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(18, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // datePickerFNAC
            // 
            this.datePickerFNAC.Location = new System.Drawing.Point(17, 323);
            this.datePickerFNAC.Name = "datePickerFNAC";
            this.datePickerFNAC.Size = new System.Drawing.Size(355, 20);
            this.datePickerFNAC.TabIndex = 12;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(252, 359);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 35);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Nuevo Cliente";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblTitleFNac
            // 
            this.lblTitleFNac.AutoSize = true;
            this.lblTitleFNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFNac.Location = new System.Drawing.Point(13, 307);
            this.lblTitleFNac.Name = "lblTitleFNac";
            this.lblTitleFNac.Size = new System.Drawing.Size(127, 13);
            this.lblTitleFNac.TabIndex = 1;
            this.lblTitleFNac.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(271, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(*) Obligatorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(75, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(98, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "(*)";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(17, 285);
            this.txtCP.MaxLength = 255;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(355, 20);
            this.txtCP.TabIndex = 13;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPostal.Location = new System.Drawing.Point(15, 269);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(85, 13);
            this.lblCodigoPostal.TabIndex = 12;
            this.lblCodigoPostal.Text = "Código Postal";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(18, 247);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(354, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblDireccionCalle
            // 
            this.lblDireccionCalle.AutoSize = true;
            this.lblDireccionCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCalle.Location = new System.Drawing.Point(15, 230);
            this.lblDireccionCalle.Name = "lblDireccionCalle";
            this.lblDireccionCalle.Size = new System.Drawing.Size(61, 13);
            this.lblDireccionCalle.TabIndex = 2;
            this.lblDireccionCalle.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(43, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "(*)";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(18, 208);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(354, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(15, 191);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(18, 169);
            this.txtMail.MaxLength = 255;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(354, 20);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(15, 152);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(30, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(65, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(67, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(44, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "(*)";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(18, 130);
            this.txtDNI.MaxLength = 18;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(355, 20);
            this.txtDNI.TabIndex = 5;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(16, 114);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(18, 92);
            this.txtApellido.MaxLength = 255;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(356, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(16, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(19, 55);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(14, 9);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(135, 24);
            this.lblClientes.TabIndex = 25;
            this.lblClientes.Text = "ABM Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(138, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "(*)";
            // 
            // NuevoClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 410);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerFNAC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitleFNac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCodigoPostal);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccionCalle);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NuevoClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NuevoClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerFNAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblTitleFNac;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccionCalle;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label8;
    }
}