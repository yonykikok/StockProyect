
namespace PROYECTO
{
    partial class FormDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeudores));
            this.barraSuperior = new System.Windows.Forms.Panel();
            this.panelListaDeudores = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.listBoxDeudores = new System.Windows.Forms.ListBox();
            this.buttonAgregarDeudor = new System.Windows.Forms.Button();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuitarDeudor = new System.Windows.Forms.Button();
            this.barraSuperior.SuspendLayout();
            this.panelListaDeudores.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // barraSuperior
            // 
            this.barraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraSuperior.Controls.Add(this.btnMinimizar);
            this.barraSuperior.Controls.Add(this.btnCerrar);
            this.barraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSuperior.Location = new System.Drawing.Point(0, 0);
            this.barraSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barraSuperior.MaximumSize = new System.Drawing.Size(1000, 28);
            this.barraSuperior.Name = "barraSuperior";
            this.barraSuperior.Size = new System.Drawing.Size(1000, 28);
            this.barraSuperior.TabIndex = 0;
            this.barraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSuperior_MouseDown);
            // 
            // panelListaDeudores
            // 
            this.panelListaDeudores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelListaDeudores.Controls.Add(this.panel1);
            this.panelListaDeudores.Controls.Add(this.buttonQuitarDeudor);
            this.panelListaDeudores.Controls.Add(this.panelEmpleados);
            this.panelListaDeudores.Controls.Add(this.buttonAgregarDeudor);
            this.panelListaDeudores.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListaDeudores.Location = new System.Drawing.Point(0, 28);
            this.panelListaDeudores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelListaDeudores.Name = "panelListaDeudores";
            this.panelListaDeudores.Size = new System.Drawing.Size(217, 581);
            this.panelListaDeudores.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.listBoxDeudores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(217, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 581);
            this.panel2.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(971, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(940, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // listBoxDeudores
            // 
            this.listBoxDeudores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.listBoxDeudores.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDeudores.ForeColor = System.Drawing.Color.White;
            this.listBoxDeudores.FormattingEnabled = true;
            this.listBoxDeudores.ItemHeight = 25;
            this.listBoxDeudores.Location = new System.Drawing.Point(543, 0);
            this.listBoxDeudores.Name = "listBoxDeudores";
            this.listBoxDeudores.Size = new System.Drawing.Size(240, 581);
            this.listBoxDeudores.TabIndex = 0;
            this.listBoxDeudores.SelectedIndexChanged += new System.EventHandler(this.listBoxDeudores_SelectedIndexChanged);
            // 
            // buttonAgregarDeudor
            // 
            this.buttonAgregarDeudor.FlatAppearance.BorderSize = 0;
            this.buttonAgregarDeudor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAgregarDeudor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarDeudor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarDeudor.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarDeudor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarDeudor.Image")));
            this.buttonAgregarDeudor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarDeudor.Location = new System.Drawing.Point(7, 31);
            this.buttonAgregarDeudor.Name = "buttonAgregarDeudor";
            this.buttonAgregarDeudor.Size = new System.Drawing.Size(216, 32);
            this.buttonAgregarDeudor.TabIndex = 11;
            this.buttonAgregarDeudor.Text = "Nuevo deudor";
            this.buttonAgregarDeudor.UseVisualStyleBackColor = true;
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelEmpleados.Location = new System.Drawing.Point(3, 31);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(5, 32);
            this.panelEmpleados.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 12;
            // 
            // buttonQuitarDeudor
            // 
            this.buttonQuitarDeudor.FlatAppearance.BorderSize = 0;
            this.buttonQuitarDeudor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonQuitarDeudor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitarDeudor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitarDeudor.ForeColor = System.Drawing.Color.White;
            this.buttonQuitarDeudor.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuitarDeudor.Image")));
            this.buttonQuitarDeudor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitarDeudor.Location = new System.Drawing.Point(7, 66);
            this.buttonQuitarDeudor.Name = "buttonQuitarDeudor";
            this.buttonQuitarDeudor.Size = new System.Drawing.Size(216, 32);
            this.buttonQuitarDeudor.TabIndex = 13;
            this.buttonQuitarDeudor.Text = "Quitar deudor";
            this.buttonQuitarDeudor.UseVisualStyleBackColor = true;
            // 
            // FormDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelListaDeudores);
            this.Controls.Add(this.barraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 609);
            this.MinimumSize = new System.Drawing.Size(1000, 609);
            this.Name = "FormDeudores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDeudores_Load);
            this.barraSuperior.ResumeLayout(false);
            this.panelListaDeudores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraSuperior;
        private System.Windows.Forms.Panel panelListaDeudores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.ListBox listBoxDeudores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuitarDeudor;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Button buttonAgregarDeudor;
    }
}