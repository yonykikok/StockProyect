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
using ExcepcionesPropias;
using System.Threading;

namespace PROYECTO
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarDatosAlGridView();
            DesactivarColumasDataGridView();
        }

        private void FormProductos_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CargarDatosAlGridView()
        {
            dataGridViewProductos.Rows.Clear();
            foreach (Producto producto in ProductosDAO.LeerProductos(""))
            {
                dataGridViewProductos.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio);
            }
        }
        /// <summary>
        /// Activa las columas Indice,StockIdeal y StockMinimo para que sean visibles
        /// </summary>
        private void ActivarColumasDataGridView()
        {
            dataGridViewProductos.Columns[0].Visible = true;
            dataGridViewProductos.Columns[4].Visible = true;
            dataGridViewProductos.Columns[5].Visible = true;
        }
        /// <summary>
        /// Desactiva las columas Indice,StockIdeal y StockMinimo para que no sean visibles
        /// </summary>
        private void DesactivarColumasDataGridView()
        {
            dataGridViewProductos.Columns[0].Visible = false;
            dataGridViewProductos.Columns[4].Visible = false;
            dataGridViewProductos.Columns[5].Visible = false;
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            labelResultadoBusqueda.Visible = false;
            if (textBoxBuscador.Text.Contains("\r\n"))
            {
                textBoxBuscador.Text=textBoxBuscador.Text.Replace("\r\n", "");
            }
            try
            {
                dataGridViewProductos.Rows.Clear();
                foreach (Producto producto in ProductosDAO.LeerProductos(textBoxBuscador.Text))
                {
                    dataGridViewProductos.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio);
                }
                textBoxBuscador.Text = "";

            }
            catch (NullReferenceException exception)
            {
                labelResultadoBusqueda.Text = "No hay coincidencias";
                labelResultadoBusqueda.Visible = true;
                textBoxBuscador.Text = "";
            }

        }

        private void dataGridViewProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBoxCodigo.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                textBoxDescripcion.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                textBoxStock.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                textBoxStockMinimo.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value.ToString();
                textBoxStockIdeal.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["StockIdeal"].Value.ToString();
                textBoxPrecio.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                textBoxIndice.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Indice"].Value.ToString();
            }
            catch (NullReferenceException exception)
            {
                textBoxCodigo.ResetText();
                textBoxDescripcion.ResetText();
                textBoxStock.ResetText();
                textBoxStockMinimo.ResetText();
                textBoxStockIdeal.ResetText();
                textBoxPrecio.ResetText();
            }
        }

        private Producto LeerProductoDelFormulario()
        {
            int stock;
            int stockIdeal;
            int stockMinimo;
            float precio;
            int id;
            Producto retorno = null;
            try
            {
                string codigo = textBoxCodigo.Text;
                string descripcion = textBoxDescripcion.Text;
                if (Int32.TryParse(textBoxStock.Text, out stock))
                {
                    if (Int32.TryParse(textBoxStockIdeal.Text, out stockIdeal))
                    {
                        if (Int32.TryParse(textBoxStockMinimo.Text, out stockMinimo))
                        {
                            if (float.TryParse(textBoxPrecio.Text, out precio))
                            {
                                if (Int32.TryParse(textBoxIndice.Text, out id))
                                {
                                    retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio, id);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("No se pudo leer el producto del formulario " + exception.Message);
            }
            return retorno;
        }
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto auxProducto = LeerProductoDelFormulario();
                ProductosDAO.InsertarProducto(auxProducto);
                CargarDatosAlGridView();
            }
            catch (ErrorAlComprobarExistenciaDeProducto exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al cargar un producto " + exception.Message);
            }
        }

        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
        }

        private void buttonQuitarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = LeerProductoDelFormulario();
            ProductosDAO.Remover(producto);
            CargarDatosAlGridView();
        }

        private void textBoxBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonBuscar_Click(sender, e);
            }
        }

        private void buttonModificarProducto_Click(object sender, EventArgs e)
        {
            ProductosDAO.ModificarProducto(LeerProductoDelFormulario());
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
