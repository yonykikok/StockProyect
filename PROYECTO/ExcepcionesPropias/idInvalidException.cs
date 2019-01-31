using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class idInvalidException : Exception
    {
        public idInvalidException(string mensaje):base(mensaje)
        {

        }
        public idInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
