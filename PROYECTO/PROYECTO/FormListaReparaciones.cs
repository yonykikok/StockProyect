using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FormListaReparaciones : Form
    {
        Thread threadReparacion;

        public Thread ThreadReparacion { get => threadReparacion; set => threadReparacion = value; }

        public FormListaReparaciones()
        {
            InitializeComponent();
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDownBar_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxHamburgeMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Visible)
            {
                panelMenu.Visible = false;
                pictureBoxHamburgeMenu.Visible = true;
                pictureBoxHamburgeMenu.Location = new Point(4, 25);
            }
            else
            {
                panelMenu.Visible = true;
                pictureBoxHamburgeMenu.Location = new Point(931, 25);
            }
        }

        private void pictureBoxHamburgeMenu_MouseHover(object sender, EventArgs e)
        {
           this.Cursor = Cursors.Hand;
        }

        private void pictureBoxHamburgeMenu_MouseLeave(object sender, EventArgs e)
        {
           this.Cursor = Cursors.Arrow;
        }

        private void IniciarFormReparacion()
        {
            FormReparacion formReparacion = new FormReparacion();
            formReparacion.ShowDialog();
        }
        private void buttonNuevaReparacion_Click(object sender, EventArgs e)
        {
            ThreadReparacion = new Thread(IniciarFormReparacion);
            Program.MockThreads.Add(ThreadReparacion);
            if (!(this.ThreadReparacion.IsAlive))
            {
                ThreadReparacion.Start();
            }
        }
    }
}
