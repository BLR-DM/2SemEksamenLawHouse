namespace UI.Forms.ClientPage
{
    partial class EmployeesView
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
            flpnlLawyers = new FlowLayoutPanel();
            lblLawyers = new Label();
            pnlDetails = new Panel();
            panel2 = new Panel();
            tboxSelected = new TextBox();
            label1 = new Label();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // flpnlLawyers
            // 
            flpnlLawyers.Location = new Point(11, 61);
            flpnlLawyers.Name = "flpnlLawyers";
            flpnlLawyers.Size = new Size(683, 540);
            flpnlLawyers.TabIndex = 2;
            // 
            // lblLawyers
            // 
            lblLawyers.Anchor = AnchorStyles.Top;
            lblLawyers.AutoSize = true;
            lblLawyers.BackColor = SystemColors.GradientInactiveCaption;
            lblLawyers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLawyers.ForeColor = Color.FromArgb(45, 93, 134);
            lblLawyers.Location = new Point(38, 26);
            lblLawyers.Name = "lblLawyers";
            lblLawyers.Size = new Size(83, 25);
            lblLawyers.TabIndex = 4;
            lblLawyers.Text = "Lawyers";
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(panel2);
            pnlDetails.Controls.Add(label1);
            pnlDetails.Location = new Point(700, 54);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(286, 519);
            pnlDetails.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 93, 134);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 519);
            panel2.TabIndex = 0;
            // 
            // tboxSelected
            // 
            tboxSelected.BackColor = SystemColors.GradientInactiveCaption;
            tboxSelected.BorderStyle = BorderStyle.None;
            tboxSelected.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tboxSelected.ForeColor = Color.FromArgb(45, 93, 134);
            tboxSelected.Location = new Point(700, 29);
            tboxSelected.Name = "tboxSelected";
            tboxSelected.ReadOnly = true;
            tboxSelected.Size = new Size(286, 22);
            tboxSelected.TabIndex = 0;
            tboxSelected.TabStop = false;
            tboxSelected.Text = "Selected name";
            tboxSelected.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 46F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(5, 199);
            label1.Name = "label1";
            label1.Size = new Size(278, 84);
            label1.TabIndex = 4;
            label1.Text = "DETAILS";
            // 
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(tboxSelected);
            Controls.Add(flpnlLawyers);
            Controls.Add(lblLawyers);
            Controls.Add(pnlDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesView";
            Text = "EmployeesView";
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpnlLawyers;
        private Label lblLawyers;
        private Panel pnlDetails;
        private Panel panel2;
        private TextBox tboxSelected;
        private Label label1;
    }
}