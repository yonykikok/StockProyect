using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class NombreYApellidoException : Exception
    {
        public NombreYApellidoException(string mensaje) : base(mensaje)
        {

        }
        public NombreYApellidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
