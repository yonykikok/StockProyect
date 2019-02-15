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
        public static void GuardarLogHistorialClientes(Carrito carrito,string impuestoIVA)
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
    }
}
