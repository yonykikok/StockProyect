using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Producto : Articulo
    {
        #region CAMPOS
        private string codigo;
        private string descripcion;
        private int stock;
        private int stockIdeal;
        private int stockMinimo;
        private float precio;
        private string imagen;
        private int id;
        #endregion

        #region CONSTRUCTORES
        static Producto()
        {

        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio) : base(codigo, descripcion, precio)//--------------------------------------------------------------------------------------------
        {
            this.Stock = stock;
            this.StockIdeal = stockIdeal;
            this.StockMinimo = stockMinimo;
        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio, int id) : base(codigo, descripcion, precio)//--------------------------------------------------------------------------------------------
        {
            this.Stock = stock;
            this.StockIdeal = stockIdeal;
            this.StockMinimo = stockMinimo;
            this.id = id;
        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio, string imagen, int id) : this(codigo, descripcion, stock, stockIdeal, stockMinimo, precio, id)//-------------
        {
            this.Imagen = imagen;
        }
        #endregion

        #region PROPIEDADES
        public string Imagen
        {
            get
            {
                return this.imagen;
            }
            set
            {
                if (value.Length > 0)
                    imagen = value;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public int StockMinimo
        {
            get
            {
                return this.stockMinimo;
            }
            set
            {
                if (value >= 0)
                    stockMinimo = value;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                    stock = value;
            }
        }
        public int StockIdeal
        {
            get
            {
                return this.stockIdeal;
            }
            set
            {
                if (value >= 0)
                    stockIdeal = value;
            }
        }
        #endregion
    }
}
