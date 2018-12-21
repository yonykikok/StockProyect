using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using CapaDeNegocios;

namespace PROYECTO
{
    static class Program
    {
        static Empleado empleadoProgram = new Empleado("Usuario", "Password","Name","LastName","Dni","Adress","MailAdress",UserType.employee);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hWmd, int wMsg, int wParam, int lParam);
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
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {        
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new FormLogin());
            // if(!(EmpleadoProgram.User is "Usuario"))
          //  Application.Run(new FormPrincipal(EmpleadoProgram));
             Application.Run(new FormProductos());

        }
    }
}
