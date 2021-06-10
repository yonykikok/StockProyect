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

namespace PROYECTO
{
    public partial class FormDeudores : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public FormDeudores()
        {
            InitializeComponent();
            clientes.Add(new Deudor("Juan", "Perez", "40132525", "pepepepe", "lalala@gmail.com", "1540132526", "Celular samsung J7 libre", 2400, DateTime.Now, DateTime.Now, 0));
            clientes.Add(new Deudor("Lucia", "Sanchez", "40131525", "pepepepe", "lalala@gmail.com", "1540132526", "Celular samsung J7 libre", 2400, DateTime.Now, DateTime.Now, 0));
            clientes.Add(new Deudor("Julieta", "Peralta", "41032525", "pepepepe", "lalala@gmail.com", "1540132526", "Celular samsung J7 libre", 2400, DateTime.Now, DateTime.Now, 0));
            clientes.Add(new Deudor("Martin", "Baez", "40132225", "pepepepe", "lalala@gmail.com", "1540132526", "Celular samsung J7 libre", 2400, DateTime.Now, DateTime.Now, 0));
            clientes.Add(new Deudor("Pedro", "Pedone", "40177725", "pepepepe", "lalala@gmail.com", "1540132526", "Celular samsung J7 libre", 2400, DateTime.Now, DateTime.Now, 0));
            clientes.Add(new Deudor("Juan", "Perez", "40132525", "pepepepe", "lalala@gmail.com", "1540132526", "Celular samsung J7 libre", 2400, DateTime.Now, DateTime.Now, 0));


            foreach (Cliente cliente in clientes) {
                this.listBoxDeudores.Items.Add(cliente.LastName+" "+ cliente.Name);
            }
        }

        private void FormDeudores_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void barraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void listBoxDeudores_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Cliente cliente in this.clientes) { 
            MessageBox.Show(cliente.ToString());
            }
        }
    }
}
