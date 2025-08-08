using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Cshart.Database
{
    internal class ConexionMysql : Conexion
    {
        private MySqlConnection connection;
        protected string cadenaConexion;
        public ConexionMysql() 
        {
            cadenaConexion = "Database=" +database +
                             ";Data Source=" + server +
                             ";User Id=" + user +
                             ";Password=" + password;
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return connection;
        }
    }
}
