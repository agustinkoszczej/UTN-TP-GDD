namespace PagoAgilFrba.AbmFactura
{
    partial class ModificarItems
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
            this.panelModificarItem = new System.Windows.Forms.Panel();
            this.txtFacturaNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarItem = new System.Windows.Forms.Button();
            this.txtItemCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemMonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemNro = new System.Windows.Forms.TextBox();
            this.lblItemNro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.listItems = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGenerarItem = new System.Windows.Forms.Button();
            this.txtNuevoCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevoMonto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelModificarItem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelModificarItem
            // 
            this.panelModificarItem.Controls.Add(this.txtFacturaNumero);
            this.panelModificarItem.Controls.Add(this.label1);
            this.panelModificarItem.Controls.Add(this.btnGuardarItem);
            this.panelModificarItem.Controls.Add(this.txtItemCantidad);
            this.panelModificarItem.Controls.Add(this.label8);
            this.panelModificarItem.Controls.Add(this.txtItemMonto);
            this.panelModificarItem.Controls.Add(this.label7);
            this.panelModificarItem.Controls.Add(this.txtItemNro);
            this.panelModificarItem.Controls.Add(this.lblItemNro);
            this.panelModificarItem.Controls.Add(this.label6);
            this.panelModificarItem.Location = new System.Drawing.Point(12, 12);
            this.panelModificarItem.Name = "panelModificarItem";
            this.panelModificarItem.Size = new System.Drawing.Size(258, 252);
            this.panelModificarItem.TabIndex = 13;
            // 
            // txtFacturaNumero
            // 
            this.txtFacturaNumero.Enabled = false;
            this.txtFacturaNumero.Location = new System.Drawing.Point(12, 53);
            this.txtFacturaNumero.Name = "txtFacturaNumero";
            this.txtFacturaNumero.Size = new System.Drawing.Size(232, 20);
            this.txtFacturaNumero.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Factura Numero:";
            // 
            // btnGuardarItem
            // 
            this.btnGuardarItem.Location = new System.Drawing.Point(170, 215);
            this.btnGuardarItem.Name = "btnGuardarItem";
            this.btnGuardarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarItem.TabIndex = 9;
            this.btnGuardarItem.Text = "Modificar";
            this.btnGuardarItem.UseVisualStyleBackColor = true;
            this.btnGuardarItem.Click += new System.EventHandler(this.btnGuardarItem_Click);
            // 
            // txtItemCantidad
            // 
            this.txtItemCantidad.Location = new System.Drawing.Point(12, 183);
            this.txtItemCantidad.Name = "txtItemCantidad";
            this.txtItemCantidad.Size = new System.Drawing.Size(232, 20);
            this.txtItemCantidad.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad:";
            // 
            // txtItemMonto
            // 
            this.txtItemMonto.Location = new System.Drawing.Point(12, 140);
            this.txtItemMonto.Name = "txtItemMonto";
            this.txtItemMonto.Size = new System.Drawing.Size(232, 20);
            this.txtItemMonto.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Monto:";
            // 
            // txtItemNro
            // 
            this.txtItemNro.Enabled = false;
            this.txtItemNro.Location = new System.Drawing.Point(12, 98);
            this.txtItemNro.Name = "txtItemNro";
            this.txtItemNro.Size = new System.Drawing.Size(232, 20);
            this.txtItemNro.TabIndex = 2;
            // 
            // lblItemNro
            // 
            this.lblItemNro.AutoSize = true;
            this.lblItemNro.Location = new System.Drawing.Point(9, 82);
            this.lblItemNro.Name = "lblItemNro";
            this.lblItemNro.Size = new System.Drawing.Size(70, 13);
            this.lblItemNro.TabIndex = 1;
            this.lblItemNro.Text = "Item Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Modificar Items ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.listItems);
            this.panel1.Location = new System.Drawing.Point(277, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 251);
            this.panel1.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(267, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "$10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(267, 7);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // listItems
            // 
            this.listItems.Location = new System.Drawing.Point(3, 3);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(258, 245);
            this.listItems.TabIndex = 0;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnGenerarItem);
            this.panel2.Controls.Add(this.txtNuevoCantidad);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNuevoMonto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 120);
            this.panel2.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(449, 87);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(530, 87);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGenerarItem
            // 
            this.btnGenerarItem.Location = new System.Drawing.Point(253, 61);
            this.btnGenerarItem.Name = "btnGenerarItem";
            this.btnGenerarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarItem.TabIndex = 11;
            this.btnGenerarItem.Text = "Nuevo Item";
            this.btnGenerarItem.UseVisualStyleBackColor = true;
            this.btnGenerarItem.Click += new System.EventHandler(this.btnGenerarItem_Click);
            // 
            // txtNuevoCantidad
            // 
            this.txtNuevoCantidad.Location = new System.Drawing.Point(15, 87);
            this.txtNuevoCantidad.Name = "txtNuevoCantidad";
            this.txtNuevoCantidad.Size = new System.Drawing.Size(232, 20);
            this.txtNuevoCantidad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad:";
            // 
            // txtNuevoMonto
            // 
            this.txtNuevoMonto.Location = new System.Drawing.Point(15, 41);
            this.txtNuevoMonto.Name = "txtNuevoMonto";
            this.txtNuevoMonto.Size = new System.Drawing.Size(232, 20);
            this.txtNuevoMonto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generar Item";
            // 
            // ModificarItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelModificarItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagoAgilFrba | Modificar Items";
            this.Load += new System.EventHandler(this.ModificarItems_Load);
            this.panelModificarItem.ResumeLayout(false);
            this.panelModificarItem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarItem;
        private System.Windows.Forms.Button btnGuardarItem;
        private System.Windows.Forms.TextBox txtItemCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemNro;
        private System.Windows.Forms.Label lblItemNro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFacturaNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListView listItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGenerarItem;
        private System.Windows.Forms.TextBox txtNuevoCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevoMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
    }
}