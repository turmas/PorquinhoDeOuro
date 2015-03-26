using PorquinhoDeOuro.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core {

    public class PorquinhoDeOuroManager {

        private bool ValidateAmount(long productAmount, long receivedAmount) {

            // TODO: Adicionar demais validações.

            return (receivedAmount >= productAmount);
        }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest calculateChangeRequest) {

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();

            if (calculateChangeRequest.IsValid == false) {

                calculateChangeResponse.OperationReportList = calculateChangeRequest.ValidationOperationReportList;
                return calculateChangeResponse;
            }

            Nullable<long> result = null;

            int[] availableCoins = new int[] { 100, 50, 25, 10, 5, 1 };

            result = calculateChangeRequest.ReceivedAmount - calculateChangeRequest.ProductAmount;

            calculateChangeResponse.Coin100 = result.Value / availableCoins[0];
            calculateChangeResponse.Coin50 = (result.Value % availableCoins[0]) / availableCoins[1];
            calculateChangeResponse.Coin25 = ((result.Value % availableCoins[0]) % availableCoins[1]) / availableCoins[2];
            calculateChangeResponse.Coin10 = (((result.Value % availableCoins[0]) % availableCoins[1]) % availableCoins[2]) / availableCoins[3];
            calculateChangeResponse.Coin5 = ((((result.Value % availableCoins[0]) % availableCoins[1]) % availableCoins[2]) % availableCoins[3]) / availableCoins[4];
            calculateChangeResponse.Coin1 = (((((result.Value % availableCoins[0]) % availableCoins[1]) % availableCoins[2]) % availableCoins[3]) % availableCoins[4]) / availableCoins[5];

            calculateChangeResponse.Result = result;

            return calculateChangeResponse;

        }

        private bool ValidateResult(long value) {
            if (value > 0) {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
