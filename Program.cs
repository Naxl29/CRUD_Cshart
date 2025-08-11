using System;
using System.IO;
using System.Windows.Forms;
using CRUD_Cshart.Config;

namespace CRUD_Cshart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.properties");
                ConfigManager.LoadConfig("config.properties");

                ApplicationConfiguration.Initialize();
                Application.Run(new Formulario());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando configuración: {ex.Message}");
            }
        }
    }
}
