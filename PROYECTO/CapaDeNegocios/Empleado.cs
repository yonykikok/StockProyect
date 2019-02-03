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
    public class Empleado : Persona
    {
        private string user;
        private string password;
        private int id;
        private UserType type;
        #region CONSTRUCTORES        
        public Empleado(string user, string password, string name, string lastName, string dni, string adress, string mailAdress, UserType type) : base(name,lastName,dni,adress,mailAdress)
        {           
            this.Type = type;
            this.User = user;
            this.Password = password;
        }
        public Empleado(string user, string password, string name, string lastName, string dni, string adress, string mailAdress, UserType type, int id) : this(user, password, name, lastName, dni, adress, mailAdress, type)
        {
            this.id = id;
        }
        #endregion
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
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
