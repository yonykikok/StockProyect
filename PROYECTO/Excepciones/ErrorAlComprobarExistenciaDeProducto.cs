﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorAlComprobarExistenciaDeProducto : Exception
    {
        public ErrorAlComprobarExistenciaDeProducto(string mensaje) : base(mensaje)
        {

        }
        public ErrorAlComprobarExistenciaDeProducto(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
