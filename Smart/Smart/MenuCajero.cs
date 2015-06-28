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
    public partial class MenuCajero : Form
    {
        public MenuCajero()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpcIniciales iniciales = new OpcIniciales();
            iniciales.Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto S-mart: Supermercado Inteligente realizado por Gaudy Blanco Meneses, Larissa Arroyo Castillo y José Eduardo Picado Salas para el curso Bases de Datos 1 de la Escuela de Ciencias de la Computación e Informática de la UCR.", "Acerca de");
        }

        private void insertarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarCompra compra = new InsertarCompra();
            compra.Show();
            this.Hide();
        }

        private void verMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerMarcas ver_marcas = new VerMarcas();
            ver_marcas.Show();
        }

        private void verCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCategorias cat = new VerCategorias();
            cat.Show();
            this.Hide();
        }

        private void verProductosPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductosPorProductos verprod = new VerProductosPorProductos();
            verprod.Show();
            this.Hide();
        }

        private void verProductosPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductosPorMarcas verprod = new VerProductosPorMarcas();
            verprod.Show();
            this.Hide();
        }

        private void verComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
