using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class NameInvalidException : Exception
    {
        public NameInvalidException(string mensaje):base(mensaje)
        {

        }
        public NameInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
