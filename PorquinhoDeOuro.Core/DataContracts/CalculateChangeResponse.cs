using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.DataContracts {

    public class CalculateChangeResponse {

        public CalculateChangeResponse() {
            this.OperationReportList = new List<OperationReport>();
            this.ChangeDictionary = new Dictionary<int, long>();
        }

        public Nullable<long> ChangeAmount { get; set; }

        public List<OperationReport> OperationReportList { get; set; }

        public Dictionary<int, long> ChangeDictionary { get; set; }

        public bool Success { get; set; }

    }
}
