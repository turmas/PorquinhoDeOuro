using PorquinhoDeOuro.Core.DataContracts;
using PorquinhoDeOuro.Core.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core {

    public class PorquinhoDeOuroManager {

        /// <summary>
        /// evento chamado quando o usuario clica em "Calcular"
        /// </summary>
        /// <param name="calculateChangeRequest"></param>
        /// <returns></returns>
        public CalculateChangeResponse CalculateChange(CalculateChangeRequest calculateChangeRequest) {

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();

            try {

                if (calculateChangeRequest.IsValid == false) {
                    calculateChangeResponse.OperationReportList = calculateChangeRequest.ValidationOperationReportList;
                    return calculateChangeResponse;
                }

                // result é o valor do troco.
                // Resultado para calcular o troco.
                long result = calculateChangeRequest.ReceivedAmount - calculateChangeRequest.ProductAmount;

                // TODO: Calcular moedas.

                Dictionary<int, long> showResult = new Dictionary<int, long>();
                long remainingChangeAmount = result;
                while (remainingChangeAmount > 0) {
                    AbstractProcessor processor = ProcessorFactory.Create(remainingChangeAmount);

                    if (processor == null) { 
                        OperationReport operationReport = new OperationReport();

                        operationReport.Message = "Desculpe, não foi possível processar o troco.";
                        calculateChangeResponse.OperationReportList.Add(operationReport);
                        return calculateChangeResponse;
                    }

                    Dictionary<int, long> resultDictionary = processor.Calculate(remainingChangeAmount);                   

                    foreach (KeyValuePair<int, long> item in resultDictionary) {
                        showResult.Add(item.Key, item.Value);
                        remainingChangeAmount = remainingChangeAmount - (item.Key * item.Value);
                    }

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

                calculateChangeResponse.OperationReportList.Add(operationReport);
            }

            return calculateChangeResponse;

        }

    }
}
