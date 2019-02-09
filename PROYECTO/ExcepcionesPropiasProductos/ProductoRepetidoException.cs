using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class ProductoRepetidoException : Exception
    {
        public ProductoRepetidoException(string mensaje) : base(mensaje)
        {

        }
        public ProductoRepetidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
