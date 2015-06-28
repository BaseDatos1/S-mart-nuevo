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

            txtID.Text = "Ej: 4512";
            txtID.ForeColor = Color.Gray;
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
            if (txtID.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && txtCedulaAdmin.Text != "")
            {
                int ID = int.Parse(txtID.Text);

                baseDatos.insertarSurcursalSQL(ID, txtNombre.Text, txtCoordenadas.Text, txtDireccion.Text, txtCedulaAdmin.Text);
                
            }

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
        }


        //Textbox1 --> ID SUCURSAL
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Ej: 4512";
                txtID.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Ej: 4512")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        //Textbox5 --> CEDULA ADMIN
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Ej: 000000000";
                txtID.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (txtCedulaAdmin.Text == "Ej: 000000000")
            {
                txtCedulaAdmin.Text = "";
                txtCedulaAdmin.ForeColor = Color.Black;
            }
        }



    }
}
