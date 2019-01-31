using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using CapaDeNegocios;

namespace PROYECTO
{
    static class Program
    {
        static Empleado empleadoProgram = new Empleado("Usuario", "Password", "Name", "LastName", "Dni", "Adress", "MailAdress", UserType.user);
        static List<Thread> mockThreads;
        #region CODIGO PARA MOVER VENTANAS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWmd, int wMsg, int wParam, int lParam);
        #endregion
        static Program()
        {
            MockThreads = new List<Thread>();
        }

        public static Empleado EmpleadoProgram
        {
            get
            {
                return empleadoProgram;
            }
            set
            {
                empleadoProgram = value;
            }
        }

        public static List<Thread> MockThreads { get => mockThreads; set => mockThreads = value; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new FormLogin());
            //  if (!(EmpleadoProgram.User is "Usuario"))
            Empleado empleadoHardcodeo = new Empleado("yonykikok", "40132526", "Name", "LastName", "Dni", "Adress", "MailAdress", UserType.admin);
                Application.Run(new FormPrincipal(empleadoHardcodeo));
        }
    }
}
