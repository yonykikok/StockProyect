using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Carrito
    {
        static private List<Compra> compras;
        private int descuento;
        private float subTotal;
        private float total;
        static Carrito()
        {
            Compras = new List<Compra>();
        }
        public Carrito(int cantidad, int descuento, float subTotal, float total) 
        {
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }

        public static List<Compra> Compras { get => compras; set => compras = value; }
        public float Total { get => total; set => total = value; }
        public float SubTotal { get => subTotal; set => subTotal = value; }
        public int Descuento { get => descuento; set => descuento = value; }




    }
}
