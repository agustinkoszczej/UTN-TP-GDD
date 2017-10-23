namespace PagoAgilFrba.AbmCliente
{
    partial class ABMClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datePickerFNAC = new System.Windows.Forms.DateTimePicker();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblTitleFNac = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionCalle = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSinFiltros = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtFiltroDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnHabilitar);
            this.panel2.Controls.Add(this.btnInhabilitar);
            this.panel2.Controls.Add(this.dataGridClientes);
            this.panel2.Location = new System.Drawing.Point(386, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 312);
            this.panel2.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(672, 273);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(104, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.Location = new System.Drawing.Point(672, 45);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(104, 23);
            this.btnHabilitar.TabIndex = 15;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(672, 16);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(104, 23);
            this.btnInhabilitar.TabIndex = 14;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(16, 16);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowTemplate.ReadOnly = true;
            this.dataGridClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(650, 280);
            this.dataGridClientes.TabIndex = 0;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.datePickerFNAC);
            this.panel4.Controls.Add(this.lblMensaje);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnCrear);
            this.panel4.Controls.Add(this.lblTitleFNac);
            this.panel4.Location = new System.Drawing.Point(12, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 113);
            this.panel4.TabIndex = 12;
            // 
            // datePickerFNAC
            // 
            this.datePickerFNAC.Location = new System.Drawing.Point(7, 18);
            this.datePickerFNAC.Name = "datePickerFNAC";
            this.datePickerFNAC.Size = new System.Drawing.Size(329, 20);
            this.datePickerFNAC.TabIndex = 12;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(8, 78);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(218, 18);
            this.lblMensaje.TabIndex = 11;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(*) Obligatorio";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(232, 76);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(104, 23);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Nuevo Cliente";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblTitleFNac
            // 
            this.lblTitleFNac.AutoSize = true;
            this.lblTitleFNac.Location = new System.Drawing.Point(3, 2);
            this.lblTitleFNac.Name = "lblTitleFNac";
            this.lblTitleFNac.Size = new System.Drawing.Size(111, 13);
            this.lblTitleFNac.TabIndex = 1;
            this.lblTitleFNac.Text = "Fecha de Nacimiento:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCP);
            this.panel5.Controls.Add(this.lblCodigoPostal);
            this.panel5.Controls.Add(this.txtDireccion);
            this.panel5.Controls.Add(this.lblDireccionCalle);
            this.panel5.Location = new System.Drawing.Point(12, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 88);
            this.panel5.TabIndex = 11;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(7, 58);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(329, 20);
            this.txtCP.TabIndex = 13;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(5, 42);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(85, 13);
            this.lblCodigoPostal.TabIndex = 12;
            this.lblCodigoPostal.Text = "Codigo Postal (*)";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(8, 19);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(328, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblDireccionCalle
            // 
            this.lblDireccionCalle.AutoSize = true;
            this.lblDireccionCalle.Location = new System.Drawing.Point(5, 2);
            this.lblDireccionCalle.Name = "lblDireccionCalle";
            this.lblDireccionCalle.Size = new System.Drawing.Size(65, 13);
            this.lblDireccionCalle.TabIndex = 2;
            this.lblDireccionCalle.Text = "Direccion (*)";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTelefono);
            this.panel6.Controls.Add(this.lblTelefono);
            this.panel6.Controls.Add(this.txtMail);
            this.panel6.Controls.Add(this.lblMail);
            this.panel6.Location = new System.Drawing.Point(12, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 88);
            this.panel6.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(8, 59);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(328, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(5, 42);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(8, 16);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(328, 20);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(5, -1);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-Mail (*)";
            // 
            // panel7
            // 
            this.panel7.AccessibleName = "";
            this.panel7.Controls.Add(this.btnLimpiar);
            this.panel7.Controls.Add(this.txtDNI);
            this.panel7.Controls.Add(this.lblDNI);
            this.panel7.Controls.Add(this.txtApellido);
            this.panel7.Controls.Add(this.lblApellido);
            this.panel7.Controls.Add(this.txtNombre);
            this.panel7.Controls.Add(this.lblNombre);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(368, 157);
            this.panel7.TabIndex = 9;
            this.panel7.Tag = "Datos principales";
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(232, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(7, 120);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(329, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(4, 104);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(48, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "D.N.I. (*)";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(8, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(328, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(5, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido (*)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(8, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre (*)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSinFiltros);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.chkHabilitado);
            this.panel1.Controls.Add(this.txtFiltroDNI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFiltroApellido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFiltroNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(386, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 146);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSinFiltros
            // 
            this.btnSinFiltros.Location = new System.Drawing.Point(672, 53);
            this.btnSinFiltros.Name = "btnSinFiltros";
            this.btnSinFiltros.Size = new System.Drawing.Size(104, 23);
            this.btnSinFiltros.TabIndex = 18;
            this.btnSinFiltros.Text = "Borrar Filtros";
            this.btnSinFiltros.UseVisualStyleBackColor = true;
            this.btnSinFiltros.Click += new System.EventHandler(this.btnSinFiltros_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(672, 91);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(104, 23);
            this.btnFiltrar.TabIndex = 17;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Checked = true;
            this.chkHabilitado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitado.Location = new System.Drawing.Point(637, 10);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(139, 17);
            this.chkHabilitado.TabIndex = 12;
            this.chkHabilitado.Text = "Solo clientes habilitados";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtFiltroDNI
            // 
            this.txtFiltroDNI.Location = new System.Drawing.Point(16, 112);
            this.txtFiltroDNI.Name = "txtFiltroDNI";
            this.txtFiltroDNI.Size = new System.Drawing.Size(650, 20);
            this.txtFiltroDNI.TabIndex = 11;
            this.txtFiltroDNI.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "D.N.I.";
            // 
            // txtFiltroApellido
            // 
            this.txtFiltroApellido.Location = new System.Drawing.Point(16, 74);
            this.txtFiltroApellido.Name = "txtFiltroApellido";
            this.txtFiltroApellido.Size = new System.Drawing.Size(650, 20);
            this.txtFiltroApellido.TabIndex = 9;
            this.txtFiltroApellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(16, 34);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(650, 20);
            this.txtFiltroNombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros de Busqueda";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMClientes";
            this.Text = "PagoAgilFrba | ABM Cliente";
            this.Load += new System.EventHandler(this.ABMClientes_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblTitleFNac;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccionCalle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker datePickerFNAC;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtFiltroDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSinFiltros;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}