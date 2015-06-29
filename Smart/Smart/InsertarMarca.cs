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
    public partial class InsertarMarca : Form
    {
        AccesoBaseDatos baseDatos;
        public InsertarMarca()
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtDistruibuidor.Text != "" && txtMarca.Text != "")
            {
                bool agregarMarca = baseDatos.insertarMarca(txtMarca.Text, txtDistruibuidor.Text);

                if (agregarMarca)
                {   
                    txtDistruibuidor.Text = "";
                    txtMarca.Text = "";
                    MessageBox.Show("Se ha ingresado correctamente la marca en el sistema S-mart.", "Insertar Marca");
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos correspondientes a la Marca", "Insertar Marca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
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

        public void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }
        public void txtDistribuidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEsGuion(e);
        }

    }
}
