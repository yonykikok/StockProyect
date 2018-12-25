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
using CapaDeDatos;
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
            ProductosDAO productos = new ProductosDAO();
            foreach (Producto producto in productos.LeerProductos(""))
            {
                dataGridViewProductos.Rows.Add(producto.Codigo, producto.Descripcion, producto.Stock, producto.StockMinimo, producto.StockIdeal, producto.Precio);
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
    }
}
