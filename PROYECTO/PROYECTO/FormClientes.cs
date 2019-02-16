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
            List<Cliente> clientes = ClientesDAO.LeerUsuarios();
            foreach (Cliente cliente in clientes)
            {
                dataGridViewClientes.Rows.Add(cliente.Id, cliente.Name, cliente.LastName, cliente.Dni, cliente.Adress,cliente.Numero);
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
                                if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Telefono"].Value is null))
                                {
                                    if (!(dataGridViewClientes.Rows[e.RowIndex].Cells["Indice"].Value is null))
                                    {
                                        textBoxNombre.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                                        textBoxApellido.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                                        textBoxDni.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Dni"].Value.ToString();
                                        textBoxDireccion.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
                                        textBoxIndice.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Indice"].Value.ToString();
                                        textBoxTelefono.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
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
            string nombre=textBoxNombre.Text;
            string apellido=textBoxApellido.Text;
            string dni = textBoxDni.Text;
            string direccion=textBoxDireccion.Text;
            string telefono=textBoxTelefono.Text;
            FormVenta.ClienteSeleccionado = new Cliente(nombre, apellido, dni, direccion,"Sin Mail", telefono);
            this.Close();
        }
    }
}
