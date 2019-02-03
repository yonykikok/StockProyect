using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocios;
using ExcepcionesPropias;
using ExcepcionesPropiasProductos;
namespace CapaDeDatos
{
    public class ProductosDAO
    {
        private static string stringDeConexion = "Data Source=MULTITASK\\SQLEXPRESS;Initial Catalog=Multitask; Integrated Security=True";
        private static SqlConnection conexionADB;
        private static SqlCommand comando;
        private static SqlDataReader dataReader;

        static ProductosDAO()// establece la conexion con SQL 
        {
            conexionADB = new SqlConnection();
            conexionADB.ConnectionString = stringDeConexion;
        }

        public static bool ComprobarExistenciaDeProducto(Producto producto)
        {
            bool retorno = false;
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Code FROM Productos", conexionADB);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    string auxCode = dataReader["Code"].ToString().ToLower();
                    if (auxCode == producto.Codigo)
                    {
                        retorno = true;
                        break;
                    }
                }
                conexionADB.Close();
            }
            catch (ErrorAlComprobarExistenciaDeProducto exception)
            {
                throw new ErrorAlComprobarExistenciaDeProducto("Error al comprobar la existencia del producto 'Codigo: " + producto.Codigo + "'", exception);
            }
            catch (Exception exception)
            {

            }
            return retorno;
        }
        public static void InsertarProducto(Producto producto)
        {
            if (ComprobarExistenciaDeProducto(producto) == false)
            {
                conexionADB.Open();
                comando = new SqlCommand(string.Format("INSERT INTO Productos (Code,Description,Stock,IdealStock,MinimumStock,Price) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio), conexionADB);
                comando.ExecuteNonQuery();
                conexionADB.Close();
            }
        }

        public static void Remover(Producto producto)
        {
            if (ComprobarExistenciaDeProducto(producto))
            {
                conexionADB.Open();
                comando = new SqlCommand(string.Format("DELETE FROM Productos WHERE Id={0}", producto.Id), conexionADB);
                comando.ExecuteNonQuery();
                conexionADB.Close();
            }
        }
        public static void ModificarProducto(Producto producto)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("UPDATE Productos SET Code = '{0}' , Description = '{1}' , Stock = '{2}', IdealStock = '{3}', MinimumStock = '{4}', Price = '{5}' WHERE id = {6}", producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio, producto.Id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        public static List<Producto> LeerProductos(string codigo)
        {
            List<Producto> retorno = null;
            try
            {

                conexionADB.Open();
                int contador = 0;
                comando = new SqlCommand("SELECT Description,Code,Stock,IdealStock,MinimumStock,Price,Id FROM Productos", conexionADB);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    string auxCode = dataReader["Code"].ToString().ToLower();
                    string auxDescription = dataReader["Description"].ToString().ToLower();
                    int auxStock = Convert.ToInt32(dataReader["Stock"].ToString());
                    int auxIdealStock = Convert.ToInt32(dataReader["IdealStock"].ToString());
                    int auxMinimumStock = Convert.ToInt32(dataReader["MinimumStock"].ToString());
                    float auxPrice = (float)Convert.ToDouble(dataReader["Price"].ToString());
                    int auxId = Convert.ToInt32(dataReader["Id"].ToString());
                    if (auxCode.Contains(codigo.ToLower()) || auxDescription.Contains(codigo.ToLower()))
                    {
                        if (contador == 0)
                        {
                            retorno = new List<Producto>();
                            contador++;
                        }
                        Producto auxProducto = new Producto(auxCode, auxDescription, Convert.ToInt32(auxStock), auxIdealStock, auxMinimumStock, auxPrice, auxId);
                        retorno.Add(auxProducto);
                    }

                }
            }
            catch (Exception exception)
            {
                throw new ConexionDBException(exception.Message);
            }
            finally
            {
                conexionADB.Close();
            }
            return retorno;
        }
    }
}
