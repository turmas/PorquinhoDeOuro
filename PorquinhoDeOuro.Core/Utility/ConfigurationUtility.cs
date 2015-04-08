using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Utility {

    public class ConfigurationUtility : IConfigurationUtility {

        public ConfigurationUtility() { }

        public string LogPath {
            get { return ConfigurationManager.AppSettings["LogPath"]; }
        }

        public string FileLogName {
            get { return ConfigurationManager.AppSettings["FileLogName"]; }
        }

        public string FullName {
            get { return Path.Combine(this.LogPath, this.FileLogName); }
        }
    }
}
