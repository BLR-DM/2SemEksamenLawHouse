namespace UI.Forms.Self_Service
{
    partial class CalcROIView
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
            pnlTop = new Panel();
            lblCreate = new Label();
            label1 = new Label();
            txtInvestment = new TextBox();
            label2 = new Label();
            txtInterestRate = new TextBox();
            label3 = new Label();
            txtAmountOfYears = new TextBox();
            panel2 = new Panel();
            btnCalculate = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            lblReturnOnInvestment = new Label();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = SystemColors.GradientActiveCaption;
            pnlTop.Controls.Add(lblCreate);
            pnlTop.Location = new Point(8, 23);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(488, 41);
            pnlTop.TabIndex = 61;
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top;
            lblCreate.AutoSize = true;
            lblCreate.BackColor = SystemColors.GradientActiveCaption;
            lblCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreate.Location = new Point(128, 10);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(246, 21);
            lblCreate.TabIndex = 43;
            lblCreate.Text = "Calculate return on investment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(144, 104);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 62;
            label1.Text = "Investment:";
            // 
            // txtInvestment
            // 
            txtInvestment.Location = new Point(256, 106);
            txtInvestment.Name = "txtInvestment";
            txtInvestment.Size = new Size(100, 23);
            txtInvestment.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(136, 164);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 66;
            label2.Text = "Interest rate:";
            // 
            // txtInterestRate
            // 
            txtInterestRate.Location = new Point(256, 164);
            txtInterestRate.Name = "txtInterestRate";
            txtInterestRate.Size = new Size(100, 23);
            txtInterestRate.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(105, 218);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 68;
            label3.Text = "Amount of years:";
            // 
            // txtAmountOfYears
            // 
            txtAmountOfYears.Location = new Point(256, 220);
            txtAmountOfYears.Name = "txtAmountOfYears";
            txtAmountOfYears.Size = new Size(100, 23);
            txtAmountOfYears.TabIndex = 69;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(44, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 3);
            panel2.TabIndex = 70;
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
            btnCalculate.TabIndex = 71;
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
            btnClear.TabIndex = 72;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(69, 448);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 73;
            label4.Text = "Return on investment:";
            // 
            // lblReturnOnInvestment
            // 
            lblReturnOnInvestment.AutoSize = true;
            lblReturnOnInvestment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReturnOnInvestment.ForeColor = SystemColors.ActiveCaptionText;
            lblReturnOnInvestment.Location = new Point(258, 451);
            lblReturnOnInvestment.Name = "lblReturnOnInvestment";
            lblReturnOnInvestment.Size = new Size(64, 17);
            lblReturnOnInvestment.TabIndex = 74;
            lblReturnOnInvestment.Text = "304,22 kr.";
            // 
            // CalcROIView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(508, 530);
            Controls.Add(lblReturnOnInvestment);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(panel2);
            Controls.Add(txtAmountOfYears);
            Controls.Add(label3);
            Controls.Add(txtInterestRate);
            Controls.Add(label2);
            Controls.Add(txtInvestment);
            Controls.Add(label1);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalcROIView";
            Text = "CalcRUIView";
            Load += CalcROIView_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblCreate;
        private Label label1;
        private TextBox txtInvestment;
        private Label label2;
        private TextBox txtInterestRate;
        private Label label3;
        private TextBox txtAmountOfYears;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnCalculate;
        private FontAwesome.Sharp.IconButton btnClear;
        private Label label4;
        private Label lblReturnOnInvestment;
    }
}