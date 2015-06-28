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
    public partial class VerCategorias : Form
    {
        AccesoBaseDatos baseDatos;

        public VerCategorias()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "";
            if (cmbCriterio.Text == "Nombre")
            {
                consulta = "SELECT * FROM Categoria WHERE Nombre like '%" +txtbusqueda.Text + "%'";
            }
            else if (cmbCriterio.Text == "Descripción")
            {
                consulta = "SELECT * FROM Categoria WHERE Descripción like '%" +txtbusqueda.Text + "%'";
            }
            else if (cmbCriterio.Text == "" && txtbusqueda.Text == "")
            {
                consulta = "SELECT * FROM Categoria";
            }
            else
            {
                consulta = "SELECT * FROM Categoria";
            }
            baseDatos.llenarTabla(consulta, displayCategorias);
        }

        private void VerCategorias_Load(object sender, EventArgs e)
        {            
            string consulta = "SELECT * FROM Categoria";
            baseDatos.llenarTabla(consulta, displayCategorias);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            admin.Show();
            this.Hide();
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
