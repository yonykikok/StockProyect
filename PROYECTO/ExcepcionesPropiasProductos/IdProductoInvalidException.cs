using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class IdProductoInvalidException : Exception
    {
        public IdProductoInvalidException(string mensaje) : base(mensaje)
        {

        }
        public IdProductoInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
