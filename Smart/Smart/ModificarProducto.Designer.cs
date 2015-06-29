namespace Smart
{
    partial class ModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNuevoValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExterno = new System.Windows.Forms.TextBox();
            this.cmbCriterioModificar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayProductos = new System.Windows.Forms.DataGridView();
            this.btnatras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNuevoValor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtExterno);
            this.groupBox1.Controls.Add(this.cmbCriterioModificar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Modificación";
            // 
            // txtNuevoValor
            // 
            this.txtNuevoValor.Location = new System.Drawing.Point(127, 69);
            this.txtNuevoValor.MaxLength = 30;
            this.txtNuevoValor.Name = "txtNuevoValor";
            this.txtNuevoValor.Size = new System.Drawing.Size(176, 22);
            this.txtNuevoValor.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nuevo Valor:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(536, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Modificar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Criterio:";
            // 
            // txtExterno
            // 
            this.txtExterno.Location = new System.Drawing.Point(411, 28);
            this.txtExterno.MaxLength = 30;
            this.txtExterno.Name = "txtExterno";
            this.txtExterno.Size = new System.Drawing.Size(200, 22);
            this.txtExterno.TabIndex = 2;
            // 
            // cmbCriterioModificar
            // 
            this.cmbCriterioModificar.FormattingEnabled = true;
            this.cmbCriterioModificar.Items.AddRange(new object[] {
            "Código Externo",
            "Código Interno",
            "Costo",
            "Precio Actual",
            "Fecha de vencimiento",
            "Peso",
            "Medida de alto (cm)",
            "Medida de largo (cm)",
            "Medida de ancho (cm)"});
            this.cmbCriterioModificar.Location = new System.Drawing.Point(127, 28);
            this.cmbCriterioModificar.Name = "cmbCriterioModificar";
            this.cmbCriterioModificar.Size = new System.Drawing.Size(176, 24);
            this.cmbCriterioModificar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // displayProductos
            // 
            this.displayProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayProductos.Location = new System.Drawing.Point(51, 166);
            this.displayProductos.Name = "displayProductos";
            this.displayProductos.Size = new System.Drawing.Size(663, 411);
            this.displayProductos.TabIndex = 1;
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(12, 625);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(64, 24);
            this.btnatras.TabIndex = 13;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.displayProductos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-mart: Modificar Producto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExterno;
        private System.Windows.Forms.ComboBox cmbCriterioModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView displayProductos;
        private System.Windows.Forms.TextBox txtNuevoValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnatras;
    }
}