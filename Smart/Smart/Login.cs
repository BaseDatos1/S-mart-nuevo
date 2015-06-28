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
        AccesoBaseDatos baseDatos;
        public Login()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string consultaCedula = "";
            string consultaUsuario = "";
            bool existeConsulta = false;


            if (txtCedula.Text != "" && txtContrasena.Text != "" && tipoUsuario.Text != "")
            {
                consultaCedula = "SELECT Persona.Cedula FROM Persona WHERE Persona.Cedula = '" + txtCedula.Text + "' AND Persona.Contraseña = " + txtContrasena.Text;

                existeConsulta = baseDatos.existe(consultaCedula);


                if (existeConsulta)
                {

                    if (tipoUsuario.Text == "Administrador")
                    {
                        consultaUsuario = "SELECT Admin_Sucursal.Cedula FROM Admin_Sucursal WHERE Admin_Sucursal.Cedula = '" + txtCedula.Text + "'";
                        existeConsulta = baseDatos.existe(consultaUsuario);

                        if (existeConsulta)
                        {
                            MenuAdmin admin = new MenuAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El usuario ingresado no se ha registrado en en el sistema S-mart.", "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                        }
                    }
                    else if (tipoUsuario.Text == "Encargado de Inventario")
                    {
                        MessageBox.Show("Entr a encarg. de inventario");
                        consultaUsuario = "SELECT Encargado_De_Inventario.Cedula FROM Encargado_De_Inventario WHERE Encargado_De_Inventario.Cedula ='" + txtCedula.Text + "'";
                        existeConsulta = baseDatos.existe(consultaUsuario);

                        if (existeConsulta)
                        {
                            MenuEncargado encargado = new MenuEncargado();
                            encargado.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El usuario ingresado no se ha registrado en en el sistema S-mart.", "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                        }
                    }
                    else if (tipoUsuario.Text == "Cajero")
                    {
                        consultaUsuario = "SELECT Cajero.Cedula FROM Cajero WHERE Cajero.Cedula = '" + txtCedula.Text + "'";
                        existeConsulta = baseDatos.existe(consultaUsuario);

                        if (existeConsulta)
                        {
                            MenuCajero cajero = new MenuCajero();
                            cajero.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El usuario ingresado no se ha registrado en en el sistema S-mart.", "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar el tipo de usuario que le corresponde.", "Iniciar sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    txtCedula.Text = "";
                    txtContrasena.Text = "";
                    tipoUsuario.Text = "";

                    MessageBox.Show("Los datos ingresados son inválidos.", "Iniciar sesión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
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

    }
}
