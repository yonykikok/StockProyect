using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDeNegocios;
namespace CapaDeDatos
{
    public class UsuariosDAO
    {
        string stringDeConexion = "Data Source=DESKTOP-7ETOVJD;Initial Catalog=Multitask; Integrated Security=True";
        SqlConnection conexionADB;
        SqlCommand comando;
        SqlDataReader dataReader;

        public UsuariosDAO()// establece la conexion con SQL 
        {
            conexionADB = new SqlConnection();
            conexionADB.ConnectionString = stringDeConexion;
        }

        public void Insertar(string Usuario, string Password)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("INSERT INTO Usuarios (Usuario,Password) VALUES ('{0}','{1}')", Usuario, Password), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public void Remover(string usuario)//remueve un elemento por el dato pasado
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("DELETE FROM Usuarios WHERE Usuario= {0}", usuario), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public void Modificar(int id, string dato, string dato2)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("UPDATE Usuarios SET nombre = '{0}' , apellido = '{1}' WHERE id = {2}", dato, dato2, id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public Empleado LeerUsuario(Empleado empleado)
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
                        retorno = new Empleado(auxUsuario, "InvalidPass");
                    }
                }
                else if (auxUsuario != empleado.User && auxContraseña == empleado.Password)
                {
                    retorno = new Empleado("InvalidUser", auxContraseña);
                }
                else
                {
                    retorno = new Empleado("InvalidUser", "InvalidPass");
                }
            }
            conexionADB.Close();
            return retorno;
        }
        public Empleado LeerUsuarioCompleto(Empleado empleado)
        {
            Empleado retorno = null;
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
                        retorno = new Empleado(auxUsuario, "InvalidPass");
                    }
                    else
                    {
                        retorno = new Empleado("InvalidUser", "InvalidPass");
                    }
                }
                else if (auxUsuario != empleado.User && auxContraseña == empleado.Password)
                {
                    retorno = new Empleado("InvalidUser", auxContraseña);
                }

            
            }
            conexionADB.Close();
            return retorno;
        }
        public List<Empleado> Leer(List<Empleado> empleados)
        {
            conexionADB.Open();
            comando = new SqlCommand("SELECT Dni,Contraseña FROM Usuarios", conexionADB);
            dataReader = comando.ExecuteReader();
            Empleado empleado = null;
            while (dataReader.Read())
            {
                string auxDni = dataReader["Dni"].ToString();
                string auxContraseña = dataReader["Contraseña"].ToString();
                empleado = new Empleado(auxContraseña, auxDni);
                empleados.Add(empleado);
            }
            conexionADB.Close();
            return empleados;
        }
    }
}
