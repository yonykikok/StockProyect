using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class EmpleadoDAO
    {
        private ConexionDB conexion = new ConexionDB();
        private SqlDataReader leer;

        public SqlDataReader iniciarSesion(string user, string pass)
        {
            string sql = "select *from Usuarios where Dni=" + user+ " and Contraseña=" + pass;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.ConectarSql();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }

    }
}
