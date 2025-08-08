using System;
using System.Collections.Generic;
using System.IO;


namespace CRUD_Cshart.Config
{
    public static class ConfigManager
    {
        private static readonly Dictionary<string, string> _settings = new();

        static ConfigManager()
        {
            LoadConfig("config.properties");
        }

        private static void LoadConfig(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Archivo de configuración no encontrado: {path}");
            }

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split('=', 2);
                if (parts.Length == 2)
                {
                    _settings[parts[0].Trim()] = parts[1].Trim();
                }
            }
        }

        public static string? Get(string key)
        {
            return _settings.TryGetValue(key, out string? value) ? value : null;
        }

    }
}
