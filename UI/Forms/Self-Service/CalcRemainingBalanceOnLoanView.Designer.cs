namespace UI.Forms.Self_Service
{
    partial class CalcRemainingBalanceOnLoanView
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
            panel2 = new Panel();
            pnlTop = new Panel();
            lblCreate = new Label();
            txtPaymentsPrYear = new TextBox();
            label3 = new Label();
            txtAnnualInterestRate = new TextBox();
            label2 = new Label();
            txtTotalLoanAmount = new TextBox();
            label1 = new Label();
            btnCalculate = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            lblRemainingBalance = new Label();
            label4 = new Label();
            txtTotalYears = new TextBox();
            label5 = new Label();
            txtPaymentsMade = new TextBox();
            label6 = new Label();
            lblAmountPrPayment = new Label();
            label8 = new Label();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(44, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 3);
            panel2.TabIndex = 71;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = SystemColors.GradientActiveCaption;
            pnlTop.Controls.Add(lblCreate);
            pnlTop.Location = new Point(8, 23);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(488, 41);
            pnlTop.TabIndex = 72;
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top;
            lblCreate.AutoSize = true;
            lblCreate.BackColor = SystemColors.GradientActiveCaption;
            lblCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreate.Location = new Point(111, 10);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(290, 21);
            lblCreate.TabIndex = 43;
            lblCreate.Text = "Calculate remaining balance on loan";
            // 
            // txtPaymentsPrYear
            // 
            txtPaymentsPrYear.Location = new Point(271, 202);
            txtPaymentsPrYear.Name = "txtPaymentsPrYear";
            txtPaymentsPrYear.Size = new Size(100, 23);
            txtPaymentsPrYear.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(108, 203);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 77;
            label3.Text = "Payments pr year:";
            // 
            // txtAnnualInterestRate
            // 
            txtAnnualInterestRate.Location = new Point(271, 146);
            txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            txtAnnualInterestRate.Size = new Size(100, 23);
            txtAnnualInterestRate.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(91, 148);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 75;
            label2.Text = "Annual interest rate:";
            // 
            // txtTotalLoanAmount
            // 
            txtTotalLoanAmount.Location = new Point(271, 88);
            txtTotalLoanAmount.Name = "txtTotalLoanAmount";
            txtTotalLoanAmount.Size = new Size(100, 23);
            txtTotalLoanAmount.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(104, 88);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 73;
            label1.Text = "Total loan amount:";
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Bottom;
            btnCalculate.BackColor = Color.FromArgb(45, 93, 134);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCalculate.IconColor = Color.Black;
            btnCalculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculate.IconSize = 70;
            btnCalculate.Location = new Point(88, 349);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 27);
            btnCalculate.TabIndex = 79;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.FromArgb(45, 93, 134);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            btnClear.IconColor = Color.Black;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.IconSize = 70;
            btnClear.Location = new Point(290, 349);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 27);
            btnClear.TabIndex = 80;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.AutoSize = true;
            lblRemainingBalance.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemainingBalance.ForeColor = SystemColors.ActiveCaptionText;
            lblRemainingBalance.Location = new Point(271, 465);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(64, 17);
            lblRemainingBalance.TabIndex = 82;
            lblRemainingBalance.Text = "304,22 kr.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(104, 462);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 81;
            label4.Text = "Remaining balance:";
            // 
            // txtTotalYears
            // 
            txtTotalYears.Location = new Point(271, 258);
            txtTotalYears.Name = "txtTotalYears";
            txtTotalYears.Size = new Size(100, 23);
            txtTotalYears.TabIndex = 84;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(157, 260);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 83;
            label5.Text = "Total years:";
            // 
            // txtPaymentsMade
            // 
            txtPaymentsMade.Location = new Point(271, 307);
            txtPaymentsMade.Name = "txtPaymentsMade";
            txtPaymentsMade.Size = new Size(100, 23);
            txtPaymentsMade.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(119, 307);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 85;
            label6.Text = "Payments made:";
            // 
            // lblAmountPrPayment
            // 
            lblAmountPrPayment.AutoSize = true;
            lblAmountPrPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountPrPayment.ForeColor = SystemColors.ActiveCaptionText;
            lblAmountPrPayment.Location = new Point(271, 426);
            lblAmountPrPayment.Name = "lblAmountPrPayment";
            lblAmountPrPayment.Size = new Size(64, 17);
            lblAmountPrPayment.TabIndex = 88;
            lblAmountPrPayment.Text = "304,22 kr.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(45, 93, 134);
            label8.Location = new Point(94, 423);
            label8.Name = "label8";
            label8.Size = new Size(161, 21);
            label8.TabIndex = 87;
            label8.Text = "Amount pr payment:";
            // 
            // CalcRemainingBalanceOnLoanView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(508, 530);
            Controls.Add(lblAmountPrPayment);
            Controls.Add(label8);
            Controls.Add(txtPaymentsMade);
            Controls.Add(label6);
            Controls.Add(txtTotalYears);
            Controls.Add(label5);
            Controls.Add(lblRemainingBalance);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtPaymentsPrYear);
            Controls.Add(label3);
            Controls.Add(txtAnnualInterestRate);
            Controls.Add(label2);
            Controls.Add(txtTotalLoanAmount);
            Controls.Add(label1);
            Controls.Add(pnlTop);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalcRemainingBalanceOnLoanView";
            Text = "CalcRemainingBalanceOnLoanView";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel pnlTop;
        private Label lblCreate;
        private TextBox txtPaymentsPrYear;
        private Label label3;
        private TextBox txtAnnualInterestRate;
        private Label label2;
        private TextBox txtTotalLoanAmount;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCalculate;
        private FontAwesome.Sharp.IconButton btnClear;
        private Label lblRemainingBalance;
        private Label label4;
        private TextBox txtTotalYears;
        private Label label5;
        private TextBox txtPaymentsMade;
        private Label label6;
        private Label lblAmountPrPayment;
        private Label label8;
    }
}