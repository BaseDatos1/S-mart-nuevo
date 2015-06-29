namespace Smart
{
    partial class InsertarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarSucursal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCedulaAdmin = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCoordenadas = new System.Windows.Forms.TextBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.txtIDSucursal = new System.Windows.Forms.TextBox();
            this.labelCedulaAdmin = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCoordenadas = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.btnatras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCedulaAdmin);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtCoordenadas);
            this.groupBox1.Controls.Add(this.txtNombreSucursal);
            this.groupBox1.Controls.Add(this.txtIDSucursal);
            this.groupBox1.Controls.Add(this.labelCedulaAdmin);
            this.groupBox1.Controls.Add(this.labelDireccion);
            this.groupBox1.Controls.Add(this.labelCoordenadas);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(190, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCedulaAdmin
            // 
            this.txtCedulaAdmin.Location = new System.Drawing.Point(138, 440);
            this.txtCedulaAdmin.MaxLength = 15;
            this.txtCedulaAdmin.Name = "txtCedulaAdmin";
            this.txtCedulaAdmin.Size = new System.Drawing.Size(223, 22);
            this.txtCedulaAdmin.TabIndex = 5;
            this.txtCedulaAdmin.Enter += new System.EventHandler(this.txtCedulaAdmin_Enter);
            this.txtCedulaAdmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaAdmin_KeyPress);
            this.txtCedulaAdmin.Leave += new System.EventHandler(this.txtCedulaAdmin_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(138, 287);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(223, 136);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtCoordenadas
            // 
            this.txtCoordenadas.Location = new System.Drawing.Point(138, 130);
            this.txtCoordenadas.MaxLength = 30;
            this.txtCoordenadas.Multiline = true;
            this.txtCoordenadas.Name = "txtCoordenadas";
            this.txtCoordenadas.Size = new System.Drawing.Size(223, 136);
            this.txtCoordenadas.TabIndex = 3;
            this.txtCoordenadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoordenadas_KeyPress);
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(138, 86);
            this.txtNombreSucursal.MaxLength = 20;
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(223, 22);
            this.txtNombreSucursal.TabIndex = 2;
            this.txtNombreSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreSucursal_KeyPress);
            // 
            // txtIDSucursal
            // 
            this.txtIDSucursal.Location = new System.Drawing.Point(138, 44);
            this.txtIDSucursal.Name = "txtIDSucursal";
            this.txtIDSucursal.Size = new System.Drawing.Size(223, 22);
            this.txtIDSucursal.TabIndex = 1;
            this.txtIDSucursal.Enter += new System.EventHandler(this.txtIDSucursal_Enter);
            this.txtIDSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDSucursal_KeyPress);
            this.txtIDSucursal.Leave += new System.EventHandler(this.txtIDSucursal_Leave);
            // 
            // labelCedulaAdmin
            // 
            this.labelCedulaAdmin.AutoSize = true;
            this.labelCedulaAdmin.Location = new System.Drawing.Point(38, 443);
            this.labelCedulaAdmin.Name = "labelCedulaAdmin";
            this.labelCedulaAdmin.Size = new System.Drawing.Size(95, 16);
            this.labelCedulaAdmin.TabIndex = 4;
            this.labelCedulaAdmin.Text = "Cédula Admin:";
            this.labelCedulaAdmin.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(38, 287);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(68, 16);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelCoordenadas
            // 
            this.labelCoordenadas.AutoSize = true;
            this.labelCoordenadas.Location = new System.Drawing.Point(38, 130);
            this.labelCoordenadas.Name = "labelCoordenadas";
            this.labelCoordenadas.Size = new System.Drawing.Size(94, 16);
            this.labelCoordenadas.TabIndex = 2;
            this.labelCoordenadas.Text = "Coordenadas:";
            this.labelCoordenadas.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(38, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(38, 47);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnatras
            // 
            this.btnatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(23, 625);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(64, 24);
            this.btnatras.TabIndex = 10;
            this.btnatras.Text = "Atrás";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // InsertarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InsertarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart: Insertar Sucursal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCedulaAdmin;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCoordenadas;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtCoordenadas;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.TextBox txtIDSucursal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCedulaAdmin;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnatras;
    }
}