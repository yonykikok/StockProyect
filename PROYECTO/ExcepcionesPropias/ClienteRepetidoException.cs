using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class ClienteRepetidoException : Exception
    {
        public ClienteRepetidoException(string mensaje) : base(mensaje)
        {

        }
        public ClienteRepetidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
