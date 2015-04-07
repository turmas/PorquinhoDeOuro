using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorquinhoDeOuro.Core.DataContracts;
using PorquinhoDeOuro.Core.Log;

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

            // logar
            LogManager logManager = new LogManager();

            logManager.Save("Save_LogCalculateChangeRequest_Test", "Request", calculateChangeRequest);
        }

        [TestMethod]
        public void Save_LogCalculateChangeResponse_Test() {

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();
            calculateChangeResponse.ChangeAmount = 150;
            calculateChangeResponse.ChangeDictionary.Add(100, 1);
            calculateChangeResponse.ChangeDictionary.Add(50, 1);
            calculateChangeResponse.Success = true;

            LogManager logManager = new LogManager();

            logManager.Save("Save_LogCalculateChangeResponse_Test", "Response", calculateChangeResponse);
        }
    }
}
