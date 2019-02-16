using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Cliente : Persona
    {
        private string numero;
        private int id;
        public Cliente(string nombre, string apellido, string dni, string direccion, string mail, string numero,int id) : base(nombre, apellido, dni, direccion, mail)
        {
            this.Numero = numero;
            this.Id = id;
        }
        public Cliente(string nombre, string apellido, string dni, string direccion, string mail, string numero) : base(nombre, apellido, dni, direccion, mail)
        {
            this.Numero = numero;
        }
        public string Numero { get => numero; set => numero = value; }
        public int Id { get => id; set => id = value; }
    }
}
