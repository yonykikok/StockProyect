using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class PrecioInvalidException : Exception
    {
        public PrecioInvalidException(string mensaje) : base(mensaje)
        {

        }
        public PrecioInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
