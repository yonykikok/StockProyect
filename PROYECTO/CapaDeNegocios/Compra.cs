using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Compra : Producto
    {
        int cantidad;

        public Compra(string codigo, string descripcion, string stock, string stockIdeal, string stockMinimo, string precio,int cantidad) : base(codigo,descripcion,stock,stockIdeal,stockMinimo,precio)//--------------------------------------------------------------------------------------------
        {
            Cantidad = cantidad;
        }
        public Compra(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio,int cantidad) : base(codigo,descripcion,stock,stockIdeal,stockMinimo,precio)//--------------------------------------------------------------------------------------------
        {
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Codigo: {0} Descripcion: {1} Cantidad: {2} Precio: {3}", Codigo, Descripcion, Cantidad, Precio);
            return retorno.ToString();
        }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
