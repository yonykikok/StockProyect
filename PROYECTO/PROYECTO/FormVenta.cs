using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;

namespace PROYECTO
{
    public partial class FormVenta : Form
    {
        private Carrito carrito;

        public Carrito Carrito { get => carrito; set => carrito = value; }

        public FormVenta()
        {
            InitializeComponent();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelDown_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private string ObtenerFechaDeVencimiento()
        {
            int dia = DateTime.Today.Day + 25;
            int mes = DateTime.Today.Month;
            int anio = DateTime.Today.Year;
            int diasDelMes = DateTime.DaysInMonth(anio, mes);
            if (dia > diasDelMes)
            {
                dia = dia - diasDelMes;
                mes++;
            }
            return dia + "/" + mes.ToString() + "/" + anio.ToString();
        }
        private string ObtenerFechaDeHoy()
        {
            return DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        private void CargarDatosAlGridView()
        {
            dataGridViewProductos.Rows.Clear();
            foreach (Compra compra in Carrito.Compras)
            {
                dataGridViewProductos.Rows.Add(compra.Cantidad, compra.Descripcion, compra.Precio);
            }
        }
        private void FormVenta_Load(object sender, EventArgs e)
        {
            // Thread threadFecha = new Thread
            CargarDatosAlGridView();
            labelFecha.Text = ObtenerFechaDeHoy();
            labelFechaVencimiento.Text = ObtenerFechaDeVencimiento();
            textBoxTotal.Text = Carrito.CalcularCostoFinal().ToString();
            labelTerminos.Text = "“Esta factura es un título valor y se aplica, en lo pertinente, las normas relativas a la letra de cambio”. Art.5, Ley 1231 de 2008, Art. 779 C. de Comercio. \nEn caso de mora se causará el interés autorizado por la Ley. La aceptación dada por una persona distinta al comprador implica que dicha persona esta\nautorizada expresamente por él para firmar, confesar la deuda y obligarlo. Recibí de conformidad y a satisfacción la mercancía de que trata esta factura\ny acepto el valor estipulado en la misma. ";
        }

    }
}
