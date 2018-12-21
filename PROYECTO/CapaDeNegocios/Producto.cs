using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Producto
    {
        private string codigo;
        private string descripcion;
        private int stock;
        private int stockIdeal;
        private int stockMinimo;
        private float precio;

        public Producto()
        {

        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Stock = stock;
            this.StockIdeal = StockIdeal;
            this.StockMinimo = stockMinimo;
            this.Precio = precio;
        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
        public int StockIdeal { get => stockIdeal; set => stockIdeal = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (value > 0)
                    precio = value;
            }
        }
    }
}
