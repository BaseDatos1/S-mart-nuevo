namespace Smart
{
    partial class InsertarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarCompra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelCajero = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.btnatras = new System.Windows.Forms.Button();
            this.displayProductos = new System.Windows.Forms.DataGridView();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtCajero);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Controls.Add(this.labelCajero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(164, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la compra";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(102, 159);
            this.txtProducto.MaxLength = 30;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(325, 22);
            this.txtProducto.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 95);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(325, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Producto:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(18, 98);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(78, 16);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID  Compra:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(102, 60);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(325, 22);
            this.txtCliente.TabIndex = 2;
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new System.Drawing.Point(102, 25);
            this.txtCajero.MaxLength = 30;
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.ReadOnly = true;
            this.txtCajero.Size = new System.Drawing.Size(325, 22);
            this.txtCajero.TabIndex = 1;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(18, 63);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(52, 16);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelCajero
            // 
            this.labelCajero.AutoSize = true;
            this.labelCajero.Location = new System.Drawing.Point(18, 28);
            this.labelCajero.Name = "labelCajero";
            this.labelCajero.Size = new System.Drawing.Size(51, 16);
            this.labelCajero.TabIndex = 0;
            this.labelCajero.Text = "Cajero:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelFecha.Location = new System.Drawing.Point(648, 20);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(72, 16);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "27/06/2015";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelHora.Location = new System.Drawing.Point(726, 20);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(39, 16);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "11:05";
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(12, 625);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(64, 24);
            this.btnatras.TabIndex = 5;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // displayProductos
            // 
            this.displayProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayProductos.Location = new System.Drawing.Point(59, 247);
            this.displayProductos.Name = "displayProductos";
            this.displayProductos.Size = new System.Drawing.Size(663, 357);
            this.displayProductos.TabIndex = 20;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(102, 127);
            this.txtMonto.MaxLength = 30;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(325, 22);
            this.txtMonto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Monto Total:";
            // 
            // InsertarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.displayProductos);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart: Insertar Compra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCajero;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.DataGridView displayProductos;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
    }
}