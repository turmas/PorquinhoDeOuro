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

            if (calculateChangeResponse.ChangeAmount != null) {
                StringBuilder builder = new StringBuilder();

                builder.Append("Total do troco: " + calculateChangeResponse.ChangeAmount + Environment.NewLine);

                foreach (KeyValuePair<int, long> item in calculateChangeResponse.ChangeDictionary) {
                    builder.AppendFormat("{0}: {1}{2}", item.Key, item.Value, Environment.NewLine);
                }

                this.UxTxtChange.Text = builder.ToString();
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
