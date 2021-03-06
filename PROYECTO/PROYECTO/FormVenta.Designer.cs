﻿namespace PROYECTO
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelDown = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCerrar = new System.Windows.Forms.PictureBox();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.panelResumenDeCompras = new System.Windows.Forms.Panel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIva = new System.Windows.Forms.Label();
            this.panelFechaDeFacturacion = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelFechaDeFacturacion = new System.Windows.Forms.Label();
            this.panelInformacionDelCliente = new System.Windows.Forms.Panel();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombreDelCliente = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.panelInformacionDeLaEmpresa = new System.Windows.Forms.Panel();
            this.labelDescripcionDeLaEmpresa = new System.Windows.Forms.Label();
            this.labelNombreDeLaEmpresa = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonAplicarIVA = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.labelTerminos = new System.Windows.Forms.Label();
            this.panelTerminos = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonConfirmarVenta = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonClienteExistente = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonClienteNuevo = new System.Windows.Forms.Button();
            this.PanelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            this.panelResumenDeCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panelFechaDeFacturacion.SuspendLayout();
            this.panelInformacionDelCliente.SuspendLayout();
            this.panelInformacionDeLaEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTerminos.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDown
            // 
            this.PanelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.PanelDown.Controls.Add(this.buttonCerrar);
            this.PanelDown.Controls.Add(this.buttonMinimizar);
            this.PanelDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDown.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PanelDown.Location = new System.Drawing.Point(0, 0);
            this.PanelDown.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(1643, 31);
            this.PanelDown.TabIndex = 1;
            this.PanelDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDown_MouseDown);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.Location = new System.Drawing.Point(1619, 4);
            this.buttonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(20, 18);
            this.buttonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.TabStop = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.Image")));
            this.buttonMinimizar.Location = new System.Drawing.Point(1591, 4);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(20, 18);
            this.buttonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizar.TabIndex = 5;
            this.buttonMinimizar.TabStop = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(203, 5);
            this.textBoxSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(228, 22);
            this.textBoxSubTotal.TabIndex = 4;
            // 
            // panelResumenDeCompras
            // 
            this.panelResumenDeCompras.Controls.Add(this.dataGridViewProductos);
            this.panelResumenDeCompras.Location = new System.Drawing.Point(16, 342);
            this.panelResumenDeCompras.Margin = new System.Windows.Forms.Padding(4);
            this.panelResumenDeCompras.Name = "panelResumenDeCompras";
            this.panelResumenDeCompras.Size = new System.Drawing.Size(1140, 375);
            this.panelResumenDeCompras.TabIndex = 5;
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
            this.dataGridViewProductos.ColumnHeadersHeight = 29;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewProductos.Location = new System.Drawing.Point(4, 15);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1136, 506);
            this.dataGridViewProductos.TabIndex = 2;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "SubTotal";
            // 
            // labelIva
            // 
            this.labelIva.AutoSize = true;
            this.labelIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIva.ForeColor = System.Drawing.Color.White;
            this.labelIva.Location = new System.Drawing.Point(4, 50);
            this.labelIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIva.Name = "labelIva";
            this.labelIva.Size = new System.Drawing.Size(49, 29);
            this.labelIva.TabIndex = 8;
            this.labelIva.Text = "IVA";
            // 
            // panelFechaDeFacturacion
            // 
            this.panelFechaDeFacturacion.Controls.Add(this.panel6);
            this.panelFechaDeFacturacion.Controls.Add(this.labelFechaVencimiento);
            this.panelFechaDeFacturacion.Controls.Add(this.label3);
            this.panelFechaDeFacturacion.Controls.Add(this.labelFecha);
            this.panelFechaDeFacturacion.Controls.Add(this.labelFechaDeFacturacion);
            this.panelFechaDeFacturacion.Location = new System.Drawing.Point(1233, 38);
            this.panelFechaDeFacturacion.Margin = new System.Windows.Forms.Padding(4);
            this.panelFechaDeFacturacion.Name = "panelFechaDeFacturacion";
            this.panelFechaDeFacturacion.Size = new System.Drawing.Size(405, 92);
            this.panelFechaDeFacturacion.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(4, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(399, 1);
            this.panel6.TabIndex = 11;
            // 
            // labelFechaVencimiento
            // 
            this.labelFechaVencimiento.AutoSize = true;
            this.labelFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVencimiento.ForeColor = System.Drawing.Color.White;
            this.labelFechaVencimiento.Location = new System.Drawing.Point(208, 57);
            this.labelFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaVencimiento.Name = "labelFechaVencimiento";
            this.labelFechaVencimiento.Size = new System.Drawing.Size(0, 25);
            this.labelFechaVencimiento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(207, 17);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 25);
            this.labelFecha.TabIndex = 1;
            // 
            // labelFechaDeFacturacion
            // 
            this.labelFechaDeFacturacion.AutoSize = true;
            this.labelFechaDeFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDeFacturacion.ForeColor = System.Drawing.Color.White;
            this.labelFechaDeFacturacion.Location = new System.Drawing.Point(21, 21);
            this.labelFechaDeFacturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaDeFacturacion.Name = "labelFechaDeFacturacion";
            this.labelFechaDeFacturacion.Size = new System.Drawing.Size(166, 20);
            this.labelFechaDeFacturacion.TabIndex = 0;
            this.labelFechaDeFacturacion.Text = "Fecha de facturacion";
            // 
            // panelInformacionDelCliente
            // 
            this.panelInformacionDelCliente.Controls.Add(this.textBoxTelefono);
            this.panelInformacionDelCliente.Controls.Add(this.textBoxDireccion);
            this.panelInformacionDelCliente.Controls.Add(this.textBoxNombreDelCliente);
            this.panelInformacionDelCliente.Controls.Add(this.panel4);
            this.panelInformacionDelCliente.Controls.Add(this.panel3);
            this.panelInformacionDelCliente.Controls.Add(this.panel2);
            this.panelInformacionDelCliente.Controls.Add(this.labelTelefono);
            this.panelInformacionDelCliente.Controls.Add(this.labelDireccion);
            this.panelInformacionDelCliente.Controls.Add(this.labelCliente);
            this.panelInformacionDelCliente.Location = new System.Drawing.Point(16, 206);
            this.panelInformacionDelCliente.Margin = new System.Windows.Forms.Padding(4);
            this.panelInformacionDelCliente.Name = "panelInformacionDelCliente";
            this.panelInformacionDelCliente.Size = new System.Drawing.Size(627, 129);
            this.panelInformacionDelCliente.TabIndex = 10;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.ForeColor = System.Drawing.Color.White;
            this.textBoxTelefono.Location = new System.Drawing.Point(171, 66);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(424, 15);
            this.textBoxTelefono.TabIndex = 15;
            this.textBoxTelefono.Text = "Ej: 1544325444";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.ForeColor = System.Drawing.Color.White;
            this.textBoxDireccion.Location = new System.Drawing.Point(171, 42);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(424, 15);
            this.textBoxDireccion.TabIndex = 14;
            this.textBoxDireccion.Text = "Ej: Calle false 123";
            // 
            // textBoxNombreDelCliente
            // 
            this.textBoxNombreDelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.textBoxNombreDelCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombreDelCliente.ForeColor = System.Drawing.Color.White;
            this.textBoxNombreDelCliente.Location = new System.Drawing.Point(171, 16);
            this.textBoxNombreDelCliente.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreDelCliente.Name = "textBoxNombreDelCliente";
            this.textBoxNombreDelCliente.Size = new System.Drawing.Size(424, 15);
            this.textBoxNombreDelCliente.TabIndex = 13;
            this.textBoxNombreDelCliente.Text = "Ej: Juan Manuel";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(171, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 1);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(171, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(171, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 1);
            this.panel2.TabIndex = 9;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(4, 68);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(73, 20);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.White;
            this.labelDireccion.Location = new System.Drawing.Point(4, 42);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(81, 20);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.White;
            this.labelCliente.Location = new System.Drawing.Point(4, 17);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(61, 20);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente";
            // 
            // panelInformacionDeLaEmpresa
            // 
            this.panelInformacionDeLaEmpresa.Controls.Add(this.labelDescripcionDeLaEmpresa);
            this.panelInformacionDeLaEmpresa.Controls.Add(this.labelNombreDeLaEmpresa);
            this.panelInformacionDeLaEmpresa.Controls.Add(this.pictureBoxLogo);
            this.panelInformacionDeLaEmpresa.Location = new System.Drawing.Point(16, 38);
            this.panelInformacionDeLaEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.panelInformacionDeLaEmpresa.Name = "panelInformacionDeLaEmpresa";
            this.panelInformacionDeLaEmpresa.Size = new System.Drawing.Size(1140, 160);
            this.panelInformacionDeLaEmpresa.TabIndex = 11;
            // 
            // labelDescripcionDeLaEmpresa
            // 
            this.labelDescripcionDeLaEmpresa.AutoSize = true;
            this.labelDescripcionDeLaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionDeLaEmpresa.ForeColor = System.Drawing.Color.White;
            this.labelDescripcionDeLaEmpresa.Location = new System.Drawing.Point(185, 78);
            this.labelDescripcionDeLaEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcionDeLaEmpresa.Name = "labelDescripcionDeLaEmpresa";
            this.labelDescripcionDeLaEmpresa.Size = new System.Drawing.Size(638, 31);
            this.labelDescripcionDeLaEmpresa.TabIndex = 14;
            this.labelDescripcionDeLaEmpresa.Text = "Servicio Tecnico Especializado en Telefonia Celular";
            // 
            // labelNombreDeLaEmpresa
            // 
            this.labelNombreDeLaEmpresa.AutoSize = true;
            this.labelNombreDeLaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDeLaEmpresa.ForeColor = System.Drawing.Color.White;
            this.labelNombreDeLaEmpresa.Location = new System.Drawing.Point(179, 10);
            this.labelNombreDeLaEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreDeLaEmpresa.Name = "labelNombreDeLaEmpresa";
            this.labelNombreDeLaEmpresa.Size = new System.Drawing.Size(268, 69);
            this.labelNombreDeLaEmpresa.TabIndex = 13;
            this.labelNombreDeLaEmpresa.Text = "Multitask";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(171, 160);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.buttonAplicarIVA);
            this.panel1.Controls.Add(this.textBoxTotal);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxIVA);
            this.panel1.Controls.Add(this.textBoxSubTotal);
            this.panel1.Controls.Add(this.labelIva);
            this.panel1.Location = new System.Drawing.Point(1200, 636);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 156);
            this.panel1.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(93, 52);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 30);
            this.panel8.TabIndex = 30;
            // 
            // buttonAplicarIVA
            // 
            this.buttonAplicarIVA.FlatAppearance.BorderSize = 0;
            this.buttonAplicarIVA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAplicarIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAplicarIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAplicarIVA.ForeColor = System.Drawing.Color.White;
            this.buttonAplicarIVA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAplicarIVA.Location = new System.Drawing.Point(100, 52);
            this.buttonAplicarIVA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAplicarIVA.Name = "buttonAplicarIVA";
            this.buttonAplicarIVA.Size = new System.Drawing.Size(87, 30);
            this.buttonAplicarIVA.TabIndex = 29;
            this.buttonAplicarIVA.Text = "Aplicar";
            this.buttonAplicarIVA.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAplicarIVA.UseVisualStyleBackColor = true;
            this.buttonAplicarIVA.Click += new System.EventHandler(this.buttonAplicarIVA_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(203, 112);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(228, 22);
            this.textBoxTotal.TabIndex = 9;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(4, 107);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(68, 29);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "Total";
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.Location = new System.Drawing.Point(203, 55);
            this.textBoxIVA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.ReadOnly = true;
            this.textBoxIVA.Size = new System.Drawing.Size(228, 22);
            this.textBoxIVA.TabIndex = 3;
            this.textBoxIVA.Text = "21%  (No Aplicado)";
            // 
            // labelTerminos
            // 
            this.labelTerminos.AutoSize = true;
            this.labelTerminos.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerminos.ForeColor = System.Drawing.Color.White;
            this.labelTerminos.Location = new System.Drawing.Point(0, 0);
            this.labelTerminos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerminos.Name = "labelTerminos";
            this.labelTerminos.Size = new System.Drawing.Size(0, 17);
            this.labelTerminos.TabIndex = 13;
            // 
            // panelTerminos
            // 
            this.panelTerminos.Controls.Add(this.labelTerminos);
            this.panelTerminos.Location = new System.Drawing.Point(16, 777);
            this.panelTerminos.Margin = new System.Windows.Forms.Padding(4);
            this.panelTerminos.Name = "panelTerminos";
            this.panelTerminos.Size = new System.Drawing.Size(1140, 73);
            this.panelTerminos.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(1381, 800);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 39);
            this.panel9.TabIndex = 35;
            // 
            // buttonConfirmarVenta
            // 
            this.buttonConfirmarVenta.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonConfirmarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmarVenta.Location = new System.Drawing.Point(1385, 800);
            this.buttonConfirmarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmarVenta.Name = "buttonConfirmarVenta";
            this.buttonConfirmarVenta.Size = new System.Drawing.Size(128, 39);
            this.buttonConfirmarVenta.TabIndex = 34;
            this.buttonConfirmarVenta.Text = "Confirmar";
            this.buttonConfirmarVenta.UseVisualStyleBackColor = true;
            this.buttonConfirmarVenta.Click += new System.EventHandler(this.buttonConfirmarVenta_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(1511, 800);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 39);
            this.panel5.TabIndex = 37;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(1515, 800);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(128, 39);
            this.buttonCancelar.TabIndex = 36;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(659, 206);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(7, 39);
            this.panel11.TabIndex = 39;
            // 
            // buttonClienteExistente
            // 
            this.buttonClienteExistente.FlatAppearance.BorderSize = 0;
            this.buttonClienteExistente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonClienteExistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClienteExistente.ForeColor = System.Drawing.Color.White;
            this.buttonClienteExistente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClienteExistente.Location = new System.Drawing.Point(663, 206);
            this.buttonClienteExistente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClienteExistente.Name = "buttonClienteExistente";
            this.buttonClienteExistente.Size = new System.Drawing.Size(219, 39);
            this.buttonClienteExistente.TabIndex = 38;
            this.buttonClienteExistente.Text = "Cliente Existente";
            this.buttonClienteExistente.UseVisualStyleBackColor = true;
            this.buttonClienteExistente.Click += new System.EventHandler(this.buttonClienteExistente_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(659, 247);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 39);
            this.panel7.TabIndex = 41;
            // 
            // buttonClienteNuevo
            // 
            this.buttonClienteNuevo.FlatAppearance.BorderSize = 0;
            this.buttonClienteNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClienteNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonClienteNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClienteNuevo.Location = new System.Drawing.Point(663, 247);
            this.buttonClienteNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClienteNuevo.Name = "buttonClienteNuevo";
            this.buttonClienteNuevo.Size = new System.Drawing.Size(219, 39);
            this.buttonClienteNuevo.TabIndex = 40;
            this.buttonClienteNuevo.Text = "Cliente Nuevo";
            this.buttonClienteNuevo.UseVisualStyleBackColor = true;
            this.buttonClienteNuevo.Click += new System.EventHandler(this.buttonClienteNuevo_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1643, 848);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.buttonClienteNuevo);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.buttonClienteExistente);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.buttonConfirmarVenta);
            this.Controls.Add(this.panelTerminos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInformacionDeLaEmpresa);
            this.Controls.Add(this.panelInformacionDelCliente);
            this.Controls.Add(this.panelFechaDeFacturacion);
            this.Controls.Add(this.panelResumenDeCompras);
            this.Controls.Add(this.PanelDown);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.PanelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            this.panelResumenDeCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panelFechaDeFacturacion.ResumeLayout(false);
            this.panelFechaDeFacturacion.PerformLayout();
            this.panelInformacionDelCliente.ResumeLayout(false);
            this.panelInformacionDelCliente.PerformLayout();
            this.panelInformacionDeLaEmpresa.ResumeLayout(false);
            this.panelInformacionDeLaEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTerminos.ResumeLayout(false);
            this.panelTerminos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDown;
        private System.Windows.Forms.PictureBox buttonCerrar;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Panel panelResumenDeCompras;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIva;
        private System.Windows.Forms.Panel panelFechaDeFacturacion;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelFechaDeFacturacion;
        private System.Windows.Forms.Panel panelInformacionDelCliente;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Panel panelInformacionDeLaEmpresa;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDescripcionDeLaEmpresa;
        private System.Windows.Forms.Label labelNombreDeLaEmpresa;
        private System.Windows.Forms.Label labelTerminos;
        private System.Windows.Forms.Panel panelTerminos;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombreDelCliente;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonConfirmarVenta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonClienteExistente;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonClienteNuevo;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonAplicarIVA;
    }
}