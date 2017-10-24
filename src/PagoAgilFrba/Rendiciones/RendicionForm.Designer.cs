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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dataGridEmpresas = new System.Windows.Forms.DataGridView();
            this.panelFacturas = new System.Windows.Forms.Panel();
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
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.lblEmpresaSelec = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).BeginInit();
            this.panelFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmpresas
            // 
            this.panelEmpresas.Controls.Add(this.lblMensaje);
            this.panelEmpresas.Controls.Add(this.btnCancelar);
            this.panelEmpresas.Controls.Add(this.label1);
            this.panelEmpresas.Controls.Add(this.btnSeleccionar);
            this.panelEmpresas.Controls.Add(this.dataGridEmpresas);
            this.panelEmpresas.Location = new System.Drawing.Point(13, 13);
            this.panelEmpresas.Name = "panelEmpresas";
            this.panelEmpresas.Size = new System.Drawing.Size(593, 411);
            this.panelEmpresas.TabIndex = 0;
            this.panelEmpresas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmpresas_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
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
            // dataGridEmpresas
            // 
            this.dataGridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpresas.Location = new System.Drawing.Point(3, 30);
            this.dataGridEmpresas.MultiSelect = false;
            this.dataGridEmpresas.Name = "dataGridEmpresas";
            this.dataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpresas.Size = new System.Drawing.Size(569, 342);
            this.dataGridEmpresas.TabIndex = 1;
            this.dataGridEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmpresas_CellContentClick);
            // 
            // panelFacturas
            // 
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
            this.panelFacturas.Controls.Add(this.dataGridFacturas);
            this.panelFacturas.Controls.Add(this.lblEmpresaSelec);
            this.panelFacturas.Location = new System.Drawing.Point(9, 12);
            this.panelFacturas.Name = "panelFacturas";
            this.panelFacturas.Size = new System.Drawing.Size(594, 409);
            this.panelFacturas.TabIndex = 1;
            this.panelFacturas.Visible = false;
            // 
            // btnRendir
            // 
            this.btnRendir.Location = new System.Drawing.Point(8, 380);
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
            // dataGridFacturas
            // 
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(2, 113);
            this.dataGridFacturas.MultiSelect = false;
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacturas.Size = new System.Drawing.Size(589, 228);
            this.dataGridFacturas.TabIndex = 1;
            this.dataGridFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(84, 385);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(407, 20);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RendicionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 430);
            this.Controls.Add(this.panelEmpresas);
            this.Controls.Add(this.panelFacturas);
            this.Name = "RendicionForm";
            this.Text = "Rendicion de Facturas Pagas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEmpresas.ResumeLayout(false);
            this.panelEmpresas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpresas)).EndInit();
            this.panelFacturas.ResumeLayout(false);
            this.panelFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmpresas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dataGridEmpresas;
        private System.Windows.Forms.Panel panelFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridFacturas;
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
    }
}