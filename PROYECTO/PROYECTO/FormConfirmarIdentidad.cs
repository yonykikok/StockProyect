using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using CapaDeNegocios;

namespace PROYECTO
{
    public partial class FormConfirmarIdentidad : Form
    {
        public FormConfirmarIdentidad()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(textBoxUsuario.Text, textBoxPassword.Text);
            Empleado auxEmpleado = UsuariosDAO.LeerUsuarioCompleto(empleado);

            if (auxEmpleado.Type != UserType.admin)
            {
                MessageBox.Show("NO TIENE PERMISO PARA ESTA ACCION");
            }            
        }
    }
}
