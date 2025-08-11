using System;
using System.Collections.Generic;
using System.IO;

namespace CRUD_Cshart.Config
{
    public static class ConfigManager
    {
        private static readonly Dictionary<string, string> _settings = new();

        public static void LoadConfig(string fileName)
        {
            // Busca el archivo en el mismo directorio donde está el ejecutable
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Archivo de configuración no encontrado: {path}");
            }

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
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
