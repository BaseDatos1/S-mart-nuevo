using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;

// Namespace para mostrar mensajes
using System.Windows.Forms;

namespace Smart
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        String conexion = @"Data Source=LARI-PC; Initial Catalog=Supermercado_inteligente; Integrated Security=SSPI";
       
        /*En data source siempre se cambia por el servidor local de la compu*/   
        /**
         * Constructor
         */
        public AccesoBaseDatos(){
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Selección de datos incorrectos"
                    , "Selección de datos"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation
                    , MessageBoxDefaultButton.Button1);
            }
            return datos;
        }

        /*Para obtener la sucursal en la que trabaja ese empleado*/
        public void obtenerSucursal(string consulta)
        {
            SqlDataReader datos = null;
            datos = ejecutarConsulta(consulta);

            if (datos != null)
            {
                while (datos.Read())
                {
                    GlobalVar.IdSucursalActual = datos.GetInt32(0);
                }
            }
        }

        public void obtenerDatosUsuario(string consulta, TextBox txt)
        {
            SqlDataReader datos = null;
            datos = ejecutarConsulta(consulta);

            if (datos != null)
            {
                while (datos.Read())
                {
                    txt.Text = datos.GetString(0) + " " + datos.GetString(1) + " " + datos.GetString(2);
                }
            }
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            return table;
        }

        /*Metodo para insertar un nuevo producto en la base de datos*/
        public bool insertarProductoSQL(string externo, string interno, string fecha, int alto, int largo, int ancho, int volumen, float peso, int costo, int precio, string descLarga, string descCorta, string marca)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("InsertarProducto", con))
                {
                    try{  
                        cmd.CommandType = CommandType.StoredProcedure;
                   
                        cmd.Parameters.Add("@codigoExterno", SqlDbType.VarChar).Value = externo;                  
                        cmd.Parameters.Add("@codigoInterno", SqlDbType.VarChar).Value = interno;                   
                        cmd.Parameters.Add("@fechaVenc", SqlDbType.DateTime).Value = fecha;                   
                        cmd.Parameters.Add("@alto", SqlDbType.Int).Value = alto;                   
                        cmd.Parameters.Add("@largo", SqlDbType.Int).Value = largo;                   
                        cmd.Parameters.Add("@ancho", SqlDbType.Int).Value = ancho;                   
                        cmd.Parameters.Add("@volumen", SqlDbType.Int).Value = volumen;                   
                        cmd.Parameters.Add("@peso", SqlDbType.Float).Value = peso;                  
                        cmd.Parameters.Add("@costo", SqlDbType.Int).Value = costo;                  
                        cmd.Parameters.Add("@precio", SqlDbType.Int).Value = precio;                  
                        cmd.Parameters.Add("@desLarga", SqlDbType.VarChar).Value = descLarga;                   
                        cmd.Parameters.Add("@descCorta", SqlDbType.VarChar).Value = descCorta;                   
                        cmd.Parameters.Add("@marca", SqlDbType.VarChar).Value = marca;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                     }
                    catch(SqlException ex){
                        MessageBox.Show("El código de barras externo ingresado ya existe en la base de datos S-mart o se ingresó algún dato inválido"
                            , "Insertar Producto"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Exclamation
                            , MessageBoxDefaultButton.Button1);

                        return false;
                    }
                }
            }
       
        }

        /*Metodo para insertar un nuevo usuario en la base de datos*/
        /*Metodo para insertar un nuevo usuario en la base de datos*/
        public bool insertarPersonaSQL(string CedulaPersona, string NombrePersona, string Apellido1Persona, string Apellido2Persona, string TelefonoPersona, string EmailPersona, string ContraseñaPersona, string ContraseñaConfirmacion /*string TipoUsuario */)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("InsertarPersona", con))
                {
                    try
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@cedulaPersona", SqlDbType.VarChar).Value = CedulaPersona;
                        cmd.Parameters.Add("@nombreP", SqlDbType.VarChar).Value = NombrePersona;
                        cmd.Parameters.Add("@apellido1P", SqlDbType.VarChar).Value = Apellido1Persona;
                        cmd.Parameters.Add("@apellido2P", SqlDbType.VarChar).Value = Apellido2Persona;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = TelefonoPersona;
                        cmd.Parameters.Add("@emailP", SqlDbType.VarChar).Value = EmailPersona;
                        cmd.Parameters.Add("@contraseñaP", SqlDbType.VarChar).Value = ContraseñaPersona;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("La cédula del usuario PERSONA ingresado ya existe en la base de datos", "Insertar Persona");
                        return false;
                    }

                }
            }

        }

        /*Método para agregar tipo de Usuario en la base de datos */
        public bool insertarUsuario(string CedulaPersona, string tipoUsuario, int numeroSucursal)
        {
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = null;

            SqlParameter Cedula = new SqlParameter("@Cedula", SqlDbType.VarChar, 15);
            Cedula.Value = CedulaPersona;

            SqlParameter numSucursal = new SqlParameter("@ID_Sucursal", SqlDbType.Int, 4);
            numSucursal.Value = numeroSucursal;

            if (tipoUsuario == "Administrador Sucursal")
            {
                string consulta = "INSERT INTO Admin_Sucursal VALUES (@Cedula)";
         
                try
                {
                    cmd = new SqlCommand(consulta, con);


                    cmd.Parameters.Add(Cedula);
           

                    cmd.ExecuteNonQuery();
       

                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La cédula del usuario ingresado ya existe en la base de datos S-mart");
                    return false;
                }
            }

            else if (tipoUsuario == "Cajero")
            {
                string consulta = "INSERT INTO Cajero VALUES (@Cedula, @ID_Sucursal)";
                try
                {
                    cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.Add(Cedula);
                    cmd.Parameters.Add(numSucursal);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La cédula del usuario ingresado ya existe en la base de datos S-mart o la sucursal es inválida");
                    return false;
                }
            }

            else if (tipoUsuario == "Encargado de Inventario")
            {
                string consulta = "INSERT INTO Encargado_De_Inventario VALUES (@Cedula, @ID_Sucursal)";
                try
                {
                    cmd = new SqlCommand(consulta, con);
                    cmd.Parameters.Add(Cedula);
                    cmd.Parameters.Add(numSucursal);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("La cédula del usuario ingresado ya existe en la base de datos S-mart o la sucursal es inválida");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario válido");
                return false;
            }
        }



        /*Método para ingresar una marca en la base de datos */
        public bool insertarMarca(string nombreMarca, string nombreDistruibuidor)
        {
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = null;

            SqlParameter NomMarca = new SqlParameter("@Nombre_marca", SqlDbType.VarChar, 20);
            NomMarca.Value = nombreMarca;

            SqlParameter NomDistruibuidor = new SqlParameter("@Nombre_dist", SqlDbType.VarChar, 20);
            NomDistruibuidor.Value = nombreDistruibuidor;


            string consulta = "INSERT INTO Marca (Nombre_marca, Nombre_dist) VALUES (@Nombre_marca, @Nombre_dist )";
            try
            {
                cmd = new SqlCommand(consulta, con);

                cmd.Parameters.Add(NomMarca);
                cmd.Parameters.Add(NomDistruibuidor);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                //  string mensajeError = ex.ToString();
                MessageBox.Show("El nombre de la marca ingresado ya existe en la base de datos S-mart");
                return false;
            }
        }

        public void cargarTexto(string consulta, TextBox txt)
        {
            SqlDataReader datos = null;
            datos = ejecutarConsulta(consulta);

            if (datos != null)
            {
                while (datos.Read())
                {
                    txt.Text = datos.GetString(0);
                }
            }
        }

        public bool insertarDatos(String consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);

            sqlConnection.Open();
            try
            {
                SqlCommand cons = new SqlCommand(consulta, sqlConnection);

                cons.ExecuteNonQuery();

                sqlConnection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Los datos ingresados ya se encuentran en la base de datos S-mart"
                    , "Inserción de datos"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation
                    , MessageBoxDefaultButton.Button1);

                return false;
            }
        }

        public bool modificarProducto(string atributo, string nuevoValor, string codigoExterno)
        {
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = null;

            MessageBox.Show("El codigo a borrar es: " + codigoExterno);

            try
            {
                if (atributo == "CBExterno" | atributo == "CBInterno"| atributo == "Desc_Larga"|atributo == "Desc_Corta")
                {
                    cmd = new SqlCommand("Update Producto SET @atributo = @nuevoValor where CBEXTERNO = @externo", con);
                    cmd.Parameters.AddWithValue("@atributo", atributo);
                    cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor);
                    cmd.Parameters.AddWithValue("@externo", codigoExterno);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else if (atributo == "Id_Marca")
                {
                    MessageBox.Show("No es posible cambiar la marca del producto.");
                    return false;
                }
                else if (atributo == "Peso")
                {
                    string valorAtributo = nuevoValor;
                    float atributoFloat = float.Parse(valorAtributo);
                    cmd.Parameters.AddWithValue("@atributo", atributo);
                    cmd.Parameters.AddWithValue("@nuevoValor", atributoFloat);
                    cmd.Parameters.AddWithValue("@externo", codigoExterno);
                    return true;
                }

                else
                {
                    string valorAtributo = nuevoValor;
                    int atributoNumerico = int.Parse(valorAtributo);
                    cmd.Parameters.AddWithValue("@atributo", atributo);
                    cmd.Parameters.AddWithValue("@nuevoValor", atributoNumerico);
                    cmd.Parameters.AddWithValue("@externo", codigoExterno);
                    return true;
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("No es posible modificar el producto debido a que se ingresaron datos inválidos. " + ex.Message);
                return false;
            }          
        }


        

        /*   public bool insertarUsuario(string CedulaPersona, int numeroSucursal, string tipoUsuario)
           {
               using (SqlConnection con = new SqlConnection(conexion))
               {
                   if (tipoUsuario == "Admininistrador")
                   {
                       string sql = "INSERT INTO Admin_Sucursal (Cedula) VALUES (@CedulaPersona)";
                   }
                   else if (tipoUsuario == "Cajero")
                   {
                       string sql = "INSERT INTO Cajero (Cedula) VALUES (@CedulaPersona, @numeroSucursal)";
                   }
                   else if (tipoUsuario == "Cliente")
                   {
                       string sql = "INSERT INTO Cliente (Cedula) VALUES (@CedulaPersona, @numeroSucursal)";
                   }
                   using (SqlCommand cmd = new SqlCommand("InsertarPersona", con))
                   {
                       try
                       {

                           cmd.CommandType = CommandType.StoredProcedure;

                           cmd.Parameters.Add("@CedulaPersona", SqlDbType.VarChar).Value = CedulaPersona;
                           cmd.Parameters.Add("@NombrePersona", SqlDbType.VarChar).Value = NombrePersona;
                           cmd.Parameters.Add("@Apellido1Persona", SqlDbType.VarChar).Value = Apellido1Persona;
                           cmd.Parameters.Add("@TelefonoPersona", SqlDbType.VarChar).Value = TelefonoPersona;
                           cmd.Parameters.Add("@EmailPersona", SqlDbType.VarChar).Value = EmailPersona;
                           cmd.Parameters.Add("@ContraseñaPersona", SqlDbType.VarChar).Value = ContraseñaPersona;

                           con.Open();
                           cmd.ExecuteNonQuery();
                           return true;
                       }
                       catch (SqlException ex)
                       {
                           MessageBox.Show("La cédula del usuario ingresado ya existe en la base de datos", "Insertar Persona");
                           return false;
                       }

                   }
               }

           } */


        public bool insertarSurcursalSQL(int IDSucursal, string NombreSucursal, string Coordenadas, string Direccion, string CedulaAdmin)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("InsertarSucursal", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ID_Sucursal", SqlDbType.Int).Value = IDSucursal;
                        cmd.Parameters.Add("@Nombre_Sucursal", SqlDbType.VarChar).Value = NombreSucursal;
                        cmd.Parameters.Add("@Coordenadas", SqlDbType.VarChar).Value = Coordenadas;
                        cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Direccion;
                        cmd.Parameters.Add("@Cedula_AdminSucursal", SqlDbType.VarChar).Value = CedulaAdmin;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("El ID de la sucursal ingresada ya existe en la base de datos S-mart"
                        , "Insertar Sucursal"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation
                        , MessageBoxDefaultButton.Button1);

                        return false;
                    }
                }
            }
        }


        /*Metodo para cargar un combobox*/
        public void cargaCombobox(ComboBox c1, string consulta)
        {          
            SqlDataReader datos = null;
            datos = ejecutarConsulta(consulta);
            
            if(datos != null)
            {
                while (datos.Read())
                {
                    c1.Items.Add(datos.GetString(0));
                }
            }            
        }


        public void cargaComboboxID(ComboBox c1, string consulta)
        {
            SqlDataReader datos = null;
            datos = ejecutarConsulta(consulta);

            if (datos != null)
            {
                while (datos.Read())
                {
                    c1.Items.Add(datos.GetInt32(0));
                }
            }
        }

        /*Método para verificar existencia de dato en una consulta */
        public bool existe(string consulta)
        {

            SqlDataReader datos = null;
            datos = ejecutarConsulta(consulta);

            if (datos != null)
            {
                if (datos.Read())
                {

                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }
        }

        /*Método para actualizar un dataGrid*/
        public void llenarTabla(string consulta, DataGridView datagridView)
        {
            DataTable tabla = null;
            try
            {
                tabla = ejecutarConsultaTabla(consulta);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tabla;

                datagridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                datagridView.DataSource = bindingSource;
                for (int i = 0; i < datagridView.ColumnCount; i++)
                {                    
                    datagridView.Columns[i].Width = 150;
                }
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }
    }
}
