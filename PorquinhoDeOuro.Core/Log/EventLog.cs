using Dlp.Framework;
using PorquinhoDeOuro.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PorquinhoDeOuro.Core.Log {
    public class EventViewerLog : AbstractLog {

        public override void Save(string methodName, string type, object logData) {

            string source = "PorquinhoDeOuro";
            string log = "Application";
            string serializedData = Serializer.JsonSerialize(logData);

            if (EventLog.SourceExists(source) == false) {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, serializedData);
        }
    }
}
