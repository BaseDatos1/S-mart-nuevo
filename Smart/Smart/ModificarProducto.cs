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
            if (cmbCriterioModificar.Text != "" && txtExterno.Text != "" && txtNuevoValor.Text != "")
            {
                String consultarProducto = "SELECT Producto.CBExterno FROM Producto WHERE Producto.CBExterno = '" + txtExterno.Text + "'";
                existeConsulta = baseDatos.existe(consultarProducto);
                if (existeConsulta)
                {
                    String atributo = cmbCriterioModificar.Text;
                     MessageBox.Show("El atributo es: " + atributo);
                    bool modificacionProducto = baseDatos.modificarProducto(atributo, txtNuevoValor.Text, txtExterno.Text);

                    if(modificacionProducto)
                    {
                        MessageBox.Show("El producto se ha modificado con éxito en el sistema S-mart.", "Modificar Producto");
                        string consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
                        baseDatos.llenarTabla(consulta, displayProductos);

                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado es inválido.", "Modificar Producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }

            }
        }
    }
}
