namespace PROYECTO
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ButtonMinimizar = new System.Windows.Forms.Panel();
            this.labelMultitask = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonMaximizar = new System.Windows.Forms.PictureBox();
            this.ButtonCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.buttonReportesStockBajo = new System.Windows.Forms.Button();
            this.buttonReportesCompras = new System.Windows.Forms.Button();
            this.panelSubPagos = new System.Windows.Forms.Panel();
            this.panelSubCompras = new System.Windows.Forms.Panel();
            this.panelSubVentas = new System.Windows.Forms.Panel();
            this.buttonReportesVentas = new System.Windows.Forms.Button();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.panelPagos = new System.Windows.Forms.Panel();
            this.buttonReparaciones = new System.Windows.Forms.Button();
            this.buttonEnvios = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.panelEnvios = new System.Windows.Forms.Panel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonDeudas = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelGlobalOpciones = new System.Windows.Forms.Panel();
            this.panelPrincipalStockBajo = new System.Windows.Forms.Panel();
            this.buttonImprimirLista = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewProductosStockBajo = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipalEstadistica = new System.Windows.Forms.Panel();
            this.panelOpcionesEstadisticas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAnual = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMensual = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonSemanal = new System.Windows.Forms.Button();
            this.chartEstadisticaGlobal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonMinimizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCerrar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelGlobalOpciones.SuspendLayout();
            this.panelPrincipalStockBajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosStockBajo)).BeginInit();
            this.panelPrincipalEstadistica.SuspendLayout();
            this.panelOpcionesEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticaGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMinimizar
            // 
            this.ButtonMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ButtonMinimizar.Controls.Add(this.labelMultitask);
            this.ButtonMinimizar.Controls.Add(this.pictureBox2);
            this.ButtonMinimizar.Controls.Add(this.ButtonMaximizar);
            this.ButtonMinimizar.Controls.Add(this.ButtonCerrar);
            this.ButtonMinimizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMinimizar.Location = new System.Drawing.Point(0, 0);
            this.ButtonMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonMinimizar.Name = "ButtonMinimizar";
            this.ButtonMinimizar.Size = new System.Drawing.Size(1733, 43);
            this.ButtonMinimizar.TabIndex = 0;
            this.ButtonMinimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinimizar_MouseDown);
            // 
            // labelMultitask
            // 
            this.labelMultitask.AutoSize = true;
            this.labelMultitask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMultitask.ForeColor = System.Drawing.Color.White;
            this.labelMultitask.Location = new System.Drawing.Point(804, 5);
            this.labelMultitask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMultitask.Name = "labelMultitask";
            this.labelMultitask.Size = new System.Drawing.Size(122, 31);
            this.labelMultitask.TabIndex = 5;
            this.labelMultitask.Text = "Multitask";
            this.labelMultitask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinimizar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1613, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ButtonMaximizar
            // 
            this.ButtonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMaximizar.Image")));
            this.ButtonMaximizar.Location = new System.Drawing.Point(1655, 5);
            this.ButtonMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonMaximizar.Name = "ButtonMaximizar";
            this.ButtonMaximizar.Size = new System.Drawing.Size(33, 31);
            this.ButtonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMaximizar.TabIndex = 1;
            this.ButtonMaximizar.TabStop = false;
            this.ButtonMaximizar.Click += new System.EventHandler(this.ButtonMaximizar_Click);
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCerrar.Image")));
            this.ButtonCerrar.Location = new System.Drawing.Point(1696, 5);
            this.ButtonCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(33, 31);
            this.ButtonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCerrar.TabIndex = 0;
            this.ButtonCerrar.TabStop = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.panelEmpleados);
            this.panelMenuVertical.Controls.Add(this.buttonEmpleados);
            this.panelMenuVertical.Controls.Add(this.panelSubMenu);
            this.panelMenuVertical.Controls.Add(this.panelReportes);
            this.panelMenuVertical.Controls.Add(this.panelPagos);
            this.panelMenuVertical.Controls.Add(this.buttonReparaciones);
            this.panelMenuVertical.Controls.Add(this.buttonEnvios);
            this.panelMenuVertical.Controls.Add(this.panelUsuarios);
            this.panelMenuVertical.Controls.Add(this.panelEnvios);
            this.panelMenuVertical.Controls.Add(this.panelVentas);
            this.panelMenuVertical.Controls.Add(this.panelClientes);
            this.panelMenuVertical.Controls.Add(this.buttonClientes);
            this.panelMenuVertical.Controls.Add(this.buttonDeudas);
            this.panelMenuVertical.Controls.Add(this.buttonReportes);
            this.panelMenuVertical.Controls.Add(this.buttonVentas);
            this.panelMenuVertical.Controls.Add(this.panelProductos);
            this.panelMenuVertical.Controls.Add(this.buttonProductos);
            this.panelMenuVertical.Controls.Add(this.pictureBoxLogo);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 43);
            this.panelMenuVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(293, 757);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelEmpleados.Location = new System.Drawing.Point(0, 165);
            this.panelEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(7, 39);
            this.panelEmpleados.TabIndex = 2;
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.FlatAppearance.BorderSize = 0;
            this.buttonEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleados.ForeColor = System.Drawing.Color.White;
            this.buttonEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmpleados.Image")));
            this.buttonEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleados.Location = new System.Drawing.Point(5, 165);
            this.buttonEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(288, 39);
            this.buttonEmpleados.TabIndex = 9;
            this.buttonEmpleados.Text = "Empleados";
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.buttonReportesStockBajo);
            this.panelSubMenu.Controls.Add(this.buttonReportesCompras);
            this.panelSubMenu.Controls.Add(this.panelSubPagos);
            this.panelSubMenu.Controls.Add(this.panelSubCompras);
            this.panelSubMenu.Controls.Add(this.panelSubVentas);
            this.panelSubMenu.Controls.Add(this.buttonReportesVentas);
            this.panelSubMenu.Location = new System.Drawing.Point(41, 539);
            this.panelSubMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(244, 143);
            this.panelSubMenu.TabIndex = 8;
            this.panelSubMenu.Visible = false;
            // 
            // buttonReportesStockBajo
            // 
            this.buttonReportesStockBajo.FlatAppearance.BorderSize = 0;
            this.buttonReportesStockBajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReportesStockBajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesStockBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesStockBajo.ForeColor = System.Drawing.Color.White;
            this.buttonReportesStockBajo.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportesStockBajo.Image")));
            this.buttonReportesStockBajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportesStockBajo.Location = new System.Drawing.Point(7, 89);
            this.buttonReportesStockBajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportesStockBajo.Name = "buttonReportesStockBajo";
            this.buttonReportesStockBajo.Size = new System.Drawing.Size(232, 39);
            this.buttonReportesStockBajo.TabIndex = 11;
            this.buttonReportesStockBajo.Text = "Stock Bajo";
            this.buttonReportesStockBajo.UseVisualStyleBackColor = true;
            this.buttonReportesStockBajo.Click += new System.EventHandler(this.buttonReportesStockBajo_Click);
            // 
            // buttonReportesCompras
            // 
            this.buttonReportesCompras.FlatAppearance.BorderSize = 0;
            this.buttonReportesCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReportesCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesCompras.ForeColor = System.Drawing.Color.White;
            this.buttonReportesCompras.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportesCompras.Image")));
            this.buttonReportesCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportesCompras.Location = new System.Drawing.Point(7, 44);
            this.buttonReportesCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportesCompras.Name = "buttonReportesCompras";
            this.buttonReportesCompras.Size = new System.Drawing.Size(232, 39);
            this.buttonReportesCompras.TabIndex = 10;
            this.buttonReportesCompras.Text = "Compras";
            this.buttonReportesCompras.UseVisualStyleBackColor = true;
            this.buttonReportesCompras.Click += new System.EventHandler(this.buttonReportesCompras_Click);
            // 
            // panelSubPagos
            // 
            this.panelSubPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSubPagos.Location = new System.Drawing.Point(0, 89);
            this.panelSubPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubPagos.Name = "panelSubPagos";
            this.panelSubPagos.Size = new System.Drawing.Size(7, 39);
            this.panelSubPagos.TabIndex = 4;
            // 
            // panelSubCompras
            // 
            this.panelSubCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSubCompras.Location = new System.Drawing.Point(0, 44);
            this.panelSubCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubCompras.Name = "panelSubCompras";
            this.panelSubCompras.Size = new System.Drawing.Size(7, 39);
            this.panelSubCompras.TabIndex = 4;
            // 
            // panelSubVentas
            // 
            this.panelSubVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSubVentas.Location = new System.Drawing.Point(0, 0);
            this.panelSubVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubVentas.Name = "panelSubVentas";
            this.panelSubVentas.Size = new System.Drawing.Size(7, 39);
            this.panelSubVentas.TabIndex = 4;
            // 
            // buttonReportesVentas
            // 
            this.buttonReportesVentas.FlatAppearance.BorderSize = 0;
            this.buttonReportesVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesVentas.ForeColor = System.Drawing.Color.White;
            this.buttonReportesVentas.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportesVentas.Image")));
            this.buttonReportesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportesVentas.Location = new System.Drawing.Point(4, 0);
            this.buttonReportesVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportesVentas.Name = "buttonReportesVentas";
            this.buttonReportesVentas.Size = new System.Drawing.Size(232, 39);
            this.buttonReportesVentas.TabIndex = 9;
            this.buttonReportesVentas.Text = "Ventas";
            this.buttonReportesVentas.UseVisualStyleBackColor = true;
            this.buttonReportesVentas.Click += new System.EventHandler(this.buttonReportesVentas_Click);
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelReportes.Location = new System.Drawing.Point(0, 492);
            this.panelReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(7, 39);
            this.panelReportes.TabIndex = 3;
            // 
            // panelPagos
            // 
            this.panelPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelPagos.Location = new System.Drawing.Point(0, 446);
            this.panelPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPagos.Name = "panelPagos";
            this.panelPagos.Size = new System.Drawing.Size(7, 39);
            this.panelPagos.TabIndex = 3;
            // 
            // buttonReparaciones
            // 
            this.buttonReparaciones.FlatAppearance.BorderSize = 0;
            this.buttonReparaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReparaciones.ForeColor = System.Drawing.Color.White;
            this.buttonReparaciones.Image = ((System.Drawing.Image)(resources.GetObject("buttonReparaciones.Image")));
            this.buttonReparaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReparaciones.Location = new System.Drawing.Point(7, 399);
            this.buttonReparaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReparaciones.Name = "buttonReparaciones";
            this.buttonReparaciones.Size = new System.Drawing.Size(287, 39);
            this.buttonReparaciones.TabIndex = 7;
            this.buttonReparaciones.Text = "Reparaciones";
            this.buttonReparaciones.UseVisualStyleBackColor = true;
            this.buttonReparaciones.Click += new System.EventHandler(this.buttonReparaciones_Click);
            // 
            // buttonEnvios
            // 
            this.buttonEnvios.FlatAppearance.BorderSize = 0;
            this.buttonEnvios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnvios.ForeColor = System.Drawing.Color.White;
            this.buttonEnvios.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnvios.Image")));
            this.buttonEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnvios.Location = new System.Drawing.Point(7, 352);
            this.buttonEnvios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnvios.Name = "buttonEnvios";
            this.buttonEnvios.Size = new System.Drawing.Size(287, 39);
            this.buttonEnvios.TabIndex = 6;
            this.buttonEnvios.Text = "Envios";
            this.buttonEnvios.UseVisualStyleBackColor = true;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelUsuarios.Location = new System.Drawing.Point(0, 399);
            this.panelUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(7, 39);
            this.panelUsuarios.TabIndex = 2;
            // 
            // panelEnvios
            // 
            this.panelEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelEnvios.Location = new System.Drawing.Point(0, 352);
            this.panelEnvios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEnvios.Name = "panelEnvios";
            this.panelEnvios.Size = new System.Drawing.Size(7, 39);
            this.panelEnvios.TabIndex = 2;
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelVentas.Location = new System.Drawing.Point(0, 305);
            this.panelVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(7, 39);
            this.panelVentas.TabIndex = 2;
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelClientes.Location = new System.Drawing.Point(0, 258);
            this.panelClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(7, 39);
            this.panelClientes.TabIndex = 2;
            // 
            // buttonClientes
            // 
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonClientes.Image")));
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(4, 258);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(289, 39);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonDeudas
            // 
            this.buttonDeudas.FlatAppearance.BorderSize = 0;
            this.buttonDeudas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonDeudas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeudas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeudas.ForeColor = System.Drawing.Color.White;
            this.buttonDeudas.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeudas.Image")));
            this.buttonDeudas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeudas.Location = new System.Drawing.Point(5, 446);
            this.buttonDeudas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeudas.Name = "buttonDeudas";
            this.buttonDeudas.Size = new System.Drawing.Size(288, 39);
            this.buttonDeudas.TabIndex = 4;
            this.buttonDeudas.Text = "Deudas";
            this.buttonDeudas.UseVisualStyleBackColor = true;
            // 
            // buttonReportes
            // 
            this.buttonReportes.FlatAppearance.BorderSize = 0;
            this.buttonReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.Color.White;
            this.buttonReportes.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportes.Image")));
            this.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.Location = new System.Drawing.Point(4, 492);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(289, 39);
            this.buttonReportes.TabIndex = 3;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            this.buttonReportes.MouseHover += new System.EventHandler(this.buttonReportes_MouseHover);
            // 
            // buttonVentas
            // 
            this.buttonVentas.FlatAppearance.BorderSize = 0;
            this.buttonVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.ForeColor = System.Drawing.Color.White;
            this.buttonVentas.Image = ((System.Drawing.Image)(resources.GetObject("buttonVentas.Image")));
            this.buttonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentas.Location = new System.Drawing.Point(4, 305);
            this.buttonVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(289, 39);
            this.buttonVentas.TabIndex = 2;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelProductos.Location = new System.Drawing.Point(0, 212);
            this.panelProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(7, 39);
            this.panelProductos.TabIndex = 1;
            // 
            // buttonProductos
            // 
            this.buttonProductos.AccessibleName = "";
            this.buttonProductos.FlatAppearance.BorderSize = 0;
            this.buttonProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.White;
            this.buttonProductos.Image = ((System.Drawing.Image)(resources.GetObject("buttonProductos.Image")));
            this.buttonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductos.Location = new System.Drawing.Point(4, 212);
            this.buttonProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(289, 39);
            this.buttonProductos.TabIndex = 0;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(293, 145);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelGlobalOpciones
            // 
            this.panelGlobalOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelGlobalOpciones.Controls.Add(this.panelPrincipalStockBajo);
            this.panelGlobalOpciones.Controls.Add(this.panelPrincipalEstadistica);
            this.panelGlobalOpciones.Location = new System.Drawing.Point(293, 43);
            this.panelGlobalOpciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGlobalOpciones.Name = "panelGlobalOpciones";
            this.panelGlobalOpciones.Size = new System.Drawing.Size(1440, 757);
            this.panelGlobalOpciones.TabIndex = 2;
            // 
            // panelPrincipalStockBajo
            // 
            this.panelPrincipalStockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelPrincipalStockBajo.Controls.Add(this.buttonImprimirLista);
            this.panelPrincipalStockBajo.Controls.Add(this.panel3);
            this.panelPrincipalStockBajo.Controls.Add(this.dataGridViewProductosStockBajo);
            this.panelPrincipalStockBajo.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipalStockBajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPrincipalStockBajo.Name = "panelPrincipalStockBajo";
            this.panelPrincipalStockBajo.Size = new System.Drawing.Size(1440, 756);
            this.panelPrincipalStockBajo.TabIndex = 3;
            this.panelPrincipalStockBajo.Visible = false;
            // 
            // buttonImprimirLista
            // 
            this.buttonImprimirLista.FlatAppearance.BorderSize = 0;
            this.buttonImprimirLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonImprimirLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimirLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImprimirLista.ForeColor = System.Drawing.Color.White;
            this.buttonImprimirLista.Image = ((System.Drawing.Image)(resources.GetObject("buttonImprimirLista.Image")));
            this.buttonImprimirLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImprimirLista.Location = new System.Drawing.Point(1208, 4);
            this.buttonImprimirLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonImprimirLista.Name = "buttonImprimirLista";
            this.buttonImprimirLista.Size = new System.Drawing.Size(232, 39);
            this.buttonImprimirLista.TabIndex = 13;
            this.buttonImprimirLista.Text = "Imprimir";
            this.buttonImprimirLista.UseVisualStyleBackColor = true;
            this.buttonImprimirLista.Click += new System.EventHandler(this.buttonImprimirLista_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(1201, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 39);
            this.panel3.TabIndex = 12;
            // 
            // dataGridViewProductosStockBajo
            // 
            this.dataGridViewProductosStockBajo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductosStockBajo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridViewProductosStockBajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProductosStockBajo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductosStockBajo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProductosStockBajo.ColumnHeadersHeight = 29;
            this.dataGridViewProductosStockBajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Stock,
            this.StockIdeal,
            this.Pedido});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductosStockBajo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductosStockBajo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewProductosStockBajo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProductosStockBajo.EnableHeadersVisualStyles = false;
            this.dataGridViewProductosStockBajo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductosStockBajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProductosStockBajo.Name = "dataGridViewProductosStockBajo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductosStockBajo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductosStockBajo.RowHeadersWidth = 51;
            this.dataGridViewProductosStockBajo.Size = new System.Drawing.Size(1200, 756);
            this.dataGridViewProductosStockBajo.TabIndex = 11;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 91;
            // 
            // StockIdeal
            // 
            this.StockIdeal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StockIdeal.HeaderText = "Stock Ideal";
            this.StockIdeal.MinimumWidth = 6;
            this.StockIdeal.Name = "StockIdeal";
            this.StockIdeal.Width = 138;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.MinimumWidth = 6;
            this.Pedido.Name = "Pedido";
            this.Pedido.Width = 125;
            // 
            // panelPrincipalEstadistica
            // 
            this.panelPrincipalEstadistica.Controls.Add(this.panelOpcionesEstadisticas);
            this.panelPrincipalEstadistica.Controls.Add(this.chartEstadisticaGlobal);
            this.panelPrincipalEstadistica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrincipalEstadistica.Location = new System.Drawing.Point(0, 245);
            this.panelPrincipalEstadistica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPrincipalEstadistica.Name = "panelPrincipalEstadistica";
            this.panelPrincipalEstadistica.Size = new System.Drawing.Size(1440, 512);
            this.panelPrincipalEstadistica.TabIndex = 2;
            this.panelPrincipalEstadistica.Visible = false;
            // 
            // panelOpcionesEstadisticas
            // 
            this.panelOpcionesEstadisticas.Controls.Add(this.panel2);
            this.panelOpcionesEstadisticas.Controls.Add(this.buttonAnual);
            this.panelOpcionesEstadisticas.Controls.Add(this.panel1);
            this.panelOpcionesEstadisticas.Controls.Add(this.buttonMensual);
            this.panelOpcionesEstadisticas.Controls.Add(this.panel11);
            this.panelOpcionesEstadisticas.Controls.Add(this.buttonSemanal);
            this.panelOpcionesEstadisticas.Location = new System.Drawing.Point(1040, 1);
            this.panelOpcionesEstadisticas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOpcionesEstadisticas.Name = "panelOpcionesEstadisticas";
            this.panelOpcionesEstadisticas.Size = new System.Drawing.Size(400, 505);
            this.panelOpcionesEstadisticas.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 39);
            this.panel2.TabIndex = 34;
            // 
            // buttonAnual
            // 
            this.buttonAnual.FlatAppearance.BorderSize = 0;
            this.buttonAnual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnual.ForeColor = System.Drawing.Color.White;
            this.buttonAnual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnual.Location = new System.Drawing.Point(4, 90);
            this.buttonAnual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnual.Name = "buttonAnual";
            this.buttonAnual.Size = new System.Drawing.Size(128, 39);
            this.buttonAnual.TabIndex = 33;
            this.buttonAnual.Text = "Anual";
            this.buttonAnual.UseVisualStyleBackColor = true;
            this.buttonAnual.Click += new System.EventHandler(this.buttonAnual_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 39);
            this.panel1.TabIndex = 32;
            // 
            // buttonMensual
            // 
            this.buttonMensual.FlatAppearance.BorderSize = 0;
            this.buttonMensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMensual.ForeColor = System.Drawing.Color.White;
            this.buttonMensual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMensual.Location = new System.Drawing.Point(4, 47);
            this.buttonMensual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMensual.Name = "buttonMensual";
            this.buttonMensual.Size = new System.Drawing.Size(128, 39);
            this.buttonMensual.TabIndex = 31;
            this.buttonMensual.Text = "Mensual";
            this.buttonMensual.UseVisualStyleBackColor = true;
            this.buttonMensual.Click += new System.EventHandler(this.buttonMensual_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(0, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 39);
            this.panel11.TabIndex = 30;
            // 
            // buttonSemanal
            // 
            this.buttonSemanal.FlatAppearance.BorderSize = 0;
            this.buttonSemanal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSemanal.ForeColor = System.Drawing.Color.White;
            this.buttonSemanal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSemanal.Location = new System.Drawing.Point(4, 4);
            this.buttonSemanal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSemanal.Name = "buttonSemanal";
            this.buttonSemanal.Size = new System.Drawing.Size(128, 39);
            this.buttonSemanal.TabIndex = 29;
            this.buttonSemanal.Text = "Semanal";
            this.buttonSemanal.UseVisualStyleBackColor = true;
            this.buttonSemanal.Click += new System.EventHandler(this.buttonSemanal_Click);
            // 
            // chartEstadisticaGlobal
            // 
            this.chartEstadisticaGlobal.BackColor = System.Drawing.Color.Empty;
            this.chartEstadisticaGlobal.BorderlineColor = System.Drawing.Color.Empty;
            this.chartEstadisticaGlobal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            this.chartEstadisticaGlobal.BorderSkin.BackColor = System.Drawing.Color.Blue;
            this.chartEstadisticaGlobal.BorderSkin.BackImage = "Blue";
            this.chartEstadisticaGlobal.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Blue;
            this.chartEstadisticaGlobal.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            this.chartEstadisticaGlobal.BorderSkin.BackSecondaryColor = System.Drawing.Color.Blue;
            this.chartEstadisticaGlobal.BorderSkin.PageColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticaGlobal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEstadisticaGlobal.Legends.Add(legend1);
            this.chartEstadisticaGlobal.Location = new System.Drawing.Point(0, 0);
            this.chartEstadisticaGlobal.Margin = new System.Windows.Forms.Padding(0);
            this.chartEstadisticaGlobal.Name = "chartEstadisticaGlobal";
            this.chartEstadisticaGlobal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.Cyan;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Glass";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.YValuesPerPoint = 2;
            this.chartEstadisticaGlobal.Series.Add(series1);
            this.chartEstadisticaGlobal.Size = new System.Drawing.Size(1036, 510);
            this.chartEstadisticaGlobal.TabIndex = 0;
            this.chartEstadisticaGlobal.Text = "Estadisticas De Venta";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.ButtonMinimizar);
            this.Controls.Add(this.panelGlobalOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ButtonMinimizar.ResumeLayout(false);
            this.ButtonMinimizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCerrar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelGlobalOpciones.ResumeLayout(false);
            this.panelPrincipalStockBajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosStockBajo)).EndInit();
            this.panelPrincipalEstadistica.ResumeLayout(false);
            this.panelOpcionesEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticaGlobal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonMinimizar;
        private System.Windows.Forms.PictureBox ButtonCerrar;
        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ButtonMaximizar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Panel panelEnvios;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonDeudas;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Panel panelPagos;
        private System.Windows.Forms.Button buttonReparaciones;
        private System.Windows.Forms.Button buttonEnvios;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelSubVentas;
        private System.Windows.Forms.Button buttonReportesVentas;
        private System.Windows.Forms.Button buttonReportesStockBajo;
        private System.Windows.Forms.Button buttonReportesCompras;
        private System.Windows.Forms.Panel panelSubPagos;
        private System.Windows.Forms.Panel panelSubCompras;
        private System.Windows.Forms.Panel panelGlobalOpciones;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticaGlobal;
        private System.Windows.Forms.Label labelMultitask;
        private System.Windows.Forms.Panel panelPrincipalEstadistica;
        private System.Windows.Forms.Panel panelOpcionesEstadisticas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAnual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMensual;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonSemanal;
        private System.Windows.Forms.Panel panelPrincipalStockBajo;
        private System.Windows.Forms.DataGridView dataGridViewProductosStockBajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.Button buttonImprimirLista;
        private System.Windows.Forms.Panel panel3;
    }
}

