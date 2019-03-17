using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class PrecioException : Exception
    {
        public PrecioException(string mensaje) : base(mensaje)
        {

        }
        public PrecioException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
