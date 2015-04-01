using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Processor {

    public abstract class AbstractProcessor {

        public abstract string GetName();

        public abstract IEnumerable<int> GetAvailableValues();

        public virtual Dictionary<int, long> Calculate(long changeAmount) {

            long actualChangeAmount = changeAmount;

            Dictionary<int, long> changeResultDictionary = new Dictionary<int, long>();

            foreach (int amount in this.GetAvailableValues().OrderByDescending(p => p)) {

                if (actualChangeAmount < amount) { continue; }

                long amountCount = actualChangeAmount / amount;
                actualChangeAmount = actualChangeAmount - (amountCount * amount);

                changeResultDictionary.Add(amount, amountCount);
            }

            return changeResultDictionary;
        }
    }
}
