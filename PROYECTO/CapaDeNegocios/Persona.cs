using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Persona
    {
        private string name;
        private string lastName;
        private string dni;
        private string adress;
        private string mailAdress;
        public Persona(string name, string lastName, string dni, string adress, string mailAdress)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Dni = dni;
            this.Adress = adress;
            this.MailAdress = mailAdress;
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                Regex SoloLetras = new Regex("^[a-z|A-Z]+?$");
                if (SoloLetras.IsMatch(value))
                {
                    this.name = value;
                }
            }
        }
        public string Dni
        {
            get { return this.dni; }
            set
            {
                if (!(value is null))
                {
                    Regex SoloNumeros = new Regex("^[0-9]+?$");
                    if (SoloNumeros.IsMatch(value))
                    {
                        if (value.Length > 5 && value.Length < 10)
                        {
                            this.dni = value;
                        }
                    }
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                Regex SoloLetras = new Regex("^[a-z|A-Z]+?$");
                if (SoloLetras.IsMatch(value))
                {
                    this.lastName = value;
                }
            }
        }
        public string MailAdress
        {
            get { return this.mailAdress; }
            set
            {
                if (!(value is null))
                {
                    if (value.Length > 10 && value.Length < 100)
                    {
                        this.mailAdress = value;
                    }
                }
            }
        }
        public string Adress
        {
            get { return this.adress; }
            set
            {
                if (!(value is null))
                {
                    Regex SoloLetras = new Regex("^[a-z|A-Z|0-9| ]+?$");
                    if (SoloLetras.IsMatch(value))
                    {
                        if (value.Length > 6 && value.Length < 50)
                        {
                            this.adress = value;
                        }
                    }
                }
            }
        }
    }
}
