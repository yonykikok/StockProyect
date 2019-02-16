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
        public Carrito(int cantidad, int descuento, float subTotal, float total) : this()
        {
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }

        public List<Compra> Compras { get => compras; set => compras = value; }
        public float Total { get => total; set => total = value; }
        public float SubTotal { get => subTotal; set => subTotal = value; }
        public int Descuento { get => descuento; set => descuento = value; }


        public float CalcularSubTotal()
        {
            float retorno = 0;
            foreach (Compra compra in Compras)
            {
                retorno += compra.Precio * compra.Cantidad;
            }
            return retorno;
        }

        public string GenerarLogDeCompra(string impuestoIVA)
        {
            StringBuilder retorno = new StringBuilder();

            foreach (Compra compra in this.Compras)
            {
                string auxCostoFinal;
                if (impuestoIVA == "21% (Aplicado)")
                {
                    auxCostoFinal = ((compra.Precio * compra.Cantidad) * 1.21).ToString();
                }
                else
                {
                    auxCostoFinal = (compra.Precio * compra.Cantidad).ToString();
                }
                retorno.AppendFormat("{0};{1};{2};{3};{4};{5}\n", DateTime.Now.ToString(), compra.Codigo, compra.Descripcion, compra.Cantidad, compra.Precio, auxCostoFinal);
            }
            return retorno.ToString();
        }

    }
}
