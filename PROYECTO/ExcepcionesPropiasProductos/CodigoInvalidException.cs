using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class CodigoInvalidException : Exception
    {
        public CodigoInvalidException(string mensaje) : base(mensaje)
        {

        }
        public CodigoInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
