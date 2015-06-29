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
    public partial class VerProductosPorMarcas : Form
    {
        AccesoBaseDatos baseDatos;

        public VerProductosPorMarcas()
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

        private void cmbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbCriterio.SelectedItem.ToString();

            //string consulta = " SELECT P.CBExterno, P.CBinterno, P.Fecha, P.Alto, P.Largo, P.Ancho, P.Volumen, P.Peso, P.Costo, P.Precio, P.Desc_Larga, P.Desc_Corta, P.Id_marca" +
            //                  " FROM Producto P " + 
            //                  " WHERE Id_marca = '" + selected + "'";

            string consulta = " SELECT P.CBExterno, P.CBinterno, P.Fecha, P.Alto, P.Largo, P.Ancho, P.Volumen, P.Peso, P.Costo, P.Precio, P.Desc_Larga, P.Desc_Corta, P.Id_marca, C.Nombre, V.cantidad" +
                              " FROM Producto P JOIN Asignado A ON P.CBExterno = A.CBExterno_Producto JOIN Categoria C ON A.ID_Categoria = C.Id_cat JOIN Vende V ON V.CBExterno_Producto = P.CBExterno and V.ID_Sucursal = '" + GlobalVar.IdSucursalActual + "'" +
                              " WHERE Id_marca = '" + selected + "' ";                    

            baseDatos.llenarTabla(consulta, displayProductos);
        }

        private void VerProductos_Load(object sender, EventArgs e)
        {           
            string consulta1 = "Select Nombre_marca FROM Marca";
            baseDatos.cargaCombobox(cmbCriterio, consulta1);
            
            string consulta = " SELECT P.CBExterno, P.CBinterno, P.Fecha, P.Alto, P.Largo, P.Ancho, P.Volumen, P.Peso, P.Costo, P.Precio, P.Desc_Larga, P.Desc_Corta, P.Id_marca, C.Nombre, V.cantidad" +
                              " FROM Producto P JOIN Asignado A ON P.CBExterno = A.CBExterno_Producto JOIN Categoria C ON A.ID_Categoria = C.Id_cat JOIN Vende V ON V.CBExterno_Producto = P.CBExterno and V.ID_Sucursal = '" + GlobalVar.IdSucursalActual + "'";
                        
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
