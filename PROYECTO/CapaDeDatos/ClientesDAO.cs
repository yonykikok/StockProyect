using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocios;
namespace CapaDeDatos
{
    public static class ClientesDAO
    {
        private static string stringDeConexion = "Data Source=MULTITASK\\SQLEXPRESS;Initial Catalog=Multitask; Integrated Security=True";
        private static SqlConnection conexionADB;
        private static SqlCommand comando;
        private static SqlDataReader dataReader;

        public static List<Cliente> LeerUsuarios()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Usuario,Password,Name,LastName,Dni,Adress,MailAdress,UserType,Id FROM Usuarios", conexionADB);
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

                    cliente = new Cliente(auxNombre,auxApellido,auxDni,auxDireccion, auxMail, auxNumero);
                    clientes.Add(cliente);
                }
            }
            catch (Exception exception)
            {

            }
            finally
            {
                conexionADB.Close();
            }
            return clientes;
        }
    }
}
