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
using ExcepcionesPropias;
using ExcepcionesPropiasDAO;
namespace PROYECTO
{
    public partial class FormClientes : Form
    {

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            SeleccionarSector();
            CargarDatosAlDataGridView();
            if (Program.EmpleadoProgram.Type != UserType.admin)
            {
                panelDatosDelCliente.Visible = false;
            }

        }
        /// <summary>
        /// Selecciona los paneles que seran visibles segun donde este haciendo click el usuario.
        /// Sector Clientes Existente;
        /// Sector Clientes Nuevos;
        /// Sector Clientes (modo Administrador);
        /// </summary>
        private void SeleccionarSector()
        {
            if (Program.MockThreads.Last().Name.ToLower() == "clienteexistente")
            {
                panelClienteExistente.Visible = true;
                panelClienteNuevo.Visible = false;
            }
            else if (Program.MockThreads.Last().Name.ToLower() == "clientes")
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
        private void CargarDatosAlDataGridView()
        {
            dataGridViewClientes.Rows.Clear();
            try
            {
                List<Cliente> clientes = ClientesDAO.LeerClientes();
                foreach (Cliente cliente in clientes)
                {
                    dataGridViewClientes.Rows.Add(cliente.Id, cliente.Name, cliente.LastName, cliente.Dni, cliente.Adress, cliente.MailAdress, cliente.Numero);
                }
            }
            catch (TablaInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
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



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridViewClientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Nombre"].Value is null))
                {
                    if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Apellido"].Value is null))
                    {
                        if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Dni"].Value is null))
                        {
                            if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Direccion"].Value is null))
                            {
                                if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Direccion"].Value is null))
                                {
                                    if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Telefono"].Value is null))
                                    {
                                        if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Indice"].Value is null))
                                        {
                                            textBoxNombre.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                                            textBoxApellido.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                                            textBoxDni.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                                            textBoxDireccion.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                                            textBoxMail.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
                                            textBoxTelefono.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                                            textBoxIndice.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Indice"].Value.ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("ERRROR EN EL ID");
                                        }
                                    }
                                    else
                                    {
                                        dataGridViewClientes.Rows[e.RowIndex].Cells["Telefono"].Value = "SinTelefono";
                                    }
                                }
                                else
                                {
                                    dataGridViewClientes.Rows[e.RowIndex].Cells["Mail"].Value = "SinMail";
                                }
                            }
                            else
                            {
                                dataGridViewClientes.Rows[e.RowIndex].Cells["Direccion"].Value = "SinDireccion";
                            }
                        }
                        else
                        {
                            dataGridViewClientes.Rows[e.RowIndex].Cells["Dni"].Value = "SinDni";
                        }
                    }
                    else
                    {
                        dataGridViewClientes.Rows[e.RowIndex].Cells["Apellido"].Value = "SinApellido";
                    }
                }
                else
                {
                    dataGridViewClientes.Rows[e.RowIndex].Cells["Nombre"].Value = "SinNombre";
                }

            }
            catch (Exception exception)
            {
                textBoxNombre.Text = "";
                textBoxApellido.Text = "";
                textBoxDni.Text = "";
                textBoxDireccion.Text = "";
                MessageBox.Show("Error al cargar los datos de los 'CLIENTES' al GridView " + exception.Message);
            }

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string dni = textBoxDni.Text;
            string direccion = textBoxDireccion.Text;
            string telefono = textBoxTelefono.Text;
            FormVenta.ClienteSeleccionado = new Cliente(nombre, apellido, dni, direccion, "Sin Mail", telefono);
            this.Close();
        }
        private Cliente ObtenerClienteDeLosTextBox()
        {
            Cliente retorno = null;
            try
            {
                if (textBoxNombre.Text.ToLower().Length > 0)
                {
                    if (textBoxApellido.Text.ToLower().Length > 0)
                    {
                        if (textBoxDni.Text.ToLower().Length > 0)
                        {
                            if (textBoxDireccion.Text.ToLower().Length > 0)
                            {
                                if (textBoxMail.Text.ToLower().Length > 0)
                                {
                                    if (textBoxTelefono.Text.ToLower().Length > 0)
                                    {
                                        int id;
                                        if (Int32.TryParse(textBoxIndice.Text, out id))
                                        {
                                            string name = textBoxNombre.Text.ToLower();
                                            string lastName = textBoxApellido.Text.ToLower();
                                            string dni = textBoxDni.Text.ToLower();
                                            string adress = textBoxDireccion.Text.ToLower();
                                            string mail = textBoxMail.Text.ToLower();
                                            string number = textBoxTelefono.Text.ToLower();
                                            retorno = new Cliente(name, lastName, dni, adress, mail, number, id);
                                        }
                                        else
                                        {
                                            string name = textBoxNombre.Text.ToLower();
                                            string lastName = textBoxApellido.Text.ToLower();
                                            string dni = textBoxDni.Text.ToLower();
                                            string adress = textBoxDireccion.Text.ToLower();
                                            string mail = textBoxMail.Text.ToLower();
                                            string number = textBoxTelefono.Text.ToLower();
                                            retorno = new Cliente(name, lastName, dni, adress, mail, number);
                                        }
                                    }
                                    else
                                    {
                                        throw new NumberInvalidException("ERROR, todos los campos son obligatorios, por favor ingrese el Numero");
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
            catch (Exception exception)
            {
                throw exception;
            }

            return retorno;
        }
        private bool VerificarExistenciaPorId(Cliente cliente)
        {
            bool retorno = false;
            List<Cliente> clientes = ClientesDAO.LeerClientes();
            foreach (Cliente auxCliente in clientes)
            {
                if (cliente.Id == auxCliente.Id)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        private bool VerificarExistenciaDelClienteEnDB(Cliente cliente)
        {
            bool retorno = false;
            List<Cliente> clientes = ClientesDAO.LeerClientes();
            foreach (Cliente auxCliente in clientes)
            {
                if (cliente.Dni == auxCliente.Dni || cliente.MailAdress == auxCliente.MailAdress || cliente.Id == auxCliente.Id)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = ObtenerClienteDeLosTextBox();
                if (VerificarExistenciaDelClienteEnDB(cliente))
                {
                    MessageBox.Show("Este Cliente ya esta registrado.");
                }
                else
                {
                    ClientesDAO.InsertarUsuario(cliente);
                    CargarDatosAlDataGridView();
                }
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
            catch (NumberInvalidException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LimpiarTextBoxs()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDni.Clear();
            textBoxDireccion.Clear();
            textBoxMail.Clear();
            textBoxTelefono.Clear();
            textBoxIndice.Clear();
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObtenerClienteDeLosTextBox();
            if (VerificarExistenciaDelClienteEnDB(cliente))
            {
                ClientesDAO.Modificar(cliente);
                CargarDatosAlDataGridView();
                LimpiarTextBoxs();
            }
            else
            {
                MessageBox.Show("Error, Cliente No Encontrado");
            }
        }

        private void dataGridViewClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridViewClientes_RowHeaderMouseDoubleClick(sender, e);
        }
    }
}
