namespace PagoAgilFrba.ListadoEstadistico
{
    partial class ListadoEstadisticoForm
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
            this.groupBoxFiltrosBusqueda = new System.Windows.Forms.GroupBox();
            this.chkArchivo = new System.Windows.Forms.CheckBox();
            this.cboListados = new System.Windows.Forms.ComboBox();
            this.lblListados = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.cboTrimestre = new System.Windows.Forms.ComboBox();
            this.cmdQuitarFiltros = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgListado = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltrosBusqueda
            // 
            this.groupBoxFiltrosBusqueda.Controls.Add(this.chkArchivo);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cboListados);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblListados);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.txtAño);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblAño);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.lblTrimestre);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cboTrimestre);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdQuitarFiltros);
            this.groupBoxFiltrosBusqueda.Controls.Add(this.cmdBuscar);
            this.groupBoxFiltrosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosBusqueda.Location = new System.Drawing.Point(10, 18);
            this.groupBoxFiltrosBusqueda.Name = "groupBoxFiltrosBusqueda";
            this.groupBoxFiltrosBusqueda.Size = new System.Drawing.Size(468, 256);
            this.groupBoxFiltrosBusqueda.TabIndex = 19;
            this.groupBoxFiltrosBusqueda.TabStop = false;
            this.groupBoxFiltrosBusqueda.Text = "Filtros de búsqueda";
            // 
            // chkArchivo
            // 
            this.chkArchivo.AutoSize = true;
            this.chkArchivo.Location = new System.Drawing.Point(20, 169);
            this.chkArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.chkArchivo.Name = "chkArchivo";
            this.chkArchivo.Size = new System.Drawing.Size(119, 17);
            this.chkArchivo.TabIndex = 39;
            this.chkArchivo.Text = "Exportar archivo";
            this.chkArchivo.UseVisualStyleBackColor = true;
            // 
            // cboListados
            // 
            this.cboListados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListados.FormattingEnabled = true;
            this.cboListados.Location = new System.Drawing.Point(20, 128);
            this.cboListados.Margin = new System.Windows.Forms.Padding(2);
            this.cboListados.Name = "cboListados";
            this.cboListados.Size = new System.Drawing.Size(432, 21);
            this.cboListados.TabIndex = 37;
            // 
            // lblListados
            // 
            this.lblListados.AutoSize = true;
            this.lblListados.Location = new System.Drawing.Point(18, 101);
            this.lblListados.Name = "lblListados";
            this.lblListados.Size = new System.Drawing.Size(172, 13);
            this.lblListados.TabIndex = 36;
            this.lblListados.Text = "Seleccione el tipo de listado:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(314, 63);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(122, 20);
            this.txtAño.TabIndex = 32;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(312, 36);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(92, 13);
            this.lblAño.TabIndex = 31;
            this.lblAño.Text = "Ingrese el año:";
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Location = new System.Drawing.Point(18, 36);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(140, 13);
            this.lblTrimestre.TabIndex = 29;
            this.lblTrimestre.Text = "Seleccione el trimestre:";
            // 
            // cboTrimestre
            // 
            this.cboTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrimestre.FormattingEnabled = true;
            this.cboTrimestre.Location = new System.Drawing.Point(20, 63);
            this.cboTrimestre.Margin = new System.Windows.Forms.Padding(2);
            this.cboTrimestre.Name = "cboTrimestre";
            this.cboTrimestre.Size = new System.Drawing.Size(184, 21);
            this.cboTrimestre.TabIndex = 20;
            // 
            // cmdQuitarFiltros
            // 
            this.cmdQuitarFiltros.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdQuitarFiltros.Location = new System.Drawing.Point(268, 202);
            this.cmdQuitarFiltros.Name = "cmdQuitarFiltros";
            this.cmdQuitarFiltros.Size = new System.Drawing.Size(121, 35);
            this.cmdQuitarFiltros.TabIndex = 28;
            this.cmdQuitarFiltros.Text = "Quitar filtros";
            this.cmdQuitarFiltros.UseVisualStyleBackColor = false;
            this.cmdQuitarFiltros.Click += new System.EventHandler(this.cmdQuitarFiltros_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.Orange;
            this.cmdBuscar.Location = new System.Drawing.Point(70, 202);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(121, 35);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.Text = "Generar listado";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dtgListado
            // 
            this.dtgListado.AllowUserToAddRows = false;
            this.dtgListado.AllowUserToDeleteRows = false;
            this.dtgListado.AllowUserToResizeColumns = false;
            this.dtgListado.AllowUserToResizeRows = false;
            this.dtgListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgListado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgListado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgListado.Location = new System.Drawing.Point(498, 28);
            this.dtgListado.MultiSelect = false;
            this.dtgListado.Name = "dtgListado";
            this.dtgListado.ReadOnly = true;
            this.dtgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListado.Size = new System.Drawing.Size(409, 246);
            this.dtgListado.TabIndex = 21;
            // 
            // ListadoEstadisticoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 300);
            this.Controls.Add(this.dtgListado);
            this.Controls.Add(this.groupBoxFiltrosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListadoEstadisticoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Listado Estadístico";
            this.groupBoxFiltrosBusqueda.ResumeLayout(false);
            this.groupBoxFiltrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltrosBusqueda;
        private System.Windows.Forms.ComboBox cboTrimestre;
        private System.Windows.Forms.Button cmdQuitarFiltros;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.ComboBox cboListados;
        private System.Windows.Forms.Label lblListados;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.CheckBox chkArchivo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dtgListado;
    }
}