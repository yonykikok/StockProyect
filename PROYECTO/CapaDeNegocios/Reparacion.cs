using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios 
{
    public class Reparacion
    {
        public enum Tipo
        {
            Celular,
            Tablet,
            Notebook,
            Otros
        }
        public enum Servicio
        {
            Reparacion,
            Presupuesto,
            Activacion,
            Garantia
        }
        public enum tipoDeBloqueo
        {
            patron,
            password,
            pin,
            KnockCodeLG
        }
        public enum Observaciones
        {
            Prende,
            NoPrende,
            ConFaltantes,
            Mojado,
            Desarmado
        }
        Cliente cliente;
        private string marca;
        private string modelo;
        private string trabajoARealizar;
        private string observaciones;
        private int garantia;
        private float precio;
        private float seña;
        private float saldo;
        private long numeroDeBoleta;

    }
}
