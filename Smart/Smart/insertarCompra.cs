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
    public partial class InsertarCompra : Form
    {
        AccesoBaseDatos baseDatos;
        int contador = 0;
        string sqlFormattedDate;
        int idCompra;
        string cedulaCliente;

        public InsertarCompra()
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

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
            if (e.KeyChar == 13)
            {
                //
            }
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void InsertarCompra_Load(object sender, EventArgs e)
        {
           // string fecha = DateTime.Now.ToString().Substring(0, 10);
            //labelFecha.Text = fecha;
            //labelHora.Text = DateTime.Now.ToString("HH:mm");
            labelFecha.Text = DateTime.Now.ToString();
            DateTime myDateTime = DateTime.Now;
            sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            baseDatos.obtenerDatosUsuario("Select Nombre, Apellido1, Apellido2 FROM Persona WHERE  Cedula = '"+ GlobalVar.CedulaUsuarioActual+ "'", txtCajero);
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string revisar = txtCliente.Text;
                baseDatos.obtenerDatosUsuario("Select Nombre, Apellido1, Apellido2 FROM Persona WHERE Cedula = '" + txtCliente.Text + "'", txtCliente);
                if (revisar != txtCliente.Text)
                {
                    cedulaCliente = revisar;
                    txtCliente.ReadOnly = true;
                }
                if (revisar == "")
                {
                    txtCliente.ReadOnly = true;
                }
            }
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);

            if (e.KeyChar == 13)
            {
                if (int.Parse(txtCaja.Text) > 0)
                {
                    txtCaja.ReadOnly = true;
                }
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            contador++;

            //primera vez de la compra
            if (contador == 1)
            {
                if (txtCliente.Text == "")
                {
                    baseDatos.insertarDatos("INSERT INTO Compra (Num_Caja, Fecha, Peso, Monto, Cédula_Cajero, Id_Sucursal, Modo_Pago) VALUES('" + int.Parse(txtCaja.Text) + "', '" + sqlFormattedDate + "', (select Peso From Producto WHERE CBExterno = '" + txtProducto.Text + "'), (select Precio From Producto WHERE CBExterno = '" + txtProducto.Text + "'), '" + GlobalVar.CedulaUsuarioActual + "', '" + GlobalVar.IdSucursalActual + "', '0' )");
                    
                }
                else
                {
                    baseDatos.insertarDatos("INSERT INTO Compra (Cédula_Cliente, Num_Caja, Fecha, Peso, Monto, Cédula_Cajero, Id_Sucursal, Modo_Pago) VALUES('" +cedulaCliente + "', '" + int.Parse(txtCaja.Text) + "', '" + sqlFormattedDate + "', (select Peso From Producto WHERE CBExterno = '" + txtProducto.Text + "'), (select Precio From Producto WHERE CBExterno = '" + txtProducto.Text + "'), '" + GlobalVar.CedulaUsuarioActual + "', '" + GlobalVar.IdSucursalActual + "', '0' )");
                }
                    idCompra = baseDatos.obtenerIdCompra("SELECT Id_compra FROM Compra WHERE Num_Caja = '" + int.Parse(txtCaja.Text) + "' and Fecha ='" + sqlFormattedDate + "' and Cédula_Cajero = '" + GlobalVar.CedulaUsuarioActual + "'");
                    baseDatos.insertarDatos("Insert INTO Posee (ID_Compra, CBExterno_Producto, Precio, Cantidad) VALUES('" + idCompra + "', '" + txtProducto.Text + "', (select Precio FROM Producto WHERE CBExterno = '" + txtProducto.Text + "'), 1 )");
            }
            else
            {
                baseDatos.insertarDatos("Insert INTO Posee (ID_Compra, CBExterno_Producto, Precio, Cantidad) VALUES('" + idCompra + "', '" + txtProducto.Text + "', (select Precio FROM Producto WHERE CBExterno = '" + txtProducto.Text + "'), 1 )");
            }
            baseDatos.llenarTabla("SELECT Producto.CBExterno, Producto.Fecha, Producto.Desc_Corta, Producto.Id_marca, Posee.Precio, Posee.Cantidad FROM Posee, Producto WHERE Posee.Id_Compra = '"+idCompra+ "' and Posee.CBExterno_Producto = Producto.CBExterno", displayProductos);
            txtProducto.Text = "";
        }
    }
}

