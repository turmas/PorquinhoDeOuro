using PorquinhoDeOuro.Core.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Test.PorquinhoDeOuro.Core.Test.Mocks {

    public class ConfigurationUtilityMock : IConfigurationUtility {

        public string FileLogName {
            get { return "Test.log"; }
        }

        public string FullName {
            get { return Path.Combine(this.LogPath, this.FileLogName); }
        }

        public string LogPath {
            get { return @"C:\Logs\Test"; }
        }

        public string LogType { get; set; }
    }
}
