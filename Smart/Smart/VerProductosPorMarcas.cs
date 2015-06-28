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
    public partial class VerProductosPorMarcas : Form
    {
        AccesoBaseDatos baseDatos;

        public VerProductosPorMarcas()
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

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbCriterio.SelectedItem.ToString();

            string consulta = " SELECT * FROM Producto WHERE  Id_marca = '" + selected +"'";
            baseDatos.llenarTabla(consulta, displayProductos);
        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Marca";
            baseDatos.cargaCombobox(cmbCriterio, consulta);            
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


    }
}
