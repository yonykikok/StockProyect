using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Articulo
    {
        private string codigo;
        private string descripcion;
        private float precio;

        public Articulo(string codigo, string descripcion, string precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            float auxPrecio;
            if (float.TryParse(precio, out auxPrecio))
            {
                this.Precio = auxPrecio;
            }
        }
        public Articulo(string codigo, string descripcion, float precio)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
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
