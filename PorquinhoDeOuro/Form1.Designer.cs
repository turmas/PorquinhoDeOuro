namespace PorquinhoDeOuro {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UxBtnCalculate = new System.Windows.Forms.Button();
            this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
            this.UxTxtReceivedAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UxTxtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UxBtnCalculate
            // 
            this.UxBtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxBtnCalculate.Location = new System.Drawing.Point(52, 425);
            this.UxBtnCalculate.Name = "UxBtnCalculate";
            this.UxBtnCalculate.Size = new System.Drawing.Size(307, 35);
            this.UxBtnCalculate.TabIndex = 0;
            this.UxBtnCalculate.Text = "Calcular";
            this.UxBtnCalculate.UseVisualStyleBackColor = true;
            this.UxBtnCalculate.Click += new System.EventHandler(this.UxBtnCalculate_Click);
            // 
            // UxTxtProductAmount
            // 
            this.UxTxtProductAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtProductAmount.Location = new System.Drawing.Point(52, 57);
            this.UxTxtProductAmount.Name = "UxTxtProductAmount";
            this.UxTxtProductAmount.Size = new System.Drawing.Size(307, 26);
            this.UxTxtProductAmount.TabIndex = 1;
            // 
            // UxTxtReceivedAmount
            // 
            this.UxTxtReceivedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtReceivedAmount.Location = new System.Drawing.Point(52, 130);
            this.UxTxtReceivedAmount.Name = "UxTxtReceivedAmount";
            this.UxTxtReceivedAmount.Size = new System.Drawing.Size(307, 26);
            this.UxTxtReceivedAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor recebido";
            // 
            // UxTxtChange
            // 
            this.UxTxtChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxtChange.Location = new System.Drawing.Point(52, 191);
            this.UxTxtChange.Multiline = true;
            this.UxTxtChange.Name = "UxTxtChange";
            this.UxTxtChange.Size = new System.Drawing.Size(307, 199);
            this.UxTxtChange.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.UxBtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Controls.Add(this.UxTxtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UxTxtReceivedAmount);
            this.Controls.Add(this.UxTxtProductAmount);
            this.Controls.Add(this.UxBtnCalculate);
            this.Name = "Form1";
            this.Text = "Porquinho de Ouro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxBtnCalculate;
        private System.Windows.Forms.TextBox UxTxtProductAmount;
        private System.Windows.Forms.TextBox UxTxtReceivedAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UxTxtChange;
    }
}

