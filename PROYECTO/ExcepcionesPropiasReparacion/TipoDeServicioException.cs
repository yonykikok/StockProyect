using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class TipoDeServicioException : Exception
    {
        public TipoDeServicioException(string mensaje) : base(mensaje)
        {

        }
        public TipoDeServicioException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
