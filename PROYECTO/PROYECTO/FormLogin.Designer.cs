namespace PROYECTO
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxUsurio = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.linkLabelPasswordLost = new System.Windows.Forms.LinkLabel();
            this.ButtonCerrar = new System.Windows.Forms.PictureBox();
            this.ButtonMinimizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelErrorUsuario = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.labelErrorDatosInvalidos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 221);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxUsurio
            // 
            this.textBoxUsurio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxUsurio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsurio.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsurio.Location = new System.Drawing.Point(341, 80);
            this.textBoxUsurio.Name = "textBoxUsurio";
            this.textBoxUsurio.Size = new System.Drawing.Size(318, 15);
            this.textBoxUsurio.TabIndex = 1;
            this.textBoxUsurio.Text = "Usuario";
            this.textBoxUsurio.Enter += new System.EventHandler(this.textBoxUsurio_Enter);
            this.textBoxUsurio.Leave += new System.EventHandler(this.textBoxUsurio_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.Location = new System.Drawing.Point(341, 144);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(318, 15);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.labelLogin.Location = new System.Drawing.Point(457, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(117, 37);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "LOGIN";
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonAcceder.FlatAppearance.BorderSize = 0;
            this.buttonAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceder.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAcceder.Location = new System.Drawing.Point(385, 262);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(274, 35);
            this.buttonAcceder.TabIndex = 3;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = false;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // linkLabelPasswordLost
            // 
            this.linkLabelPasswordLost.AutoSize = true;
            this.linkLabelPasswordLost.Location = new System.Drawing.Point(461, 300);
            this.linkLabelPasswordLost.Name = "linkLabelPasswordLost";
            this.linkLabelPasswordLost.Size = new System.Drawing.Size(137, 13);
            this.linkLabelPasswordLost.TabIndex = 0;
            this.linkLabelPasswordLost.TabStop = true;
            this.linkLabelPasswordLost.Text = "Ha olvidado la contraseña?";
            // 
            // ButtonCerrar
            // 
            this.ButtonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCerrar.Image")));
            this.ButtonCerrar.Location = new System.Drawing.Point(764, 0);
            this.ButtonCerrar.Name = "ButtonCerrar";
            this.ButtonCerrar.Size = new System.Drawing.Size(15, 15);
            this.ButtonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonCerrar.TabIndex = 6;
            this.ButtonCerrar.TabStop = false;
            this.ButtonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // ButtonMinimizar
            // 
            this.ButtonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimizar.Image")));
            this.ButtonMinimizar.Location = new System.Drawing.Point(743, 0);
            this.ButtonMinimizar.Name = "ButtonMinimizar";
            this.ButtonMinimizar.Size = new System.Drawing.Size(15, 15);
            this.ButtonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimizar.TabIndex = 7;
            this.ButtonMinimizar.TabStop = false;
            this.ButtonMinimizar.Click += new System.EventHandler(this.ButtonMinimizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(341, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(341, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 1);
            this.panel3.TabIndex = 9;
            // 
            // labelErrorUsuario
            // 
            this.labelErrorUsuario.AutoSize = true;
            this.labelErrorUsuario.Location = new System.Drawing.Point(338, 99);
            this.labelErrorUsuario.Name = "labelErrorUsuario";
            this.labelErrorUsuario.Size = new System.Drawing.Size(68, 13);
            this.labelErrorUsuario.TabIndex = 10;
            this.labelErrorUsuario.Text = "Error Usuario";
            this.labelErrorUsuario.Visible = false;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.Location = new System.Drawing.Point(338, 163);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(78, 13);
            this.labelErrorPassword.TabIndex = 11;
            this.labelErrorPassword.Text = "Error Password";
            this.labelErrorPassword.Visible = false;
            // 
            // labelErrorDatosInvalidos
            // 
            this.labelErrorDatosInvalidos.AutoSize = true;
            this.labelErrorDatosInvalidos.Location = new System.Drawing.Point(382, 246);
            this.labelErrorDatosInvalidos.Name = "labelErrorDatosInvalidos";
            this.labelErrorDatosInvalidos.Size = new System.Drawing.Size(105, 13);
            this.labelErrorDatosInvalidos.TabIndex = 12;
            this.labelErrorDatosInvalidos.Text = "Error Datos Invalidos";
            this.labelErrorDatosInvalidos.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.labelErrorDatosInvalidos);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.labelErrorUsuario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonMinimizar);
            this.Controls.Add(this.ButtonCerrar);
            this.Controls.Add(this.linkLabelPasswordLost);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsurio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUsurio;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.LinkLabel linkLabelPasswordLost;
        private System.Windows.Forms.PictureBox ButtonCerrar;
        private System.Windows.Forms.PictureBox ButtonMinimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelErrorUsuario;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Label labelErrorDatosInvalidos;
    }
}