using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class TipoDeEquipoException : Exception
    {
        public TipoDeEquipoException(string mensaje) : base(mensaje)
        {

        }
        public TipoDeEquipoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
