using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Log {

    public interface ILog {

        void Save(string methodName, string type, object logData);
    }
}
