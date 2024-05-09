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
            pnlDetailsPicture = new Panel();
            pboxDetails = new FontAwesome.Sharp.IconPictureBox();
            lblSelected = new Label();
            lboxSpecialties = new ListBox();
            panel2 = new Panel();
            lblDetailsEmailValue = new Label();
            lblDetailsEmail = new Label();
            lblDetailsPhoneValue = new Label();
            lblDetailsPhone = new Label();
            lblDetailsCityValue = new Label();
            lblDetailsCity = new Label();
            lblDetailsTitleValue = new Label();
            lblDetailsTitle = new Label();
            lblSpecialities = new Label();
            gradiantPanel1 = new Toolbox.GradiantPanel();
            lblFilter = new Label();
            cboxSpecialities = new ComboBox();
            lblFilterSpeciality = new Label();
            lblSort = new Label();
            cboxSort = new ComboBox();
            pnlDetails.SuspendLayout();
            pnlDetailsPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxDetails).BeginInit();
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
            // pnlDetails
            // 
            pnlDetails.BackColor = Color.Transparent;
            pnlDetails.BackgroundImage = Properties.Resources.background;
            pnlDetails.Controls.Add(pnlDetailsPicture);
            pnlDetails.Controls.Add(lblSelected);
            pnlDetails.Controls.Add(lboxSpecialties);
            pnlDetails.Controls.Add(panel2);
            pnlDetails.Controls.Add(lblDetailsEmailValue);
            pnlDetails.Controls.Add(lblDetailsEmail);
            pnlDetails.Controls.Add(lblDetailsPhoneValue);
            pnlDetails.Controls.Add(lblDetailsPhone);
            pnlDetails.Controls.Add(lblDetailsCityValue);
            pnlDetails.Controls.Add(lblDetailsCity);
            pnlDetails.Controls.Add(lblDetailsTitleValue);
            pnlDetails.Controls.Add(lblDetailsTitle);
            pnlDetails.Controls.Add(lblSpecialities);
            pnlDetails.Location = new Point(658, 54);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(336, 523);
            pnlDetails.TabIndex = 5;
            // 
            // pnlDetailsPicture
            // 
            pnlDetailsPicture.Controls.Add(pboxDetails);
            pnlDetailsPicture.Location = new Point(15, 28);
            pnlDetailsPicture.Name = "pnlDetailsPicture";
            pnlDetailsPicture.Size = new Size(311, 218);
            pnlDetailsPicture.TabIndex = 5;
            // 
            // pboxDetails
            // 
            pboxDetails.BackColor = Color.Transparent;
            pboxDetails.BackgroundImageLayout = ImageLayout.Center;
            pboxDetails.Dock = DockStyle.Fill;
            pboxDetails.ForeColor = SystemColors.ActiveCaptionText;
            pboxDetails.IconChar = FontAwesome.Sharp.IconChar.BlackTie;
            pboxDetails.IconColor = SystemColors.ActiveCaptionText;
            pboxDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxDetails.IconSize = 218;
            pboxDetails.Location = new Point(0, 0);
            pboxDetails.Name = "pboxDetails";
            pboxDetails.Size = new Size(311, 218);
            pboxDetails.SizeMode = PictureBoxSizeMode.CenterImage;
            pboxDetails.TabIndex = 5;
            pboxDetails.TabStop = false;
            // 
            // lblSelected
            // 
            lblSelected.BackColor = Color.Transparent;
            lblSelected.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSelected.ForeColor = Color.FromArgb(45, 93, 134);
            lblSelected.Location = new Point(15, 4);
            lblSelected.Name = "lblSelected";
            lblSelected.RightToLeft = RightToLeft.No;
            lblSelected.Size = new Size(311, 21);
            lblSelected.TabIndex = 4;
            lblSelected.Text = "Select an employee to see details";
            lblSelected.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lboxSpecialties
            // 
            lboxSpecialties.BackColor = SystemColors.GradientInactiveCaption;
            lboxSpecialties.BorderStyle = BorderStyle.None;
            lboxSpecialties.Font = new Font("Segoe UI", 9.75F);
            lboxSpecialties.ForeColor = SystemColors.ControlText;
            lboxSpecialties.FormattingEnabled = true;
            lboxSpecialties.ItemHeight = 17;
            lboxSpecialties.Location = new Point(24, 401);
            lboxSpecialties.Name = "lboxSpecialties";
            lboxSpecialties.SelectionMode = SelectionMode.None;
            lboxSpecialties.Size = new Size(299, 119);
            lboxSpecialties.Sorted = true;
            lboxSpecialties.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 93, 134);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 523);
            panel2.TabIndex = 0;
            // 
            // lblDetailsEmailValue
            // 
            lblDetailsEmailValue.Anchor = AnchorStyles.Top;
            lblDetailsEmailValue.AutoSize = true;
            lblDetailsEmailValue.BackColor = Color.Transparent;
            lblDetailsEmailValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsEmailValue.ForeColor = SystemColors.ControlText;
            lblDetailsEmailValue.Location = new Point(67, 349);
            lblDetailsEmailValue.Name = "lblDetailsEmailValue";
            lblDetailsEmailValue.Size = new Size(0, 17);
            lblDetailsEmailValue.TabIndex = 4;
            // 
            // lblDetailsEmail
            // 
            lblDetailsEmail.Anchor = AnchorStyles.Top;
            lblDetailsEmail.AutoSize = true;
            lblDetailsEmail.BackColor = Color.Transparent;
            lblDetailsEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsEmail.Location = new Point(21, 348);
            lblDetailsEmail.Name = "lblDetailsEmail";
            lblDetailsEmail.Size = new Size(49, 19);
            lblDetailsEmail.TabIndex = 4;
            lblDetailsEmail.Text = "Email:";
            // 
            // lblDetailsPhoneValue
            // 
            lblDetailsPhoneValue.Anchor = AnchorStyles.Top;
            lblDetailsPhoneValue.AutoSize = true;
            lblDetailsPhoneValue.BackColor = Color.Transparent;
            lblDetailsPhoneValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsPhoneValue.ForeColor = SystemColors.ControlText;
            lblDetailsPhoneValue.Location = new Point(73, 319);
            lblDetailsPhoneValue.Name = "lblDetailsPhoneValue";
            lblDetailsPhoneValue.Size = new Size(0, 17);
            lblDetailsPhoneValue.TabIndex = 4;
            // 
            // lblDetailsPhone
            // 
            lblDetailsPhone.Anchor = AnchorStyles.Top;
            lblDetailsPhone.AutoSize = true;
            lblDetailsPhone.BackColor = Color.Transparent;
            lblDetailsPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsPhone.Location = new Point(21, 318);
            lblDetailsPhone.Name = "lblDetailsPhone";
            lblDetailsPhone.Size = new Size(55, 19);
            lblDetailsPhone.TabIndex = 4;
            lblDetailsPhone.Text = "Phone:";
            // 
            // lblDetailsCityValue
            // 
            lblDetailsCityValue.Anchor = AnchorStyles.Top;
            lblDetailsCityValue.AutoSize = true;
            lblDetailsCityValue.BackColor = Color.Transparent;
            lblDetailsCityValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsCityValue.ForeColor = SystemColors.ControlText;
            lblDetailsCityValue.Location = new Point(57, 289);
            lblDetailsCityValue.Name = "lblDetailsCityValue";
            lblDetailsCityValue.Size = new Size(0, 17);
            lblDetailsCityValue.TabIndex = 4;
            // 
            // lblDetailsCity
            // 
            lblDetailsCity.Anchor = AnchorStyles.Top;
            lblDetailsCity.AutoSize = true;
            lblDetailsCity.BackColor = Color.Transparent;
            lblDetailsCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsCity.Location = new Point(21, 288);
            lblDetailsCity.Name = "lblDetailsCity";
            lblDetailsCity.Size = new Size(39, 19);
            lblDetailsCity.TabIndex = 4;
            lblDetailsCity.Text = "City:";
            // 
            // lblDetailsTitleValue
            // 
            lblDetailsTitleValue.Anchor = AnchorStyles.Top;
            lblDetailsTitleValue.AutoSize = true;
            lblDetailsTitleValue.BackColor = Color.Transparent;
            lblDetailsTitleValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsTitleValue.ForeColor = SystemColors.ControlText;
            lblDetailsTitleValue.Location = new Point(60, 259);
            lblDetailsTitleValue.Name = "lblDetailsTitleValue";
            lblDetailsTitleValue.Size = new Size(0, 17);
            lblDetailsTitleValue.TabIndex = 4;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.Anchor = AnchorStyles.Top;
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.BackColor = Color.Transparent;
            lblDetailsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsTitle.Location = new Point(21, 258);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(42, 19);
            lblDetailsTitle.TabIndex = 4;
            lblDetailsTitle.Text = "Title:";
            // 
            // lblSpecialities
            // 
            lblSpecialities.Anchor = AnchorStyles.Top;
            lblSpecialities.AutoSize = true;
            lblSpecialities.BackColor = Color.Transparent;
            lblSpecialities.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpecialities.ForeColor = Color.FromArgb(45, 93, 134);
            lblSpecialities.Location = new Point(21, 378);
            lblSpecialities.Name = "lblSpecialities";
            lblSpecialities.Size = new Size(88, 19);
            lblSpecialities.TabIndex = 4;
            lblSpecialities.Text = "Specialities:";
            // 
            // gradiantPanel1
            // 
            gradiantPanel1.Angle = 180F;
            gradiantPanel1.BackColor = Color.Transparent;
            gradiantPanel1.BackgroundImageLayout = ImageLayout.None;
            gradiantPanel1.BottomColor = SystemColors.GradientInactiveCaption;
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
            // EmployeesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(998, 613);
            Controls.Add(cboxSort);
            Controls.Add(cboxSpecialities);
            Controls.Add(pnlDetails);
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
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            pnlDetailsPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pboxDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpnlLawyers;
        private Label lblLawyers;
        private Panel pnlDetails;
        private Panel panel2;
        private ListBox lboxSpecialties;
        private Label lblSpecialities;
        private FontAwesome.Sharp.IconPictureBox pboxDetails;
        private Panel pnlDetailsPicture;
        private Label lblDetailsEmailValue;
        private Label lblDetailsEmail;
        private Label lblDetailsPhoneValue;
        private Label lblDetailsPhone;
        private Label lblDetailsCityValue;
        private Label lblDetailsCity;
        private Label lblDetailsTitleValue;
        private Label lblDetailsTitle;
        private Toolbox.GradiantPanel gradiantPanel1;
        private Label lblSelected;
        private Label lblFilter;
        private ComboBox cboxSpecialities;
        private Label lblFilterSpeciality;
        private Label lblSort;
        private ComboBox cboxSort;
    }
}