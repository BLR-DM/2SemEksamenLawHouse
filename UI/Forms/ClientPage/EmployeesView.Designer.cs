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
            panel2 = new Panel();
            gradiantPanel1 = new Toolbox.GradiantPanel();
            lblFilter = new Label();
            cboxSpecialities = new ComboBox();
            lblFilterSpeciality = new Label();
            lblSort = new Label();
            cboxSort = new ComboBox();
            pnlLawyerDetails = new Panel();
            gradiantPanel1.SuspendLayout();
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
            lblLawyers.Location = new Point(32, 15);
            lblLawyers.Name = "lblLawyers";
            lblLawyers.Size = new Size(83, 25);
            lblLawyers.TabIndex = 4;
            lblLawyers.Text = "Lawyers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 93, 134);
            panel2.Location = new Point(4, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 523);
            panel2.TabIndex = 0;
            // 
            // gradiantPanel1
            // 
            gradiantPanel1.Angle = 180F;
            gradiantPanel1.BackColor = Color.Transparent;
            gradiantPanel1.BackgroundImageLayout = ImageLayout.None;
            gradiantPanel1.BottomColor = SystemColors.GradientInactiveCaption;
            gradiantPanel1.Controls.Add(panel2);
            gradiantPanel1.Controls.Add(pnlLawyerDetails);
            gradiantPanel1.Dock = DockStyle.Right;
            gradiantPanel1.Location = new Point(658, 0);
            gradiantPanel1.Name = "gradiantPanel1";
            gradiantPanel1.Size = new Size(340, 613);
            gradiantPanel1.TabIndex = 7;
            gradiantPanel1.TopColor = Color.FromArgb(156, 193, 232);
            // 
            // lblFilter
            // 
            lblFilter.Anchor = AnchorStyles.Top;
            lblFilter.AutoSize = true;
            lblFilter.BackColor = SystemColors.GradientInactiveCaption;
            lblFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFilter.ForeColor = Color.FromArgb(45, 93, 134);
            lblFilter.Location = new Point(36, 54);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(45, 19);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter:";
            // 
            // cboxSpecialities
            // 
            cboxSpecialities.BackColor = SystemColors.GradientInactiveCaption;
            cboxSpecialities.Cursor = Cursors.Hand;
            cboxSpecialities.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSpecialities.FlatStyle = FlatStyle.Flat;
            cboxSpecialities.FormattingEnabled = true;
            cboxSpecialities.Location = new Point(168, 53);
            cboxSpecialities.Name = "cboxSpecialities";
            cboxSpecialities.Size = new Size(203, 23);
            cboxSpecialities.TabIndex = 8;
            // 
            // lblFilterSpeciality
            // 
            lblFilterSpeciality.Anchor = AnchorStyles.Top;
            lblFilterSpeciality.AutoSize = true;
            lblFilterSpeciality.BackColor = SystemColors.GradientInactiveCaption;
            lblFilterSpeciality.Font = new Font("Segoe UI", 10F);
            lblFilterSpeciality.ForeColor = Color.FromArgb(45, 93, 134);
            lblFilterSpeciality.Location = new Point(101, 54);
            lblFilterSpeciality.Name = "lblFilterSpeciality";
            lblFilterSpeciality.Size = new Size(65, 19);
            lblFilterSpeciality.TabIndex = 4;
            lblFilterSpeciality.Text = "Speciality";
            // 
            // lblSort
            // 
            lblSort.Anchor = AnchorStyles.Top;
            lblSort.AutoSize = true;
            lblSort.BackColor = SystemColors.GradientInactiveCaption;
            lblSort.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSort.ForeColor = Color.FromArgb(45, 93, 134);
            lblSort.Location = new Point(418, 54);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(57, 19);
            lblSort.TabIndex = 4;
            lblSort.Text = "Sort by:";
            // 
            // cboxSort
            // 
            cboxSort.BackColor = SystemColors.GradientInactiveCaption;
            cboxSort.Cursor = Cursors.Hand;
            cboxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSort.FlatStyle = FlatStyle.Flat;
            cboxSort.FormattingEnabled = true;
            cboxSort.Location = new Point(481, 53);
            cboxSort.Name = "cboxSort";
            cboxSort.Size = new Size(119, 23);
            cboxSort.TabIndex = 8;
            // 
            // pnlLawyerDetails
            // 
            pnlLawyerDetails.Location = new Point(11, 55);
            pnlLawyerDetails.Name = "pnlLawyerDetails";
            pnlLawyerDetails.Size = new Size(315, 523);
            pnlLawyerDetails.TabIndex = 4;
            // 
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(cboxSort);
            Controls.Add(cboxSpecialities);
            Controls.Add(flpnlLawyers);
            Controls.Add(lblFilterSpeciality);
            Controls.Add(lblSort);
            Controls.Add(lblFilter);
            Controls.Add(lblLawyers);
            Controls.Add(gradiantPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeesView";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "EmployeesView";
            gradiantPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpnlLawyers;
        private Label lblLawyers;
        private Panel panel2;
        private Toolbox.GradiantPanel gradiantPanel1;
        private Label lblFilter;
        private ComboBox cboxSpecialities;
        private Label lblFilterSpeciality;
        private Label lblSort;
        private ComboBox cboxSort;
        private Panel pnlLawyerDetails;
    }
}