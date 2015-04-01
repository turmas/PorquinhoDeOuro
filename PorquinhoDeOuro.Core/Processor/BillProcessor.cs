using PorquinhoDeOuro.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Processor {

    public class BillProcessor : AbstractProcessor {

        public BillProcessor() { }

        public override string GetName() {
            return this.GetType().Name;
        }

        public override IEnumerable<int> GetAvailableValues() {
            return new int[] { 10000, 5000, 2000, 1000, 500, 200 };
        }
    }
}
