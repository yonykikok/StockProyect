using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class PasswordInvalidException : Exception
    {
        public PasswordInvalidException(string mensaje):base(mensaje)
        {

        }
        public PasswordInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
