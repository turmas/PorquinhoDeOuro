using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PorquinhoDeOuro.Core;
using PorquinhoDeOuro.Core.DataContracts;

namespace PorquinhoDeOuro {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void UxBtnCalculate_Click(object sender, EventArgs e) {

            this.Calculate();
        }

        private void Calculate() {

            PorquinhoDeOuroManager porquinhoDeOuroManager = new PorquinhoDeOuroManager();
            long productAmount = Convert.ToInt64(this.UxTxtProductAmount.Text);
            long receivedAmount = Convert.ToInt64(this.UxTxtReceivedAmount.Text);

            CalculateChangeRequest request = new CalculateChangeRequest();
            request.ProductAmount = productAmount;
            request.ReceivedAmount = receivedAmount;

            CalculateChangeResponse calculateChangeResponse = porquinhoDeOuroManager.CalculateChange(request);

            if (calculateChangeResponse.Result != null) {
                string message = string.Concat("Total do troco: ", calculateChangeResponse.Result, Environment.NewLine,
                                                "Moedas R$ 1,00: ", calculateChangeResponse.Coin100, Environment.NewLine,
                                                "Moedas R$ 0,50: ", calculateChangeResponse.Coin50, Environment.NewLine,
                                                "Moedas R$ 0,25: ", calculateChangeResponse.Coin25, Environment.NewLine,
                                                "Moedas R$ 0,10: ", calculateChangeResponse.Coin10, Environment.NewLine,
                                                "Moedas R$ 0,05: ", calculateChangeResponse.Coin5, Environment.NewLine,
                                                "Moedas R$ 0,01: ", calculateChangeResponse.Coin1, Environment.NewLine);

                this.UxTxtChange.Text = message;
            }
            else {

                StringBuilder stringBuilder = new StringBuilder();

                foreach(OperationReport operationReport in calculateChangeResponse.OperationReportList){

                    stringBuilder.AppendFormat("{0}: {1}{2}", operationReport.FieldName, operationReport.Message, Environment.NewLine);
                }

                this.UxTxtChange.Text = stringBuilder.ToString();
            }
        }
    }
}
