using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class LastNameInvalidException : Exception
    {
        public LastNameInvalidException(string mensaje):base(mensaje)
        {

        }
        public LastNameInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
