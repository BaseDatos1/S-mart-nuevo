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
    public partial class MenuAdminSucursal : Form
    {
        public MenuAdminSucursal()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto S-mart: Supermercado Inteligente realizado por Gaudy Blanco Meneses, Larissa Arroyo Castillo y José Eduardo Picado Salas para el curso Bases de Datos 1 de la Escuela de Ciencias de la Computación e Informática de la UCR.", "Acerca de");
        }              

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            InsertarSucursal insSucursal = new InsertarSucursal();
            insSucursal.Show();
            this.Hide();    
             
        }        

        private void insertarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarMarca cat = new InsertarMarca();
            cat.Show();
        }        

        private void insertarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarCategorias categorias = new InsertarCategorias();
            categorias.Show();
        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarProducto insProd = new InsertarProducto();
            insProd.Show();
            this.Hide();
        }

        private void insertarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarCompra compra = new InsertarCompra();
            compra.Show();
            this.Hide();
        }              

        private void verSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerMarcas ver_marcas = new VerMarcas();
            ver_marcas.Show();
            this.Hide();
        }

        private void verCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCategorias cat = new VerCategorias();
            cat.Show();
            this.Hide();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductos verprod = new VerProductos();
            verprod.Show();
            this.Hide();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
