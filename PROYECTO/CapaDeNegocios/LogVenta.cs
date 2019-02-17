using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class LogVenta
    {
        private DateTime fecha;
        private string codigo;
        private string descripcion;
        private int cantidad;
        private float precio;
        private float costoFinal;

        public LogVenta(DateTime fecha,string codigo,string descripcion,int cantidad,float precio,float costoFinal)
        {
            this.Fecha = fecha;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.CostoFinal = costoFinal;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public float CostoFinal { get => costoFinal; set => costoFinal = value; }
    }
}
