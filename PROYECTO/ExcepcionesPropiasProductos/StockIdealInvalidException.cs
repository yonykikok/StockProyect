using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class StockIdealInvalidException : Exception
    {
        public StockIdealInvalidException(string mensaje) : base(mensaje)
        {

        }
        public StockIdealInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
