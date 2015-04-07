using PorquinhoDeOuro.Core.DataContracts;
using PorquinhoDeOuro.Core.Log;
using PorquinhoDeOuro.Core.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core {

    public class PorquinhoDeOuroManager {

        public PorquinhoDeOuroManager() {

            LogManager = new LogManager();
        }

        public LogManager LogManager { get; set; }

        /// <summary>
        /// evento chamado quando o usuario clica em "Calcular"
        /// </summary>
        /// <param name="calculateChangeRequest"></param>
        /// <returns></returns>
        public CalculateChangeResponse CalculateChange(CalculateChangeRequest calculateChangeRequest) {

            // salva a requisição do cliente
            this.LogManager.Save("CalculateChange", "Request", calculateChangeRequest);

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();

            try {

                if (calculateChangeRequest.IsValid == false) {
                    calculateChangeResponse.OperationReportList = calculateChangeRequest.ValidationOperationReportList;

                    // Log de erro na regra de negócio
                    this.LogManager.Save("CalculateChange", "Response", calculateChangeResponse);
                    return calculateChangeResponse;
                }

                // result é o valor do troco.
                // Resultado para calcular o troco.
                long result = calculateChangeRequest.ReceivedAmount - calculateChangeRequest.ProductAmount;

                Dictionary<int, long> showResult = this.CalculateChange(result);

                if (showResult == null) {
                    OperationReport operationReport = new OperationReport();

                    operationReport.Message = "Desculpe, não foi possível processar o troco.";
                    calculateChangeResponse.OperationReportList.Add(operationReport);
                    this.LogManager.Save("CalculateChange", "Response", calculateChangeResponse);
                    return calculateChangeResponse;
                }

                calculateChangeResponse.ChangeAmount = result;
                calculateChangeResponse.ChangeDictionary = showResult;
                // ----------------------

                calculateChangeResponse.Success = true;
            }
            catch (Exception ex) {

                OperationReport operationReport = new OperationReport();

                operationReport.FieldName = string.Empty;
                operationReport.Message = "Ocorreu um erro ao processar a sua requisição. Por favor, tente novamente mais tarde.";

                // TODO: Salvar a informação da exceção em log.
                this.LogManager.Save("CalculateChange", "Exception", ex.ToString());

                calculateChangeResponse.OperationReportList.Add(operationReport);
            }

            this.LogManager.Save("CalculateChange", "Response", calculateChangeResponse);
            return calculateChangeResponse;

        }

        private Dictionary<int, long> CalculateChange(long changeAmount) {

            Dictionary<int, long> changeDictionary = new Dictionary<int, long>();
            long remainingChangeAmount = changeAmount;

            while (remainingChangeAmount > 0) {

                AbstractProcessor processor = ProcessorFactory.Create(remainingChangeAmount);

                if (processor == null) { return null; }

                Dictionary<int, long> resultDictionary = processor.Calculate(remainingChangeAmount);

                foreach (KeyValuePair<int, long> item in resultDictionary) {
                    changeDictionary.Add(item.Key, item.Value);
                    remainingChangeAmount = remainingChangeAmount - (item.Key * item.Value);
                }
            }

            return changeDictionary;
        }
    }
}
