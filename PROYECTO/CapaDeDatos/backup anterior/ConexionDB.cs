using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDeDatos
{
    public class ConexionDB
    {
        private SqlConnection sqlConexion = new SqlConnection("Server=DESKTOP-7ETOVJD;DataBase=Multitask;Integrated Security=true");

        public SqlConnection ConectarSql()
        {
            if (sqlConexion.State == ConnectionState.Closed)
            {
                sqlConexion.Open();
            }
            return sqlConexion;
        }
        public SqlConnection DesconectarSql()
        {
            if (sqlConexion.State == ConnectionState.Open)
            {
                sqlConexion.Close();
            }
            return sqlConexion;
        }
    }
}
