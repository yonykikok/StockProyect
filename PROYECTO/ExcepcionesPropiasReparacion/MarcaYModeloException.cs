using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasReparacion
{
    public class MarcaYModeloException : Exception
    {
        public MarcaYModeloException(string mensaje) : base(mensaje)
        {

        }
        public MarcaYModeloException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
