using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class TrabajoARealizarException : Exception
    {
        public TrabajoARealizarException(string mensaje) : base(mensaje)
        {

        }
        public TrabajoARealizarException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
