using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SConfigurator
{
    public class ConfigurationAggregator
    {
        private ConfigurationFileLoader fileLoader;

        public ConfigurationAggregator(params string[] paths)
        {
            fileLoader = new ConfigurationFileLoader(paths);
        }


    }
}