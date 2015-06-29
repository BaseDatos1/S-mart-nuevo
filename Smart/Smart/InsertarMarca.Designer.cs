namespace Smart
{
    partial class InsertarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarMarca));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistruibuidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(136, 38);
            this.txtMarca.MaxLength = 30;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(266, 22);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(298, 155);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(104, 31);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Agregar";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distribuidor:";
            // 
            // txtDistruibuidor
            // 
            this.txtDistruibuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistruibuidor.Location = new System.Drawing.Point(136, 91);
            this.txtDistruibuidor.MaxLength = 30;
            this.txtDistruibuidor.Name = "txtDistruibuidor";
            this.txtDistruibuidor.Size = new System.Drawing.Size(266, 22);
            this.txtDistruibuidor.TabIndex = 1;
            this.txtDistruibuidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistribuidor_KeyPress);
            // 
            // InsertarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(439, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtDistruibuidor);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-mart: Agregar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistruibuidor;
    }
}