using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasDAO
{
    public class ErrorAlConectarConLaBaseDeDatosException : Exception
    {
        public ErrorAlConectarConLaBaseDeDatosException(string mensaje) : base(mensaje)
        {

        }
        public ErrorAlConectarConLaBaseDeDatosException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
