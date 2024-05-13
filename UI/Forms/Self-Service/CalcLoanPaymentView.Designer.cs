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
            panel1 = new Panel();
            btnCalculate = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            txtLoanAmmount = new TextBox();
            txtAnnualInterestRate = new TextBox();
            txtPaymentsPrYear = new TextBox();
            txtAmmountOfYears = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblCreate = new Label();
            pnlTop = new Panel();
            label5 = new Label();
            label6 = new Label();
            lblPaymentPrYear = new Label();
            label7 = new Label();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(46, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 3);
            panel1.TabIndex = 2;
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
            btnCalculate.Location = new Point(90, 328);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 27);
            btnCalculate.TabIndex = 19;
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
            btnClear.Location = new Point(292, 328);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 27);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtLoanAmmount
            // 
            txtLoanAmmount.Location = new Point(271, 87);
            txtLoanAmmount.Name = "txtLoanAmmount";
            txtLoanAmmount.Size = new Size(100, 23);
            txtLoanAmmount.TabIndex = 21;
            // 
            // txtAnnualInterestRate
            // 
            txtAnnualInterestRate.Location = new Point(271, 147);
            txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            txtAnnualInterestRate.Size = new Size(100, 23);
            txtAnnualInterestRate.TabIndex = 22;
            // 
            // txtPaymentsPrYear
            // 
            txtPaymentsPrYear.Location = new Point(271, 206);
            txtPaymentsPrYear.Name = "txtPaymentsPrYear";
            txtPaymentsPrYear.Size = new Size(100, 23);
            txtPaymentsPrYear.TabIndex = 23;
            // 
            // txtAmmountOfYears
            // 
            txtAmmountOfYears.Location = new Point(271, 264);
            txtAmmountOfYears.Name = "txtAmmountOfYears";
            txtAmmountOfYears.Size = new Size(100, 23);
            txtAmmountOfYears.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(131, 87);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 39;
            label1.Text = "Loan ammount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(97, 145);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 40;
            label2.Text = "Annual interest rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(114, 204);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 41;
            label3.Text = "Payments pr year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(105, 262);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 42;
            label4.Text = "Ammount of years:";
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top;
            lblCreate.AutoSize = true;
            lblCreate.BackColor = SystemColors.GradientActiveCaption;
            lblCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreate.Location = new Point(131, 9);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(215, 21);
            lblCreate.TabIndex = 43;
            lblCreate.Text = "Calculate payment on loan";
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = SystemColors.GradientActiveCaption;
            pnlTop.Controls.Add(lblCreate);
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(488, 41);
            pnlTop.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(79, 420);
            label5.Name = "label5";
            label5.Size = new Size(175, 21);
            label5.TabIndex = 45;
            label5.Text = "Ammount pr payment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 93, 134);
            label6.Location = new Point(121, 456);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 46;
            label6.Text = "Payment pr year:";
            // 
            // lblPaymentPrYear
            // 
            lblPaymentPrYear.AutoSize = true;
            lblPaymentPrYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentPrYear.ForeColor = SystemColors.ActiveCaptionText;
            lblPaymentPrYear.Location = new Point(271, 424);
            lblPaymentPrYear.Name = "lblPaymentPrYear";
            lblPaymentPrYear.Size = new Size(64, 17);
            lblPaymentPrYear.TabIndex = 47;
            lblPaymentPrYear.Text = "304,22 kr.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(271, 460);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 48;
            label7.Text = "3650,63 kr.";
            // 
            // CalcLoanPaymentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(508, 530);
            Controls.Add(label7);
            Controls.Add(lblPaymentPrYear);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pnlTop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAmmountOfYears);
            Controls.Add(txtPaymentsPrYear);
            Controls.Add(txtAnnualInterestRate);
            Controls.Add(txtLoanAmmount);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalcLoanPaymentView";
            Text = "CalcLoanPayment";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCalculate;
        private FontAwesome.Sharp.IconButton btnClear;
        private TextBox txtLoanAmmount;
        private TextBox txtAnnualInterestRate;
        private TextBox txtPaymentsPrYear;
        private TextBox txtAmmountOfYears;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCreate;
        private Panel pnlTop;
        private Label label5;
        private Label label6;
        private Label lblPaymentPrYear;
        private Label label7;
    }
}