namespace FutureValue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(176, 114);
            this.txtFutureValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(111, 22);
            this.txtFutureValue.TabIndex = 30;
            this.txtFutureValue.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(188, 155);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(72, 155);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(176, 79);
            this.txtYears.Margin = new System.Windows.Forms.Padding(4);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(111, 22);
            this.txtYears.TabIndex = 27;
            this.txtYears.TextChanged += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(176, 46);
            this.txtInterestRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(111, 22);
            this.txtInterestRate.TabIndex = 26;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtInterestRate.DoubleClick += new System.EventHandler(this.txtInterestRate_DoubleClick);
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(176, 11);
            this.txtMonthlyInvestment.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(111, 22);
            this.txtMonthlyInvestment.TabIndex = 25;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtMonthlyInvestment.MouseHover += new System.EventHandler(this.ClearFutureValue);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Future Value:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Number of Years:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yearly Interest Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Monthly Investment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(308, 194);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}