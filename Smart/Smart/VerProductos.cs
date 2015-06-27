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
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = '" + txtbusqueda.Text + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }
            else if (cmbCriterio.Text == "Código Interno")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.CBinterno = '" + txtbusqueda.Text + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
      
            }
            else if (cmbCriterio.Text == "Costo")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Costo = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }
            else if (cmbCriterio.Text == "Precio Actual")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Precio = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";

            }
            else if (cmbCriterio.Text == "Fecha de vencimiento")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Fecha = '" + txtbusqueda.Text + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }
            else if (cmbCriterio.Text == "Peso")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Peso = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }
            else if (cmbCriterio.Text == "Medida de alto (cm)")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Alto = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }
            else if (cmbCriterio.Text == "Medida de largo (cm)")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Largo = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
               
            }
            else if (cmbCriterio.Text == "Medida de ancho (cm)")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.Ancho = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }
            else if (cmbCriterio.Text == "" || txtbusqueda.Text == "")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat";
            }

            baseDatos.llenarTabla(consulta, displayProductos);
        }
    }
}
