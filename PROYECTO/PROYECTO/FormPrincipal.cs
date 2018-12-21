using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaDeNegocios;
using CapaDeDatos;
using System.Threading;

namespace PROYECTO
{
    public partial class FormPrincipal : Form
    {
        static Thread threadEmpleados;
        Empleado empleado;
        public Thread ThreadEmpleados
        {
            get
            {
                return threadEmpleados;
            }
        }

        public FormPrincipal()
        {
            InitializeComponent();
            threadEmpleados = new Thread(IniciarFormEmpleados);
        }
        public FormPrincipal(Empleado empleado):this()
        {
            this.empleado = new Empleado(empleado.User,empleado.Password,empleado.Name,empleado.LastName,empleado.Dni,empleado.Adress,empleado.MailAdress,empleado.Type);
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void ButtonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWmd, int wMsg, int wParam, int lParam);

        private void ButtonMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonReportesVentas_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;

        }

        private void buttonReportesCompras_Click(object sender, EventArgs e)
        {

            panelSubMenu.Visible = false;
        }

        private void buttonReportesPagos_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            else if (panelSubMenu.Visible == false)
                panelSubMenu.Visible = true;
        }

        private void buttonReportes_MouseHover(object sender, EventArgs e)
        {
            panelSubMenu.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
           
        }

        private void PrivilegioUsuarios()
        {
            if (this.empleado.Type != UserType.admin)
            {
                buttonUsuario.Visible = false;
                buttonPagos.Visible = false;
                buttonReportes.Visible = false;
                panelUsuarios.Visible = false;
                buttonEmpleados.Visible = false;
                panelEmpleados.Visible = false;
                panelPagos.Visible = false;
                panelReportes.Visible = false;
            }
        }
        private void panelProductos_Paint(object sender, PaintEventArgs e)
        {         
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            PrivilegioUsuarios();
        }
        private void IniciarFormEmpleados()
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.ShowDialog();
        }
        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            threadEmpleados.Start();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadEmpleados.IsAlive)
            {
                threadEmpleados.Abort();
            }
        }
    }
}
