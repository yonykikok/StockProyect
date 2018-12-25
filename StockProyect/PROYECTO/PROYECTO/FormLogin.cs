using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using CapaDeDatos;
namespace PROYECTO
{
    public partial class FormLogin : Form
    {
        Empleado empleado;

        public Empleado Empleado
        {
            get
            {
                return this.empleado;
            }
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsurio_Enter(object sender, EventArgs e)
        {
            if (textBoxUsurio.Text == "Usuario")
            {
                textBoxUsurio.Text = "";
                textBoxUsurio.ForeColor = Color.LightGray;

            }
        }

        private void textBoxUsurio_Leave(object sender, EventArgs e)
        {
            if (textBoxUsurio.Text == "")
            {
                textBoxUsurio.Text = "Usuario";
                textBoxUsurio.ForeColor = Color.DimGray;

            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.UseSystemPasswordChar = true;

            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.DimGray;
                textBoxPassword.UseSystemPasswordChar = false;

            }
        }

        private void ButtonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                labelErrorUsuario.Text = "";
                labelErrorPassword.Text = "";
                labelErrorDatosInvalidos.Text = "";
                empleado = new Empleado(textBoxUsurio.Text, textBoxPassword.Text);
                UsuariosDAO personaDao = new UsuariosDAO();
                Empleado empleadoLeido = personaDao.LeerUsuarioCompleto(empleado);
                if (empleadoLeido.User == empleado.User && empleadoLeido.Password == empleado.Password)
                {
                    this.Close();
                    FormPrincipal mainForm = new FormPrincipal(empleadoLeido);
                    Program.EmpleadoProgram = empleadoLeido;
                    mainForm.ShowDialog();
                }
                else
                {
                    if (empleadoLeido.User == "InvalidUser" && empleadoLeido.Password != "InvalidPass")
                    {
                        labelErrorUsuario.Text = "Usuario Incorrecto, intente de nuevo";
                        labelErrorUsuario.Visible = true;
                        textBoxPassword.Text = "";
                        textBoxUsurio_Leave(null, e);
                        textBoxUsurio.Focus();
                    }
                    else if (empleado.User == empleadoLeido.User && empleadoLeido.Password == "InvalidPass")
                    {
                        labelErrorPassword.Text = "Password Incorrecto, intente de nuevo";
                        labelErrorPassword.Visible = true;
                        textBoxPassword.Text = "";
                        textBoxPassword_Leave(null, e);
                        textBoxPassword.Focus();
                    }
                }
            }
            catch (Exception)
            {
                labelErrorDatosInvalidos.Text = "Datos Invalidos vuelva a Intentar";
                labelErrorDatosInvalidos.Visible = true;
                textBoxPassword.Text = "";
                textBoxUsurio.Text = "";
                labelErrorUsuario.Text = "";
                textBoxUsurio_Leave(null, e);
                textBoxUsurio.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
