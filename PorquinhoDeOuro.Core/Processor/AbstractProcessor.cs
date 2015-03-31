using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Processor {

    public abstract class AbstractProcessor {

        public abstract string GetName();

        public abstract IEnumerable<int> GetAvailableValues();

        public abstract Dictionary<int, long> Calculate(long changeAmount);
    }
}
