using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class UsuarioInvalidException : Exception
    {
        public UsuarioInvalidException(string mensaje):base(mensaje)
        {

        }
        public UsuarioInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
