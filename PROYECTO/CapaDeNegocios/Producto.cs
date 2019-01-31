using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Producto
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
        public Producto()
        {

        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio)//--------------------------------------------------------------------------------------------
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Stock = stock;
            this.StockIdeal = stockIdeal;
            this.StockMinimo = stockMinimo;
            this.Precio = precio;
        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio,int id)//--------------------------------------------------------------------------------------------
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Stock = stock;
            this.StockIdeal = stockIdeal;
            this.StockMinimo = stockMinimo;
            this.Precio = precio;
            this.id = id;
        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio,string imagen, int id):this(codigo,descripcion,stock,stockIdeal,stockMinimo,precio,id)//-------------
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
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                if (value.Length > 0)
                    descripcion = value;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                if (value.Length > 0)
                    codigo = value;
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
