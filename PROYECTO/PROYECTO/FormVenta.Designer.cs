namespace PROYECTO
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
            this.PanelDown = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCerrar = new System.Windows.Forms.PictureBox();
            this.buttonMinimizar = new System.Windows.Forms.PictureBox();
            this.richTextBoxResumen = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PanelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).BeginInit();
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
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(1232, 25);
            this.PanelDown.TabIndex = 1;
            this.PanelDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDown_MouseDown);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.Image")));
            this.buttonCerrar.Location = new System.Drawing.Point(1214, 3);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(15, 15);
            this.buttonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCerrar.TabIndex = 4;
            this.buttonCerrar.TabStop = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.Image")));
            this.buttonMinimizar.Location = new System.Drawing.Point(1193, 3);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(15, 15);
            this.buttonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizar.TabIndex = 5;
            this.buttonMinimizar.TabStop = false;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // richTextBoxResumen
            // 
            this.richTextBoxResumen.Location = new System.Drawing.Point(28, 225);
            this.richTextBoxResumen.Name = "richTextBoxResumen";
            this.richTextBoxResumen.ReadOnly = true;
            this.richTextBoxResumen.Size = new System.Drawing.Size(725, 328);
            this.richTextBoxResumen.TabIndex = 2;
            this.richTextBoxResumen.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1002, 511);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1002, 470);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 4;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1232, 676);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBoxResumen);
            this.Controls.Add(this.PanelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVenta";
            this.PanelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDown;
        private System.Windows.Forms.PictureBox buttonCerrar;
        private System.Windows.Forms.PictureBox buttonMinimizar;
        private System.Windows.Forms.RichTextBox richTextBoxResumen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}