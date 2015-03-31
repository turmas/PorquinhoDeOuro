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
            return new int[] { 100, 50, 25, 10, 5, 1 };
        }

        public override Dictionary<int, long> Calculate(long changeAmount) {

            long actualChangeAmount = changeAmount;

            Dictionary<int, long> changeResultDictionary = new Dictionary<int, long>();

            foreach (int amount in this.GetAvailableValues().OrderByDescending(p => p)) {

                if (actualChangeAmount <= amount) { continue; }

                long amountCount = actualChangeAmount / amount;
                actualChangeAmount = actualChangeAmount - (amountCount * amount);

                changeResultDictionary.Add(amount, amountCount);
            }

            return changeResultDictionary;
        }
    }
}
