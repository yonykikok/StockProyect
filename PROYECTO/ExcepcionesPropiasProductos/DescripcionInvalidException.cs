using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class DescripcionInvalidException : Exception
    {
        public DescripcionInvalidException(string mensaje) : base(mensaje)
        {

        }
        public DescripcionInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
