using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Carrito : Articulo
    {
        private string CodigoDeProducto;
        private string descripcion;
        private int cantidad;
        private int descuento;
        private float precio;
        private float subTotal;
        private float total;

        public Carrito(string codigoDeProducto,string descripcion,float precio, int cantidad, int descuento,float subTotal,float total):base(codigoDeProducto,descripcion,precio)
        {
            Codigo = codigoDeProducto;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }

        public float Total { get => total; set => total = value; }
        public float SubTotal { get => subTotal; set => subTotal = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Descuento { get => descuento; set => descuento = value; }

       


    }
}
