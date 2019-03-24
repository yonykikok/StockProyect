using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using ExcepcionesPropiasReparacion;
using ExcepcionesPropias;
namespace PROYECTO
{
    public partial class FormReparacion : Form
    {
        private int[] patterLock;

        public int[] PatterLock { get => patterLock; set => patterLock = value; }

        public FormReparacion()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDown_MouseDown(object sender, MouseEventArgs e)
        {
            Program.ReleaseCapture();
            Program.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// enumera 7(siete) aclaraciones para el cliente sobre una reparacion.
        /// </summary>
        /// <returns></returns>
        private string Aclaraciones()
        {
            string puntoUno = "1)-Pasado los 30 dias de corrido de la fecha de reparacion del equipo, \nse cobrara $8(pesos) diarios en concepto de almacenaje y estadia.";
            string puntoDos = "2)-Los equipos se reciben sin simcard, sin memoria y sin accesorios, sujetos a la exclusiva responsabilidad del cliente.";
            string puntoTres = "3)-Los trabajos de desbloqueo no tienen garantia.";
            string puntoCuatro = "4)-En caso de extravio de este comprobante el equipo solo puede ser retirado por el titular con el DNI en mano.";
            string puntoCinco = "5)-Por golpes o mojaduras, la garantia se anula automaticamente.";
            string puntoSeis = "6)-En los trabajos de Flash se pueden llegar a perder todos los datos del equipo";
            string puntoSiete = "7)-Garantia 15 dias.";
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n", puntoUno, puntoDos, puntoTres, puntoCuatro, puntoCinco, puntoSeis, puntoSiete);
        }
        private string AcuerdosAntesDeFirmar()
        {
            return "1)-Por medio de la firma, el propietario se declara en pleno conocimiento de los siguiente:\nTodo aparato dejado en el laboratorio a efecto de ser reparado y/o confeccionar presupuesto, debera ser retirado dentro de los 60 dias a partir de la fecha, reparado o no, caso contrario se considera abandonado por su dueño, Art.2525 y 2526 del Codigo Civil porlo que 'STM' dispondra del aparato como crea conveniente, renunciando el propietario a exigir suma alguna en concepto de compensacion y/o indemnizacion. Toda suma que hubiese sido entraga a cuenta de reparacion sera destinada a cubrir gastos ocacionados y deposito.\n2)-Garantia 15 dias sobre la falla declarada por el cliente.";
        }
        private void FormReparacion_Load(object sender, EventArgs e)
        {
            richTextBoxAclaraciones.Text = Aclaraciones();
            richTextBoxAcuerdos.Text = AcuerdosAntesDeFirmar();
            textBoxFecha.Text = DateTime.Now.ToString();
            textBoxNroDeBoleta.Text = "0003015";
            foreach (string observacion in Enum.GetNames(typeof(EObservaciones)))
            {
                comboBoxObservaciones.Items.Add(observacion);
            }

        }
        private void PatterLockControl_PassCodeSubmitted(object sender, GestureLockApp.GestureLockControl.PassCodeSubmittedEventArgs e)
        {
            if (e.Code.Length >= 4)
            {
                PatterLock = e.Code;
            }
            else
            {
                //error patron invalido.
            }
            //PatterLockControl.SetPassCode(passCode);
        }


        private void pictureBoxCheckForm_MouseHover(object sender, EventArgs e)
        {
            panelCheckForm.BackColor = Color.FromArgb(0, 80, 200);
        }

        private void pictureBoxCheckForm_MouseLeave(object sender, EventArgs e)
        {
            panelCheckForm.BackColor = Color.FromArgb(22, 32, 40);
        }


        private Reparacion ObtenerReparacionDelForm()
        {
            #region VARIABLES
            Reparacion reparacion = null;
            Cliente cliente = null;
            //declaracion de variables
            float precio;
            float senia;
            float saldo;
            int garantia;
            long numeroDeBoleta;
            string nombre;
            string apellido;
            string dni;
            string telefono;
            ETipoDeBloqueo bloqueo;
            ETipoDeEquipo equipo;
            EServicio servicio;
            EObservaciones observacion;
            string strPassword;
            int[] patterLock = null;
            DateTime fecha;
            #endregion

            #region SELECCION EQUIPO Y SERVICIO
            if (checkedListBoxEquipo.SelectedItem is null)
            {
                throw new TipoDeEquipoException("Debe Seleccionar un tipo de equipo");
            }
            if (checkedListBoxServicios.SelectedItem is null)
            {
                throw new TipoDeServicioException("Debe Seleccionar un tipo de servicio");
            }
            #endregion

            #region DATOS DEL CLIENTE
            string[] nombreYApellido = textBoxNombreYApellido.Text.Split(' ');
            if (nombreYApellido.Length >= 2)
            {
                if (!(nombreYApellido[0] is null) && !(nombreYApellido[1] is null))
                {
                    nombre = nombreYApellido[1].ToLower();
                    apellido = nombreYApellido[0].ToLower();
                    Regex SoloNumeros = new Regex("^[0-9]+?$");//expresion regular solo numeros.
                    if (SoloNumeros.IsMatch(textBoxDni.Text))
                    {
                        dni = textBoxDni.Text;
                        if (SoloNumeros.IsMatch(textBoxTelefono.Text))
                        {
                            telefono = textBoxTelefono.Text;
                            cliente = new Cliente(nombre,apellido, textBoxDni.Text, "", "", textBoxTelefono.Text);
                        }
                        else
                        {
                            throw new NumberInvalidException("Error, ingrese solo numeros para TELEFONO");
                        }
                    }
                    else
                    {
                        throw new DniInvalidException("Error, ingrese solo numeros para el DNI");
                    }
                }
                else
                {
                    throw new NombreYApellidoException("Error, ingrese nombre y apellido");
                }
            }
            else
            {
                throw new NombreYApellidoException("Error, ingrese nombre y apellido");
            }
            #endregion


            string trabajoARealizar = textBoxTrabajoARealizar.Text + " " + textBoxTrabajoARealizar2.Text + " " + textBoxTrabajoARealizar3.Text;
            string marcaYModelo = textBoxMarcaYModelo.Text;
            string observacionesPropias = textBoxObservaciones.Text;

            equipo = (ETipoDeEquipo)Enum.Parse(typeof(ETipoDeEquipo), checkedListBoxEquipo.SelectedItem.ToString());
            servicio = (EServicio)Enum.Parse(typeof(EServicio), checkedListBoxServicios.SelectedItem.ToString());

            //verificamos que los datos se puedan parsiar al tipo correcto.
            bool validarNroDeBoleta = long.TryParse(textBoxNroDeBoleta.Text, out numeroDeBoleta);
            bool validarFecha = DateTime.TryParse(textBoxFecha.Text, out fecha);
            bool validarGarantia = Int32.TryParse(textBoxGarantia15Dias.Text, out garantia);
            bool validarPrecio = float.TryParse(textBoxPrecio.Text, out precio);
            bool validarSenia = float.TryParse(textBoxSenia.Text, out senia);
            bool validarSaldo = float.TryParse(textBoxSaldo.Text, out saldo);


            if (!(marcaYModelo is null) && marcaYModelo.Length > 4)
            {
                #region SELECCION OBSERVACIONES
                if (comboBoxObservaciones.SelectedItem is null)
                {
                    throw new TipoDeObservacionException("Debe Seleccionar un tipo de observacion");
                }
                observacion = (EObservaciones)Enum.Parse(typeof(EObservaciones), comboBoxObservaciones.SelectedItem.ToString());
                //verificamos si uso verificaciones predefinidas o alguna propia
                if (!(observacionesPropias is null) && observacionesPropias.Length > 1)
                {
                    //si entra aca quiere decir que ingreso una observacion propia
                }
                else
                {
                    observacionesPropias = observacion.ToString();// sino es una obsrvacion predefinida
                }
                #endregion
                if (!(trabajoARealizar is null) && trabajoARealizar.Length > 4)
                {
                    if (validarNroDeBoleta)
                    {
                        if (validarFecha)
                        {
                            if (validarPrecio)
                            {
                                if ((validarSenia) && (senia <= precio) && (senia >= 0))
                                {
                                    if ((validarSaldo) && ((precio - senia) >= 0) && (saldo == (precio - senia)))
                                    {
                                        //---verificamos la garantia
                                        if (validarGarantia)
                                        {
                                            if (garantia >= 0)
                                            {

                                            }
                                            else
                                            {
                                                garantia = 15;
                                            }
                                        }
                                        else
                                        {
                                            garantia = 15;
                                        }
                                        //---verificamos que tipo de bloqueo eligio 
                                        if (panelPatterLock.Visible)
                                        {
                                            bloqueo = ETipoDeBloqueo.patron;
                                            patterLock = PatterLock;
                                            if (patterLock.Length < 4)
                                            {
                                                MessageBox.Show("error en el patron seleccione 4 puntos minimo");
                                            }
                                        }
                                        else if (panelPassword.Visible)
                                        {
                                            bloqueo = ETipoDeBloqueo.password;
                                            strPassword = textBoxPassword.Text;
                                        }
                                        else
                                        {
                                            bloqueo = ETipoDeBloqueo.ninguno;
                                        }
                                        //---Creamos la reparacion si estan todos los datos correctos.
                                        reparacion = new Reparacion(equipo, servicio, bloqueo, observacion, cliente, marcaYModelo, trabajoARealizar, garantia, precio, senia, saldo, numeroDeBoleta, fecha);
                                    }
                                    else
                                    {
                                        throw new SaldoException("Error, no es un saldo valido");
                                    }
                                }
                                else
                                {
                                    throw new SeniaException("Error, no es una seña valida");
                                }
                            }
                            else
                            {
                                throw new PrecioException("Error, no es un precio valido");
                            }
                        }
                        else
                        {
                            throw new FechaException("Error, en la lectura de la Fecha.");
                        }
                    }
                    else
                    {
                        throw new NroDeBoletaException("Error, en la lectura del numero de Boleta.");
                    }
                }
                else
                {
                    throw new TrabajoARealizarException("Error en la descripcion del trabajo a realizar. minimo 4 caracteres.");
                }
            }
            else
            {
                throw new MarcaYModeloException("Error en la marca y modelo. minimo 4 caracteres.");
            }



            return reparacion;
        }
        private void OcultarLabelsDeErrorOcultarLabelsDeError()
        {
            labelErrorTrabajoARealizar.Visible = false;
            labelErrorMarcaYModelo.Visible = false;
            labelErrorTipoDeEquipo.Visible = false;
            labelErrorTipoDeObservacion.Visible = false;
            labelErrorPrecio.Visible = false;
            labelErrorSenia.Visible = false;
            labelErrorSaldo.Visible = false;
            labelErrorTipoDeServicio.Visible = false;
            labelErrorNombreYApellido.Visible = false;
            labelErrorDni.Visible = false;
            labelErrorTelefono.Visible = false;
        }
        private void pictureBoxCheckForm_Click(object sender, EventArgs e)
        {
            //Reparacion reparacion = new Reparacion();
            try
            {
                OcultarLabelsDeErrorOcultarLabelsDeError();
                ObtenerReparacionDelForm();
            }
            catch (TrabajoARealizarException exception)
            {
                textBoxTrabajoARealizar.Focus();
                labelErrorTrabajoARealizar.Visible = true;
            }
            catch (MarcaYModeloException exception)
            {
                textBoxMarcaYModelo.Focus();
                labelErrorMarcaYModelo.Visible = true;
            }
            catch (NroDeBoletaException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (FechaException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (PrecioException exception)
            {
                textBoxPrecio.Focus();
                labelErrorPrecio.Visible = true;
            }
            catch (SeniaException exception)
            {
                textBoxSenia.Focus();
                labelErrorSenia.Visible = true;
            }
            catch (SaldoException exception)
            {
                textBoxSaldo.Focus();
                labelErrorSaldo.Visible = true;
            }
            catch (TipoDeEquipoException exception)
            {
                checkedListBoxEquipo.Focus();
                labelErrorTipoDeEquipo.Visible = true;
            }
            catch (TipoDeServicioException exception)
            {
                checkedListBoxServicios.Focus();
                labelErrorTipoDeServicio.Visible = true;
            }
            catch (TipoDeObservacionException exception)
            {
                comboBoxObservaciones.Focus();
                labelErrorTipoDeObservacion.Visible = true;
            }
            catch (NombreYApellidoException exception)
            {
                textBoxNombreYApellido.Focus();
                labelErrorNombreYApellido.Visible = true;
            }
            catch (DniInvalidException exception)
            {
                textBoxDni.Focus();
                labelErrorDni.Visible = true;
            }
            catch (NumberInvalidException exception)
            {
                textBoxTelefono.Focus();
                labelErrorTelefono.Visible = true;
            }
        }

        private void buttonPatron_Click(object sender, EventArgs e)
        {
            panelPatterLock.Visible = true;
            panelPassword.Visible = false;
        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            panelPatterLock.Visible = false;
            panelPassword.Visible = true;
        }

        private void buttonNinguno_Click(object sender, EventArgs e)
        {
            panelPatterLock.Visible = false;
            panelPassword.Visible = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxObservaciones.SelectedItem.ToString() == "Otro")
            {
                textBoxObservaciones.Visible = true;
                panelObservacionUnderline.Visible = true;
            }
            else
            {
                textBoxObservaciones.Visible = false;
                panelObservacionUnderline.Visible = false;
            }
        }
    }
}
