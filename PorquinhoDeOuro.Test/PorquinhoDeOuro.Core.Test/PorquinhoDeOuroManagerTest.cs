using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorquinhoDeOuro.Core;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using PorquinhoDeOuro.Core.DataContracts;
using PorquinhoDeOuro.Test.PorquinhoDeOuro.Core.Test.Mocks;
using Dlp.Framework.Container;
using PorquinhoDeOuro.Core.Utility;

namespace PorquinhoDeOuro.Test.PorquinhoDeOuro.Core.Test {

    [TestClass]
    [ExcludeFromCodeCoverage]
    public class PorquinhoDeOuroManagerTest {

        [TestMethod]
        public void CalculateChange_ChangeFor20_Test() {

            PorquinhoDeOuroManager manager = new PorquinhoDeOuroManager();

            PrivateObject privateObject = new PrivateObject(manager);

            Dictionary<int, long> changeDictionary = privateObject.Invoke("CalculateChange", Convert.ToInt64(20)) as Dictionary<int, long>;

            Assert.IsNotNull(changeDictionary);
            Assert.AreEqual(1, changeDictionary.Count);
            Assert.IsTrue(changeDictionary.Any(p => p.Key == 10 & p.Value == 2) == true);
        }

        [TestMethod]
        public void CalculateChange_ChangeFor0_Test() {

            PorquinhoDeOuroManager manager = new PorquinhoDeOuroManager();

            PrivateObject privateObject = new PrivateObject(manager);

            Dictionary<int, long> changeDictionary = privateObject.Invoke("CalculateChange", Convert.ToInt64(0)) as Dictionary<int, long>;

            Assert.IsNotNull(changeDictionary);
            Assert.AreEqual(0, changeDictionary.Count);
        }

        [TestMethod]
        public void CalculateChange_LogToFile_Test() {

            ConfigurationUtilityMock mock = new ConfigurationUtilityMock();

            mock.LogType = "filelog";

            IocFactory.Register(
                    Component.For<IConfigurationUtility>()
                    .Instance(mock)
                );

            PorquinhoDeOuroManager manager = new PorquinhoDeOuroManager();

            CalculateChangeRequest request = new CalculateChangeRequest();

            request.ProductAmount = 123;
            request.ReceivedAmount = 321;

            CalculateChangeResponse response = manager.CalculateChange(request);

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void CalculateChange_LogToEventViewer_Test() {

            ConfigurationUtilityMock mock = new ConfigurationUtilityMock();

            mock.LogType = "EventLog";

            IocFactory.Register(
                    Component.For<IConfigurationUtility>()
                    .Instance(mock)
                );

            PorquinhoDeOuroManager manager = new PorquinhoDeOuroManager();

            CalculateChangeRequest request = new CalculateChangeRequest();

            request.ProductAmount = 123;
            request.ReceivedAmount = 321;

            CalculateChangeResponse response = manager.CalculateChange(request);

            Assert.IsNotNull(response);
        }
    }
}
