using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.Processor {
   public class CandyProcessor : AbstractProcessor {

       public CandyProcessor() {

       }
       public override string GetName() {
           return this.GetType().Name;
       }

       public override IEnumerable<int> GetAvailableValues() {
           return new int[] { 3, 1 };
       }
    }
}
