using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Deudor : Cliente
    {
        String descripcion;
        float cantidadAdeudada;
        DateTime fechaInicio;
        DateTime fechaLimite;
        float recargoPorcentual;
        public Deudor(string nombre, string apellido, string dni, string direccion, string mail, string numero,string descripcion, float cantidadAdeudada, DateTime fechaInicio, DateTime fechaLimite, float recargoPorcentual) : base(nombre, apellido, dni, direccion, mail, numero)
        {
            this.descripcion = descripcion;
            this.cantidadAdeudada = cantidadAdeudada;
            this.fechaInicio = fechaInicio;
            this.fechaLimite = fechaLimite;
            this.recargoPorcentual = recargoPorcentual;
        }
        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Deudor " + this.LastName.ToUpper() + " " + this.Name.ToUpper()+ ", DNI: "+this.Dni);
            retorno.AppendLine("-----------------------------------------------------------------");
            retorno.AppendLine("Datos de contacto: ");
            retorno.AppendLine("Direccion: "+this.Adress);
            retorno.AppendLine("Numero: "+this.Numero);
            retorno.AppendLine("-----------------------------------------------------------------");
            retorno.AppendLine("DETALLE DE LA DEUDA:");
            retorno.AppendLine("Fecha de cuando inicio de deuda: "+this.fechaInicio.ToShortDateString());
            retorno.AppendLine(this.descripcion);
            retorno.AppendLine("Fecha limite de la deuda: "+this.fechaLimite.ToShortDateString());
            retorno.AppendLine("-----------------------------------------------------------------");
            retorno.AppendLine("Cuanto debe: $"+this.cantidadAdeudada);



            return retorno.ToString();
        }
    }
}
