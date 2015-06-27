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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();

            txtCedula.Text = "Ej: 000000000";
            txtCedula.ForeColor = Color.Gray;
            txtTelefono.Text = "Ej: 00000000";
            txtTelefono.ForeColor = Color.Gray;
            txtEmail.Text = "Ej: persona@email.com";
            txtEmail.ForeColor = Color.Gray;
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario registrado con éxito en el sistema S-mart.", "Registrar usuario");
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
        }


        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }        

        public static void soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        
        
        //CEDULA
        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Ej: 000000000")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Black;
            }
        }
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Ej: 000000000";
                txtCedula.ForeColor = Color.Gray;
            }
        }        
        
        //TELEFONO
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Ej: 00000000")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ej: 00000000";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        //EMAIL        
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Ej: persona@email.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Ej: persona@email.com";
                txtEmail.ForeColor = Color.Gray;
            }
        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        } 

        public void txtNombre_KeyPress(object sender, KeyPressEventArgs e) 
        {
            soloLetras(e);
        }
        public void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }
        public void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }
        public static void soloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
