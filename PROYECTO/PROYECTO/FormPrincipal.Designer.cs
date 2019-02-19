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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ButtonMinimizar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonMaximizar = new System.Windows.Forms.PictureBox();
            this.ButtonCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.buttonReportesPagos = new System.Windows.Forms.Button();
            this.buttonReportesCompras = new System.Windows.Forms.Button();
            this.panelSubPagos = new System.Windows.Forms.Panel();
            this.panelSubCompras = new System.Windows.Forms.Panel();
            this.panelSubVentas = new System.Windows.Forms.Panel();
            this.buttonReportesVentas = new System.Windows.Forms.Button();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.panelPagos = new System.Windows.Forms.Panel();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonEnvios = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.panelEnvios = new System.Windows.Forms.Panel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonPagos = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chartEstadisticaGlobal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonMinimizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCerrar)).BeginInit();
            this.panelMenuVertical.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticaGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMinimizar
            // 
            this.ButtonMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.ButtonMinimizar.Controls.Add(this.pictureBox2);
            this.ButtonMinimizar.Controls.Add(this.ButtonMaximizar);
            this.ButtonMinimizar.Controls.Add(this.ButtonCerrar);
            this.ButtonMinimizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonMinimizar.Location = new System.Drawing.Point(0, 0);
            this.ButtonMinimizar.Name = "ButtonMinimizar";
            this.ButtonMinimizar.Size = new System.Drawing.Size(1300, 35);
            this.ButtonMinimizar.TabIndex = 0;
            this.ButtonMinimizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinimizar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1210, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
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
            this.ButtonMaximizar.Location = new System.Drawing.Point(1241, 4);
            this.ButtonMaximizar.Name = "ButtonMaximizar";
            this.ButtonMaximizar.Size = new System.Drawing.Size(25, 25);
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
            this.ButtonCerrar.Location = new System.Drawing.Point(1272, 4);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(25, 25);
            this.ButtonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCerrar.TabIndex = 0;
            this.ButtonCerrar.TabStop = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.panelEmpleados);
            this.panelMenuVertical.Controls.Add(this.buttonEmpleados);
            this.panelMenuVertical.Controls.Add(this.panelSubMenu);
            this.panelMenuVertical.Controls.Add(this.panelReportes);
            this.panelMenuVertical.Controls.Add(this.panelPagos);
            this.panelMenuVertical.Controls.Add(this.buttonUsuario);
            this.panelMenuVertical.Controls.Add(this.buttonEnvios);
            this.panelMenuVertical.Controls.Add(this.panelUsuarios);
            this.panelMenuVertical.Controls.Add(this.panelEnvios);
            this.panelMenuVertical.Controls.Add(this.panelVentas);
            this.panelMenuVertical.Controls.Add(this.panelClientes);
            this.panelMenuVertical.Controls.Add(this.buttonClientes);
            this.panelMenuVertical.Controls.Add(this.buttonPagos);
            this.panelMenuVertical.Controls.Add(this.buttonReportes);
            this.panelMenuVertical.Controls.Add(this.buttonVentas);
            this.panelMenuVertical.Controls.Add(this.panelProductos);
            this.panelMenuVertical.Controls.Add(this.buttonProductos);
            this.panelMenuVertical.Controls.Add(this.pictureBoxLogo);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 35);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(220, 615);
            this.panelMenuVertical.TabIndex = 1;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelEmpleados.Location = new System.Drawing.Point(0, 134);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(5, 32);
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
            this.buttonEmpleados.Location = new System.Drawing.Point(4, 134);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(216, 32);
            this.buttonEmpleados.TabIndex = 9;
            this.buttonEmpleados.Text = "Empleados";
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.buttonReportesPagos);
            this.panelSubMenu.Controls.Add(this.buttonReportesCompras);
            this.panelSubMenu.Controls.Add(this.panelSubPagos);
            this.panelSubMenu.Controls.Add(this.panelSubCompras);
            this.panelSubMenu.Controls.Add(this.panelSubVentas);
            this.panelSubMenu.Controls.Add(this.buttonReportesVentas);
            this.panelSubMenu.Location = new System.Drawing.Point(31, 438);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(183, 116);
            this.panelSubMenu.TabIndex = 8;
            this.panelSubMenu.Visible = false;
            // 
            // buttonReportesPagos
            // 
            this.buttonReportesPagos.FlatAppearance.BorderSize = 0;
            this.buttonReportesPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReportesPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportesPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportesPagos.ForeColor = System.Drawing.Color.White;
            this.buttonReportesPagos.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportesPagos.Image")));
            this.buttonReportesPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportesPagos.Location = new System.Drawing.Point(5, 72);
            this.buttonReportesPagos.Name = "buttonReportesPagos";
            this.buttonReportesPagos.Size = new System.Drawing.Size(174, 32);
            this.buttonReportesPagos.TabIndex = 11;
            this.buttonReportesPagos.Text = "Pagos";
            this.buttonReportesPagos.UseVisualStyleBackColor = true;
            this.buttonReportesPagos.Click += new System.EventHandler(this.buttonReportesPagos_Click);
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
            this.buttonReportesCompras.Location = new System.Drawing.Point(5, 36);
            this.buttonReportesCompras.Name = "buttonReportesCompras";
            this.buttonReportesCompras.Size = new System.Drawing.Size(174, 32);
            this.buttonReportesCompras.TabIndex = 10;
            this.buttonReportesCompras.Text = "Compras";
            this.buttonReportesCompras.UseVisualStyleBackColor = true;
            this.buttonReportesCompras.Click += new System.EventHandler(this.buttonReportesCompras_Click);
            // 
            // panelSubPagos
            // 
            this.panelSubPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSubPagos.Location = new System.Drawing.Point(0, 72);
            this.panelSubPagos.Name = "panelSubPagos";
            this.panelSubPagos.Size = new System.Drawing.Size(5, 32);
            this.panelSubPagos.TabIndex = 4;
            // 
            // panelSubCompras
            // 
            this.panelSubCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSubCompras.Location = new System.Drawing.Point(0, 36);
            this.panelSubCompras.Name = "panelSubCompras";
            this.panelSubCompras.Size = new System.Drawing.Size(5, 32);
            this.panelSubCompras.TabIndex = 4;
            // 
            // panelSubVentas
            // 
            this.panelSubVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSubVentas.Location = new System.Drawing.Point(0, 0);
            this.panelSubVentas.Name = "panelSubVentas";
            this.panelSubVentas.Size = new System.Drawing.Size(5, 32);
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
            this.buttonReportesVentas.Location = new System.Drawing.Point(3, 0);
            this.buttonReportesVentas.Name = "buttonReportesVentas";
            this.buttonReportesVentas.Size = new System.Drawing.Size(174, 32);
            this.buttonReportesVentas.TabIndex = 9;
            this.buttonReportesVentas.Text = "Ventas";
            this.buttonReportesVentas.UseVisualStyleBackColor = true;
            this.buttonReportesVentas.Click += new System.EventHandler(this.buttonReportesVentas_Click);
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelReportes.Location = new System.Drawing.Point(0, 400);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(5, 32);
            this.panelReportes.TabIndex = 3;
            // 
            // panelPagos
            // 
            this.panelPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelPagos.Location = new System.Drawing.Point(0, 362);
            this.panelPagos.Name = "panelPagos";
            this.panelPagos.Size = new System.Drawing.Size(5, 32);
            this.panelPagos.TabIndex = 3;
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.Color.White;
            this.buttonUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsuario.Image")));
            this.buttonUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuario.Location = new System.Drawing.Point(5, 324);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Size = new System.Drawing.Size(215, 32);
            this.buttonUsuario.TabIndex = 7;
            this.buttonUsuario.Text = "Usuarios";
            this.buttonUsuario.UseVisualStyleBackColor = true;
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
            this.buttonEnvios.Location = new System.Drawing.Point(5, 286);
            this.buttonEnvios.Name = "buttonEnvios";
            this.buttonEnvios.Size = new System.Drawing.Size(215, 32);
            this.buttonEnvios.TabIndex = 6;
            this.buttonEnvios.Text = "Envios";
            this.buttonEnvios.UseVisualStyleBackColor = true;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelUsuarios.Location = new System.Drawing.Point(0, 324);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(5, 32);
            this.panelUsuarios.TabIndex = 2;
            // 
            // panelEnvios
            // 
            this.panelEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelEnvios.Location = new System.Drawing.Point(0, 286);
            this.panelEnvios.Name = "panelEnvios";
            this.panelEnvios.Size = new System.Drawing.Size(5, 32);
            this.panelEnvios.TabIndex = 2;
            // 
            // panelVentas
            // 
            this.panelVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelVentas.Location = new System.Drawing.Point(0, 248);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(5, 32);
            this.panelVentas.TabIndex = 2;
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelClientes.Location = new System.Drawing.Point(0, 210);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(5, 32);
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
            this.buttonClientes.Location = new System.Drawing.Point(3, 210);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(217, 32);
            this.buttonClientes.TabIndex = 5;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonPagos
            // 
            this.buttonPagos.FlatAppearance.BorderSize = 0;
            this.buttonPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagos.ForeColor = System.Drawing.Color.White;
            this.buttonPagos.Image = ((System.Drawing.Image)(resources.GetObject("buttonPagos.Image")));
            this.buttonPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPagos.Location = new System.Drawing.Point(4, 362);
            this.buttonPagos.Name = "buttonPagos";
            this.buttonPagos.Size = new System.Drawing.Size(216, 32);
            this.buttonPagos.TabIndex = 4;
            this.buttonPagos.Text = "Pagos";
            this.buttonPagos.UseVisualStyleBackColor = true;
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
            this.buttonReportes.Location = new System.Drawing.Point(3, 400);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(217, 32);
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
            this.buttonVentas.Location = new System.Drawing.Point(3, 248);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(217, 32);
            this.buttonVentas.TabIndex = 2;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelProductos.Location = new System.Drawing.Point(0, 172);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(5, 32);
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
            this.buttonProductos.Location = new System.Drawing.Point(3, 172);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(217, 32);
            this.buttonProductos.TabIndex = 0;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(220, 118);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel8.Controls.Add(this.chartEstadisticaGlobal);
            this.panel8.Location = new System.Drawing.Point(220, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1080, 615);
            this.panel8.TabIndex = 2;
            // 
            // chartEstadisticaGlobal
            // 
            this.chartEstadisticaGlobal.BorderlineColor = System.Drawing.Color.Empty;
            this.chartEstadisticaGlobal.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticaGlobal.ChartAreas.Add(chartArea1);
            this.chartEstadisticaGlobal.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartEstadisticaGlobal.Legends.Add(legend1);
            this.chartEstadisticaGlobal.Location = new System.Drawing.Point(0, 186);
            this.chartEstadisticaGlobal.Name = "chartEstadisticaGlobal";
            this.chartEstadisticaGlobal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chartEstadisticaGlobal.Size = new System.Drawing.Size(1080, 429);
            this.chartEstadisticaGlobal.TabIndex = 0;
            this.chartEstadisticaGlobal.Text = "Estadisticas De Venta";
            this.chartEstadisticaGlobal.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.ButtonMinimizar);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ButtonMinimizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCerrar)).EndInit();
            this.panelMenuVertical.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel8.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonPagos;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Panel panelPagos;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonEnvios;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelSubVentas;
        private System.Windows.Forms.Button buttonReportesVentas;
        private System.Windows.Forms.Button buttonReportesPagos;
        private System.Windows.Forms.Button buttonReportesCompras;
        private System.Windows.Forms.Panel panelSubPagos;
        private System.Windows.Forms.Panel panelSubCompras;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticaGlobal;
    }
}

