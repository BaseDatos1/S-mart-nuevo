using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart
{
    public partial class InsertarSucursal : Form
    {
        AccesoBaseDatos baseDatos;

        public InsertarSucursal()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();

            txtIDSucursal.Text = "Ej: 4512";
            txtIDSucursal.ForeColor = Color.Gray;
            txtCedulaAdmin.Text = "Ej: 000000000";
            txtCedulaAdmin.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIDSucursal.Text != "" && txtNombreSucursal.Text != "" && txtDireccion.Text != "" && txtCedulaAdmin.Text != "")
            {
                int ID = int.Parse(txtIDSucursal.Text);
                
                bool result = baseDatos.insertarSurcursalSQL(ID, txtNombreSucursal.Text, txtCoordenadas.Text, txtDireccion.Text, txtCedulaAdmin.Text);                
              
                if (result)
                {
                    MessageBox.Show("Sucursal almacenada correctamente", "Insertar Sucursal");                   
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos correspondientes al producto"
                    , "Insertar Producto"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation
                    , MessageBoxDefaultButton.Button1);
        
            }
        }
    
        private void btnatras_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
        }


        //Textbox1 --> ID SUCURSAL
        private void txtIDSucursal_Leave(object sender, EventArgs e)
        {
            if (txtIDSucursal.Text == "")
            {
                txtIDSucursal.Text = "Ej: 4512";
                txtIDSucursal.ForeColor = Color.Gray;
            }
        }

        private void txtIDSucursal_Enter(object sender, EventArgs e)
        {
            if (txtIDSucursal.Text == "Ej: 4512")
            {
                txtIDSucursal.Text = "";
                txtIDSucursal.ForeColor = Color.Black;
            }
        }

        //Textbox5 --> CEDULA ADMIN
        private void txtCedulaAdmin_Leave(object sender, EventArgs e)
        {
            if (txtCedulaAdmin.Text == "")
            {
                txtCedulaAdmin.Text = "Ej: 000000000";
                txtCedulaAdmin.ForeColor = Color.Gray;
            }
        }

        private void txtCedulaAdmin_Enter(object sender, EventArgs e)
        {
            if (txtCedulaAdmin.Text == "Ej: 000000000")
            {
                txtCedulaAdmin.Text = "";
                txtCedulaAdmin.ForeColor = Color.Black;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
