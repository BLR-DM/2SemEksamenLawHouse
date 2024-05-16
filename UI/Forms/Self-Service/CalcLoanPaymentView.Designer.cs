namespace UI.Forms.Self_Service
{
    partial class CalcLoanPaymentView
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
            lblPaymentPrYear = new Label();
            lblAmountPrPayment = new Label();
            label6 = new Label();
            label5 = new Label();
            pnlTop = new Panel();
            lblCreate = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAmountOfYears = new TextBox();
            txtPaymentsPrYear = new TextBox();
            txtAnnualInterestRate = new TextBox();
            txtLoanAmount = new TextBox();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnCalculate = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblPaymentPrYear
            // 
            lblPaymentPrYear.AutoSize = true;
            lblPaymentPrYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentPrYear.ForeColor = SystemColors.ActiveCaptionText;
            lblPaymentPrYear.Location = new Point(269, 481);
            lblPaymentPrYear.Name = "lblPaymentPrYear";
            lblPaymentPrYear.Size = new Size(71, 17);
            lblPaymentPrYear.TabIndex = 64;
            lblPaymentPrYear.Text = "3650,63 kr.";
            // 
            // lblAmountPrPayment
            // 
            lblAmountPrPayment.AutoSize = true;
            lblAmountPrPayment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountPrPayment.ForeColor = SystemColors.ActiveCaptionText;
            lblAmountPrPayment.Location = new Point(269, 445);
            lblAmountPrPayment.Name = "lblAmountPrPayment";
            lblAmountPrPayment.Size = new Size(64, 17);
            lblAmountPrPayment.TabIndex = 63;
            lblAmountPrPayment.Text = "304,22 kr.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(119, 477);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 62;
            label6.Text = "Payment pr year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(88, 441);
            label5.Name = "label5";
            label5.Size = new Size(161, 21);
            label5.TabIndex = 61;
            label5.Text = "Amount pr payment:";
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = SystemColors.GradientActiveCaption;
            pnlTop.Controls.Add(lblCreate);
            pnlTop.Location = new Point(8, 23);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(488, 41);
            pnlTop.TabIndex = 60;
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top;
            lblCreate.AutoSize = true;
            lblCreate.BackColor = SystemColors.GradientActiveCaption;
            lblCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreate.Location = new Point(144, 10);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(215, 21);
            lblCreate.TabIndex = 43;
            lblCreate.Text = "Calculate payment on loan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(112, 267);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 59;
            label4.Text = "Amount of years:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(112, 209);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 58;
            label3.Text = "Payments pr year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(95, 150);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 57;
            label2.Text = "Annual interest rate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(138, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 56;
            label1.Text = "Loan amount:";
            // 
            // txtAmountOfYears
            // 
            txtAmountOfYears.Location = new Point(269, 269);
            txtAmountOfYears.Name = "txtAmountOfYears";
            txtAmountOfYears.Size = new Size(100, 23);
            txtAmountOfYears.TabIndex = 55;
            // 
            // txtPaymentsPrYear
            // 
            txtPaymentsPrYear.Location = new Point(269, 211);
            txtPaymentsPrYear.Name = "txtPaymentsPrYear";
            txtPaymentsPrYear.Size = new Size(100, 23);
            txtPaymentsPrYear.TabIndex = 54;
            // 
            // txtAnnualInterestRate
            // 
            txtAnnualInterestRate.Location = new Point(269, 152);
            txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            txtAnnualInterestRate.Size = new Size(100, 23);
            txtAnnualInterestRate.TabIndex = 53;
            // 
            // txtLoanAmount
            // 
            txtLoanAmount.Location = new Point(269, 92);
            txtLoanAmount.Name = "txtLoanAmount";
            txtLoanAmount.Size = new Size(100, 23);
            txtLoanAmount.TabIndex = 52;
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
            btnClear.TabIndex = 51;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = false;
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
            btnCalculate.TabIndex = 50;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(44, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 3);
            panel1.TabIndex = 49;
            // 
            // CalcLoanPaymentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(508, 530);
            Controls.Add(lblPaymentPrYear);
            Controls.Add(lblAmountPrPayment);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pnlTop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAmountOfYears);
            Controls.Add(txtPaymentsPrYear);
            Controls.Add(txtAnnualInterestRate);
            Controls.Add(txtLoanAmount);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalcLoanPaymentView";
            Text = "CalcLoanPaymentView";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaymentPrYear;
        private Label lblAmountPrPayment;
        private Label label6;
        private Label label5;
        private Panel pnlTop;
        private Label lblCreate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAmountOfYears;
        private TextBox txtPaymentsPrYear;
        private TextBox txtAnnualInterestRate;
        private TextBox txtLoanAmount;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnCalculate;
        private Panel panel1;
    }
}