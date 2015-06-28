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

            ControlBox = true;
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
    }
}
