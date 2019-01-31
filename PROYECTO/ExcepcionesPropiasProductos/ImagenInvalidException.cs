using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class ImagenInvalidException : Exception
    {
        public ImagenInvalidException(string mensaje) : base(mensaje)
        {

        }
        public ImagenInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
