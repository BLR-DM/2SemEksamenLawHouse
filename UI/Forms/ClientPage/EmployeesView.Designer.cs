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
            lblSpecialties = new Label();
            lblSpeciality = new Label();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // flpnlLawyers
            // 
            flpnlLawyers.AutoScroll = true;
            flpnlLawyers.Location = new Point(11, 76);
            flpnlLawyers.Name = "flpnlLawyers";
            flpnlLawyers.Size = new Size(641, 525);
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
            pnlDetails.Controls.Add(lblSpeciality);
            pnlDetails.Location = new Point(658, 54);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(328, 519);
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
            tboxSelected.Location = new Point(663, 29);
            tboxSelected.Name = "tboxSelected";
            tboxSelected.ReadOnly = true;
            tboxSelected.Size = new Size(323, 22);
            tboxSelected.TabIndex = 0;
            tboxSelected.TabStop = false;
            tboxSelected.Text = "Selected name";
            tboxSelected.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSpecialties
            // 
            lblSpecialties.Anchor = AnchorStyles.Top;
            lblSpecialties.AutoSize = true;
            lblSpecialties.BackColor = SystemColors.GradientInactiveCaption;
            lblSpecialties.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSpecialties.ForeColor = Color.FromArgb(45, 93, 134);
            lblSpecialties.Location = new Point(38, 54);
            lblSpecialties.Name = "lblSpecialties";
            lblSpecialties.Size = new Size(59, 19);
            lblSpecialties.TabIndex = 4;
            lblSpecialties.Text = "Lawyers";
            // 
            // lblSpeciality
            // 
            lblSpeciality.Anchor = AnchorStyles.Top;
            lblSpeciality.AutoSize = true;
            lblSpeciality.BackColor = SystemColors.GradientInactiveCaption;
            lblSpeciality.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSpeciality.ForeColor = Color.FromArgb(45, 93, 134);
            lblSpeciality.Location = new Point(9, 217);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(59, 19);
            lblSpeciality.TabIndex = 4;
            lblSpeciality.Text = "Lawyers";
            // 
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(tboxSelected);
            Controls.Add(flpnlLawyers);
            Controls.Add(lblSpecialties);
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
        private Label lblSpecialties;
        private Label lblSpeciality;
    }
}