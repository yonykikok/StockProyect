﻿using System;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace PROYECTO
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        #region CAMPOS
        private Thread threadVenta;
        private Producto producto;
        private Carrito carrito;
        #endregion
        #region PROPIEDADES
        public Carrito Carrito { get => carrito; set => carrito = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public Thread ThreadVenta { get => threadVenta; set => threadVenta = value; }
        #endregion
        /// <summary>
        /// busca los productos que contenga la palabra clave, y modifica su foto por la imagen perteneciente al pathImagen.
        /// </summary>
        /// <param name="pathImagen"></param>
        /// <param name="palabraClave"></param>
        private void AgregarFotosALosProductosDelMismoTipo(string pathImagen, string palabraClave)
        {
            for (int i = 0; i < 500; i++)
            {
                Producto producto = ProductosDAO.ObtenerProductoPorId(i);
                if (producto != null)
                {
                    producto.Imagen = pathImagen;
                    if (producto.Descripcion.Contains(palabraClave))
                    {
                        ProductosDAO.ModificarImagenDelProducto(producto);
                    }
                }

            }
        }
        private void AgregarImagenesALosProductos()
        {
            
            
            //---------temporal----
           /* string pathImagenCargadorInova3mAh = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cargador inova.jpg";
            string pathImagenGlass = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\Film Glass.jpg";
            string pathImagenCableIphoneMetal = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cable iphone metalico.jpg";
            string pathImagensd16gb = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\sd 16gb.jpg";
            string pathImagensdPendrive16gb = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\pendrive 16gb.jpg";
            string pathImagensdoOtg = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\otg.jpg";
            string pathImagensdCamaraAxis = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\camara axis.jpg";
            string pathImagensCargadorBateria = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cargador bateria.jpg";
            string pathImagensdCargadorSam = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cargador samsung.jpg";
            string pathImagensdCargador2mah = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cargador 2mah.jpg";
            string pathImagensdcableTelaIphone = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cable tela iphone.jpg";
            string pathImagensdAuricularVincha = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\auricular estampado.jpg";
            string pathImagensdTipoCTela = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\cable tipo C tela.jpg";
            string pathImagenJoystick = "C:\\Users\\Haedo Jonathan\\Desktop\\StockProyect\\Imegenes\\joystick ps3.jpg";
            AgregarFotosALosProductosDelMismoTipo(pathImagenCargadorInova3mAh, "3.1m");
            AgregarFotosALosProductosDelMismoTipo(pathImagenGlass, "glass");
            AgregarFotosALosProductosDelMismoTipo(pathImagenCableIphoneMetal, "metalico iphone");
            AgregarFotosALosProductosDelMismoTipo(pathImagensd16gb, "16gb");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdPendrive16gb, "pendrive");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdoOtg, "otg");
            AgregarFotosALosProductosDelMismoTipo(pathImagensCargadorBateria, "universal de baterias");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdCargador2mah, "inova 2 en 1");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdCamaraAxis, "camaras segurida");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdcableTelaIphone, "tela iphone");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdCargadorSam, "cargador samsung");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdAuricularVincha, "vincha dise");
            AgregarFotosALosProductosDelMismoTipo(pathImagensdTipoCTela, "tela tipo c");
            AgregarFotosALosProductosDelMismoTipo(pathImagenJoystick, "joystick");*/
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            Carrito = new Carrito(0, 0, 0, 0);
            CargarDatosAlGridView();
            DesactivarColumasDataGridView();
            if (Program.MockThreads.Last().Name.ToLower() == "ventas")
            {
                panelVenderProductos.Visible = true;
                panelCargarProducto.Visible = false;
                labelProductosVentas.Text = "Multitask-Ventas";
            }
            else
            {
                panelVenderProductos.Visible = false;
                panelCargarProducto.Visible = true;
                labelProductosVentas.Text = "Multitask-Productos";
            }
           //AgregarImagenesALosProductos();
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
                List<Producto> productos = ProductosDAO.LeerProductos("");
                if (productos != null) { 
                    foreach (Producto producto in ProductosDAO.LeerProductos(""))
                    {
                        dataGridViewProductos.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio, producto.Imagen);
                    }
                }
            }
            catch (ConexionDBException exception)
            {
                MessageBox.Show("Error al conectarse con la tabla Productos. InnerException: " + exception.Message + "\nSugerencia: Puede que la tabla no se encuentre en la base de datos");
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
            dataGridViewProductos.Columns[7].Visible = true;
        }
        /// <summary>
        /// Desactiva las columas Indice,StockIdeal y StockMinimo para que no sean visibles
        /// </summary>
        private void DesactivarColumasDataGridView()
        {
            dataGridViewProductos.Columns[0].Visible = false;
            dataGridViewProductos.Columns[4].Visible = false;
            dataGridViewProductos.Columns[5].Visible = false;
            dataGridViewProductos.Columns[7].Visible = false;
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
                    dataGridViewProductos.Rows.Add(producto.Id, producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio, producto.Imagen);
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
        /// carga los datos de una fila, al formulario de los textbox para poder crear un producto nuevo, modificarlo o borrarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool ValidarDatosDelProductoSeleccionado(int rowIndex)
        {

            bool retorno = false;
            try
            {
                if (!(dataGridViewProductos.Rows[rowIndex].Cells["Codigo"].Value is null))
                {
                    if (!(dataGridViewProductos.Rows[rowIndex].Cells["Descripcion"].Value is null))
                    {
                        if (!(dataGridViewProductos.Rows[rowIndex].Cells["Stock"].Value is null))
                        {
                            if (!(dataGridViewProductos.Rows[rowIndex].Cells["StockMinimo"].Value is null))
                            {
                                if (!(dataGridViewProductos.Rows[rowIndex].Cells["StockIdeal"].Value is null))
                                {
                                    if (!(dataGridViewProductos.Rows[rowIndex].Cells["Precio"].Value is null))
                                    {
                                        if (!(dataGridViewProductos.Rows[rowIndex].Cells["Indice"].Value is null))
                                        {
                                            retorno = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("ERRROR EN EL ID");
                                        }
                                    }
                                    else
                                    {
                                        dataGridViewProductos.Rows[rowIndex].Cells["Precio"].Value = "Ingrese Un Precio";
                                    }
                                }
                                else
                                {
                                    dataGridViewProductos.Rows[rowIndex].Cells["StockIdeal"].Value = "Ingrese El Stock Ideal";
                                }
                            }
                            else
                            {
                                dataGridViewProductos.Rows[rowIndex].Cells["StockMinimo"].Value = "Ingrese El Stock Minimo";
                            }
                        }
                        else
                        {
                            dataGridViewProductos.Rows[rowIndex].Cells["Stock"].Value = "Ingrese El Stock";
                        }
                    }
                    else
                    {
                        dataGridViewProductos.Rows[rowIndex].Cells["Descripcion"].Value = "Ingrese La Descripcion";
                    }
                }
                else
                {
                    dataGridViewProductos.Rows[rowIndex].Cells["Codigo"].Value = "Ingrese El Codigo";
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
            return retorno;
        }
        /// <summary>
        /// Al Hacerle Doble click en el HEADER de una linea, carga los datos de la misma a los textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.seleccionarProducto(e.RowIndex);
        }



        private void seleccionarProducto(int rowIndex) {

            string pathCarpetaImagenes= this.ObtenerPathCarpetaImagenes()+"productos\\";
            if (ValidarDatosDelProductoSeleccionado(rowIndex))
            {
                if (panelCargarProducto.Visible == true)//si esta visible quiere decir, que estamos en la seccion productos
                {
                    textBoxCodigo.Text = dataGridViewProductos.Rows[rowIndex].Cells["Codigo"].Value.ToString();
                    textBoxDescripcion.Text = dataGridViewProductos.Rows[rowIndex].Cells["Descripcion"].Value.ToString();
                    textBoxStock.Text = dataGridViewProductos.Rows[rowIndex].Cells["Stock"].Value.ToString();
                    textBoxStockMinimo.Text = dataGridViewProductos.Rows[rowIndex].Cells["StockMinimo"].Value.ToString();
                    textBoxStockIdeal.Text = dataGridViewProductos.Rows[rowIndex].Cells["StockIdeal"].Value.ToString();
                    textBoxPrecio.Text = dataGridViewProductos.Rows[rowIndex].Cells["Precio"].Value.ToString();
                    textBoxIndice.Text = dataGridViewProductos.Rows[rowIndex].Cells["Indice"].Value.ToString();
                    if(dataGridViewProductos.Rows[rowIndex].Cells["Imagen"].Value!=null)//solucion temporal al no poner imagen en alta de producto
                    textBoxImagen.Text = dataGridViewProductos.Rows[rowIndex].Cells["Imagen"].Value.ToString();
                    Producto = new Producto(textBoxCodigo.Text, textBoxDescripcion.Text, textBoxStock.Text, textBoxStockIdeal.Text, textBoxStockMinimo.Text, textBoxPrecio.Text, textBoxImagen.Text);
                    if ((textBoxImagen.Text != null) && (textBoxImagen.Text != "") && (textBoxImagen.Text != "sin imagen"))
                    {
                        try {
                            
                            string[] fileNameArray = textBoxImagen.Text.Split('\\');
                            FileStream fs = new System.IO.FileStream(pathCarpetaImagenes + fileNameArray[fileNameArray.Length - 1], FileMode.Open, FileAccess.Read);
                            pictureBoxImagenProducto.Image = Image.FromStream(fs);
                            fs.Close();
                            //pictureBoxImagenProducto.Image = Image.FromFile(pathCarpetaImagenes + fileNameArray[fileNameArray.Length-1]);//cargo la imagen al pictureBox
                        }
                        catch (FileNotFoundException e) {
                            MessageBox.Show("Esta imagen no se encontro en la carpeta IMAGENES!");
                        }
                    }
                    else
                    {
                        pictureBoxImagenProducto.Image = null;
                    }
                }
                else//si no, estamos en la seccion ventas.
                {
                    string imagen = dataGridViewProductos.Rows[rowIndex].Cells["Imagen"].Value.ToString();
                    Producto = new Producto(dataGridViewProductos.Rows[rowIndex].Cells["Codigo"].Value.ToString(), dataGridViewProductos.Rows[rowIndex].Cells["Descripcion"].Value.ToString(), dataGridViewProductos.Rows[rowIndex].Cells["Stock"].Value.ToString(), dataGridViewProductos.Rows[rowIndex].Cells["StockIdeal"].Value.ToString(), dataGridViewProductos.Rows[rowIndex].Cells["StockMinimo"].Value.ToString(), dataGridViewProductos.Rows[rowIndex].Cells["Precio"].Value.ToString());
                    richTextBoxProducto.Text = string.Format("Codigo De Producto: {0}\nDescripcion: {1}\nPrecio: ${2}\n", Producto.Codigo, Producto.Descripcion, Producto.Precio);
                    if (!(imagen is null) && imagen.Length > 1 && imagen != "sin imagen")
                    {
                        pictureBoxImagenProductoVenta.Visible = true;
                        pictureBoxImagenProductoVenta.Image = Image.FromFile(pathCarpetaImagenes + imagen);
                    }
                    else
                    {
                        pictureBoxImagenProductoVenta.Visible = false;
                    }
                    float auxPrecio;
                    if (float.TryParse(dataGridViewProductos.Rows[rowIndex].Cells["Precio"].Value.ToString(), out auxPrecio))
                    {
                        Producto.Precio = auxPrecio;
                    }
                    else
                    {
                        MessageBox.Show("ERRROR EN EL PRECIO");
                    }
                }
            }
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
            string codigo = textBoxCodigo.Text;
            string descripcion = textBoxDescripcion.Text;
            string imagen = textBoxImagen.Text;
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
                                        if (!(textBoxImagen.Text is null) && (textBoxCodigo.Text.ToLower().Length > 1))
                                        {
                                            string[] pathImagenArray = imagen.Split('\\');
                                            string newPathImage = this.ObtenerPathCarpetaImagenes() + pathImagenArray[pathImagenArray.Length - 1];
                                            if (Int32.TryParse(textBoxIndice.Text, out id))//si tiene id es porque es un producto ya ingresado.
                                            {
                                                /*string codigo = textBoxCodigo.Text;
                                                string descripcion = textBoxDescripcion.Text;
                                                string imagen = textBoxImagen.Text;*/                                              
                                                retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio, imagen, id);
                                            }
                                            else//si no tiene id quiere decir que es un producto nuevo y requiere de un id.
                                            {
                                                /*string codigo = textBoxCodigo.Text;
                                                string descripcion = textBoxDescripcion.Text;
                                                string imagen = textBoxImagen.Text;*/
                                                retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio, imagen);                                                
                                            }
                                        }
                                        else
                                        {

                                            if (Int32.TryParse(textBoxIndice.Text, out id))//si tiene id es porque es un producto ya ingresado.
                                            {
                                                /*string codigo = textBoxCodigo.Text;
                                                string descripcion = textBoxDescripcion.Text;*/
                                                retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio, id);
                                            }
                                            else//si no tiene id quiere decir que es un producto nuevo y requiere de un id.
                                            {
                                                /*string codigo = textBoxCodigo.Text;
                                                string descripcion = textBoxDescripcion.Text;*/
                                                retorno = new Producto(codigo, descripcion, stock, stockIdeal, stockMinimo, precio);
                                            }
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
                this.copiarImagenSeleccionadaALaCarpetaImagenes(auxProducto,"productos\\");

                ProductosDAO.InsertarProducto(auxProducto);
                CargarDatosAlGridView();
                textBoxCodigo.Focus();
            }
            catch (ProductoRepetidoException exception)
            {
                MessageBox.Show(exception.Message);
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
        /// Selecciona una imagen que representara al producto y devuelve un string con el path de la imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private string ObtenerPathCarpetaImagenes()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
            projectDirectory += "\\Imegenes\\";
            return projectDirectory;
        }
        /// <summary>
        /// crea un thread para la apertura del FileDialog y establece el thread como 'STA'(hilo principal)
        /// agrega el thread al Mock de thread en 'Program.MockThreads'.
        /// </summary>
        private void CreaYEjecutaThreadSeleccionarImagen(OpenFileDialog openFile)
        {
            Thread threadSeleccionarImagen = new Thread(new ParameterizedThreadStart(param => { openFile.ShowDialog(); }));
            Program.MockThreads.Add(threadSeleccionarImagen);//lo agrego a la lista de threads para cerrar.
            threadSeleccionarImagen.SetApartmentState(ApartmentState.STA);
            threadSeleccionarImagen.Start();
            threadSeleccionarImagen.Join();//hasta que no finaliza el hilo el resto del codigo se pausa.
        }
        private string SeleccionarImagen()
        {
            string pathDeImagen;
            OpenFileDialog openFile = new OpenFileDialog();
            CreaYEjecutaThreadSeleccionarImagen(openFile);
            pathDeImagen = openFile.FileName;
            return pathDeImagen;
        }
        /// <summary>
        /// carga la imagen seleccionada al PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeleccionarImagen_Click(object sender, EventArgs e)
        {
            string pathDeImagen = SeleccionarImagen();
            if (pathDeImagen.EndsWith(".png") || pathDeImagen.EndsWith(".jpg"))
            {
                pictureBoxImagenProducto.Image = Image.FromFile(pathDeImagen);//cargo la imagen al pictureBox
                textBoxImagen.Text = pathDeImagen;
            }
            else
            {
                MessageBox.Show("ERROR, eso no es una imagen.");
            }
        }

        private void eliminarFotoFisica(string pathFileToRemove) {
            try
            {
                pictureBoxImagenProducto.Image = null;
                Application.DoEvents();
                if (System.IO.File.Exists(pathFileToRemove) == true)
                {
                    System.IO.File.Delete(pathFileToRemove);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        /// <summary>
        /// remueve un producto de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = LeerProductoDelFormulario();
            string lala=producto.Imagen;
            ProductosDAO.Remover(producto);
            string pathFileToRemove = this.ObtenerPathCarpetaImagenes() + "productos\\" + producto.Imagen;
            this.eliminarFotoFisica(pathFileToRemove);
            
            CargarDatosAlGridView();
            textBoxCodigo.Text = "";
            textBoxDescripcion.Text ="";
            textBoxStock.Text = "";
            textBoxStockMinimo.Text = "";
            textBoxStockIdeal.Text = "";
            textBoxPrecio.Text = "";
            textBoxIndice.Text = "";
            textBoxImagen.Text = "";
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
                Producto productoActualizado = LeerProductoDelFormulario();
                Producto auxProductoOriginal =ProductosDAO.ObtenerProductoPorCodigo(productoActualizado.Codigo);
                //MessageBox.Show(productoActualizado.Imagen.ToLower()+auxProductoOriginal.Imagen.ToLower());
                if (!(productoActualizado is null))
                {
                    int id;
                    if (Int32.TryParse(textBoxIndice.Text, out id))
                    {
                        if (productoActualizado.Imagen != auxProductoOriginal.Imagen) { 
                           this.eliminarFotoFisica(this.ObtenerPathCarpetaImagenes()+"productos\\"+auxProductoOriginal.Imagen);
                           this.copiarImagenSeleccionadaALaCarpetaImagenes(productoActualizado, "productos\\");
                        }
                        ProductosDAO.ModificarProducto(productoActualizado);
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
                MessageBox.Show("Error al modificar un Producto, puede que algun dato no este ingresado " + exception.Message);
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
        /// <summary>
        /// Calcula el costo final de un producto basandose en la cantidad x el precio.
        /// </summary>
        /// <param name="cantidad"></param>
        /// <param name="precio"></param>
        /// <returns></returns>
        private float CalcularPrecioTotal(int cantidad, float precio)
        {
            float retorno = 0;
            if (cantidad != 0 && precio != 0)
            {
                retorno = precio * cantidad;
            }
            return retorno;
        }
        /// <summary>
        /// verifica si hay stock disponible para la cantidad de productos a comprar
        /// </summary>
        /// <param name="cantidadAComprar"></param>
        /// <returns></returns>
        private bool VerificarStockDisponible(int cantidadAComprar)
        {
            bool retorno = false;
            if (producto.Stock >= cantidadAComprar)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Limpia Los ListBox y recorre el carrito de compras, agregando los detalles de las compras a los listBox
        /// </summary>
        /// <param name="carrito"></param>
        private void MostrarDatosDeCompraEnLosListBox(Carrito carrito)
        {
            listBoxCantidad.Items.Clear();
            listBoxCarrito.Items.Clear();
            listBoxPrecio.Items.Clear();
            listBoxPrecioTotal.Items.Clear();
            foreach (Compra compra in Carrito.Compras)
            {
                listBoxCantidad.Items.Add(compra.Cantidad.ToString());
                listBoxCarrito.Items.Add(string.Format("{0}", compra.Descripcion));
                listBoxPrecio.Items.Add("$" + compra.Precio.ToString());
                listBoxPrecioTotal.Items.Add("$" + (compra.Cantidad * compra.Precio).ToString());
            }
        }
        /// <summary>
        /// valida los datos y verifica si el stock disponible es menor al exigido en la compra.
        /// </summary>
        /// <param name="formCantidad"></param>
        /// <returns></returns>
        private bool ValidarDatosDeLaCompra(FormCantidad formCantidad)
        {
            bool retorno = false;
            if (!(producto is null))//si tiene seleccionado un producto, entra.
            {
                if (!(formCantidad.Cantidad == 0))
                {
                    if (VerificarStockDisponible(formCantidad.Cantidad))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("El stock disponible es de " + producto.Stock + " no podemos vender mas de eso.");
                    }
                }
            }
            else
            {
                //tengo que agregar un evento que para que no aparesca este mensaje si cancelo el form cantidad.
                if (!(formCantidad.Name == "Cancelado"))
                {
                    MessageBox.Show("Debe Seleccionar un producto para poder agregarlo.");
                }
            }
            return retorno;
        }
        /// <summary>
        /// verifica si ese producto ya esta en el carrito de compras. si lo esta, suma las cantidades y modifica la compra existente.
        /// </summary>
        /// <param name="codigoDelProducto"></param>
        /// <returns>retorna true en caso de que este repetido</returns>
        private bool ValidarProductoRepetido(string codigoDelProducto)
        {
            bool retorno = false;
            foreach (Compra compra in Carrito.Compras)
            {
                if (compra.Codigo == codigoDelProducto)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// si un producto esta repetido, calcula cual es la cantidad a comprar entre todos los productos iguales
        /// </summary>
        /// <param name="codigoDelProducto"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        private int CalcularCantidadActual(string codigoDelProducto, int cantidad)
        {
            int retorno = cantidad;
            foreach (Compra compra in Carrito.Compras)
            {
                if (compra.Codigo == codigoDelProducto)
                {
                    retorno = compra.Cantidad + cantidad;
                    if (retorno <= compra.Stock)
                    {
                        compra.Cantidad = retorno;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// agrega una compra al carrito de compras. y lo mustra en los listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarVenta_Click(object sender, EventArgs e)
        {
            FormCantidad formCantidad = new FormCantidad();
            formCantidad.ShowDialog();
            float auxTotal = 0;
            try
            {
                if (ValidarDatosDeLaCompra(formCantidad))
                {
                    //armar el carrito
                    Compra compra = new Compra(Producto.Codigo, producto.Descripcion, producto.Stock, producto.StockIdeal, producto.StockMinimo, producto.Precio, formCantidad.Cantidad);
                    if (Carrito.Compras.Count > 0)
                    {
                        if (ValidarProductoRepetido(Producto.Codigo))//verifica si este producto ya esta en la lista de compras
                        {
                            int cantidadActual = CalcularCantidadActual(Producto.Codigo, formCantidad.Cantidad);
                            if (VerificarStockDisponible(cantidadActual))
                            {
                                compra.Cantidad = cantidadActual;
                                auxTotal = CalcularPrecioTotal(cantidadActual, compra.Precio);
                                MostrarDatosDeCompraEnLosListBox(Carrito);
                            }
                            else
                            {
                                throw new StockInvalidException("No hay stock suficiente para este pedido");
                            }
                        }
                        else
                        {
                            Carrito.Compras.Add(compra);
                            auxTotal = CalcularPrecioTotal(compra.Cantidad, compra.Precio);
                            MostrarDatosDeCompraEnLosListBox(Carrito);
                        }
                    }
                    else
                    {
                        Carrito.Compras.Add(compra);
                        auxTotal = CalcularPrecioTotal(compra.Cantidad, compra.Precio);
                        MostrarDatosDeCompraEnLosListBox(Carrito);
                    }
                }
                richTextBoxTotalProductos.Text = "$"+this.calcularTotalDelCarrito().ToString();
            }
            catch (StockInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch
            {

            }

        }

        private float calcularTotalDelCarrito() {
            float total = 0;
            foreach (Compra compra in this.carrito.Compras) {
             total+=   (compra.Cantidad * compra.Precio);
            }
            return total;
        }

        private void IniciarFormVenta()
        {
            FormVenta formVenta = new FormVenta();
            formVenta.Carrito = this.Carrito;
            formVenta.ShowDialog();
        }
        /// <summary>
        /// finaliza la lista de compras y abre el formFinalizarVenta para la facturacion final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (this.carrito.Compras.Count > 0)
            {
                ThreadVenta = new Thread(IniciarFormVenta);
                Program.MockThreads.Add(ThreadVenta);
                if (!(ThreadVenta.IsAlive))
                {
                    ThreadVenta.Start();
                }
                this.Close();
            }
            else {
                MessageBox.Show("Debe agregar al menos un producto para continuar.");
            }
        }
        /// <summary>
        /// alerta al usuario de los productos con stock basico. (naranja= stock minimo) (rojo= stock por debajo del minimo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProductos.Columns[e.ColumnIndex].Name == "Stock")
            {
              /*  if (Convert.ToInt32(e.Value) < Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(e.Value) == Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["StockMinimo"].Value))
                {
                    e.CellStyle.BackColor = Color.Orange;
                }*/
            }
        }
        private void copiarImagenSeleccionadaALaCarpetaImagenes(Producto producto, string subFolder = "") {
            string sourceFile= textBoxImagen.Text;
            string targetPath = this.ObtenerPathCarpetaImagenes()+subFolder;
            string[] pathImagenArray = textBoxImagen.Text.Split('.');
            producto.Imagen = producto.Descripcion.Replace(' ', '_') + "." + pathImagenArray[pathImagenArray.Length-1];
       
            string destFile = System.IO.Path.Combine(targetPath, producto.Imagen);
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        private void dataGridViewProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.seleccionarProducto(e.RowIndex);
        }

        private void buttonQuitarVenta_Click(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedItem != null)
            {
                foreach (Compra compra in this.carrito.Compras)
                {
                    if (compra.Descripcion == listBoxCarrito.SelectedItem.ToString())
                    {
                        this.carrito.Compras.Remove(compra);
                        MostrarDatosDeCompraEnLosListBox(this.carrito);
                        richTextBoxTotalProductos.Text = "$" + this.calcularTotalDelCarrito().ToString();
                        break;
                    }
                }
            }
            else {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }
    }
}
