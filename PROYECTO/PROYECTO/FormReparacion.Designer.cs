namespace PROYECTO
{
    partial class FormReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReparacion));
            this.panelDown = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxCelular = new System.Windows.Forms.PictureBox();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelSabado = new System.Windows.Forms.Label();
            this.labelLunesAViernes = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelServicio = new System.Windows.Forms.Panel();
            this.checkBoxGarantia = new System.Windows.Forms.CheckBox();
            this.checkBoxActivacion = new System.Windows.Forms.CheckBox();
            this.checkBoxPresupuesto = new System.Windows.Forms.CheckBox();
            this.checkBoxReparacion = new System.Windows.Forms.CheckBox();
            this.checkBoxOtro = new System.Windows.Forms.CheckBox();
            this.checkBoxNotebook = new System.Windows.Forms.CheckBox();
            this.checkBoxCelular = new System.Windows.Forms.CheckBox();
            this.checkBoxTablet = new System.Windows.Forms.CheckBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelNroBoleta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTiempoDeGarantia = new System.Windows.Forms.Label();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCelular)).BeginInit();
            this.panelIntro.SuspendLayout();
            this.panelServicio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelDown.Controls.Add(this.pictureBoxMinimizar);
            this.panelDown.Controls.Add(this.pictureBoxClose);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDown.Location = new System.Drawing.Point(0, 0);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(979, 23);
            this.panelDown.TabIndex = 0;
            this.panelDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDown_MouseDown);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizar.Image")));
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(933, 0);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 2;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(956, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxCelular
            // 
            this.pictureBoxCelular.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCelular.Image")));
            this.pictureBoxCelular.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCelular.Name = "pictureBoxCelular";
            this.pictureBoxCelular.Size = new System.Drawing.Size(136, 121);
            this.pictureBoxCelular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCelular.TabIndex = 1;
            this.pictureBoxCelular.TabStop = false;
            // 
            // panelIntro
            // 
            this.panelIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIntro.Controls.Add(this.labelNumero);
            this.panelIntro.Controls.Add(this.labelSabado);
            this.panelIntro.Controls.Add(this.labelLunesAViernes);
            this.panelIntro.Controls.Add(this.labelTitulo);
            this.panelIntro.Controls.Add(this.pictureBoxCelular);
            this.panelIntro.Location = new System.Drawing.Point(0, 24);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(389, 135);
            this.panelIntro.TabIndex = 2;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.ForeColor = System.Drawing.Color.White;
            this.labelNumero.Location = new System.Drawing.Point(243, 104);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(109, 20);
            this.labelNumero.TabIndex = 5;
            this.labelNumero.Text = "11-3894-1181";
            // 
            // labelSabado
            // 
            this.labelSabado.AutoSize = true;
            this.labelSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSabado.ForeColor = System.Drawing.Color.White;
            this.labelSabado.Location = new System.Drawing.Point(155, 77);
            this.labelSabado.Name = "labelSabado";
            this.labelSabado.Size = new System.Drawing.Size(173, 20);
            this.labelSabado.TabIndex = 4;
            this.labelSabado.Text = "Sabados de 14 a 17hs.";
            // 
            // labelLunesAViernes
            // 
            this.labelLunesAViernes.AutoSize = true;
            this.labelLunesAViernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunesAViernes.ForeColor = System.Drawing.Color.White;
            this.labelLunesAViernes.Location = new System.Drawing.Point(155, 52);
            this.labelLunesAViernes.Name = "labelLunesAViernes";
            this.labelLunesAViernes.Size = new System.Drawing.Size(224, 20);
            this.labelLunesAViernes.TabIndex = 3;
            this.labelLunesAViernes.Text = "Lunes a Viernes de 10 a 17hs.";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(155, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(173, 31);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "S.T.Multitask";
            // 
            // panelServicio
            // 
            this.panelServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServicio.Controls.Add(this.checkBoxGarantia);
            this.panelServicio.Controls.Add(this.checkBoxActivacion);
            this.panelServicio.Controls.Add(this.checkBoxPresupuesto);
            this.panelServicio.Controls.Add(this.checkBoxReparacion);
            this.panelServicio.Controls.Add(this.checkBoxOtro);
            this.panelServicio.Controls.Add(this.checkBoxNotebook);
            this.panelServicio.Controls.Add(this.checkBoxCelular);
            this.panelServicio.Controls.Add(this.checkBoxTablet);
            this.panelServicio.Controls.Add(this.labelFecha);
            this.panelServicio.Controls.Add(this.labelNroBoleta);
            this.panelServicio.Location = new System.Drawing.Point(386, 24);
            this.panelServicio.Name = "panelServicio";
            this.panelServicio.Size = new System.Drawing.Size(593, 135);
            this.panelServicio.TabIndex = 3;
            // 
            // checkBoxGarantia
            // 
            this.checkBoxGarantia.AutoSize = true;
            this.checkBoxGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGarantia.ForeColor = System.Drawing.Color.White;
            this.checkBoxGarantia.Location = new System.Drawing.Point(194, 100);
            this.checkBoxGarantia.Name = "checkBoxGarantia";
            this.checkBoxGarantia.Size = new System.Drawing.Size(90, 24);
            this.checkBoxGarantia.TabIndex = 23;
            this.checkBoxGarantia.Text = "Garantia";
            this.checkBoxGarantia.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivacion
            // 
            this.checkBoxActivacion.AutoSize = true;
            this.checkBoxActivacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActivacion.ForeColor = System.Drawing.Color.White;
            this.checkBoxActivacion.Location = new System.Drawing.Point(194, 70);
            this.checkBoxActivacion.Name = "checkBoxActivacion";
            this.checkBoxActivacion.Size = new System.Drawing.Size(100, 24);
            this.checkBoxActivacion.TabIndex = 22;
            this.checkBoxActivacion.Text = "Activacion";
            this.checkBoxActivacion.UseVisualStyleBackColor = true;
            // 
            // checkBoxPresupuesto
            // 
            this.checkBoxPresupuesto.AutoSize = true;
            this.checkBoxPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPresupuesto.ForeColor = System.Drawing.Color.White;
            this.checkBoxPresupuesto.Location = new System.Drawing.Point(194, 40);
            this.checkBoxPresupuesto.Name = "checkBoxPresupuesto";
            this.checkBoxPresupuesto.Size = new System.Drawing.Size(118, 24);
            this.checkBoxPresupuesto.TabIndex = 21;
            this.checkBoxPresupuesto.Text = "Presupuesto";
            this.checkBoxPresupuesto.UseVisualStyleBackColor = true;
            // 
            // checkBoxReparacion
            // 
            this.checkBoxReparacion.AutoSize = true;
            this.checkBoxReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReparacion.ForeColor = System.Drawing.Color.White;
            this.checkBoxReparacion.Location = new System.Drawing.Point(194, 10);
            this.checkBoxReparacion.Name = "checkBoxReparacion";
            this.checkBoxReparacion.Size = new System.Drawing.Size(110, 24);
            this.checkBoxReparacion.TabIndex = 20;
            this.checkBoxReparacion.Text = "Reparacion";
            this.checkBoxReparacion.UseVisualStyleBackColor = true;
            // 
            // checkBoxOtro
            // 
            this.checkBoxOtro.AutoSize = true;
            this.checkBoxOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOtro.ForeColor = System.Drawing.Color.White;
            this.checkBoxOtro.Location = new System.Drawing.Point(8, 100);
            this.checkBoxOtro.Name = "checkBoxOtro";
            this.checkBoxOtro.Size = new System.Drawing.Size(59, 24);
            this.checkBoxOtro.TabIndex = 19;
            this.checkBoxOtro.Text = "Otro";
            this.checkBoxOtro.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotebook
            // 
            this.checkBoxNotebook.AutoSize = true;
            this.checkBoxNotebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNotebook.ForeColor = System.Drawing.Color.White;
            this.checkBoxNotebook.Location = new System.Drawing.Point(8, 70);
            this.checkBoxNotebook.Name = "checkBoxNotebook";
            this.checkBoxNotebook.Size = new System.Drawing.Size(97, 24);
            this.checkBoxNotebook.TabIndex = 18;
            this.checkBoxNotebook.Text = "Notebook";
            this.checkBoxNotebook.UseVisualStyleBackColor = true;
            // 
            // checkBoxCelular
            // 
            this.checkBoxCelular.AutoSize = true;
            this.checkBoxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCelular.ForeColor = System.Drawing.Color.White;
            this.checkBoxCelular.Location = new System.Drawing.Point(8, 40);
            this.checkBoxCelular.Name = "checkBoxCelular";
            this.checkBoxCelular.Size = new System.Drawing.Size(77, 24);
            this.checkBoxCelular.TabIndex = 17;
            this.checkBoxCelular.Text = "Celular";
            this.checkBoxCelular.UseVisualStyleBackColor = true;
            // 
            // checkBoxTablet
            // 
            this.checkBoxTablet.AutoSize = true;
            this.checkBoxTablet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTablet.ForeColor = System.Drawing.Color.White;
            this.checkBoxTablet.Location = new System.Drawing.Point(8, 10);
            this.checkBoxTablet.Name = "checkBoxTablet";
            this.checkBoxTablet.Size = new System.Drawing.Size(72, 24);
            this.checkBoxTablet.TabIndex = 16;
            this.checkBoxTablet.Text = "Tablet";
            this.checkBoxTablet.UseVisualStyleBackColor = true;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(337, 97);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(54, 20);
            this.labelFecha.TabIndex = 15;
            this.labelFecha.Text = "Fecha";
            // 
            // labelNroBoleta
            // 
            this.labelNroBoleta.AutoSize = true;
            this.labelNroBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroBoleta.ForeColor = System.Drawing.Color.White;
            this.labelNroBoleta.Location = new System.Drawing.Point(337, 77);
            this.labelNroBoleta.Name = "labelNroBoleta";
            this.labelNroBoleta.Size = new System.Drawing.Size(113, 20);
            this.labelNroBoleta.TabIndex = 14;
            this.labelNroBoleta.Text = "Nro De Boleta:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTiempoDeGarantia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(487, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 191);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Marca y Modelo";
            // 
            // labelTiempoDeGarantia
            // 
            this.labelTiempoDeGarantia.AutoSize = true;
            this.labelTiempoDeGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempoDeGarantia.ForeColor = System.Drawing.Color.White;
            this.labelTiempoDeGarantia.Location = new System.Drawing.Point(3, 44);
            this.labelTiempoDeGarantia.Name = "labelTiempoDeGarantia";
            this.labelTiempoDeGarantia.Size = new System.Drawing.Size(214, 20);
            this.labelTiempoDeGarantia.TabIndex = 25;
            this.labelTiempoDeGarantia.Text = "Tiempo De Garantia 15 Dias:";
            // 
            // FormReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(979, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelServicio);
            this.Controls.Add(this.panelIntro);
            this.Controls.Add(this.panelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReparacion";
            this.Text = "FormReparacion";
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCelular)).EndInit();
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.panelServicio.ResumeLayout(false);
            this.panelServicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxCelular;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelSabado;
        private System.Windows.Forms.Label labelLunesAViernes;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelServicio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelNroBoleta;
        private System.Windows.Forms.CheckBox checkBoxTablet;
        private System.Windows.Forms.CheckBox checkBoxGarantia;
        private System.Windows.Forms.CheckBox checkBoxActivacion;
        private System.Windows.Forms.CheckBox checkBoxPresupuesto;
        private System.Windows.Forms.CheckBox checkBoxReparacion;
        private System.Windows.Forms.CheckBox checkBoxOtro;
        private System.Windows.Forms.CheckBox checkBoxNotebook;
        private System.Windows.Forms.CheckBox checkBoxCelular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTiempoDeGarantia;
        private System.Windows.Forms.Label label1;
    }
}