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
                    MessageBox.Show("Se ha ingresado correctamente la marca en el sistema S-mart.", "Insertar Marca");
                    MenuAdmin admin = new MenuAdmin();
                    admin.Show();
                    this.Hide();
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
    }
}
