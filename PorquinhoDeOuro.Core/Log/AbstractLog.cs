using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PorquinhoDeOuro.Core.Utility;

namespace PorquinhoDeOuro.Core.Log {

    public abstract class AbstractLog : ILog {

        public IConfigurationUtility ConfigurationUtility { get; set; }

        public abstract void Save(string methodName, string type, object logData);
    }
}
