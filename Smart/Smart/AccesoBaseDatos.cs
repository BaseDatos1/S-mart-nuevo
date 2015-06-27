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
        String conexion = "Data Source=10.1.4.59; Initial Catalog=Supermercado_inteligente; Integrated Security=SSPI";
       
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
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
            return datos;
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
                        MessageBox.Show("El còdigo de barras externo ingresado ya existe en la base de datos S-mart o se ingresó una marca inválida", "Insertar producto");
                        return false;
                    }

                }
            }
       
        }

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
                        MessageBox.Show("La cédula del usuario ingresado ya existe en la base de datos", "Insertar Persona");
                        return false;
                    }

                }
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
                    datagridView.Columns[i].Width = 100;
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
