namespace PROYECTO
{
    partial class FormListaReparaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaReparaciones));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonNuevaReparacion = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDeBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxHamburgeMenu = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSinSolucion = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSinHacer = new System.Windows.Forms.Button();
            this.buttonTerminados = new System.Windows.Forms.Button();
            this.buttonEnProceso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panelDecorativo = new System.Windows.Forms.Panel();
            this.panelDownBar = new System.Windows.Forms.Panel();
            this.labelReparaciones = new System.Windows.Forms.Label();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHamburgeMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.panelDownBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMain.Controls.Add(this.buttonNuevaReparacion);
            this.panelMain.Controls.Add(this.panel5);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.pictureBoxHamburgeMenu);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.panelBuscador);
            this.panelMain.Controls.Add(this.panelDownBar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1251, 637);
            this.panelMain.TabIndex = 0;
            // 
            // buttonNuevaReparacion
            // 
            this.buttonNuevaReparacion.FlatAppearance.BorderSize = 0;
            this.buttonNuevaReparacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonNuevaReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevaReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaReparacion.ForeColor = System.Drawing.Color.White;
            this.buttonNuevaReparacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevaReparacion.Location = new System.Drawing.Point(937, 117);
            this.buttonNuevaReparacion.Name = "buttonNuevaReparacion";
            this.buttonNuevaReparacion.Size = new System.Drawing.Size(174, 32);
            this.buttonNuevaReparacion.TabIndex = 55;
            this.buttonNuevaReparacion.Text = "Nueva Reparacion";
            this.buttonNuevaReparacion.UseVisualStyleBackColor = true;
            this.buttonNuevaReparacion.Click += new System.EventHandler(this.buttonNuevaReparacion_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(932, 117);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewClientes);
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 571);
            this.panel4.TabIndex = 53;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.NroDeBoleta,
            this.Modelo,
            this.Dni,
            this.Problema,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientes.EnableHeadersVisualStyles = false;
            this.dataGridViewClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dataGridViewClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClientes.Size = new System.Drawing.Size(931, 571);
            this.dataGridViewClientes.TabIndex = 8;
            // 
            // Indice
            // 
            this.Indice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            this.Indice.Visible = false;
            // 
            // NroDeBoleta
            // 
            this.NroDeBoleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroDeBoleta.HeaderText = "Nro De Boleta";
            this.NroDeBoleta.Name = "NroDeBoleta";
            this.NroDeBoleta.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Problema
            // 
            this.Problema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // pictureBoxHamburgeMenu
            // 
            this.pictureBoxHamburgeMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHamburgeMenu.Image")));
            this.pictureBoxHamburgeMenu.Location = new System.Drawing.Point(4, 25);
            this.pictureBoxHamburgeMenu.Name = "pictureBoxHamburgeMenu";
            this.pictureBoxHamburgeMenu.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxHamburgeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHamburgeMenu.TabIndex = 52;
            this.pictureBoxHamburgeMenu.TabStop = false;
            this.pictureBoxHamburgeMenu.Click += new System.EventHandler(this.pictureBoxHamburgeMenu_Click);
            this.pictureBoxHamburgeMenu.MouseLeave += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseLeave);
            this.pictureBoxHamburgeMenu.MouseHover += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseHover);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.buttonSinSolucion);
            this.panelMenu.Controls.Add(this.panel11);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.buttonSinHacer);
            this.panelMenu.Controls.Add(this.buttonTerminados);
            this.panelMenu.Controls.Add(this.buttonEnProceso);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Location = new System.Drawing.Point(0, 25);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(931, 37);
            this.panelMenu.TabIndex = 50;
            this.panelMenu.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(303, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 51;
            // 
            // buttonSinSolucion
            // 
            this.buttonSinSolucion.FlatAppearance.BorderSize = 0;
            this.buttonSinSolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSinSolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSinSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinSolucion.ForeColor = System.Drawing.Color.White;
            this.buttonSinSolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSinSolucion.Location = new System.Drawing.Point(308, 3);
            this.buttonSinSolucion.Name = "buttonSinSolucion";
            this.buttonSinSolucion.Size = new System.Drawing.Size(99, 32);
            this.buttonSinSolucion.TabIndex = 50;
            this.buttonSinSolucion.Text = "Sin Solucion";
            this.buttonSinSolucion.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 32);
            this.panel11.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 49;
            // 
            // buttonSinHacer
            // 
            this.buttonSinHacer.FlatAppearance.BorderSize = 0;
            this.buttonSinHacer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonSinHacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSinHacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinHacer.ForeColor = System.Drawing.Color.White;
            this.buttonSinHacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSinHacer.Location = new System.Drawing.Point(6, 3);
            this.buttonSinHacer.Name = "buttonSinHacer";
            this.buttonSinHacer.Size = new System.Drawing.Size(96, 32);
            this.buttonSinHacer.TabIndex = 44;
            this.buttonSinHacer.Text = "Sin Hacer";
            this.buttonSinHacer.UseVisualStyleBackColor = true;
            this.buttonSinHacer.MouseLeave += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseLeave);
            this.buttonSinHacer.MouseHover += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseHover);
            // 
            // buttonTerminados
            // 
            this.buttonTerminados.FlatAppearance.BorderSize = 0;
            this.buttonTerminados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonTerminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerminados.ForeColor = System.Drawing.Color.White;
            this.buttonTerminados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminados.Location = new System.Drawing.Point(208, 3);
            this.buttonTerminados.Name = "buttonTerminados";
            this.buttonTerminados.Size = new System.Drawing.Size(96, 32);
            this.buttonTerminados.TabIndex = 48;
            this.buttonTerminados.Text = "Terminados";
            this.buttonTerminados.UseVisualStyleBackColor = true;
            this.buttonTerminados.MouseLeave += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseLeave);
            this.buttonTerminados.MouseHover += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseHover);
            // 
            // buttonEnProceso
            // 
            this.buttonEnProceso.FlatAppearance.BorderSize = 0;
            this.buttonEnProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonEnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnProceso.ForeColor = System.Drawing.Color.White;
            this.buttonEnProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnProceso.Location = new System.Drawing.Point(107, 3);
            this.buttonEnProceso.Name = "buttonEnProceso";
            this.buttonEnProceso.Size = new System.Drawing.Size(96, 32);
            this.buttonEnProceso.TabIndex = 46;
            this.buttonEnProceso.Text = "En Proceso";
            this.buttonEnProceso.UseVisualStyleBackColor = true;
            this.buttonEnProceso.MouseLeave += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseLeave);
            this.buttonEnProceso.MouseHover += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(102, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 47;
            // 
            // panelBuscador
            // 
            this.panelBuscador.Controls.Add(this.textBoxBuscador);
            this.panelBuscador.Controls.Add(this.buttonBuscar);
            this.panelBuscador.Controls.Add(this.panelDecorativo);
            this.panelBuscador.Location = new System.Drawing.Point(970, 26);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(279, 34);
            this.panelBuscador.TabIndex = 43;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.CausesValidation = false;
            this.textBoxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscador.Location = new System.Drawing.Point(4, 2);
            this.textBoxBuscador.MinimumSize = new System.Drawing.Size(25, 25);
            this.textBoxBuscador.Multiline = true;
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(190, 25);
            this.textBoxBuscador.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(200, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(72, 25);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.MouseLeave += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseLeave);
            this.buttonBuscar.MouseHover += new System.EventHandler(this.pictureBoxHamburgeMenu_MouseHover);
            // 
            // panelDecorativo
            // 
            this.panelDecorativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDecorativo.Location = new System.Drawing.Point(195, 2);
            this.panelDecorativo.Name = "panelDecorativo";
            this.panelDecorativo.Size = new System.Drawing.Size(5, 25);
            this.panelDecorativo.TabIndex = 8;
            // 
            // panelDownBar
            // 
            this.panelDownBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDownBar.Controls.Add(this.labelReparaciones);
            this.panelDownBar.Controls.Add(this.pictureBoxMinimizar);
            this.panelDownBar.Controls.Add(this.pictureBoxCerrar);
            this.panelDownBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDownBar.Location = new System.Drawing.Point(0, 0);
            this.panelDownBar.Name = "panelDownBar";
            this.panelDownBar.Size = new System.Drawing.Size(1251, 25);
            this.panelDownBar.TabIndex = 0;
            this.panelDownBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDownBar_MouseDown);
            // 
            // labelReparaciones
            // 
            this.labelReparaciones.AutoSize = true;
            this.labelReparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReparaciones.ForeColor = System.Drawing.Color.White;
            this.labelReparaciones.Location = new System.Drawing.Point(516, 2);
            this.labelReparaciones.Name = "labelReparaciones";
            this.labelReparaciones.Size = new System.Drawing.Size(176, 20);
            this.labelReparaciones.TabIndex = 3;
            this.labelReparaciones.Text = "Multitask-Reparaciones";
            this.labelReparaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDownBar_MouseDown);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(1212, 3);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 2;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1233, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 1;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // FormListaReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 637);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaReparaciones";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReparaciones";
            this.panelMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHamburgeMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelDownBar.ResumeLayout(false);
            this.panelDownBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDownBar;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Panel panelDecorativo;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonSinHacer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTerminados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEnProceso;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxHamburgeMenu;
        private System.Windows.Forms.Label labelReparaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSinSolucion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button buttonNuevaReparacion;
        private System.Windows.Forms.Panel panel5;
    }
}