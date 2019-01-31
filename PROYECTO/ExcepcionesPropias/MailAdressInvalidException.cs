using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias
{
    public class MailAdressInvalidException : Exception
    {
        public MailAdressInvalidException(string mensaje):base(mensaje)
        {

        }
        public MailAdressInvalidException(string mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
