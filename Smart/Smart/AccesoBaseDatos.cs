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
                        MessageBox.Show("El còdigo de barras externo ingresado ya existe en la base de datos S-mart", "Insertar producto");
                        return false;
                    }

                }
            }
       
        }

        /*Metodo para cargar un combobox*/
        public void cargaCombobox(ComboBox c1, string consulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
                while (datos.Read())
                {
                    c1.Items.Add(datos.GetString(0));
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
