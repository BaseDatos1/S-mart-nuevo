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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
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

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarProducto insProd = new InsertarProducto();
            insProd.Show();
            this.Hide();
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

        private void productoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VerProductos verprod = new VerProductos();
            verprod.Show();
            this.Hide(); 
        }

        private void insertarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarCompra compra = new InsertarCompra();
            compra.Show();
            this.Hide();
        }

    }
}
