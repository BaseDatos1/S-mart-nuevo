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
    public partial class insCategoria : Form
    {
        AccesoBaseDatos baseDatos;

        public insCategoria(string codigoProductoExterno)
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
            txtCodigoExterno.Text = codigoProductoExterno;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Asignado VALUES ((Select Id_Cat FROM Categoria WHERE Nombre = '"+ cmbCategorias.Text + "' and Descripción = '" + txtdescripcion.Text + "'), '"+ txtCodigoExterno.Text +"')";
            bool result = baseDatos.insertarDatos(consulta);
            if (result)
            {
                MessageBox.Show("Producto asignado con su característica correctamente, si lo desea puede agregar más categorías", "Agregar características al producto");
                ControlBox = true;
            }
        }

        private void insCategoria_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT Nombre FROM Categoria";
            baseDatos.cargaCombobox(cmbCategorias, consulta);
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "Select Descripción FROM Categoria WHERE Nombre = '" + cmbCategorias.Text + "'";
            baseDatos.cargarTexto(consulta, txtdescripcion);
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

        public void txtCodigoExterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        public void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }


    }
}
