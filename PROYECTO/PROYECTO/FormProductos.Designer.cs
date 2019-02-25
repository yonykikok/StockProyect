﻿namespace PROYECTO
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCargarProducto = new System.Windows.Forms.Panel();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.pictureBoxImagenProducto = new System.Windows.Forms.PictureBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxStockMinimo = new System.Windows.Forms.TextBox();
            this.textBoxStockIdeal = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelStockMinimo = new System.Windows.Forms.Label();
            this.labelStockIdeal = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonQuitarProducto = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonModificarProducto = new System.Windows.Forms.Button();
            this.panelPagos = new System.Windows.Forms.Panel();
            this.buttonAgregarProducto = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSeleccionarImagen = new System.Windows.Forms.Button();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProductosVentas = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonAgregarVenta = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonFinalizarVenta = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonQuitarVenta = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.listBoxCantidad = new System.Windows.Forms.ListBox();
            this.listBoxPrecioTotal = new System.Windows.Forms.ListBox();
            this.listBoxPrecio = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxProducto = new System.Windows.Forms.RichTextBox();
            this.panelVenderProductos = new System.Windows.Forms.Panel();
            this.pictureBoxImagenProductoVenta = new System.Windows.Forms.PictureBox();
            this.labelResultadoBusqueda = new System.Windows.Forms.Label();
            this.panelEnvios = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panelCargarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelVenderProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProductoVenta)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridViewProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Codigo,
            this.Descripcion,
            this.Stock,
            this.StockIdeal,
            this.StockMinimo,
            this.Precio,
            this.Imagen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductos.Size = new System.Drawing.Size(836, 475);
            this.dataGridViewProductos.TabIndex = 10;
            this.dataGridViewProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProductos_CellFormatting);
            this.dataGridViewProductos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductos_RowHeaderMouseDoubleClick);
            // 
            // Indice
            // 
            this.Indice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            this.Indice.Width = 77;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Codigo.HeaderText = "Codigo Producto";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 152;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 75;
            // 
            // StockIdeal
            // 
            this.StockIdeal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StockIdeal.HeaderText = "Stock Ideal";
            this.StockIdeal.Name = "StockIdeal";
            this.StockIdeal.Width = 114;
            // 
            // StockMinimo
            // 
            this.StockMinimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StockMinimo.HeaderText = "Stock Minimo";
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.Width = 129;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // panelCargarProducto
            // 
            this.panelCargarProducto.Controls.Add(this.textBoxImagen);
            this.panelCargarProducto.Controls.Add(this.textBoxIndice);
            this.panelCargarProducto.Controls.Add(this.pictureBoxImagenProducto);
            this.panelCargarProducto.Controls.Add(this.textBoxPrecio);
            this.panelCargarProducto.Controls.Add(this.textBoxStockMinimo);
            this.panelCargarProducto.Controls.Add(this.textBoxStockIdeal);
            this.panelCargarProducto.Controls.Add(this.textBoxStock);
            this.panelCargarProducto.Controls.Add(this.textBoxDescripcion);
            this.panelCargarProducto.Controls.Add(this.textBoxCodigo);
            this.panelCargarProducto.Controls.Add(this.labelImagen);
            this.panelCargarProducto.Controls.Add(this.labelPrecio);
            this.panelCargarProducto.Controls.Add(this.labelStockMinimo);
            this.panelCargarProducto.Controls.Add(this.labelStockIdeal);
            this.panelCargarProducto.Controls.Add(this.labelStock);
            this.panelCargarProducto.Controls.Add(this.labelDescripcion);
            this.panelCargarProducto.Controls.Add(this.labelCodigo);
            this.panelCargarProducto.Controls.Add(this.panel4);
            this.panelCargarProducto.Controls.Add(this.panel3);
            this.panelCargarProducto.Controls.Add(this.buttonQuitarProducto);
            this.panelCargarProducto.Controls.Add(this.panel5);
            this.panelCargarProducto.Controls.Add(this.buttonModificarProducto);
            this.panelCargarProducto.Controls.Add(this.panelPagos);
            this.panelCargarProducto.Controls.Add(this.buttonAgregarProducto);
            this.panelCargarProducto.Controls.Add(this.panel6);
            this.panelCargarProducto.Controls.Add(this.buttonSeleccionarImagen);
            this.panelCargarProducto.Location = new System.Drawing.Point(842, 82);
            this.panelCargarProducto.Name = "panelCargarProducto";
            this.panelCargarProducto.Size = new System.Drawing.Size(314, 418);
            this.panelCargarProducto.TabIndex = 2;
            this.panelCargarProducto.Visible = false;
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(97, 33);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(199, 20);
            this.textBoxImagen.TabIndex = 51;
            this.textBoxImagen.Visible = false;
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Location = new System.Drawing.Point(97, 137);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.Size = new System.Drawing.Size(199, 20);
            this.textBoxIndice.TabIndex = 7;
            this.textBoxIndice.Visible = false;
            // 
            // pictureBoxImagenProducto
            // 
            this.pictureBoxImagenProducto.Location = new System.Drawing.Point(6, 195);
            this.pictureBoxImagenProducto.Name = "pictureBoxImagenProducto";
            this.pictureBoxImagenProducto.Size = new System.Drawing.Size(302, 154);
            this.pictureBoxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenProducto.TabIndex = 50;
            this.pictureBoxImagenProducto.TabStop = false;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(97, 137);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(199, 20);
            this.textBoxPrecio.TabIndex = 47;
            // 
            // textBoxStockMinimo
            // 
            this.textBoxStockMinimo.Location = new System.Drawing.Point(97, 111);
            this.textBoxStockMinimo.Name = "textBoxStockMinimo";
            this.textBoxStockMinimo.Size = new System.Drawing.Size(199, 20);
            this.textBoxStockMinimo.TabIndex = 6;
            // 
            // textBoxStockIdeal
            // 
            this.textBoxStockIdeal.Location = new System.Drawing.Point(97, 85);
            this.textBoxStockIdeal.Name = "textBoxStockIdeal";
            this.textBoxStockIdeal.Size = new System.Drawing.Size(199, 20);
            this.textBoxStockIdeal.TabIndex = 5;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(97, 59);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(199, 20);
            this.textBoxStock.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(97, 33);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(199, 20);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(97, 7);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(199, 20);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.ForeColor = System.Drawing.Color.White;
            this.labelImagen.Location = new System.Drawing.Point(8, 170);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(42, 13);
            this.labelImagen.TabIndex = 40;
            this.labelImagen.Text = "Imagen";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(8, 144);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 39;
            this.labelPrecio.Text = "Precio";
            // 
            // labelStockMinimo
            // 
            this.labelStockMinimo.AutoSize = true;
            this.labelStockMinimo.ForeColor = System.Drawing.Color.White;
            this.labelStockMinimo.Location = new System.Drawing.Point(8, 118);
            this.labelStockMinimo.Name = "labelStockMinimo";
            this.labelStockMinimo.Size = new System.Drawing.Size(71, 13);
            this.labelStockMinimo.TabIndex = 38;
            this.labelStockMinimo.Text = "Stock Minimo";
            // 
            // labelStockIdeal
            // 
            this.labelStockIdeal.AutoSize = true;
            this.labelStockIdeal.ForeColor = System.Drawing.Color.White;
            this.labelStockIdeal.Location = new System.Drawing.Point(8, 92);
            this.labelStockIdeal.Name = "labelStockIdeal";
            this.labelStockIdeal.Size = new System.Drawing.Size(61, 13);
            this.labelStockIdeal.TabIndex = 37;
            this.labelStockIdeal.Text = "Stock Ideal";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(8, 66);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 36;
            this.labelStock.Text = "Stock";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.Color.White;
            this.labelDescripcion.Location = new System.Drawing.Point(8, 40);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 35;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(8, 14);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 34;
            this.labelCodigo.Text = "Codigo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(299, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(205, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 33;
            // 
            // buttonQuitarProducto
            // 
            this.buttonQuitarProducto.FlatAppearance.BorderSize = 0;
            this.buttonQuitarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.buttonQuitarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitarProducto.Location = new System.Drawing.Point(208, 378);
            this.buttonQuitarProducto.Name = "buttonQuitarProducto";
            this.buttonQuitarProducto.Size = new System.Drawing.Size(96, 32);
            this.buttonQuitarProducto.TabIndex = 11;
            this.buttonQuitarProducto.Text = "Quitar";
            this.buttonQuitarProducto.UseVisualStyleBackColor = true;
            this.buttonQuitarProducto.Click += new System.EventHandler(this.buttonQuitarProducto_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(111, 378);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 31;
            // 
            // buttonModificarProducto
            // 
            this.buttonModificarProducto.FlatAppearance.BorderSize = 0;
            this.buttonModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarProducto.ForeColor = System.Drawing.Color.White;
            this.buttonModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificarProducto.Location = new System.Drawing.Point(114, 378);
            this.buttonModificarProducto.Name = "buttonModificarProducto";
            this.buttonModificarProducto.Size = new System.Drawing.Size(96, 32);
            this.buttonModificarProducto.TabIndex = 10;
            this.buttonModificarProducto.Text = "Modificar";
            this.buttonModificarProducto.UseVisualStyleBackColor = true;
            this.buttonModificarProducto.Click += new System.EventHandler(this.buttonModificarProducto_Click);
            // 
            // panelPagos
            // 
            this.panelPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelPagos.Location = new System.Drawing.Point(17, 378);
            this.panelPagos.Name = "panelPagos";
            this.panelPagos.Size = new System.Drawing.Size(5, 32);
            this.panelPagos.TabIndex = 28;
            // 
            // buttonAgregarProducto
            // 
            this.buttonAgregarProducto.FlatAppearance.BorderSize = 0;
            this.buttonAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarProducto.Location = new System.Drawing.Point(20, 378);
            this.buttonAgregarProducto.Name = "buttonAgregarProducto";
            this.buttonAgregarProducto.Size = new System.Drawing.Size(96, 32);
            this.buttonAgregarProducto.TabIndex = 9;
            this.buttonAgregarProducto.Text = "Agregar";
            this.buttonAgregarProducto.UseVisualStyleBackColor = true;
            this.buttonAgregarProducto.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(96, 164);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 25);
            this.panel6.TabIndex = 5;
            // 
            // buttonSeleccionarImagen
            // 
            this.buttonSeleccionarImagen.FlatAppearance.BorderSize = 0;
            this.buttonSeleccionarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionarImagen.ForeColor = System.Drawing.Color.White;
            this.buttonSeleccionarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeleccionarImagen.Location = new System.Drawing.Point(101, 164);
            this.buttonSeleccionarImagen.Name = "buttonSeleccionarImagen";
            this.buttonSeleccionarImagen.Size = new System.Drawing.Size(195, 25);
            this.buttonSeleccionarImagen.TabIndex = 8;
            this.buttonSeleccionarImagen.Text = "Seleccionar Imagen";
            this.buttonSeleccionarImagen.UseVisualStyleBackColor = true;
            this.buttonSeleccionarImagen.Click += new System.EventHandler(this.buttonSeleccionarImagen_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1138, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(1117, 3);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.labelProductosVentas);
            this.panel1.Controls.Add(this.pictureBoxMinimizar);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProductos_MouseDown);
            // 
            // labelProductosVentas
            // 
            this.labelProductosVentas.AutoSize = true;
            this.labelProductosVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductosVentas.ForeColor = System.Drawing.Color.White;
            this.labelProductosVentas.Location = new System.Drawing.Point(487, 2);
            this.labelProductosVentas.Name = "labelProductosVentas";
            this.labelProductosVentas.Size = new System.Drawing.Size(128, 20);
            this.labelProductosVentas.TabIndex = 4;
            this.labelProductosVentas.Text = "Multitask-Ventas";
            this.labelProductosVentas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProductos_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1516, 722);
            this.panel7.TabIndex = 5;
            // 
            // buttonAgregarVenta
            // 
            this.buttonAgregarVenta.FlatAppearance.BorderSize = 0;
            this.buttonAgregarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarVenta.Location = new System.Drawing.Point(17, 387);
            this.buttonAgregarVenta.Name = "buttonAgregarVenta";
            this.buttonAgregarVenta.Size = new System.Drawing.Size(96, 32);
            this.buttonAgregarVenta.TabIndex = 9;
            this.buttonAgregarVenta.Text = "Agregar";
            this.buttonAgregarVenta.UseVisualStyleBackColor = true;
            this.buttonAgregarVenta.Click += new System.EventHandler(this.buttonAgregarVenta_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(14, 387);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 32);
            this.panel11.TabIndex = 28;
            // 
            // buttonFinalizarVenta
            // 
            this.buttonFinalizarVenta.FlatAppearance.BorderSize = 0;
            this.buttonFinalizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonFinalizarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFinalizarVenta.Location = new System.Drawing.Point(111, 387);
            this.buttonFinalizarVenta.Name = "buttonFinalizarVenta";
            this.buttonFinalizarVenta.Size = new System.Drawing.Size(96, 32);
            this.buttonFinalizarVenta.TabIndex = 10;
            this.buttonFinalizarVenta.Text = "Finalizar";
            this.buttonFinalizarVenta.UseVisualStyleBackColor = true;
            this.buttonFinalizarVenta.Click += new System.EventHandler(this.buttonFinalizarVenta_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(108, 387);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 32);
            this.panel10.TabIndex = 31;
            // 
            // buttonQuitarVenta
            // 
            this.buttonQuitarVenta.FlatAppearance.BorderSize = 0;
            this.buttonQuitarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonQuitarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonQuitarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitarVenta.Location = new System.Drawing.Point(205, 387);
            this.buttonQuitarVenta.Name = "buttonQuitarVenta";
            this.buttonQuitarVenta.Size = new System.Drawing.Size(96, 32);
            this.buttonQuitarVenta.TabIndex = 11;
            this.buttonQuitarVenta.Text = "Quitar";
            this.buttonQuitarVenta.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(202, 387);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 32);
            this.panel9.TabIndex = 33;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(296, 387);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 32);
            this.panel8.TabIndex = 30;
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.Location = new System.Drawing.Point(35, 189);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.Size = new System.Drawing.Size(172, 186);
            this.listBoxCarrito.TabIndex = 34;
            // 
            // listBoxCantidad
            // 
            this.listBoxCantidad.FormattingEnabled = true;
            this.listBoxCantidad.Location = new System.Drawing.Point(5, 189);
            this.listBoxCantidad.Name = "listBoxCantidad";
            this.listBoxCantidad.Size = new System.Drawing.Size(28, 186);
            this.listBoxCantidad.TabIndex = 35;
            // 
            // listBoxPrecioTotal
            // 
            this.listBoxPrecioTotal.FormattingEnabled = true;
            this.listBoxPrecioTotal.Location = new System.Drawing.Point(261, 189);
            this.listBoxPrecioTotal.Name = "listBoxPrecioTotal";
            this.listBoxPrecioTotal.Size = new System.Drawing.Size(49, 186);
            this.listBoxPrecioTotal.TabIndex = 36;
            // 
            // listBoxPrecio
            // 
            this.listBoxPrecio.FormattingEnabled = true;
            this.listBoxPrecio.Location = new System.Drawing.Point(209, 189);
            this.listBoxPrecio.Name = "listBoxPrecio";
            this.listBoxPrecio.Size = new System.Drawing.Size(49, 186);
            this.listBoxPrecio.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cant.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Producto.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "C/u";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(267, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Total";
            // 
            // richTextBoxProducto
            // 
            this.richTextBoxProducto.Location = new System.Drawing.Point(8, 3);
            this.richTextBoxProducto.Name = "richTextBoxProducto";
            this.richTextBoxProducto.ReadOnly = true;
            this.richTextBoxProducto.Size = new System.Drawing.Size(300, 163);
            this.richTextBoxProducto.TabIndex = 42;
            this.richTextBoxProducto.Text = "";
            // 
            // panelVenderProductos
            // 
            this.panelVenderProductos.Controls.Add(this.pictureBoxImagenProductoVenta);
            this.panelVenderProductos.Controls.Add(this.richTextBoxProducto);
            this.panelVenderProductos.Controls.Add(this.label4);
            this.panelVenderProductos.Controls.Add(this.label3);
            this.panelVenderProductos.Controls.Add(this.label2);
            this.panelVenderProductos.Controls.Add(this.label1);
            this.panelVenderProductos.Controls.Add(this.listBoxPrecio);
            this.panelVenderProductos.Controls.Add(this.listBoxPrecioTotal);
            this.panelVenderProductos.Controls.Add(this.listBoxCantidad);
            this.panelVenderProductos.Controls.Add(this.listBoxCarrito);
            this.panelVenderProductos.Controls.Add(this.panel8);
            this.panelVenderProductos.Controls.Add(this.panel9);
            this.panelVenderProductos.Controls.Add(this.buttonQuitarVenta);
            this.panelVenderProductos.Controls.Add(this.panel10);
            this.panelVenderProductos.Controls.Add(this.buttonFinalizarVenta);
            this.panelVenderProductos.Controls.Add(this.panel11);
            this.panelVenderProductos.Controls.Add(this.buttonAgregarVenta);
            this.panelVenderProductos.Location = new System.Drawing.Point(842, 82);
            this.panelVenderProductos.Name = "panelVenderProductos";
            this.panelVenderProductos.Size = new System.Drawing.Size(314, 418);
            this.panelVenderProductos.TabIndex = 3;
            // 
            // pictureBoxImagenProductoVenta
            // 
            this.pictureBoxImagenProductoVenta.BackColor = System.Drawing.Color.White;
            this.pictureBoxImagenProductoVenta.Location = new System.Drawing.Point(157, 66);
            this.pictureBoxImagenProductoVenta.Name = "pictureBoxImagenProductoVenta";
            this.pictureBoxImagenProductoVenta.Size = new System.Drawing.Size(151, 100);
            this.pictureBoxImagenProductoVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenProductoVenta.TabIndex = 43;
            this.pictureBoxImagenProductoVenta.TabStop = false;
            this.pictureBoxImagenProductoVenta.Visible = false;
            // 
            // labelResultadoBusqueda
            // 
            this.labelResultadoBusqueda.AutoSize = true;
            this.labelResultadoBusqueda.ForeColor = System.Drawing.Color.White;
            this.labelResultadoBusqueda.Location = new System.Drawing.Point(3, 31);
            this.labelResultadoBusqueda.Name = "labelResultadoBusqueda";
            this.labelResultadoBusqueda.Size = new System.Drawing.Size(138, 13);
            this.labelResultadoBusqueda.TabIndex = 6;
            this.labelResultadoBusqueda.Text = "Resultado De La Busqueda";
            this.labelResultadoBusqueda.Visible = false;
            // 
            // panelEnvios
            // 
            this.panelEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelEnvios.Location = new System.Drawing.Point(197, 3);
            this.panelEnvios.Name = "panelEnvios";
            this.panelEnvios.Size = new System.Drawing.Size(5, 25);
            this.panelEnvios.TabIndex = 5;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(202, 3);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(106, 25);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.CausesValidation = false;
            this.textBoxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscador.Location = new System.Drawing.Point(6, 3);
            this.textBoxBuscador.MinimumSize = new System.Drawing.Size(25, 25);
            this.textBoxBuscador.Multiline = true;
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(190, 25);
            this.textBoxBuscador.TabIndex = 1;
            this.textBoxBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscador_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxBuscador);
            this.panel2.Controls.Add(this.buttonBuscar);
            this.panel2.Controls.Add(this.panelEnvios);
            this.panel2.Controls.Add(this.labelResultadoBusqueda);
            this.panel2.Location = new System.Drawing.Point(842, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 44);
            this.panel2.TabIndex = 4;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1156, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelVenderProductos);
            this.Controls.Add(this.panelCargarProducto);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panelCargarProducto.ResumeLayout(false);
            this.panelCargarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelVenderProductos.ResumeLayout(false);
            this.panelVenderProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenProductoVenta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Panel panelCargarProducto;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxStockMinimo;
        private System.Windows.Forms.TextBox textBoxStockIdeal;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelStockMinimo;
        private System.Windows.Forms.Label labelStockIdeal;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonQuitarProducto;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonModificarProducto;
        private System.Windows.Forms.Panel panelPagos;
        private System.Windows.Forms.Button buttonAgregarProducto;
        private System.Windows.Forms.PictureBox pictureBoxImagenProducto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonSeleccionarImagen;
        private System.Windows.Forms.TextBox textBoxIndice;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonAgregarVenta;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonFinalizarVenta;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button buttonQuitarVenta;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListBox listBoxCarrito;
        private System.Windows.Forms.ListBox listBoxCantidad;
        private System.Windows.Forms.ListBox listBoxPrecioTotal;
        private System.Windows.Forms.ListBox listBoxPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxProducto;
        private System.Windows.Forms.Panel panelVenderProductos;
        private System.Windows.Forms.Label labelResultadoBusqueda;
        private System.Windows.Forms.Panel panelEnvios;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.PictureBox pictureBoxImagenProductoVenta;
        private System.Windows.Forms.Label labelProductosVentas;
    }
}