using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class StockMinimoInvalidException : Exception
    {
        public StockMinimoInvalidException(string mensaje) : base(mensaje)
        {

        }
        public StockMinimoInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
