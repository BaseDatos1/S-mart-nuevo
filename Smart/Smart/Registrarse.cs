using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Smart
{
    public partial class Registrarse : Form
    {
        AccesoBaseDatos baseDatos;

        public Registrarse()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();

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
            int numSucursal = 0;
            bool agregarUsuario = false;
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" && txtContraseña.Text != "" && txtConfirmacion.Text != "" && cmbTipoUsuario.Text != "")
            {

                if (txtContraseña.Text != txtConfirmacion.Text)
                {
                    txtConfirmacion.Text = "";
                    txtContraseña.Text = "";
                    MessageBox.Show("Contraseña inválida. Inténtelo de nuevo", "Registrarse",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    bool agregarPersona = baseDatos.insertarPersonaSQL(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text, txtEmail.Text, txtContraseña.Text, txtConfirmacion.Text /*TipoUsuario.Text != "" */);

                    string tipoDeUsuario = cmbTipoUsuario.Text;

                    if (agregarPersona)
                    {

                        if (tipoDeUsuario != "Administrador")
                        {
                            string sucursal = cmbSucursales.Text;
                            numSucursal = int.Parse(sucursal);
                        }

                        agregarUsuario = baseDatos.insertarUsuario(txtCedula.Text, tipoDeUsuario, numSucursal);
                    }


                    if (agregarPersona && agregarUsuario)
                    {
                        MessageBox.Show("El usuario se ha registrado con éxito en el sistema S-mart.", "Registrar usuario");
                        MenuAdmin admin = new MenuAdmin();
                        admin.Show();
                        this.Hide();

                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos correspondientes al registro del usuario", "Registrarse",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
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

        public void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }

        public void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }

        public void txtConfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }

        //Verifica que en los "textbox" no se puedan ingresar ';' ni '-'
        public static void noEsGuion(KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == ';')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedIndex == 0) 
            {
                label10.Visible = false;
                cmbSucursales.Visible = false;
            }
            else if (cmbTipoUsuario.SelectedIndex == 1)
            {
                label10.Visible = true;
                cmbSucursales.Visible = true;  
            }
            else if (cmbTipoUsuario.SelectedIndex == 2)
            {
                label10.Visible = true;
                cmbSucursales.Visible = true;                          
            }
            else 
            {
                label10.Visible = false;
                cmbSucursales.Visible = false;
            }
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            //string consulta = "Select Id_Sucursal from Sucursal";
            //baseDatos.cargaComboboxID(cmbSucursales, consulta);
        }

    }
}
