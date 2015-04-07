using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorquinhoDeOuro.Core;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

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


    }
}
