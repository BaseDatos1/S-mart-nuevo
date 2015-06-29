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
    public partial class EliminarUsuario : Form
    {
        AccesoBaseDatos baseDatos;
        public EliminarUsuario()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (GlobalVar.TipoUsuarioSistema == "Administrador")
            {
                MenuAdmin admin = new MenuAdmin();
                admin.Show();
                this.Hide();
            }
            else if (GlobalVar.TipoUsuarioSistema == "Administrador de Sucursal")
            {
                MenuAdminSucursal adminSuc = new MenuAdminSucursal();
                adminSuc.Show();
                this.Hide();
            }
            else if (GlobalVar.TipoUsuarioSistema == "Encargado de Inventario")
            {
                MenuEncargado encargado = new MenuEncargado();
                encargado.Show();
                this.Hide();
            }
            else if (GlobalVar.TipoUsuarioSistema == "Cajero")
            {
                MenuCajero cajero = new MenuCajero();
                cajero.Show();
                this.Hide();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text != "" && (cmbCriterioEliminar.SelectedIndex == 0 | cmbCriterioEliminar.SelectedIndex == 1 | cmbCriterioEliminar.SelectedIndex == 2))
            {
                string tipoUsuario = cmbCriterioEliminar.Text;
                bool eliminarUsu = false;
                bool existe = false;
                string consultar = "";
                if (cmbCriterioEliminar.SelectedIndex == 0 | cmbCriterioEliminar.SelectedIndex == 1 | cmbCriterioEliminar.SelectedIndex == 2)
                {
                    consultar = "SELECT Persona.Cedula from Persona where Persona.Cedula ='" + txtEliminar.Text + "'";
                    
                    existe = baseDatos.existe(consultar);
                    if (existe && txtEliminar.Text != "0000000000")
                    {
                        eliminarUsu = baseDatos.eliminarUsuario(txtEliminar.Text);

                        if (eliminarUsu)
                        {
                            MessageBox.Show("El usuario se ha eliminado con éxito del sistema S-mart.", "Eliminar usuario");
                            if (cmbCriterioEliminar.SelectedIndex == 0)
                            {
                                string consulta = "SELECT * FROM Admin_Sucursal";
                                baseDatos.llenarTabla(consulta, displayUsuarios);
                            }
                            else if (cmbCriterioEliminar.SelectedIndex == 1)
                            {
                                string consulta = "SELECT * FROM Cajero";
                                baseDatos.llenarTabla(consulta, displayUsuarios);
                            }
                            else if (cmbCriterioEliminar.SelectedIndex == 2)
                            {
                                string consulta = "SELECT * FROM Encargado_De_Inventario";
                                baseDatos.llenarTabla(consulta, displayUsuarios);
                            }
                            else if (cmbCriterioEliminar.SelectedIndex == 3)
                            {
                                string consulta = "SELECT * from Cliente";
                                baseDatos.llenarTabla(consulta, displayUsuarios);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cédula ingresada es inválida.", "Eliminar usuario");

                    } 
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos correspondientes", "Eliminar Usuario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {            
            
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

        public void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }

        private void cmbCriterioEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbCriterioEliminar.SelectedIndex == 0)
            {
                string consulta = "SELECT * FROM Admin_Sucursal";
                baseDatos.llenarTabla(consulta, displayUsuarios);
            }
            else if (cmbCriterioEliminar.SelectedIndex == 1)
            {
                string consulta = "SELECT * FROM Cajero";
                baseDatos.llenarTabla(consulta, displayUsuarios);
            }
            else if (cmbCriterioEliminar.SelectedIndex == 2)
            {
                string consulta = "SELECT * FROM Encargado_De_Inventario";
                baseDatos.llenarTabla(consulta, displayUsuarios);
            }
            else if (cmbCriterioEliminar.SelectedIndex == 3)
            {
                string consulta = "SELECT * from Cliente";
                baseDatos.llenarTabla(consulta, displayUsuarios);
            }
        }





    }
}
