using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
<<<<<<< HEAD
using System.Threading;
=======
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using CapaDeNegocios;

namespace PROYECTO
{
    static class Program
    {
<<<<<<< HEAD
        static Empleado empleadoProgram = new Empleado("Usuario", "Password", "Name", "LastName", "Dni", "Adress", "MailAdress", UserType.employee);
        static List<Thread> mockThreads;
        #region CODIGO PARA MOVER VENTANAS
=======
        static Empleado empleadoProgram = new Empleado("Usuario", "Password","Name","LastName","Dni","Adress","MailAdress",UserType.employee);
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWmd, int wMsg, int wParam, int lParam);
<<<<<<< HEAD
        #endregion
        static Program()
        {
            MockThreads = new List<Thread>();
        }

=======
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12
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
<<<<<<< HEAD
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new FormLogin());
            //if (!(EmpleadoProgram.User is "Usuario"))
                Application.Run(new FormPrincipal(EmpleadoProgram));
=======
        {        
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new FormLogin());
            // if(!(EmpleadoProgram.User is "Usuario"))
          //  Application.Run(new FormPrincipal(EmpleadoProgram));
             Application.Run(new FormProductos());
>>>>>>> 7e3db99809bed467e7213c9e8eba93b6df21cc12

        }
    }
}
