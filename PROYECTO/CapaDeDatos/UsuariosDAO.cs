using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDeNegocios;
using ExcepcionesPropiasDAO;
namespace CapaDeDatos
{
    public class UsuariosDAO
    {
        private static string stringDeConexion = "Data Source=DESKTOP-HGEBRUB\\MSSQLSERVER01;Initial Catalog=Multitask; Integrated Security=True";
        private static SqlConnection conexionADB;
        private static SqlCommand comando;
        private static SqlDataReader dataReader;

        static UsuariosDAO()// establece la conexion con SQL 
        {
            conexionADB = new SqlConnection();
            conexionADB.ConnectionString = stringDeConexion;
        }

        public static void InsertarUsuario(Empleado empleado)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("INSERT INTO Usuarios (Usuario,Password,Name,LastName,Dni,Adress,MailAdress,UserType) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", empleado.User, empleado.Password, empleado.Name, empleado.LastName, empleado.Dni, empleado.Adress, empleado.MailAdress, empleado.Type), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public static void Remover(Empleado usuario)//remueve un elemento por el dato pasado
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("DELETE FROM Usuarios WHERE Id= {0}", usuario.Id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public static void Modificar(Empleado empleado)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("UPDATE Usuarios SET Usuario = '{0}' , Password = '{1}', Name = '{2}', LastName = '{3}', Dni = '{4}', Adress = '{5}', MailAdress = '{6}', UserType = '{7}' WHERE id = {8}", empleado.User, empleado.Password, empleado.Name, empleado.LastName, empleado.Dni, empleado.Adress, empleado.MailAdress, empleado.Type, empleado.Id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public static bool comprobarIdUsuario(Empleado empleado)
        {
            bool retorno = false;
            conexionADB.Open();
            comando = new SqlCommand("SELECT Usuario,Dni FROM Usuarios", conexionADB);
            dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                string auxUsuario = dataReader["Usuario"].ToString();
                string auxDni = dataReader["Dni"].ToString();
                if (auxUsuario == empleado.User || auxDni == empleado.Dni)
                {
                    retorno = true;
                    break;
                }
            }
            conexionADB.Close();
            return retorno;
        }
        /// <summary>
        /// Busca un empleado por usuario y password.
        /// </summary>
        /// <param name="empleado"> es el empleado a ser buscado en la base de datos</param>
        /// <returns> retorna el empleado, si lo encuentra. retorna NULL si, no lo encuentra</returns>
        public static Empleado LeerUsuario(Empleado empleado)
        {
            Empleado retorno = null;
            conexionADB.Open();
            comando = new SqlCommand("SELECT Usuario,Password FROM Usuarios", conexionADB);
            dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                string auxUsuario = dataReader["Usuario"].ToString();
                string auxContraseña = dataReader["Password"].ToString();
                if (auxUsuario == empleado.User)
                {
                    if (auxContraseña == empleado.Password)
                    {
                        retorno = empleado;
                        break;
                    }
                    else
                    {
                        retorno = new Empleado(auxUsuario, "InvalidPass", "Nombre", "Apellido", "Dni", "Direccion", "Gmail@gmail.com", UserType.user);
                    }
                }
                else if (auxUsuario != empleado.User && auxContraseña == empleado.Password)
                {
                    retorno = new Empleado("InvalidUser", auxContraseña, "Nombre", "Apellido", "Dni", "Direccion", "Gmail@gmail.com", UserType.user);
                }
                else
                {
                    retorno = new Empleado("InvalidUser", "InvalidPass", "Nombre", "Apellido", "Dni", "Direccion", "Gmail@gmail.com", UserType.user);
                }
            }
            conexionADB.Close();
            return retorno;
        }
        /// <summary>
        /// Busca un empleado por usuario y password y te devuelve un empleado completo con todos sus datos
        /// </summary>
        /// <param name="empleado"> es el empleado a ser buscado en la base de datos</param>
        /// <returns> retorna el empleado, si lo encuentra. retorna NULL si, no lo encuentra</returns>
        public static Empleado LeerUsuarioCompleto(Empleado empleado)
        {
            Empleado retorno = null;
            try
            {

                conexionADB.Open();
                comando = new SqlCommand("SELECT Usuario,Password,Name,LastName,Dni,Adress,MailAdress,UserType FROM Usuarios", conexionADB);
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    string auxUsuario = dataReader["Usuario"].ToString();
                    string auxContraseña = dataReader["Password"].ToString();
                    string auxName = dataReader["Name"].ToString();
                    string auxLastName = dataReader["LastName"].ToString();
                    string auxDni = dataReader["Dni"].ToString();
                    string auxAdress = dataReader["Adress"].ToString();
                    string auxMailAdress = dataReader["MailAdress"].ToString();
                    string auxUserType = dataReader["UserType"].ToString().ToLower();
                    if (auxUsuario.ToLower() == empleado.User.ToLower())
                    {
                        if (auxContraseña.ToLower() == empleado.Password.ToLower())
                        {
                            UserType tipo;
                            Enum.TryParse<UserType>(auxUserType, out tipo);
                            retorno = new Empleado(empleado.User, empleado.Password, auxName, auxLastName, auxDni, auxAdress, auxMailAdress, tipo);
                            break;
                        }
                        else if (auxUsuario == empleado.User && auxContraseña != empleado.Password)
                        {
                            retorno = new Empleado(auxUsuario, "InvalidPass", "Nombre", "Apellido", "Dni", "Direccion", "Gmail@gmail.com", UserType.user);
                        }
                        else
                        {
                            retorno = new Empleado("InvalidUser", "InvalidPass", "Nombre", "Apellido", "Dni", "Direccion", "Gmail@gmail.com", UserType.user);
                        }
                    }
                    else if (auxUsuario != empleado.User && auxContraseña == empleado.Password)
                    {
                        retorno = new Empleado("InvalidUser", auxContraseña, "Nombre", "Apellido", "Dni", "Direccion", "Gmail@gmail.com", UserType.user);
                    }


                }


            }
            catch (Exception exception)
            {
                if (exception.Message == "Invalid object name 'Usuarios'.")
                {
                    throw new TablaInvalidException("Error, al conectarse con la tabla 'Usuarios'. InnerException: " + exception.Message+"\nSugerencia: Puede que la tabla no se encuentre en la base de datos");
                }
                else
                {
                    throw new ErrorAlConectarConLaBaseDeDatosException("Error Al Conectar Con Las Base De Datos: " + stringDeConexion);
                }
            }

            finally
            {
                conexionADB.Close();
            }
            return retorno;
        }
        public static List<Empleado> LeerUsuarios()
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Usuario,Password,Name,LastName,Dni,Adress,MailAdress,UserType,Id FROM Usuarios", conexionADB);
                dataReader = comando.ExecuteReader();
                Empleado empleado = null;
                while (dataReader.Read())
                {
                    int id;
                    string auxUsuario = dataReader["Usuario"].ToString();
                    string auxPassword = dataReader["Password"].ToString();
                    string auxName = dataReader["Name"].ToString();
                    string auxLastName = dataReader["LastName"].ToString();
                    string auxDni = dataReader["Dni"].ToString();
                    string auxAdress = dataReader["Adress"].ToString();
                    string auxMailAdress = dataReader["MailAdress"].ToString();
                    string auxUserType = dataReader["UserType"].ToString();
                    Int32.TryParse(dataReader["Id"].ToString(), out id);
                    UserType type;
                    Enum.TryParse<UserType>(auxUserType, out type);//convierte un string a un tipo de enumerado.
                    empleado = new Empleado(auxUsuario, auxPassword, auxName, auxLastName, auxDni, auxAdress, auxMailAdress, type, id);
                    empleados.Add(empleado);
                }
            }
            catch (Exception exception)
            {

            }
            finally
            {
                conexionADB.Close();
            }
            return empleados;
        }
    }
}
