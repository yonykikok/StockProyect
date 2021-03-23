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
        private static string stringDeConexion = "Data Source=DESKTOP-HGEBRUB\\MSSQLSERVER01;Initial Catalog=Multitask; Integrated Security=True";
        private static SqlConnection conexionADB;
        private static SqlCommand comando;
        private static SqlDataReader dataReader;

        static ProductosDAO()// establece la conexion con SQL 
        {
            conexionADB = new SqlConnection();
            conexionADB.ConnectionString = stringDeConexion;
        }

        public static bool LeerProductoPorCodigo(Producto producto)
        {
            bool retorno = false;
            conexionADB.Open();
            comando = new SqlCommand("SELECT Code FROM Productos", conexionADB);
            dataReader = comando.ExecuteReader();
            while (dataReader.Read())
            {
                string auxCodigo = dataReader["Code"].ToString();
                if (auxCodigo == producto.Codigo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static Producto ObtenerProductoPorCodigo(string codigo)
        {
            Producto retorno = null; ;
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Description,Code,Stock,IdealStock,MinimumStock,Price,Id,Img FROM Productos", conexionADB);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    string auxCode = dataReader["Code"].ToString().ToLower();
                    string auxDescription = dataReader["Description"].ToString().ToLower();
                    string auxImagen = dataReader["Img"].ToString().ToLower();
                    int auxStock = Convert.ToInt32(dataReader["Stock"].ToString());
                    int auxIdealStock = Convert.ToInt32(dataReader["IdealStock"].ToString());
                    int auxMinimumStock = Convert.ToInt32(dataReader["MinimumStock"].ToString());
                    float auxPrice = (float)Convert.ToDouble(dataReader["Price"].ToString());
                    int auxId = Convert.ToInt32(dataReader["Id"].ToString());
                    if (auxCode == codigo)
                    {
                        retorno = new Producto(auxCode, auxDescription, auxStock, auxIdealStock, auxMinimumStock, auxPrice,auxImagen, auxId);
                        break;
                    }
                }
                conexionADB.Close();
            }
            catch (ErrorAlComprobarExistenciaDeProducto exception)
            {
                throw new ErrorAlComprobarExistenciaDeProducto("Error al comprobar la existencia del producto 'Codigo: " + codigo + "'", exception);
            }
            catch (Exception exception)
            {

            }
            return retorno;
        }
        public static Producto ObtenerProductoPorId(int id)
        {
            Producto retorno = null; ;
            try
            {
                conexionADB.Open();
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
                    if (auxId == id)
                    {
                        retorno = new Producto(auxCode, auxDescription, auxStock, auxIdealStock, auxMinimumStock, auxPrice, auxId);
                        break;
                    }
                }
                conexionADB.Close();
            }
            catch (ErrorAlComprobarExistenciaDeProducto exception)
            {
                throw new ErrorAlComprobarExistenciaDeProducto("Error al comprobar la existencia del producto 'Id: " + id + "'", exception);
            }
            catch (Exception exception)
            {

            }
            return retorno;
        }
        public static bool ComprobarExistenciaDeProducto(Producto producto)
        {
            bool retorno = false;
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Code,Description FROM Productos", conexionADB);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    string auxCode = dataReader["Code"].ToString().ToLower();
                    string auxDescription = dataReader["Description"].ToString().ToLower();
                    if (auxCode == producto.Codigo || auxDescription == producto.Descripcion)
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
                comando = new SqlCommand(string.Format("INSERT INTO Productos (Code,Description,Stock,IdealStock,MinimumStock,Price,img) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio, producto.Imagen), conexionADB);
                comando.ExecuteNonQuery();
                conexionADB.Close();
            }
            else
            {
                throw new ProductoRepetidoException("El Procuto ya se encuentra en la lista");
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
            try
            {
                conexionADB.Open();
                comando = new SqlCommand(string.Format("UPDATE Productos SET Code = '{0}' , Description = '{1}' , Stock = '{2}', IdealStock = '{3}', MinimumStock = '{4}', Price = '{5}', img = '{6}' WHERE id = {7}", producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio, producto.Imagen, producto.Id), conexionADB);
                comando.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new Exception("Error al modificar un producto en ProductosDAO");
            }
            finally
            {
                conexionADB.Close();
            }

        }
        public static void ModificarImagenDelProducto(Producto producto)
        {
            conexionADB.Open();
            comando = new SqlCommand(string.Format("UPDATE Productos SET img = '{0}' WHERE id = {1}", producto.Imagen, producto.Id), conexionADB);
            comando.ExecuteNonQuery();
            conexionADB.Close();
        }
        /// <summary>
        /// busca productos en la base de datos que contengan el string pasado como argumento, lo busca en Codigo y Descripcion.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static List<Producto> LeerProductos(string codigo)
        {
            List<Producto> retorno = null;
            try
            {
                conexionADB.Open();
                int contador = 0;
                comando = new SqlCommand("SELECT Description,Code,Stock,IdealStock,MinimumStock,Price,Id,img FROM Productos", conexionADB);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    string auxCode = dataReader["Code"].ToString().ToLower();
                    string auxDescription = dataReader["Description"].ToString().ToLower();
                    string auxImg = dataReader["img"].ToString().ToLower();
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
                        Producto auxProducto = new Producto(auxCode, auxDescription, Convert.ToInt32(auxStock), auxIdealStock, auxMinimumStock, auxPrice, auxImg, auxId);
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


        public static List<Producto> LeerProductos()
        {
            List<Producto> retorno = new List<Producto>();
            try
            {
                conexionADB.Open();
                comando = new SqlCommand("SELECT Description,Code,Stock,IdealStock,MinimumStock,Price,Id,img FROM Productos", conexionADB);
                dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    string auxCode = dataReader["Code"].ToString().ToLower();
                    string auxDescription = dataReader["Description"].ToString().ToLower();
                    string auxImg = dataReader["img"].ToString().ToLower();
                    int auxStock = Convert.ToInt32(dataReader["Stock"].ToString());
                    int auxIdealStock = Convert.ToInt32(dataReader["IdealStock"].ToString());
                        int auxMinimumStock = Convert.ToInt32(dataReader["MinimumStock"].ToString());
                    float auxPrice = (float)Convert.ToDouble(dataReader["Price"].ToString());
                    int auxId = Convert.ToInt32(dataReader["Id"].ToString());                   
                    Producto auxProducto = new Producto(auxCode, auxDescription, Convert.ToInt32(auxStock), auxIdealStock, auxMinimumStock, auxPrice, auxImg, auxId);
                    retorno.Add(auxProducto);
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
