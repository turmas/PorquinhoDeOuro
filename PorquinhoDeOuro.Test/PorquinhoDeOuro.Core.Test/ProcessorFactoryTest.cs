using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PorquinhoDeOuro.Core.Processor;

namespace PorquinhoDeOuro.Test.PorquinhoDeOuro.Core.Test {

    [TestClass]
    public class ProcessorFactoryTest {

        [TestMethod]
        public void Create_GetCandyProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(1);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CandyProcessor));
        }

        [TestMethod]
        public void Create_GetCoinProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(5);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CoinProcessor));
        }

        [TestMethod]
        public void Create_GetBillProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(200);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(BillProcessor));
        }

        [TestMethod]
        public void Create_GetSilverProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(50000);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(SilverProcessor));
        }

        [TestMethod]
        public void Create_GetNullProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(0);

            Assert.IsNull(processor);
        }
              
    }
}
