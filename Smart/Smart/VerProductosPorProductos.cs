﻿using System;
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
    public partial class VerProductosPorProductos : Form
    {
        AccesoBaseDatos baseDatos;

        public VerProductosPorProductos()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (GlobalVar.TipoUsuarioSistema == "Administrador")
            {
                MenuAdmin admin = new MenuAdmin();
                admin.Show();
                this.Hide();
            }
            else if (GlobalVar.TipoUsuarioSistema == "Administrador de Sucursal")
            {
                MenuAdminSucursal adminSuc = new MenuAdminSucursal();
                adminSuc.Show();
                this.Hide();
            }
            else if (GlobalVar.TipoUsuarioSistema == "Encargado de Inventario")
            {
                MenuEncargado encargado = new MenuEncargado();
                encargado.Show();
                this.Hide();
            }
            else if (GlobalVar.TipoUsuarioSistema == "Cajero")
            {
                MenuCajero cajero = new MenuCajero();
                cajero.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String consulta = "";

            if(cmbCriterio.Text == "Código Externo")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad FROM Producto, Categoria, Asignado, Vende WHERE (Producto.CBExterno = '" + txtbusqueda.Text + "' or Producto.CBExterno like '%" + txtbusqueda.Text + "%') and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else if (cmbCriterio.Text == "Código Interno")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE (Producto.CBinterno = '" + txtbusqueda.Text + "' or Producto.CBinterno like '%" + txtbusqueda.Text + "%') and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_ca Vende.CBExterno_Producto = Producto.CBExternot";
      
            }
            else if (cmbCriterio.Text == "Costo")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Costo = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else if (cmbCriterio.Text == "Precio Actual")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Precio = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat Vende.CBExterno_Producto = Producto.CBExterno";

            }
            else if (cmbCriterio.Text == "Fecha de vencimiento")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Fecha = '" + txtbusqueda.Text + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else if (cmbCriterio.Text == "Peso")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Peso = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else if (cmbCriterio.Text == "Medida de alto (cm)")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Alto = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else if (cmbCriterio.Text == "Medida de largo (cm)")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Largo = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
               
            }
            else if (cmbCriterio.Text == "Medida de ancho (cm)")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.Ancho = '" + int.Parse(txtbusqueda.Text) + "' and Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else if (cmbCriterio.Text == "" && txtbusqueda.Text == "")
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }
            else
            {
                consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno";
            }

            baseDatos.llenarTabla(consulta, displayProductos);
        }

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            string consulta = "Select Producto.CBExterno, Producto.CBinterno, Producto.Fecha, Producto.Alto, Producto.Largo, Producto.Ancho, Producto.Volumen, Producto.Peso, Producto.Costo, Producto.Precio, Producto.Desc_Larga, Producto.Desc_Corta, Producto.Id_marca, Categoria.Descripción, Vende.cantidad, Vende.ID_Sucursal FROM Producto, Categoria, Asignado, Vende WHERE Producto.CBExterno = Asignado.CBExterno_Producto and Asignado.ID_Categoria = Categoria.Id_cat and Vende.CBExterno_Producto = Producto.CBExterno and Vende.CBExterno_Producto = Producto.CBExterno";
            baseDatos.llenarTabla(consulta, displayProductos);
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
