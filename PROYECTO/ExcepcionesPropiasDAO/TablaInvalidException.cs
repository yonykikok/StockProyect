using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasDAO
{
    public class TablaInvalidException : Exception
    {
        public TablaInvalidException(string mensaje) : base(mensaje)
        {

        }
        public TablaInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
