using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
<<<<<<< HEAD
using CapaDeDatos;
=======
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
namespace PROYECTO
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ProductosDAO productos = new ProductosDAO();
            foreach (Producto producto in productos.LeerProductos(""))
            {
                dataGridViewProductos.Rows.Add(producto.Codigo, producto.Descripcion, producto.Stock, producto.StockMinimo, producto.StockIdeal, producto.Precio);
=======
            List<Producto> productos = new List<Producto>();
            Producto CargadorRapido = new Producto("054218410", "Cargador Inova Rapido de 3.1mAh", 3, 4, 2, 250);
            Producto CargadorInova = new Producto("054218410", "Cargador Inova de 2mAh", 3, 4, 2, 150);
            Producto CargadorSamsung = new Producto("054218410", "Cargador Samsung de 2mAh", 3, 4, 2, 100);
            productos.Add(CargadorRapido);
            productos.Add(CargadorInova);
            productos.Add(CargadorSamsung);
            foreach (Producto producto in productos)
            {
                dataGridViewProductos.Rows.Add(producto.Codigo, producto.Descripcion, producto.Stock,producto.Precio, producto.StockMinimo, producto.StockIdeal);
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxBuscador_Click(object sender, EventArgs e)
        {
            textBoxBuscador.Text = "";
        }
<<<<<<< HEAD

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            labelResultadoBusqueda.Visible = false;
            try
            {
                ProductosDAO productos = new ProductosDAO();
                dataGridViewProductos.Rows.Clear();
                foreach (Producto producto in productos.LeerProductos(textBoxBuscador.Text))
                {
                    dataGridViewProductos.Rows.Add(producto.Codigo, producto.Descripcion, producto.Stock, producto.Precio, producto.StockMinimo, producto.StockIdeal);
                }
            }
            catch (NullReferenceException exception)
            {
                labelResultadoBusqueda.Text = "No hay coincidencias";
                labelResultadoBusqueda.Visible = true;
            }

        }

        private void dataGridViewProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            MessageBox.Show("ESTO ES LO QUE BUSCABA "+ dataGridViewProductos.CurrentRow.Index);

         
        }
=======
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
    }
}
