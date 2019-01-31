using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class AdressInvalidException : Exception
    {
        public AdressInvalidException(string mensaje):base(mensaje)
        {

        }
        public AdressInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
