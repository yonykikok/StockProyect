using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class UserTypeInvalidException : Exception
    {
        public UserTypeInvalidException(string mensaje):base(mensaje)
        {

        }
        public UserTypeInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
