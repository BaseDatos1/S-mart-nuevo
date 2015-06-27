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
    public partial class VerProductos : Form
    {
        AccesoBaseDatos baseDatos;

        public VerProductos()
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

        private void button1_Click(object sender, EventArgs e)
        {
            String consulta = "";
            String criterio = "";

            if(cmbCriterio.Text == "Código Externo")
            {
                criterio = "CBExterno";
                baseDatos.llenarTabla(consulta, displayProductos);
            }
            else if (cmbCriterio.Text == "Código Interno")
            {
                criterio = "CBinterno";
            }
            else if (cmbCriterio.Text == "Costo")
            {
                criterio = "Costo";
            }
            else if (cmbCriterio.Text == "Precio Actual")
            {
                criterio = "Precio";
            }
            else if (cmbCriterio.Text == "Fecha de vencimiento")
            {
                criterio = "Fecha";
            }
            else if (cmbCriterio.Text == "Peso")
            {
                criterio = "Peso";
            }
            else if (cmbCriterio.Text == "Alto")
            {
                criterio = "Alto";
            }
            else if (cmbCriterio.Text == "Largo")
            {
                criterio = "Largo";
            }
            else if (cmbCriterio.Text == "Ancho")
            {
                criterio = "Ancho";
            }
            consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE " + criterio + " = " + txtbusqueda.Text; 
        }
    }
}
