using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.DataContracts {

    public class CalculateChangeResponse {

        public CalculateChangeResponse() {
            this.OperationReportList = new List<OperationReport>();
        }

        public long Coin100 { get; set; }
        public long Coin50 { get; set; }
        public long Coin25 { get; set; }
        public long Coin10 { get; set; }
        public long Coin5 { get; set; }
        public long Coin1 { get; set; }
        public Nullable<long> Result { get; set; }

        public List<OperationReport> OperationReportList { get; set; }

    }
}
