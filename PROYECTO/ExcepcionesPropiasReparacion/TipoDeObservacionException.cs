using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class TipoDeObservacionException : Exception
    {
        public TipoDeObservacionException(string mensaje) : base(mensaje)
        {

        }
        public TipoDeObservacionException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
