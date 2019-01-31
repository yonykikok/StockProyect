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
using CapaDeDatos;
using CapaDeNegocios;
using ExcepcionesPropias;
namespace PROYECTO
{
    public partial class FormEmpleados : Form
    {
        private List<Empleado> listaEmpleados;
        public FormEmpleados()
        {
            listaEmpleados = new List<Empleado>();
            InitializeComponent();
        }

        private void CargarDatosAlGridView()
        {
            dataGridViewUsuarios.Rows.Clear();
            listaEmpleados = UsuariosDAO.LeerUsuarios();
            foreach (Empleado empleado in listaEmpleados)
            {
                dataGridViewUsuarios.Rows.Add(empleado.Id, empleado.User, empleado.Name, empleado.LastName, empleado.Dni, empleado.Adress, empleado.MailAdress, empleado.Password, empleado.Type);
            }
        }
        private void ActivarColumasDataGridView()
        {
            dataGridViewUsuarios.Columns[1].Visible = true;//Usuario
            dataGridViewUsuarios.Columns[2].Visible = true;//Nombre
            dataGridViewUsuarios.Columns[3].Visible = true;//Apellido
            dataGridViewUsuarios.Columns[8].Visible = true;//Tipo de cuenta
        }
        /// <summary>
        /// Desactiva las columas Indice,dni,direccion,mail,StockIdeal y StockMinimo para que no sean visibles
        /// </summary>
        private void DesactivarColumasDataGridView()
        {
            dataGridViewUsuarios.Columns[0].Visible = false;//Indice / Id
            dataGridViewUsuarios.Columns[4].Visible = false;//Dni
            dataGridViewUsuarios.Columns[5].Visible = false;//Direccion
            dataGridViewUsuarios.Columns[6].Visible = false;//Mail
            dataGridViewUsuarios.Columns[7].Visible = false;//Contraseña
        }
        /// <summary>
        /// carga los datos al gridView, vacia los textbox y desactiva las colomnas especiales de datos del gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarDatosAlGridView();
            textBoxUsuario.Text = null;
            textBoxName.Text = null;
            textBoxLastName.Text = null;
            textBoxDni.Text = null;
            textBoxAdress.Text = null;
            textBoxMailAdress.Text = null;
            textBoxPassword.Text = null;
            DesactivarColumasDataGridView();
        }
        /// <summary>
        /// permite deslizar la ventana 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Empleados_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        /// <summary>
        /// obtiene los datos de los TextBox y crea un empleado si los datos estan correcto
        /// </summary>
        /// <returns> retorna un empleado</returns>
        private Empleado ObtenerEmpleadoDelFormulario()
        {
            Empleado empleado = null;
            try
            {
                if (textBoxUsuario.Text.ToLower().Length > 0)
                {
                    if (textBoxPassword.Text.ToLower().Length > 0)
                    {
                        if (textBoxName.Text.ToLower().Length > 0)
                        {
                            if (textBoxLastName.Text.ToLower().Length > 0)
                            {
                                if (textBoxDni.Text.ToLower().Length > 0)
                                {
                                    if (textBoxAdress.Text.ToLower().Length > 0)
                                    {
                                        if (textBoxMailAdress.Text.ToLower().Length > 0)
                                        {
                                            if (comboBoxUserType.SelectedItem.ToString().ToLower() == "user" || comboBoxUserType.SelectedItem.ToString().ToLower() == "admin")
                                            {
                                                int id;
                                                if (Int32.TryParse(textBoxId.Text, out id))
                                                {
                                                    string user = textBoxUsuario.Text.ToLower();
                                                    string password = textBoxPassword.Text.ToLower();
                                                    string name = textBoxName.Text.ToLower();
                                                    string lastName = textBoxLastName.Text.ToLower();
                                                    string dni = textBoxDni.Text.ToLower();
                                                    string adress = textBoxAdress.Text.ToLower();
                                                    string mailAdress = textBoxMailAdress.Text.ToLower();
                                                    UserType userType = (UserType)Enum.Parse(typeof(UserType), comboBoxUserType.SelectedItem.ToString().ToLower());
                                                    empleado = new Empleado(user, password, name, lastName, dni, adress, mailAdress, userType, id);
                                                }
                                                else
                                                {
                                                    string user = textBoxUsuario.Text.ToLower();
                                                    string password = textBoxPassword.Text.ToLower();
                                                    string name = textBoxName.Text.ToLower();
                                                    string lastName = textBoxLastName.Text.ToLower();
                                                    string dni = textBoxDni.Text.ToLower();
                                                    string adress = textBoxAdress.Text.ToLower();
                                                    string mailAdress = textBoxMailAdress.Text.ToLower();
                                                    UserType userType = (UserType)Enum.Parse(typeof(UserType), comboBoxUserType.SelectedItem.ToString().ToLower());
                                                    empleado = new Empleado(user, password, name, lastName, dni, adress, mailAdress, userType);
                                                }
                                            }
                                            else
                                            {
                                                throw new UserTypeInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Tipo de Usuario");
                                            }

                                        }
                                        else
                                        {
                                            throw new MailAdressInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Mail");
                                        }
                                    }
                                    else
                                    {
                                        throw new AdressInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese Direccion");
                                    }
                                }
                                else
                                {
                                    throw new DniInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Dni");
                                }
                            }
                            else
                            {
                                throw new LastNameInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Apellido");
                            }
                        }
                        else
                        {
                            throw new NameInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Nombre");
                        }
                    }
                    else
                    {
                        throw new PasswordInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese la Contraseña");
                    }
                }
                else
                {
                    throw new UsuarioInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Usuario");
                }

            }
            catch (Exception exception)
            {
                throw exception;
            }
            return empleado;
        }
        /// <summary>
        /// agrega un usuario a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                Empleado empleado = ObtenerEmpleadoDelFormulario();
                if (!UsuariosDAO.comprobarIdUsuario(empleado))
                {
                    UsuariosDAO.InsertarUsuario(empleado);
                    CargarDatosAlGridView();
                }
                else
                {
                    MessageBox.Show("El usuario ya existe.");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al Agregar Usuario " + exception.Message);
            }

        }
        /// <summary>
        /// Cargo Los Usuarios leidos Obtenidos del GridView  a los textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsuarios_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value is null))
                {
                    if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value is null))
                    {
                        if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value is null))
                        {
                            if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Dni"].Value is null))
                            {
                                if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Direccion"].Value is null))
                                {
                                    if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Mail"].Value is null))
                                    {
                                        if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value is null))
                                        {
                                            if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["Indice"].Value is null))
                                            {
                                                if (!(dataGridViewUsuarios.Rows[e.RowIndex].Cells["TipoDeUsuario"].Value is null))//verifica que no tenga datos nulos
                                                {
                                                    textBoxUsuario.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                                                    textBoxName.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                                                    textBoxLastName.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                                                    textBoxDni.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                                                    textBoxAdress.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                                                    textBoxMailAdress.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
                                                    textBoxPassword.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                                                    textBoxId.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells["Indice"].Value.ToString();
                                                    if (dataGridViewUsuarios.Rows[e.RowIndex].Cells["TipoDeUsuario"].Value.ToString().ToLower() == "admin")
                                                    {
                                                        comboBoxUserType.SelectedItem = "Admin";
                                                    }
                                                    else
                                                    {
                                                        comboBoxUserType.SelectedItem = "User";
                                                    }
                                                }
                                                else
                                                {
                                                    dataGridViewUsuarios.Rows[e.RowIndex].Cells["TipoDeUsuario"].Value = "user";
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("ERRROR EN EL ID");
                                            }
                                        }
                                        else
                                        {
                                            dataGridViewUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value = "SinPassword";
                                        }
                                    }
                                    else
                                    {
                                        dataGridViewUsuarios.Rows[e.RowIndex].Cells["Mail"].Value = "SinMail";
                                    }
                                }
                                else
                                {
                                    dataGridViewUsuarios.Rows[e.RowIndex].Cells["Direccion"].Value = "SinDireccion";
                                }
                            }
                            else
                            {
                                dataGridViewUsuarios.Rows[e.RowIndex].Cells["Dni"].Value = "SinDni";
                            }
                        }
                        else
                        {
                            dataGridViewUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value = "SinApellido";
                        }
                    }
                    else
                    {
                        dataGridViewUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value = "SinNombre";
                    }
                }
                else
                {
                    dataGridViewUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value = "SinUsuario";
                }

            }
            catch (Exception exception)
            {
                textBoxUsuario.Text = "";
                textBoxName.Text = "";
                textBoxLastName.Text = "";
                textBoxDni.Text = "";
                textBoxAdress.Text = "";
                textBoxMailAdress.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show("Error al cargar los datos de los 'USUARIOS' al GridView");
            }
        }
        /// <summary>
        /// minimiza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// modifica los datos de un usuario en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
             try
            {
                Empleado empleado = ObtenerEmpleadoDelFormulario();
                if (!(empleado is null))
                {
                    int id;
                    if (Int32.TryParse(textBoxId.Text, out id))
                    {
                        UsuariosDAO.Modificar(empleado);
                        CargarDatosAlGridView();
                    }
                }
            }
            catch (UsuarioInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (NameInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (LastNameInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (DniInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (AdressInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (MailAdressInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (PasswordInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (UserTypeInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error al modificar un usuario, puede que algun dato no este ingresado");
            }
        }
        /// <summary>
        /// remueve un usuario de la base de datos por el id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitarUsuario_Click(object sender, EventArgs e)
        {
            Empleado empleado = ObtenerEmpleadoDelFormulario();
            int id;
            if (Int32.TryParse(textBoxId.Text, out id))
            {
                UsuariosDAO.Remover(empleado);
                CargarDatosAlGridView();
            }
        }
    }
}
