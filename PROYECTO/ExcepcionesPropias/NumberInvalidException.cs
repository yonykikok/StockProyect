using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class NumberInvalidException : Exception
    {
        public NumberInvalidException(string mensaje):base(mensaje)
        {

        }
        public NumberInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
