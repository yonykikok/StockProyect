using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Producto
    {
<<<<<<< HEAD
        #region CAMPOS
=======
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
        private string codigo;
        private string descripcion;
        private int stock;
        private int stockIdeal;
        private int stockMinimo;
        private float precio;
<<<<<<< HEAD
        private string imagen;
        #endregion

        #region CONSTRUCTORES
=======

>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
        public Producto()
        {

        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Stock = stock;
<<<<<<< HEAD
            this.StockIdeal = stockIdeal;
            this.StockMinimo = stockMinimo;
            this.Precio = precio;
        }
        public Producto(string codigo, string descripcion, int stock, int stockIdeal, int stockMinimo, float precio,string imagen):this(codigo,descripcion,stock,stockIdeal,stockMinimo,precio)
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
=======
            this.StockIdeal = StockIdeal;
            this.StockMinimo = stockMinimo;
            this.Precio = precio;
        }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
        public int StockIdeal { get => stockIdeal; set => stockIdeal = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
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
<<<<<<< HEAD
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
=======
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
    }
}
