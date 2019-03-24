using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{

    public enum EEstado
    {
        SinHacer,
        EnProceso,
        Terminado,
        SinSolucion
    }
    public enum ETipoDeEquipo
    {
        Celular,
        Tablet,
        Notebook,
        Otros
    }
    public enum EServicio
    {
        Reparacion,
        Presupuesto,
        Activacion,
        Garantia
    }
    public enum ETipoDeBloqueo
    {
        patron,
        password,
        ninguno
    }
    public enum EObservaciones
    {
        Prende,
        NoPrende,
        ConFaltantes,
        Mojado,
        Desarmado,
        Ninguno,
        Otro
    }
    public class Reparacion : Cliente
    {

        private ETipoDeEquipo tipo;
        private EServicio servicio;
        private ETipoDeBloqueo tipoDeBloqueo;
        private EObservaciones observacionesPredefinidas;
        private Cliente cliente;
        private string marcaYModelo;
        private string trabajoARealizar;
        private int garantia;
        private float precio;
        private float seña;
        private float saldo;
        private long numeroDeBoleta;
        private DateTime fecha;

        #region PROPIEDADES
        public ETipoDeEquipo Tipo { get => tipo; set => tipo = value; }
        public EServicio TipoDeServicio { get => servicio; set => servicio = value; }
        public ETipoDeBloqueo TipoDeBloqueo1 { get => tipoDeBloqueo; set => tipoDeBloqueo = value; }
        public EObservaciones ObservacionesPredefinidas { get => observacionesPredefinidas; set => observacionesPredefinidas = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string TrabajoARealizar { get => trabajoARealizar; set => trabajoARealizar = value; }
        public int Garantia { get => garantia; set => garantia = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Seña { get => seña; set => seña = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public long NumeroDeBoleta { get => numeroDeBoleta; set => numeroDeBoleta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string MarcaYModelo { get => marcaYModelo; set => marcaYModelo = value; }
        #endregion

        #region CONSTRUCTORES
        public Reparacion(ETipoDeEquipo tipo, EServicio servicio, ETipoDeBloqueo tipoDeBloqueo, EObservaciones observacionesPredefinidas, Cliente cliente, string marcaYModelo, string trabajoARealizar, int garantia, float precio, float seña, float saldo, long numeroDeBoleta, DateTime fecha) : base(cliente.Name, cliente.LastName, cliente.Dni, cliente.Adress, cliente.MailAdress, cliente.Numero)
        {
            this.Tipo = tipo;
            this.TipoDeServicio = servicio;
            this.TipoDeBloqueo1 = tipoDeBloqueo;
            this.ObservacionesPredefinidas = observacionesPredefinidas;
            this.Cliente = cliente;
            this.MarcaYModelo = marcaYModelo;
            this.TrabajoARealizar = trabajoARealizar;
            this.Garantia = garantia;
            this.Precio = precio;
            this.Seña = seña;
            this.Saldo = saldo;
            this.NumeroDeBoleta = numeroDeBoleta;
            this.Fecha = fecha;
        }
        #endregion
    }
}
