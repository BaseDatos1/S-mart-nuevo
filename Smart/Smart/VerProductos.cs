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

            if(cmbCriterio.Text == "Código Externo")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE CBExterno = '" + txtbusqueda.Text + "'";
            }
            else if (cmbCriterio.Text == "Código Interno")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE CBinterno = '" + txtbusqueda.Text + "'";
      
            }
            else if (cmbCriterio.Text == "Costo")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Costo = '" + int.Parse(txtbusqueda.Text) + "'";
            }
            else if (cmbCriterio.Text == "Precio Actual")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Precio = '" + int.Parse(txtbusqueda.Text) + "'";

            }
            else if (cmbCriterio.Text == "Fecha de vencimiento")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Fecha = '" + txtbusqueda.Text + "'";
            }
            else if (cmbCriterio.Text == "Peso")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Peso = '" + int.Parse(txtbusqueda.Text) + "'";
            }
            else if (cmbCriterio.Text == "Medida de alto (cm)")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Alto = '" + int.Parse(txtbusqueda.Text) + "'";
            }
            else if (cmbCriterio.Text == "Medida de largo (cm)")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Largo = '" + int.Parse(txtbusqueda.Text) + "'";
            }
            else if (cmbCriterio.Text == "Medida de ancho (cm)")
            {
                consulta = "Select CBExterno, CBinterno, Fecha, Alto, Largo, Ancho, Volumen, Peso, Costo, Precio, Desc_Larga, Desc_Corta, Id_marca FROM Producto WHERE Ancho = '" + int.Parse(txtbusqueda.Text) + "'";
            }
            baseDatos.llenarTabla(consulta, displayProductos);
        }
    }
}
