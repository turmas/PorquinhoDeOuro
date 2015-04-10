using Dlp.Framework.Container;
using PorquinhoDeOuro.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Log {

    public static class LogFactory {

        public static ILog Create() {

            // Obtém uma instancia do utilitário de acesso ao arquivo de configuração.
            IConfigurationUtility configurationUtility = IocFactory.Resolve<IConfigurationUtility>();

            //string logType = configurationUtility.LogType.ToUpper();

            return IocFactory.ResolveByName<ILog>(configurationUtility.LogType);

            //switch (logType) {
            //    case "FILELOG" :
            //        return IocFactory.ResolveByName<ILog>();

            //    case "EVENTLOG" :
            //        return new EventViewerLog();

            //    default:
            //        throw new NotSupportedException("Tipo de log não encontrado");
            //}
        }
    }
}
