using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class SaldoException : Exception
    {
        public SaldoException(string mensaje) : base(mensaje)
        {

        }
        public SaldoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
