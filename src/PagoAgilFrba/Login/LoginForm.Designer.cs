namespace PagoAgilFrba.Login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdIngresarButton = new System.Windows.Forms.Button();
            this.cmdCancelarButton = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.lnlCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.cmdSeleccionarRol = new System.Windows.Forms.Button();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(98, 121);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(113, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(28, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmdIngresarButton
            // 
            this.cmdIngresarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIngresarButton.Location = new System.Drawing.Point(50, 245);
            this.cmdIngresarButton.Name = "cmdIngresarButton";
            this.cmdIngresarButton.Size = new System.Drawing.Size(75, 23);
            this.cmdIngresarButton.TabIndex = 4;
            this.cmdIngresarButton.Text = "Ingresar";
            this.cmdIngresarButton.UseVisualStyleBackColor = false;
            this.cmdIngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // cmdCancelarButton
            // 
            this.cmdCancelarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCancelarButton.Location = new System.Drawing.Point(159, 246);
            this.cmdCancelarButton.Name = "cmdCancelarButton";
            this.cmdCancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelarButton.TabIndex = 5;
            this.cmdCancelarButton.Text = "Salir";
            this.cmdCancelarButton.UseVisualStyleBackColor = true;
            this.cmdCancelarButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.lnlCerrarSesion);
            this.groupBoxLogin.Controls.Add(this.cmdSeleccionarRol);
            this.groupBoxLogin.Controls.Add(this.txtUsername);
            this.groupBoxLogin.Controls.Add(this.cboRoles);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 99);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(260, 185);
            this.groupBoxLogin.TabIndex = 6;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login PagoAgilFrba";
            // 
            // lnlCerrarSesion
            // 
            this.lnlCerrarSesion.AutoSize = true;
            this.lnlCerrarSesion.Location = new System.Drawing.Point(187, 16);
            this.lnlCerrarSesion.Name = "lnlCerrarSesion";
            this.lnlCerrarSesion.Size = new System.Drawing.Size(67, 13);
            this.lnlCerrarSesion.TabIndex = 9;
            this.lnlCerrarSesion.TabStop = true;
            this.lnlCerrarSesion.Text = "cerrar sesión";
            this.lnlCerrarSesion.Visible = false;
            this.lnlCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlCerrarSesion_LinkClicked);
            // 
            // cmdSeleccionarRol
            // 
            this.cmdSeleccionarRol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdSeleccionarRol.Location = new System.Drawing.Point(38, 71);
            this.cmdSeleccionarRol.Name = "cmdSeleccionarRol";
            this.cmdSeleccionarRol.Size = new System.Drawing.Size(75, 23);
            this.cmdSeleccionarRol.TabIndex = 8;
            this.cmdSeleccionarRol.Text = "Seleccionar Rol";
            this.cmdSeleccionarRol.UseVisualStyleBackColor = false;
            this.cmdSeleccionarRol.Visible = false;
            this.cmdSeleccionarRol.Click += new System.EventHandler(this.cmdSeleccionarRol_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(76, 38);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(121, 21);
            this.cboRoles.TabIndex = 0;
            this.cboRoles.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cmdCancelarButton);
            this.Controls.Add(this.cmdIngresarButton);
            this.Controls.Add(this.groupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Login";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdIngresarButton;
        private System.Windows.Forms.Button cmdCancelarButton;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Button cmdSeleccionarRol;
        private System.Windows.Forms.LinkLabel lnlCerrarSesion;
    }
}