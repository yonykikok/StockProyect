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
    public partial class FormCantidad : Form
    {
        private int cantidad;
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidad = value;
                }
            }
        }

        public FormCantidad()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonAgregarVenta_Click(object sender, EventArgs e)
        {
            int auxCantidad;
            if (!(comboBoxCantidad.SelectedItem is null))
            {
                if (Int32.TryParse(comboBoxCantidad.SelectedItem.ToString(), out auxCantidad))
                    Cantidad = auxCantidad;
            }
            else
            {
                MessageBox.Show("ingrese una cantidad.");
            }
        }

        private void FormCantidad_Load(object sender, EventArgs e)
        {
            comboBoxCantidad.SelectedItem = 1;
        }
    }
}
