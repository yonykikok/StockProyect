using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CapaDeNegocios
{
    public enum UserType
    {
        user,
        admin
    }
    public class Empleado
    {
        private string user;
        private string password;
        private string name;
        private string lastName;
        private string dni;
        private string adress;
        private string mailAdress;
        private int id;
        private UserType type;
        #region CONSTRUCTORES
        public Empleado(string user, string password)
        {
            this.User = user;
            this.Password = password;
        }
        public Empleado(string user, string password, string name, string lastName, string dni, string adress, string mailAdress, UserType type) : this(user, password)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Dni = dni;
            this.Adress = adress;
            this.MailAdress = mailAdress;
            this.Type = type;
        }
        public Empleado(string user, string password, string name, string lastName, string dni, string adress, string mailAdress, UserType type, int id) : this(user, password, name, lastName, dni, adress, mailAdress, type)
        {
            this.id = id;
        }
        #endregion
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
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public UserType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                Regex SoloLetras = new Regex("^[a-z|A-Z]+?$");
                if (SoloLetras.IsMatch(value.ToString()))
                {
                    value.ToString().ToLower();
                    if (value == UserType.admin || value == UserType.user)
                    {
                        this.type = value;
                    }
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
                    Regex SoloLetras = new Regex("^[0-9]+?$");
                    if (SoloLetras.IsMatch(value))
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
        public string User
        {
            get { return this.user; }
            set
            {
                Regex SoloLetras = new Regex("^[-|a-z|A-Z|.|_|0-9|]+?$");
                if (SoloLetras.IsMatch(value))
                {
                    this.user = value;
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
                        if (value.Length > 8 && value.Length < 50)
                        {
                            this.adress = value;
                        }
                    }
                }
            }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
