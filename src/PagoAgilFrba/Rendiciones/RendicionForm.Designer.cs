namespace PagoAgilFrba.Rendicion
{
    partial class RendicionForm
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
            this.panelEmpresas = new System.Windows.Forms.Panel();
            this.panelMesARendir = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSoloMesActual = new System.Windows.Forms.CheckBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.panelFacturas = new System.Windows.Forms.Panel();
            this.lblNoHayFacturas = new System.Windows.Forms.Label();
            this.lblMesAnio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.btnRendir = new System.Windows.Forms.Button();
            this.lblTotalRendido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPorcentajeComision = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValorComision = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSumaCobrada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFacturasARendir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpresaSelec = new System.Windows.Forms.Label();
            this.dataGridEmpresas = new System.Windows.Forms.DataGridView();
            this.panelEmpresas.SuspendLayout();
            this.panelMesARendir.SuspendLayout();
            this.panelFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmpresas
            // 
            this.panelEmpresas.Controls.Add(this.dataGridEmpresas);
            this.panelEmpresas.Controls.Add(this.panelMesARendir);
            this.panelEmpresas.Controls.Add(this.chkSoloMesActual);
            this.panelEmpresas.Controls.Add(this.lblMensaje);
            this.panelEmpresas.Controls.Add(this.btnCancelar);
            this.panelEmpresas.Controls.Add(this.label1);
            this.panelEmpresas.Controls.Add(this.btnSeleccionar);
            this.panelEmpresas.Location = new System.Drawing.Point(9, 7);
            this.panelEmpresas.Name = "panelEmpresas";
            this.panelEmpresas.Size = new System.Drawing.Size(593, 411);
            this.panelEmpresas.TabIndex = 0;
            this.panelEmpresas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmpresas_Paint);
            // 
            // panelMesARendir
            // 
            this.panelMesARendir.Controls.Add(this.label10);
            this.panelMesARendir.Controls.Add(this.txtMes);
            this.panelMesARendir.Controls.Add(this.txtAnio);
            this.panelMesARendir.Controls.Add(this.label8);
            this.panelMesARendir.Controls.Add(this.label9);
            this.panelMesARendir.Enabled = false;
            this.panelMesARendir.Location = new System.Drawing.Point(308, 294);
            this.panelMesARendir.Name = "panelMesARendir";
            this.panelMesARendir.Size = new System.Drawing.Size(276, 85);
            this.panelMesARendir.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Seleccione el mes a rendir";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(16, 51);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 18;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(157, 51);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Año:";
            // 
            // chkSoloMesActual
            // 
            this.chkSoloMesActual.AutoSize = true;
            this.chkSoloMesActual.Checked = true;
            this.chkSoloMesActual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloMesActual.Location = new System.Drawing.Point(23, 308);
            this.chkSoloMesActual.Name = "chkSoloMesActual";
            this.chkSoloMesActual.Size = new System.Drawing.Size(133, 17);
            this.chkSoloMesActual.TabIndex = 17;
            this.chkSoloMesActual.Text = "Rendir solo mes actual";
            this.chkSoloMesActual.UseVisualStyleBackColor = true;
            this.chkSoloMesActual.CheckedChanged += new System.EventHandler(this.chkSoloMesActual_CheckedChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(84, 385);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(407, 20);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona la empresa a rendir";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(497, 385);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // panelFacturas
            // 
            this.panelFacturas.Controls.Add(this.lblNoHayFacturas);
            this.panelFacturas.Controls.Add(this.lblMesAnio);
            this.panelFacturas.Controls.Add(this.label11);
            this.panelFacturas.Controls.Add(this.btnVolver);
            this.panelFacturas.Controls.Add(this.dataGridFacturas);
            this.panelFacturas.Controls.Add(this.btnRendir);
            this.panelFacturas.Controls.Add(this.lblTotalRendido);
            this.panelFacturas.Controls.Add(this.label7);
            this.panelFacturas.Controls.Add(this.lblPorcentajeComision);
            this.panelFacturas.Controls.Add(this.label6);
            this.panelFacturas.Controls.Add(this.lblValorComision);
            this.panelFacturas.Controls.Add(this.label5);
            this.panelFacturas.Controls.Add(this.lblSumaCobrada);
            this.panelFacturas.Controls.Add(this.label4);
            this.panelFacturas.Controls.Add(this.lblFacturasARendir);
            this.panelFacturas.Controls.Add(this.label3);
            this.panelFacturas.Controls.Add(this.label2);
            this.panelFacturas.Controls.Add(this.lblEmpresaSelec);
            this.panelFacturas.Location = new System.Drawing.Point(9, 12);
            this.panelFacturas.Name = "panelFacturas";
            this.panelFacturas.Size = new System.Drawing.Size(594, 409);
            this.panelFacturas.TabIndex = 1;
            this.panelFacturas.Visible = false;
            // 
            // lblNoHayFacturas
            // 
            this.lblNoHayFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHayFacturas.Location = new System.Drawing.Point(179, 366);
            this.lblNoHayFacturas.Name = "lblNoHayFacturas";
            this.lblNoHayFacturas.Size = new System.Drawing.Size(261, 39);
            this.lblNoHayFacturas.TabIndex = 18;
            this.lblNoHayFacturas.Text = "No existen facturas que rendir en el mes seleccionado";
            this.lblNoHayFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoHayFacturas.Visible = false;
            // 
            // lblMesAnio
            // 
            this.lblMesAnio.AutoSize = true;
            this.lblMesAnio.Location = new System.Drawing.Point(481, 25);
            this.lblMesAnio.Name = "lblMesAnio";
            this.lblMesAnio.Size = new System.Drawing.Size(58, 13);
            this.lblMesAnio.TabIndex = 17;
            this.lblMesAnio.Text = "MM/AAAA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mostrando mes: ";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(4, 383);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(79, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.AllowUserToAddRows = false;
            this.dataGridFacturas.AllowUserToDeleteRows = false;
            this.dataGridFacturas.AllowUserToResizeColumns = false;
            this.dataGridFacturas.AllowUserToResizeRows = false;
            this.dataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridFacturas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridFacturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridFacturas.Location = new System.Drawing.Point(8, 113);
            this.dataGridFacturas.MultiSelect = false;
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.ReadOnly = true;
            this.dataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacturas.Size = new System.Drawing.Size(583, 243);
            this.dataGridFacturas.TabIndex = 14;
            // 
            // btnRendir
            // 
            this.btnRendir.Location = new System.Drawing.Point(484, 383);
            this.btnRendir.Name = "btnRendir";
            this.btnRendir.Size = new System.Drawing.Size(107, 23);
            this.btnRendir.TabIndex = 13;
            this.btnRendir.Text = "Rendir Facturas";
            this.btnRendir.UseVisualStyleBackColor = true;
            this.btnRendir.Click += new System.EventHandler(this.btnRendir_Click);
            // 
            // lblTotalRendido
            // 
            this.lblTotalRendido.AutoSize = true;
            this.lblTotalRendido.Location = new System.Drawing.Point(98, 359);
            this.lblTotalRendido.Name = "lblTotalRendido";
            this.lblTotalRendido.Size = new System.Drawing.Size(19, 13);
            this.lblTotalRendido.TabIndex = 12;
            this.lblTotalRendido.Text = "$$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Rendido: ";
            // 
            // lblPorcentajeComision
            // 
            this.lblPorcentajeComision.AutoSize = true;
            this.lblPorcentajeComision.Location = new System.Drawing.Point(309, 74);
            this.lblPorcentajeComision.Name = "lblPorcentajeComision";
            this.lblPorcentajeComision.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentajeComision.TabIndex = 10;
            this.lblPorcentajeComision.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Porcentaje de Comisión: ";
            // 
            // lblValorComision
            // 
            this.lblValorComision.AutoSize = true;
            this.lblValorComision.Location = new System.Drawing.Point(96, 74);
            this.lblValorComision.Name = "lblValorComision";
            this.lblValorComision.Size = new System.Drawing.Size(19, 13);
            this.lblValorComision.TabIndex = 8;
            this.lblValorComision.Text = "$$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comisión: ";
            // 
            // lblSumaCobrada
            // 
            this.lblSumaCobrada.AutoSize = true;
            this.lblSumaCobrada.Location = new System.Drawing.Point(96, 51);
            this.lblSumaCobrada.Name = "lblSumaCobrada";
            this.lblSumaCobrada.Size = new System.Drawing.Size(19, 13);
            this.lblSumaCobrada.TabIndex = 6;
            this.lblSumaCobrada.Text = "$$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Suma cobrada: ";
            // 
            // lblFacturasARendir
            // 
            this.lblFacturasARendir.AutoSize = true;
            this.lblFacturasARendir.Location = new System.Drawing.Point(96, 25);
            this.lblFacturasARendir.Name = "lblFacturasARendir";
            this.lblFacturasARendir.Size = new System.Drawing.Size(44, 13);
            this.lblFacturasARendir.TabIndex = 4;
            this.lblFacturasARendir.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Facturas a rendir:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Facturas que se rendirán:";
            // 
            // lblEmpresaSelec
            // 
            this.lblEmpresaSelec.AutoSize = true;
            this.lblEmpresaSelec.Location = new System.Drawing.Point(0, 0);
            this.lblEmpresaSelec.Name = "lblEmpresaSelec";
            this.lblEmpresaSelec.Size = new System.Drawing.Size(194, 13);
            this.lblEmpresaSelec.TabIndex = 0;
            this.lblEmpresaSelec.Text = "Empresa Seleccionada: ____________";
            // 
            // dataGridEmpresas
            // 
            this.dataGridEmpresas.AllowUserToAddRows = false;
            this.dataGridEmpresas.AllowUserToDeleteRows = false;
            this.dataGridEmpresas.AllowUserToResizeColumns = false;
            this.dataGridEmpresas.AllowUserToResizeRows = false;
            this.dataGridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEmpresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridEmpresas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpresas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridEmpresas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridEmpresas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridEmpresas.Location = new System.Drawing.Point(4, 29);
            this.dataGridEmpresas.MultiSelect = false;
            this.dataGridEmpresas.Name = "dataGridEmpresas";
            this.dataGridEmpresas.ReadOnly = true;
            this.dataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresas.Size = new System.Drawing.Size(581, 261);
            this.dataGridEmpresas.TabIndex = 23;
            // 
            // RendicionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 431);
            this.Controls.Add(this.panelEmpresas);
            this.Controls.Add(this.panelFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RendicionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Rendición de Facturas Pagas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEmpresas.ResumeLayout(false);
            this.panelEmpresas.PerformLayout();
            this.panelMesARendir.ResumeLayout(false);
            this.panelMesARendir.PerformLayout();
            this.panelFacturas.ResumeLayout(false);
            this.panelFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmpresas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel panelFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpresaSelec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRendir;
        private System.Windows.Forms.Label lblTotalRendido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPorcentajeComision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblValorComision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSumaCobrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFacturasARendir;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dataGridFacturas;
        private System.Windows.Forms.Panel panelMesARendir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSoloMesActual;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMesAnio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNoHayFacturas;
        private System.Windows.Forms.DataGridView dataGridEmpresas;
    }
}