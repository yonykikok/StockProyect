using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class SeniaException : Exception
    {
        public SeniaException(string mensaje) : base(mensaje)
        {

        }
        public SeniaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
