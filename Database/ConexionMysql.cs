using CRUD_Cshart.Config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Cshart.Database
{
    internal class ConexionMysql
    {
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
        }

        public MySqlConnection getConnection()
        {
            try
            {
                var connection = new MySqlConnection(cadenaConexion);
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {e.Message}");
                throw;
            }
        }
    }
}