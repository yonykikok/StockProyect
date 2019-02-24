namespace PROYECTO
{
    partial class FormCantidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCantidad));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.comboBoxCantidad = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonAgregarVenta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCantidadTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.labelCantidadTitle);
            this.panel1.Controls.Add(this.buttonMinimizar);
            this.panel1.Controls.Add(this.buttonCerrar);
            this.panel1.Controls.Add(this.pictureBoxMinimizar);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 25);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.Image")));
            this.buttonMinimizar.Location = new System.Drawing.Point(183, 3);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(15, 15);
            this.buttonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizar.TabIndex = 3;
            this.buttonMinimizar.TabStop = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.Location = new System.Drawing.Point(204, 3);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(15, 15);
            this.buttonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.TabStop = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
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
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCantidad.Location = new System.Drawing.Point(68, 29);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(82, 16);
            this.labelCantidad.TabIndex = 2;
            this.labelCantidad.Text = "Cantidad ?";
            // 
            // comboBoxCantidad
            // 
            this.comboBoxCantidad.DisplayMember = "1";
            this.comboBoxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCantidad.FormattingEnabled = true;
            this.comboBoxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.comboBoxCantidad.Location = new System.Drawing.Point(53, 51);
            this.comboBoxCantidad.Name = "comboBoxCantidad";
            this.comboBoxCantidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCantidad.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(32, 90);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 29);
            this.panel11.TabIndex = 30;
            // 
            // buttonAgregarVenta
            // 
            this.buttonAgregarVenta.FlatAppearance.BorderSize = 0;
            this.buttonAgregarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarVenta.Location = new System.Drawing.Point(35, 90);
            this.buttonAgregarVenta.Name = "buttonAgregarVenta";
            this.buttonAgregarVenta.Size = new System.Drawing.Size(85, 29);
            this.buttonAgregarVenta.TabIndex = 29;
            this.buttonAgregarVenta.Text = "Aceptar";
            this.buttonAgregarVenta.UseVisualStyleBackColor = true;
            this.buttonAgregarVenta.Click += new System.EventHandler(this.buttonAgregarVenta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(106, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 29);
            this.panel2.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(109, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelCantidadTitle
            // 
            this.labelCantidadTitle.AutoSize = true;
            this.labelCantidadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadTitle.ForeColor = System.Drawing.Color.White;
            this.labelCantidadTitle.Location = new System.Drawing.Point(22, 2);
            this.labelCantidadTitle.Name = "labelCantidadTitle";
            this.labelCantidadTitle.Size = new System.Drawing.Size(141, 20);
            this.labelCantidadTitle.TabIndex = 5;
            this.labelCantidadTitle.Text = "Multitask-Cantidad";
            // 
            // FormCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(222, 125);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.buttonAgregarVenta);
            this.Controls.Add(this.comboBoxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCantidad";
            this.Load += new System.EventHandler(this.FormCantidad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.PictureBox buttonCerrar;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.ComboBox comboBoxCantidad;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button buttonAgregarVenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCantidadTitle;
    }
}