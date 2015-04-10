using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Interceptors {
    
    public class LogInterceptor : IInterceptor {

        public void Intercept(IInvocation invocation) {

            if (invocation.MethodInvocationTarget.Name == "Save") {

                invocation.Arguments[0] = "Intercepted: " + invocation.Arguments[0];
            }

            invocation.Proceed();
        }
    }
}
