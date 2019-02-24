using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDeNegocios;
using CapaDeDatos;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROYECTO
{
    public partial class FormPrincipal : Form
    {
        private static Thread threadEmpleados;
        private static Thread threadProductos;
        private static Thread threadVentas;
        private static Thread threadClientes;
        private static Thread threadReparaciones;
        Empleado empleado;

        public Thread ThreadVentas
        {
            get { return threadVentas; }
        }
        public Thread ThreadEmpleados
        {
            get { return threadEmpleados; }
        }
        public Thread ThreadProductos
        {
            get { return threadProductos; }
        }

        public static Thread ThreadClientes { get => threadClientes; set => threadClientes = value; }
        public static Thread ThreadReparaciones { get => threadReparaciones; set => threadReparaciones = value; }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            PrivilegioUsuarios();


            //------probando
            List<LogVenta> listaLogs = ClientesLog.LeerHistorialDeVentas();
            foreach (LogVenta log in listaLogs)
            {
                Series serie = chartEstadisticaGlobal.Series.Add(log.Descripcion);//agrega las series.
                serie.Label = log.Cantidad.ToString();//los muestra como label a la derecha del grafico
                serie.Points.Add(log.Cantidad);//establece las cantidades o porcentajes
            }

        }
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public FormPrincipal(Empleado empleado) : this()
        {
            this.empleado = new Empleado(empleado.User, empleado.Password, empleado.Name, empleado.LastName, empleado.Dni, empleado.Adress, empleado.MailAdress, empleado.Type);
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
        private void ButtonMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonReportesVentas_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            if (chartEstadisticaGlobal.Visible)
            {
                chartEstadisticaGlobal.Visible = false;
            }
            else
            {
                chartEstadisticaGlobal.Visible = true;
            }
        }

        private void buttonReportesCompras_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;

        }



        private void buttonReportes_Click(object sender, EventArgs e)
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            else if (panelSubMenu.Visible == false)
                panelSubMenu.Visible = true;
        }

        private void buttonReportes_MouseHover(object sender, EventArgs e)
        {
            panelSubMenu.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }
        /// <summary>
        /// oculta sectores que solo deben ser accesibles para usuarios administradores.
        /// </summary>
        private void PrivilegioUsuarios()
        {
            if (this.empleado.Type != UserType.admin)
            {
                buttonReparaciones.Visible = false;
                buttonPagos.Visible = false;
                buttonReportes.Visible = false;
                panelUsuarios.Visible = false;
                buttonEmpleados.Visible = false;
                panelEmpleados.Visible = false;
                panelPagos.Visible = false;
                panelReportes.Visible = false;
            }
        }

        /// <summary>
        /// inicializa el form empleados
        /// </summary>
        private void IniciarFormEmpleados()
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.ShowDialog();
        }
        /// <summary>
        /// insicializa el form de productos
        /// </summary>
        private void IniciarFormProductos()
        {
            FormProductos formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void IniciarFormReparaciones()
        {
            FormReparaciones formReparaciones = new FormReparaciones();
            formReparaciones.ShowDialog();
        }

        private void IniciarFormClientes()
        {
            FormClientes formCliente = new FormClientes();
            formCliente.ShowDialog();
        }
        /// <summary>
        /// crea un nuevo hilo para abrir una nueva ventana de form de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            threadEmpleados = new Thread(IniciarFormEmpleados);
            Program.MockThreads.Add(threadEmpleados);
            if (!(this.ThreadEmpleados.IsAlive))
                threadEmpleados.Start();
        }
        /// <summary>
        /// cierra todos los hilos antes de cerrar la aplicacion principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread hilo in Program.MockThreads)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
        /// <summary>
        /// crea un nuevo hilo para abrir una nueva ventana de form de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProductos_Click(object sender, EventArgs e)
        {
            threadProductos = new Thread(IniciarFormProductos);
            Program.MockThreads.Add(threadProductos);
            if (!(this.ThreadProductos.IsAlive))
            {
                ThreadProductos.Name = "productos";
                threadProductos.Start();
            }
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            threadVentas = new Thread(IniciarFormProductos);
            Program.MockThreads.Add(threadVentas);
            if (!(this.ThreadVentas.IsAlive))
            {
                ThreadVentas.Name = "ventas";
                threadVentas.Start();
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            threadClientes = new Thread(IniciarFormClientes);
            Program.MockThreads.Add(threadClientes);
            if (!(threadClientes.IsAlive))
            {
                threadClientes.Name = "Clientes";
                threadClientes.Start();
            }
        }

        private void buttonReparaciones_Click(object sender, EventArgs e)
        {
            ThreadReparaciones = new Thread(IniciarFormReparaciones);
            Program.MockThreads.Add(ThreadReparaciones);
            if (!(ThreadReparaciones.IsAlive))
            {
                ThreadReparaciones.Start();
            }
        }

        private void buttonReportesStockBajo_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            //-----     
            if(richTextBoxStockBajo.Visible)
            {
                richTextBoxStockBajo.Visible = false;
            }
            else
            {
                richTextBoxStockBajo.Visible = true;
            }
            List<Producto> listaProductosDB = ProductosDAO.LeerProductos();
            List<Producto> listaStockBajo = new List<Producto>();
            foreach (Producto auxProducto in listaProductosDB)
            {
                if (auxProducto.Stock <= auxProducto.StockMinimo)
                {
                    listaStockBajo.Add(auxProducto);
                }
            }
            foreach (Producto auxProducto in listaStockBajo)
            {               
                richTextBoxStockBajo.Text += string.Format("Producto: {0}, Stock: {1}, Stock Ideal: {2}\n", auxProducto.Descripcion, auxProducto.Stock, auxProducto.StockIdeal); ;
            }
        }

      
    }
}
