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
            panel1 = new Panel();
            pnlCalc = new Panel();
            lblCalcLoanPayment = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(390, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 493);
            panel1.TabIndex = 1;
            // 
            // pnlCalc
            // 
            pnlCalc.Location = new Point(456, 28);
            pnlCalc.Name = "pnlCalc";
            pnlCalc.Size = new Size(508, 530);
            pnlCalc.TabIndex = 2;
            // 
            // lblCalcLoanPayment
            // 
            lblCalcLoanPayment.AutoSize = true;
            lblCalcLoanPayment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcLoanPayment.ForeColor = Color.FromArgb(45, 93, 134);
            lblCalcLoanPayment.Location = new Point(46, 74);
            lblCalcLoanPayment.Name = "lblCalcLoanPayment";
            lblCalcLoanPayment.Size = new Size(212, 21);
            lblCalcLoanPayment.TabIndex = 3;
            lblCalcLoanPayment.Text = "- Calculate payment on loan";
            // 
            // CalculationsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(lblCalcLoanPayment);
            Controls.Add(pnlCalc);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculationsView";
            Text = "Calculations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel pnlCalc;
        private Label lblCalcLoanPayment;
    }
}