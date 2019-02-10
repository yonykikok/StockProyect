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
using CapaDeDatos;
using ExcepcionesPropiasProductos;

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
            int dia = DateTime.Today.Day + 15;
            int mes = DateTime.Today.Month;
            int anio = DateTime.Today.Year;
            int diasDelMes = DateTime.DaysInMonth(anio, mes);
            if (dia > diasDelMes)
            {
                dia = dia - diasDelMes;
                mes++;
                if (mes > 12)
                {
                    mes = 1;
                }
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVenta_Load(object sender, EventArgs e)
        {
            // Thread threadFecha = new Thread
            CargarDatosAlGridView();
            labelFecha.Text = ObtenerFechaDeHoy();
            labelFechaVencimiento.Text = ObtenerFechaDeVencimiento();
            textBoxTotal.Text = Carrito.CalcularCostoFinal().ToString();
            labelTerminos.Text = "“Esta factura es un título valor y se aplica, en lo pertinente, las normas relativas a la letra de cambio”. Art.5, Ley 1231 de 2008, Art. 779 C. de Comercio. \nEn caso de mora se causará el interés autorizado por la Ley. La aceptación dada por una persona distinta al comprador implica que dicha persona esta\nautorizada expresamente por él para firmar, confesar la deuda y obligarlo. Recibí de conformidad y a satisfacción la mercancía de que trata esta factura\ny acepto el valor estipulado en la misma. ";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        /// <summary>
        /// Recore la lista de compras y va descontando el stock en la base de datos siempre y cuando no se exeda el numero de stock disponible.
        /// </summary>
        private void descontarStockDeLosProductosVendidos()
        {
            foreach (Compra compra in carrito.Compras)
            {
                try
                {
                    Producto auxProducto = ProductosDAO.ObtenerProductoPorCodigo(compra.Codigo);
                    int id = auxProducto.Id;
                    int auxStock = auxProducto.Stock - compra.Cantidad;
                    auxProducto.Stock =auxStock;
                    if (auxStock >= 0)
                    {
                        ProductosDAO.ModificarProducto(auxProducto);
                    }
                    else
                    {
                        throw new StockInvalidException("Error al descontar stock de la base de datos.");
                    }
                }
                catch (StockInvalidException exception)
                {
                    throw exception;
                }
            }
        }
        /// <summary>
        /// finaliza una venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                descontarStockDeLosProductosVendidos();
                MessageBox.Show("Venta Finaliza Con Exito");
                this.Close();
            }
            catch(StockInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
