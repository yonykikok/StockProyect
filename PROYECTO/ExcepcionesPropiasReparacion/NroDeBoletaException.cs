using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class NroDeBoletaException : Exception
    {
        public NroDeBoletaException(string mensaje) : base(mensaje)
        {

        }
        public NroDeBoletaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
