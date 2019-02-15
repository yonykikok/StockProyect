using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void panelBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
           
            if (Program.MockThreads.Last().Name.ToLower() == "clienteexistente")
            {
                panelClienteExistente.Visible = true;
                panelClienteNuevo.Visible = false;                
            }
            else if(Program.MockThreads.Last().Name.ToLower() == "clientes")
            {
                panelClienteExistente.Visible = false;
                panelClienteNuevo.Visible = false;
                panelAdministraror.Visible = true;
                panelHistorial.Visible = true;
            }
            else
            {
                panelClienteExistente.Visible = false;
                panelClienteNuevo.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
