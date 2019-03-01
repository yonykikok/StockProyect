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
    public partial class FormReparacion : Form
    {
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
        }
        private void PatterLockControl_PassCodeSubmitted(object sender, GestureLockApp.GestureLockControl.PassCodeSubmittedEventArgs e)
        {
            string passCode = e.ToString();
            //PatterLockControl.SetPassCode(passCode);
        }
    }
}
