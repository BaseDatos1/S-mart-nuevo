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
    public partial class InsertarCategorias : Form
    {
        AccesoBaseDatos baseDatos;

        public InsertarCategorias()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }

        private void btnAgregarCaracteristica_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtdescripcion.Text != "")
            {
                string consulta = "INSERT INTO Categoria (Nombre, Descripción) VALUES ('" + txtNombre.Text + "', '" + txtdescripcion.Text + "')";
                bool result = baseDatos.insertarDatos(consulta);
                if (result)
                {
                    MessageBox.Show("Característica para asignar a productos almacenada correctamente", "Insertar Producto");
                }

            }
        }
    }
}
