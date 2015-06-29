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
    public partial class ModificarProducto : Form
    {
        AccesoBaseDatos baseDatos;

        public ModificarProducto()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            string consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            baseDatos.llenarTabla(consulta, displayProductos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool existeConsulta = false;
            string consulta = "";
            string atributo = "";
            string valorNuevo = "";

            if (cmbCriterioModificar.Text != "" && txtExterno.Text != "" && (txtNuevoValorNumero.Text != "" || txtNuevoValorTexto.Text != "" || txtDescripcion.Text != "" || DTPVencimiento.Text != ""))
            {

                if (cmbCriterioModificar.Text == "Código Externo")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "CBExterno";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Código Interno")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "CBinterno";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Costo")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Costo";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Precio Actual")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Precio";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Fecha de vencimiento")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Fecha";
                    valorNuevo = DTPVencimiento.Text;
                }
                else if (cmbCriterioModificar.Text == "Peso")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Peso";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Medida de alto (cm)")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Alto";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Medida de largo (cm)")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Largo";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Medida de ancho (cm)")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Ancho";
                    valorNuevo = txtNuevoValorNumero.Text;
                }
                else if (cmbCriterioModificar.Text == "Descripción Larga")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Desc_Larga";
                    valorNuevo = txtDescripcion.Text;
                }
                else if (cmbCriterioModificar.Text == "Descripción Corta")
                {
                    consulta = "Select Producto.CBExterno FROM Producto, Asignado WHERE Producto.CBExterno = '" + txtExterno.Text + "' AND Asignado.CBExterno_Producto = '" + txtExterno.Text + "'";
                    existeConsulta = baseDatos.existe(consulta);
                    atributo = "Desc_Corta";
                    valorNuevo = txtDescripcion.Text;
                }


                if (existeConsulta)
                {

                    bool modificacionProducto = baseDatos.modificarProducto(atributo, valorNuevo, txtExterno.Text);

                    if (modificacionProducto)
                    {
                        MessageBox.Show("El producto se ha modificado con éxito en el sistema S-mart.", "Modificar Producto");
                        string consultarProducto = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
                        baseDatos.llenarTabla(consultarProducto, displayProductos);

                    }
                }
                else
                {
                    MessageBox.Show("El código o el criterio seleccionado es inválido.", "Modificar Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    txtExterno.Text = "";
                }

            }
            else
            {
                  MessageBox.Show("Debe ingresar los datos correspondientes.", "Modificar Producto",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);
            }
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

        public void txtNuevoValorNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        public void txtNuevoValorTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        public void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }

        public void txtExterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }


        private void cmbCriterioModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCriterioModificar.SelectedIndex == 0 || cmbCriterioModificar.SelectedIndex == 1 || cmbCriterioModificar.SelectedIndex == 2 || cmbCriterioModificar.SelectedIndex == 3 || cmbCriterioModificar.SelectedIndex == 5 || cmbCriterioModificar.SelectedIndex == 6 || cmbCriterioModificar.SelectedIndex == 7 || cmbCriterioModificar.SelectedIndex == 8)
            {
                label3.Visible = true;
                txtDescripcion.Visible = false;
                txtNuevoValorNumero.Visible = true;
                txtNuevoValorTexto.Visible = false;
                DTPVencimiento.Visible = false;
            }
           
            else if (cmbCriterioModificar.SelectedIndex == 4)
            {
                label3.Visible = true;
                txtDescripcion.Visible = false;
                txtNuevoValorNumero.Visible = false;
                txtNuevoValorTexto.Visible = false;
                DTPVencimiento.Visible = true;
            }
            else if (cmbCriterioModificar.SelectedIndex == 9 || cmbCriterioModificar.SelectedIndex == 10)
            {
                label3.Visible = true;
                txtDescripcion.Visible = true;
                txtNuevoValorNumero.Visible = false;
                txtNuevoValorTexto.Visible = false;
                DTPVencimiento.Visible = false;
            }
            else
            {
                label3.Visible = false;               
            }
        }




    }
}
