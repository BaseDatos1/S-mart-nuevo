namespace Smart
{
    partial class insCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoExterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregarCaracteristica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de producto:";
            // 
            // txtCodigoExterno
            // 
            this.txtCodigoExterno.Enabled = false;
            this.txtCodigoExterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoExterno.Location = new System.Drawing.Point(163, 22);
            this.txtCodigoExterno.MaxLength = 30;
            this.txtCodigoExterno.Name = "txtCodigoExterno";
            this.txtCodigoExterno.Size = new System.Drawing.Size(240, 22);
            this.txtCodigoExterno.TabIndex = 1;
            this.txtCodigoExterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoExterno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Característica:";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(163, 59);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(240, 24);
            this.cmbCategorias.TabIndex = 2;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(163, 95);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(240, 55);
            this.txtdescripcion.TabIndex = 3;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // btnAgregarCaracteristica
            // 
            this.btnAgregarCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCaracteristica.Location = new System.Drawing.Point(299, 173);
            this.btnAgregarCaracteristica.Name = "btnAgregarCaracteristica";
            this.btnAgregarCaracteristica.Size = new System.Drawing.Size(104, 31);
            this.btnAgregarCaracteristica.TabIndex = 4;
            this.btnAgregarCaracteristica.Text = "Agregar";
            this.btnAgregarCaracteristica.UseVisualStyleBackColor = true;
            this.btnAgregarCaracteristica.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // insCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(439, 226);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregarCaracteristica);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoExterno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "insCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-mart: Agregar características";
            this.Load += new System.EventHandler(this.insCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoExterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnAgregarCaracteristica;
    }
}