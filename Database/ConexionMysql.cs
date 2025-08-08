using CRUD_Cshart.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Cshart.Database
{
    internal class ConexionMysql 
    {
        private MySqlConnection connection;
        protected string cadenaConexion;
        public ConexionMysql() 
        {
            string? database = ConfigManager.Get("db.name");
            string? server = ConfigManager.Get("db.host");
            string? user = ConfigManager.Get("db.user");
            string? password = ConfigManager.Get("db.password");

            if (database == null || server == null || user == null || password == null)
            {
                throw new Exception("Faltan claves en el archivo config.properties");
            }

            cadenaConexion = $"Database={database};Data Source={server};User Id={user};Password={password}";
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
