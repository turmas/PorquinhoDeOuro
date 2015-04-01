using PorquinhoDeOuro.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Processor {
    public class CoinProcessor : AbstractProcessor {

        public CoinProcessor() { }

        public override string GetName() {
            return this.GetType().Name;
        }

        public override IEnumerable<int> GetAvailableValues() {
            return new int[] { 100, 50, 25, 10, 5};
        }
    }
}
