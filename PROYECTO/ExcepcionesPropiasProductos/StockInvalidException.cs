using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropiasProductos
{
    public class StockInvalidException : Exception
    {
        public StockInvalidException(string mensaje) : base(mensaje)
        {

        }
        public StockInvalidException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
