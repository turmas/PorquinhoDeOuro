using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorquinhoDeOuro.Core.DataContracts {

    public abstract class AbstractRequest {

        public AbstractRequest() {
            this.ActualOperationReportList = new List<OperationReport>();
        }

        public bool IsValid {
            get {
                this.ActualOperationReportList.Clear();
                this.Validate();
                return (this.ActualOperationReportList.Any() == false);
            }
        }

        public List<OperationReport> ValidationOperationReportList {
            get { return this.ActualOperationReportList.ToList(); }
        }

        private List<OperationReport> ActualOperationReportList { get; set; }

        protected void AddErrorMessage(string fieldName, string message) {

            OperationReport operationReport = new OperationReport();

            operationReport.FieldName = string.Format("{0}.{1}", this.GetType().Name, fieldName);
            operationReport.Message = message;

            this.ActualOperationReportList.Add(operationReport);
        }

        protected abstract void Validate();
    }
}
