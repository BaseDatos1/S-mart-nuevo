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
    public partial class InsertarCompra : Form
    {
        AccesoBaseDatos baseDatos;


        public InsertarCompra()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
            if (e.KeyChar == 13)
            {
                //
            }
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

        private void InsertarCompra_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString().Substring(0, 10);
            string hora = DateTime.Now.ToString().Substring(10, 10);
            labelFecha.Text = fecha;
            labelHora.Text = DateTime.Now.ToString("HH:mm");

            baseDatos.obtenerDatosUsuario("Select Nombre, Apellido1, Apellido2 FROM Persona WHERE  Cedula = '"+ GlobalVar.CedulaUsuarioActual+ "'", txtCajero);
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string revisar = txtCliente.Text;
                baseDatos.obtenerDatosUsuario("Select Nombre, Apellido1, Apellido2 FROM Persona WHERE Cedula = '" + txtCliente.Text + "'", txtCliente);
                if (revisar != txtCliente.Text)
                {
                    txtCliente.ReadOnly = true;
                }
                if (revisar == "")
                {
                    txtCliente.ReadOnly = true;
                }
            }
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);

            if (e.KeyChar == 13)
            {
                if (int.Parse(txtCaja.Text) > 0)
                {
                    txtCaja.ReadOnly = true;
                }
            }
        }
    }
}
