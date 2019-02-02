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
using ExcepcionesPropiasProductos;
using System.Threading;

namespace PROYECTO
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        private string descripcion;
        private float precio;
        public string DescripcionDeProducto
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public float PrecioDeProducto
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarDatosAlGridView();
            DesactivarColumasDataGridView();
            if (Program.MockThreads.Last().Name.ToLower() == "ventas")
            {
                panelVenderProductos.Visible = true;
                panelCargarProducto.Visible = false;
            }
            else
            {
                panelVenderProductos.Visible = false;
                panelCargarProducto.Visible = true;
            }
        }
        /// <summary>
        /// permite deslizar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProductos_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// carga los productos de la base de datos al dataGridView
        /// </summary>
        private void CargarDatosAlGridView()
        {
            try
            {
                dataGridViewProductos.Rows.Clear();
                foreach (Producto producto in ProductosDAO.LeerProductos(""))
                {
                    dataGridViewProductos.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio);
                }
            }
            catch (ConexionDBException exception)
            {
                MessageBox.Show("Error al conectarse con la base de datos. InnerException: " + exception.Message);
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

        /// <summary>
        /// busca productos basandose en su Codigo o Descripcion segun el texto ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            labelResultadoBusqueda.Visible = false;
            if (textBoxBuscador.Text.Contains("\r\n"))
            {
                textBoxBuscador.Text = textBoxBuscador.Text.Replace("\r\n", "");
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
        /// <summary>
        /// carga los datos de una fila al formulario de los textbox para poder crear uno nuevo, modificarlo o borrarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarDatosDelProductoAlFormulario(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["Codigo"].Value is null))
                {
                    if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["Descripcion"].Value is null))
                    {
                        if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["Stock"].Value is null))
                        {
                            if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value is null))
                            {
                                if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["StockIdeal"].Value is null))
                                {
                                    if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["Precio"].Value is null))
                                    {
                                        if (!(dataGridViewProductos.Rows[e.RowIndex].Cells["Indice"].Value is null))
                                        {
                                            if (panelCargarProducto.Visible == true)//si esta visible quiere decir que estamos en la seccion productos
                                            {
                                                textBoxCodigo.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                                                textBoxDescripcion.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                                                textBoxStock.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                                                textBoxStockMinimo.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value.ToString();
                                                textBoxStockIdeal.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["StockIdeal"].Value.ToString();
                                                textBoxPrecio.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                                                textBoxIndice.Text = dataGridViewProductos.Rows[e.RowIndex].Cells["Indice"].Value.ToString();
                                            }
                                            else//si no, estamos en la seccion ventas.
                                            {
                                                richTextBoxProducto.Text = string.Format("Codigo De Producto: {0}\nDescripcion: {1}\nPrecio: ${2}\n", dataGridViewProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(), dataGridViewProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString(), dataGridViewProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
                                                DescripcionDeProducto = dataGridViewProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                                                float auxPrecio;
                                                if (float.TryParse(dataGridViewProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out auxPrecio))
                                                {
                                                    PrecioDeProducto = auxPrecio;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("ERRROR EN EL PRECIO");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("ERRROR EN EL ID");
                                        }
                                    }
                                    else
                                    {
                                        dataGridViewProductos.Rows[e.RowIndex].Cells["Precio"].Value = "Ingrese Un Precio";
                                    }
                                }
                                else
                                {
                                    dataGridViewProductos.Rows[e.RowIndex].Cells["StockIdeal"].Value = "Ingrese El Stock Ideal";
                                }
                            }
                            else
                            {
                                dataGridViewProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value = "Ingrese El Stock Minimo";
                            }
                        }
                        else
                        {
                            dataGridViewProductos.Rows[e.RowIndex].Cells["Stock"].Value = "Ingrese El Stock";
                        }
                    }
                    else
                    {
                        dataGridViewProductos.Rows[e.RowIndex].Cells["Descripcion"].Value = "Ingrese La Descripcion";
                    }
                }
                else
                {
                    dataGridViewProductos.Rows[e.RowIndex].Cells["Codigo"].Value = "Ingrese El Codigo";
                }
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
        private void dataGridViewProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarDatosDelProductoAlFormulario(sender, e);
        }
        /// <summary>
        /// crea y devuelvo un producto en base a los datos en los textbox. 
        /// </summary>
        /// <returns> retorna un producto si los datos son correctos</returns>
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
                if (!(textBoxCodigo.Text.ToLower() is null) && (textBoxCodigo.Text.ToLower().Length > 1))
                {
                    if ((!(textBoxDescripcion.Text.ToLower() is null)) && (textBoxDescripcion.Text.ToLower().Length > 1))
                    {
                        if (Int32.TryParse(textBoxStock.Text, out stock))
                        {
                            if (Int32.TryParse(textBoxStockIdeal.Text, out stockIdeal))
                            {
                                if (Int32.TryParse(textBoxStockMinimo.Text, out stockMinimo))
                                {
                                    if (float.TryParse(textBoxPrecio.Text, out precio))
                                    {
                                        if (Int32.TryParse(textBoxIndice.Text, out id))//si tiene id es porque es un producto ya ingresado.
                                        {
                                            string codigo = textBoxCodigo.Text;
                                            string descripcion = textBoxDescripcion.Text;
                                            retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio, id);
                                        }
                                        else//si no tiene id quiere decir que es un producto nuevo y requiere de un id.
                                        {
                                            string codigo = textBoxCodigo.Text;
                                            string descripcion = textBoxDescripcion.Text;
                                            retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio);
                                        }

                                    }
                                    else
                                    {
                                        throw new PrecioInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Precio");
                                    }
                                }
                                else
                                {
                                    throw new StockMinimoInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Stock Minimo");
                                }
                            }
                            else
                            {
                                throw new StockIdealInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Stock Ideal");
                            }
                        }
                        else
                        {
                            throw new StockInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Stock");
                        }
                    }
                    else
                    {
                        throw new DescripcionInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese la Descripcion");
                    }
                }
                else
                {
                    throw new CodigoInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Codigo");
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return retorno;
        }
        /// <summary>
        /// agrega un producto a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto auxProducto = LeerProductoDelFormulario();
                ProductosDAO.InsertarProducto(auxProducto);
                CargarDatosAlGridView();
                textBoxCodigo.Text = "";
                textBoxDescripcion.Text = "";
                textBoxPrecio.Text = "";
                textBoxCodigo.Focus();
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
        /// <summary>
        /// Selecciona una imagen que representara al producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();//falta termina y nose como xDD
        }
        private void IniciarOpenFile()
        {

        }
        /// <summary>
        /// remueve un producto de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = LeerProductoDelFormulario();
            ProductosDAO.Remover(producto);
            CargarDatosAlGridView();
        }
        /// <summary>
        /// detecta la tecla 'ENTER' para buscar el producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonBuscar_Click(sender, e);
            }
        }
        /// <summary>
        /// modifica los datos actuales de un producto existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = LeerProductoDelFormulario();
                if (!(producto is null))
                {
                    int id;
                    if (Int32.TryParse(textBoxIndice.Text, out id))
                    {
                        ProductosDAO.ModificarProducto(producto);

                        ProductosDAO.ModificarProducto(producto);
                        CargarDatosAlGridView();
                    }
                }
            }
            catch (CodigoInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (DescripcionInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (StockInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (StockIdealInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (StockMinimoInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (PrecioInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (ImagenInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (IdProductoInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al modificar un Producto, puede que algun dato no este ingresado");
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// minimiza el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private float CalcularTotal(int cantidad, float precio)
        {
            float retorno = 0;
            if (cantidad != 0 && precio != 0)
            {
                retorno = precio * cantidad;
            }
            return retorno;
        }
        private void buttonAgregarVenta_Click(object sender, EventArgs e)
        {
            FormCantidad formCantidad = new FormCantidad();
            formCantidad.ShowDialog();
            float auxTotal = CalcularTotal(formCantidad.Cantidad, PrecioDeProducto);
            if (!(formCantidad.Cantidad == 0))
            {
                listBoxCantidad.Items.Add(formCantidad.Cantidad.ToString());
                listBoxCarrito.Items.Add(string.Format("Descripcion: {0}", DescripcionDeProducto));
                if (auxTotal != 0)
                {
                    listBoxPrecio.Items.Add("$" + PrecioDeProducto.ToString());
                    listBoxPrecioTotal.Items.Add("$" + auxTotal.ToString());
                }
                else
                {
                    MessageBox.Show("Error Precio Total");
                }
            }

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
