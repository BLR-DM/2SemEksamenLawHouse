namespace UI.Forms.Self_Service
{
    partial class CalculationsView
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
            lblCalcLoanPayment = new Label();
            pnlCalc = new Panel();
            panel1 = new Panel();
            lblCalcROI = new Label();
            lblCalcRemainingBalanceOnLoan = new Label();
            SuspendLayout();
            // 
            // lblCalcLoanPayment
            // 
            lblCalcLoanPayment.AutoSize = true;
            lblCalcLoanPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcLoanPayment.ForeColor = Color.FromArgb(45, 93, 134);
            lblCalcLoanPayment.Location = new Point(40, 87);
            lblCalcLoanPayment.Name = "lblCalcLoanPayment";
            lblCalcLoanPayment.Size = new Size(212, 21);
            lblCalcLoanPayment.TabIndex = 6;
            lblCalcLoanPayment.Text = "- Calculate payment on loan";
            // 
            // pnlCalc
            // 
            pnlCalc.Location = new Point(450, 41);
            pnlCalc.Name = "pnlCalc";
            pnlCalc.Size = new Size(508, 530);
            pnlCalc.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(384, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 493);
            panel1.TabIndex = 4;
            // 
            // lblCalcROI
            // 
            lblCalcROI.AutoSize = true;
            lblCalcROI.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcROI.ForeColor = Color.FromArgb(45, 93, 134);
            lblCalcROI.Location = new Point(40, 147);
            lblCalcROI.Name = "lblCalcROI";
            lblCalcROI.Size = new Size(243, 21);
            lblCalcROI.TabIndex = 7;
            lblCalcROI.Text = "- Calculate return on investment";
            // 
            // lblCalcRemainingBalanceOnLoan
            // 
            lblCalcRemainingBalanceOnLoan.AutoSize = true;
            lblCalcRemainingBalanceOnLoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcRemainingBalanceOnLoan.ForeColor = Color.FromArgb(45, 93, 134);
            lblCalcRemainingBalanceOnLoan.Location = new Point(40, 208);
            lblCalcRemainingBalanceOnLoan.Name = "lblCalcRemainingBalanceOnLoan";
            lblCalcRemainingBalanceOnLoan.Size = new Size(281, 21);
            lblCalcRemainingBalanceOnLoan.TabIndex = 8;
            lblCalcRemainingBalanceOnLoan.Text = "- Calculate remaining balance on loan";
            // 
            // CalculationsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblCalcRemainingBalanceOnLoan);
            Controls.Add(lblCalcROI);
            Controls.Add(lblCalcLoanPayment);
            Controls.Add(pnlCalc);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculationsView";
            Text = "CalculationsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalcLoanPayment;
        private Panel pnlCalc;
        private Panel panel1;
        private Label lblCalcROI;
        private Label lblCalcRemainingBalanceOnLoan;
    }
}