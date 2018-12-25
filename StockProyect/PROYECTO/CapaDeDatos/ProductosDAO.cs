using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocios;
namespace CapaDeDatos
{
    public class ProductosDAO
    {
        string stringDeConexion = "Data Source=DESKTOP-7ETOVJD;Initial Catalog=Multitask; Integrated Security=True";
        SqlConnection conexionADB;
        SqlCommand comando;
        SqlDataReader dataReader;

        public ProductosDAO()// establece la conexion con SQL 
        {
            conexionADB = new SqlConnection();
            conexionADB.ConnectionString = stringDeConexion;
        }

        public void Insertar(string Usuario, string Password)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("INSERT INTO Productos (Usuario,Password) VALUES ('{0}','{1}')", Usuario, Password), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public void Remover(string usuario)//remueve un elemento por el dato pasado
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("DELETE FROM Productos WHERE Usuario= {0}", usuario), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public void Modificar(int id, string dato, string dato2)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("UPDATE Productos SET nombre = '{0}' , apellido = '{1}' WHERE id = {2}", dato, dato2, id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public List<Producto> LeerProductos(string codigo)
        {
            List<Producto> retorno = null;
            conexionADB.Open();
            int contador = 0;
            comando = new SqlCommand("SELECT Description,Code,Stock,IdealStock,MinimumStock,Price FROM Productos", conexionADB);
            dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                string auxCode = dataReader["Code"].ToString().ToLower();
                string auxDescription = dataReader["Description"].ToString().ToLower();
                int auxStock = Convert.ToInt32(dataReader["Stock"].ToString());
                int auxIdealStock = Convert.ToInt32(dataReader["IdealStock"].ToString());
                int auxMinimumStock = Convert.ToInt32(dataReader["MinimumStock"].ToString());
                float auxPrice = (float)Convert.ToDouble(dataReader["Price"].ToString());
                if (auxCode.Contains(codigo.ToLower()) || auxDescription.Contains(codigo.ToLower()))
                {
                    if (contador == 0)
                    {
                        retorno = new List<Producto>();
                        contador++;
                    }
                    Producto auxProducto = new Producto(auxCode, auxDescription, Convert.ToInt32(auxStock), auxIdealStock, auxMinimumStock, auxPrice);
                    retorno.Add(auxProducto);
                }

            }
            conexionADB.Close();
            return retorno;
        }/*
        public Producto LeerUsuarioCompleto(Producto empleado)
        {
            Producto retorno = null;
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
                        retorno = new Producto(empleado.User, empleado.Password, auxName, auxLastName, auxDni, auxAdress, auxMailAdress, tipo);
                        break;
                    }
                    else if (auxUsuario == empleado.User && auxContraseña != empleado.Password)
                    {
                        retorno = new Producto(auxUsuario, "InvalidPass");
                    }
                    else
                    {
                        retorno = new Producto("InvalidUser", "InvalidPass");
                    }
                }
                else if (auxUsuario != empleado.User && auxContraseña == empleado.Password)
                {
                    retorno = new Producto("InvalidUser", auxContraseña);
                }


            }
            conexionADB.Close();
            return retorno;
        }
        public List<Producto> Leer(List<Producto> empleados)
        {
            conexionADB.Open();
            comando = new SqlCommand("SELECT Dni,Contraseña FROM Usuarios", conexionADB);
            dataReader = comando.ExecuteReader();
            Producto empleado = null;
            while (dataReader.Read())
            {
                string auxDni = dataReader["Dni"].ToString();
                string auxContraseña = dataReader["Contraseña"].ToString();
                empleado = new Producto(auxContraseña, auxDni);
                empleados.Add(empleado);
            }
            conexionADB.Close();
            return empleados;
        }*/
    }
}
