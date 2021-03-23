using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocios;
using ExcepcionesPropiasDAO;
namespace CapaDeDatos
{
    public static class ClientesDAO
    {
        private static string stringDeConexion = "Data Source=DESKTOP-HGEBRUB\\MSSQLSERVER01;Initial Catalog=Multitask; Integrated Security=True";
        private static SqlConnection conexionADB;
        private static SqlCommand comando;
        private static SqlDataReader dataReader;

        static ClientesDAO()// establece la conexion con SQL 
        {
            conexionADB = new SqlConnection();
            conexionADB.ConnectionString = stringDeConexion;
        }
        /// <summary>
        /// Lee todos los Clientes de la Base de Datos. y devuelve una lista con todos los clientes
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> LeerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Name,LastName,Dni,Adress,Dni,Adress,MailAdress,Number,Id FROM Clientes", conexionADB);
                dataReader = comando.ExecuteReader();
                Cliente cliente = null;
                while (dataReader.Read())
                {
                    int id;
                    string auxNombre = dataReader["Name"].ToString();
                    string auxApellido = dataReader["LastName"].ToString();
                    string auxDni = dataReader["Dni"].ToString();
                    string auxDireccion = dataReader["Adress"].ToString();
                    string auxMail = dataReader["MailAdress"].ToString();
                    string auxNumero = dataReader["Number"].ToString();
                    Int32.TryParse(dataReader["Id"].ToString(), out id);

                    cliente = new Cliente(auxNombre,auxApellido,auxDni,auxDireccion, auxMail, auxNumero,id);
                    clientes.Add(cliente);
                }
            }
            catch (Exception exception)
            {
                if(exception.Message=="Invalid object name 'Clientes'.")
                {
                    throw new TablaInvalidException("Error, al conectarse con la tabla 'Clientes'. InnerException: " + exception.Message + "\nSugerencia: Puede que la tabla no se encuentre en la base de datos");
                }

            }
            finally
            {
                conexionADB.Close();
            }
            return clientes;
        }
        public static void Modificar(Cliente cliente)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("UPDATE Clientes SET Name = '{0}' , LastName = '{1}', Dni = '{2}', Adress = '{3}', MailAdress = '{4}', Number = '{5}' WHERE id = {6}", cliente.Name, cliente.LastName, cliente.Dni, cliente.Adress, cliente.MailAdress, cliente.Numero, cliente.Id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public static void InsertarUsuario(Cliente cliente)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("INSERT INTO Clientes (Name,LastName,Dni,Adress,MailAdress,Number) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",cliente.Name, cliente.LastName, cliente.Dni, cliente.Adress, cliente.MailAdress, cliente.Numero), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
    }
}
