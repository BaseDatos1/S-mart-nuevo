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
    public partial class InsertarProducto : Form
    {
        AccesoBaseDatos baseDatos;

        public InsertarProducto()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtExterno.Text != "" && txtInterno.Text != "" && DTPVencimiento.Text != "" && txtCosto.Text != "" && txtAlto.Text != "" && txtAncho.Text != "" && txtCantidad.Text != "" && txtDCorta.Text != "" && cmbMarca.Text != "" && txtDLarga.Text != "" && txtPrecio.Text != "" && txtLargo.Text != "" && txtCantidad.Text != "")
            {
                int alto = int.Parse(txtAlto.Text);
                int largo = int.Parse(txtLargo.Text);
                int ancho = int.Parse(txtAncho.Text);
                float peso = float.Parse(txtPeso.Text);
                int costo = int.Parse(txtCosto.Text);
                int precio = int.Parse(txtPrecio.Text);
                string marca = cmbMarca.Text;

                bool result = baseDatos.insertarProductoSQL(txtExterno.Text, txtInterno.Text, DTPVencimiento.Text, alto, largo, ancho, alto * largo * ancho, peso, costo, precio, txtDLarga.Text, txtDCorta.Text, marca);

                if (result)
                {

                    DialogResult result2 = MessageBox.Show("¿Desea agregarle características a este producto en este momento?", "Clasificación del producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result2 == DialogResult.No)
                    {
                        MessageBox.Show("Producto almacenado correctamente", "Insertar Producto");
                        MessageBox.Show("Si lo desea, en cualquier momento puede modificar el producto y agregarle características.", "Clasificación del producto");
                        MenuAdmin admin = new MenuAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (result2 == DialogResult.Yes)
                    {
                        insCategoria agregar = new insCategoria();
                        agregar.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos correspondientes al producto", "Insertar Producto",
       MessageBoxButtons.OK,
       MessageBoxIcon.Exclamation,
       MessageBoxDefaultButton.Button1);
        
            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
        }



        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtLargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtAlto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosYPuntos(e);
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

        public static void soloNumerosYPuntos(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void InsertarProducto_Load(object sender, EventArgs e)
        {
            string consulta = "Select Nombre_marca from Marca";
            baseDatos.cargaCombobox(cmbMarca, consulta);
        }

    }
}
