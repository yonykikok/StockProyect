using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Carrito
    {
        private List<Compra> compras;
        private int descuento;
        private float subTotal;
        private float total;
        private Carrito()
        {
            Compras = new List<Compra>();
        }
        public Carrito(int cantidad, int descuento, float subTotal, float total) :this()
        {
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }

        public List<Compra> Compras { get => compras; set => compras = value; }
        public float Total { get => total; set => total = value; }
        public float SubTotal { get => subTotal; set => subTotal = value; }
        public int Descuento { get => descuento; set => descuento = value; }


        public float CalcularCostoFinal()
        {
            float retorno = 0;
            foreach(Compra compra in Compras)
            {
                retorno += compra.Precio * compra.Cantidad;
            }
            return retorno;
        }

    }
}
