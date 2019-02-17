using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocios;
namespace CapaDeDatos
{
    public class ClientesLog
    {
        public static void GuardarLogHistorialClientes(Carrito carrito, string impuestoIVA)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\log.txt";
            StreamWriter writer;
            if (!(File.Exists(path)))
            {
                writer = new StreamWriter(path, true);
                writer.WriteLine("Fecha y Hora; Codigo; Descripcion; Cantidad; Precio; CostoFinal");
            }
            else
            {
                writer = new StreamWriter(path, true);
            }
            writer.Write(carrito.GenerarLogDeCompra(impuestoIVA));
            writer.Close();
        }
        /// <summary>
        /// Obtiene El Log De 'Una' Venta.
        /// </summary>
        /// <param name="compras"></param>
        public static LogVenta ObtenerLogDeUnaVenta(string[] compras)
        {
            LogVenta retorno = null;
            string fecha = null;
            string codigo = null;
            string descripcion = null;
            string cantidad = null;
            string precio = null;
            string costoFinal = null;
            int contador = 0;
            foreach (string auxDato in compras)
            {
                switch (contador)
                {
                    case 0:
                        fecha = auxDato;
                        break;
                    case 1:
                        codigo = auxDato;
                        break;
                    case 2:
                        descripcion = auxDato;
                        break;
                    case 3:
                        cantidad = auxDato;
                        break;
                    case 4:
                        precio = auxDato;
                        break;
                    case 5:
                        costoFinal = auxDato;
                        break;
                }
                contador++;
            }
            retorno = ConvertirDatosEnObjetoLogVenta(fecha, codigo, descripcion, cantidad, precio, costoFinal);
            return retorno;
        }
        /// <summary>
        /// actualiza la lista, si el log ya esta en la lista actualiza la cantidad vendida, si no esta en la lista lo agrega.
        /// </summary>
        /// <param name="log">log de la venta a verificar/ actualizar.</param>
        /// <param name="listaLogs"> lista de logs a recorrer.</param>
        public static void ActualizarLista(LogVenta log,List<LogVenta> listaLogs)
        {
            int bandera = 0;
            foreach (LogVenta auxLog in listaLogs)
            {
                bandera = 0;
                if (log.Codigo == auxLog.Codigo)
                {
                    auxLog.Cantidad += log.Cantidad;//si ya se encuentra en la lista suma la cantidad a al item ya existente y cambia la bandera a 1. 
                    bandera = 1;
                    break;
                }
            }
            if (bandera == 0)//si la bandera esta en 0, es porque es un item nuevo y lo agrega.
            {
                listaLogs.Add(log);
            }
        }
        public static List<LogVenta> LeerHistorialDeVentas()
        {            
            List<LogVenta> listaLogs = new List<LogVenta>();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\log.txt";
            StreamReader reader = null;
            if (File.Exists(path))//verifico si exite el archivo
            {
                reader = new StreamReader(path);
                string lineaLeida = reader.ReadLine();
                lineaLeida.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");//ignoramos la primera linea ya que es la descripcion.
                while (lineaLeida != null)
                {
                    lineaLeida = reader.ReadLine();
                    if (lineaLeida is null)//si es el final del archivo rompe el while.
                    { break; }

                    lineaLeida.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");//remuevo los salto de lineas de la linea leida 
                    string[] compras = lineaLeida.Split(';');//separamos las palabras.

                    LogVenta log = ObtenerLogDeUnaVenta(compras);
                    ActualizarLista(log, listaLogs);                    
                }
                reader.Close();
            }
            return listaLogs;
        }
        /// <summary>
        /// verifica los datos de y devuevle un logVenta si los datos son correctos
        /// </summary>
        /// <param name="strFecha"></param>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="strCantidad"></param>
        /// <param name="strPrecio"></param>
        /// <param name="strCostoFinal"></param>
        /// <returns></returns>
        public static LogVenta ConvertirDatosEnObjetoLogVenta(string strFecha, string codigo, string descripcion, string strCantidad, string strPrecio, string strCostoFinal)
        {
            DateTime fecha;
            LogVenta retorno = null;
            int cantidad;
            float precio;
            float costoFinal;
            if (!(codigo is null) && !(descripcion is null))
            {
                if (DateTime.TryParse(strFecha, out fecha))
                {
                    if (Int32.TryParse(strCantidad, out cantidad))
                    {
                        if (float.TryParse(strPrecio, out precio))
                        {
                            if (float.TryParse(strCostoFinal, out costoFinal))
                            {
                                retorno = new LogVenta(fecha, codigo, descripcion, cantidad, precio, costoFinal);
                            }
                        }
                    }
                }
            }
            return retorno;
        }
    }
}
