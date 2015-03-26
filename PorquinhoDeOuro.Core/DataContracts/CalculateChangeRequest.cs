using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.DataContracts {

    public class CalculateChangeRequest : AbstractRequest {

        public CalculateChangeRequest() : base() { }

        public long ProductAmount { get; set; }

        public long ReceivedAmount { get; set; }

        protected override void Validate() {

            // Valida o valor do produto.
            if (ProductAmount <= 0) {
                this.AddErrorMessage("ProductAmount", "Valor do produto deve ser maior que zero.");
            }

            if (ReceivedAmount <= 0) {
                this.AddErrorMessage("ReceivedAmount", "Valor inserido deve ser maior que zero.");
            }

            if (ReceivedAmount < ProductAmount) {
                this.AddErrorMessage("ReceivedAmount", "Valor inserido deve ser maior ou igual ao valor do produto.");
            }
        }
    }
}
