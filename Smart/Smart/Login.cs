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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtContrasena.Text != "" && tipoUsuario.Text != "")
            {
                if (tipoUsuario.Text == "Administrador")
                {
                    MenuAdmin admin = new MenuAdmin();
                    admin.Show();
                    this.Hide();
                }
                else if (tipoUsuario.Text == "Encargado de Inventario")
                {
                    MenuEncargado encargado = new MenuEncargado();
                    encargado.Show();
                    this.Hide();
                }
                else if (tipoUsuario.Text == "Cajero")
                {
                    MenuCajero cajero = new MenuCajero();
                    cajero.Show();
                    this.Hide();
                }
            }
            else {
                MessageBox.Show("Debe ingresar todos los datos correspondientes al usuario", "Iniciar sesión",
       MessageBoxButtons.OK,
       MessageBoxIcon.Exclamation,
       MessageBoxDefaultButton.Button1);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            permitirNumeros(e);
        }


        public static void permitirNumeros(KeyPressEventArgs e)
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

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ';' || e.KeyChar == '-')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

    }
}
