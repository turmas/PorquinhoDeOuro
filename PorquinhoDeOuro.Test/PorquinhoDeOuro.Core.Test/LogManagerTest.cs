using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorquinhoDeOuro.Core.DataContracts;
using PorquinhoDeOuro.Core.Log;
using PorquinhoDeOuro.Core.Utility;
using PorquinhoDeOuro.Test.PorquinhoDeOuro.Core.Test.Mocks;

namespace PorquinhoDeOuro.Test.PorquinhoDeOuro.Core.Test {
    /// <summary>
    /// Summary description for LogManageTest
    /// </summary>
    [TestClass]
    public class LogManagerTest {
        public LogManagerTest() {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void Save_LogCalculateChangeRequest_Test() {

            // Criar objeto de quesição 
            CalculateChangeRequest calculateChangeRequest = new CalculateChangeRequest();
            calculateChangeRequest.ProductAmount = 300;
            calculateChangeRequest.ReceivedAmount = 500;

            IConfigurationUtility configurationUtility = new ConfigurationUtilityMock();

            // logar
            LogManager logManager = new LogManager(configurationUtility);

            logManager.Save("Save_LogCalculateChangeRequest_Test", "Request", calculateChangeRequest);
        }

        [TestMethod]
        public void Save_LogCalculateChangeResponse_Test() {

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();
            calculateChangeResponse.ChangeAmount = 150;
            calculateChangeResponse.ChangeDictionary.Add(100, 1);
            calculateChangeResponse.ChangeDictionary.Add(50, 1);
            calculateChangeResponse.Success = true;

            IConfigurationUtility configurationUtility = new ConfigurationUtilityMock();

            LogManager logManager = new LogManager(configurationUtility);

            logManager.Save("Save_LogCalculateChangeResponse_Test", "Response", calculateChangeResponse);
        }
    }
}
