using System;
using System.Collections.Generic;
using System.IO;

namespace SConfigurator
{
    public class ConfigurationFileLoader
    {
        private readonly List<string> loadedTextFiles = new List<string>();

        public ConfigurationFileLoader(params string[] paths)
        {
            this.ValidateAllFilePaths(paths);
            foreach (var path in paths)
            {
                loadedTextFiles.Add(this.LoadTextFromFile(path));
            }
        }

        private bool CheckIfFileExists(string path)
        {
            return File.Exists(path);
        }

        private void ValidateAllFilePaths(string[] paths)
        {
            foreach (var filePath in paths)
            {
                if (!CheckIfFileExists(filePath))
                    throw new ArgumentException($"File {filePath} has not been found.");
            }
        }

        private string LoadTextFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}