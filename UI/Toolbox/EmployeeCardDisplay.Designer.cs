namespace UI.Toolbox
{
    partial class EmployeeCardDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSpecialities = new Label();
            lblDetailsTitle = new Label();
            lblDetailsCity = new Label();
            lblDetailsPhone = new Label();
            lblDetailsEmail = new Label();
            lblFullname = new Label();
            pboxDetails = new FontAwesome.Sharp.IconPictureBox();
            lblDetailsTitleValue = new Label();
            lblDetailsCityValue = new Label();
            lblDetailsPhoneValue = new Label();
            lblDetailsEmailValue = new Label();
            lboxSpecialties = new ListBox();
            lblHireDate = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxDetails).BeginInit();
            SuspendLayout();
            // 
            // lblSpecialities
            // 
            lblSpecialities.Anchor = AnchorStyles.Top;
            lblSpecialities.BackColor = Color.Transparent;
            lblSpecialities.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSpecialities.ForeColor = Color.FromArgb(45, 93, 134);
            lblSpecialities.Location = new Point(6, 368);
            lblSpecialities.Name = "lblSpecialities";
            lblSpecialities.Size = new Size(88, 19);
            lblSpecialities.TabIndex = 4;
            lblSpecialities.Text = "Specialities:";
            lblSpecialities.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.Anchor = AnchorStyles.Top;
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.BackColor = Color.Transparent;
            lblDetailsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsTitle.Location = new Point(51, 265);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(42, 19);
            lblDetailsTitle.TabIndex = 4;
            lblDetailsTitle.Text = "Title:";
            // 
            // lblDetailsCity
            // 
            lblDetailsCity.Anchor = AnchorStyles.Top;
            lblDetailsCity.AutoSize = true;
            lblDetailsCity.BackColor = Color.Transparent;
            lblDetailsCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsCity.Location = new Point(55, 291);
            lblDetailsCity.Name = "lblDetailsCity";
            lblDetailsCity.Size = new Size(39, 19);
            lblDetailsCity.TabIndex = 4;
            lblDetailsCity.Text = "City:";
            // 
            // lblDetailsPhone
            // 
            lblDetailsPhone.Anchor = AnchorStyles.Top;
            lblDetailsPhone.AutoSize = true;
            lblDetailsPhone.BackColor = Color.Transparent;
            lblDetailsPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsPhone.Location = new Point(39, 317);
            lblDetailsPhone.Name = "lblDetailsPhone";
            lblDetailsPhone.Size = new Size(55, 19);
            lblDetailsPhone.TabIndex = 4;
            lblDetailsPhone.Text = "Phone:";
            // 
            // lblDetailsEmail
            // 
            lblDetailsEmail.Anchor = AnchorStyles.Top;
            lblDetailsEmail.AutoSize = true;
            lblDetailsEmail.BackColor = Color.Transparent;
            lblDetailsEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsEmail.Location = new Point(45, 343);
            lblDetailsEmail.Name = "lblDetailsEmail";
            lblDetailsEmail.Size = new Size(49, 19);
            lblDetailsEmail.TabIndex = 4;
            lblDetailsEmail.Text = "Email:";
            // 
            // lblFullname
            // 
            lblFullname.BackColor = Color.Transparent;
            lblFullname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFullname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFullname.Location = new Point(6, 1);
            lblFullname.Name = "lblFullname";
            lblFullname.RightToLeft = RightToLeft.No;
            lblFullname.Size = new Size(311, 21);
            lblFullname.TabIndex = 4;
            lblFullname.Text = "Select an employee to see details";
            lblFullname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pboxDetails
            // 
            pboxDetails.BackColor = Color.Transparent;
            pboxDetails.BackgroundImageLayout = ImageLayout.Center;
            pboxDetails.ForeColor = SystemColors.ActiveCaptionText;
            pboxDetails.IconChar = FontAwesome.Sharp.IconChar.BlackTie;
            pboxDetails.IconColor = SystemColors.ActiveCaptionText;
            pboxDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxDetails.IconSize = 218;
            pboxDetails.Location = new Point(6, 37);
            pboxDetails.Name = "pboxDetails";
            pboxDetails.Size = new Size(311, 218);
            pboxDetails.SizeMode = PictureBoxSizeMode.CenterImage;
            pboxDetails.TabIndex = 5;
            pboxDetails.TabStop = false;
            // 
            // lblDetailsTitleValue
            // 
            lblDetailsTitleValue.Anchor = AnchorStyles.Top;
            lblDetailsTitleValue.AutoSize = true;
            lblDetailsTitleValue.BackColor = Color.Transparent;
            lblDetailsTitleValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsTitleValue.ForeColor = SystemColors.ControlText;
            lblDetailsTitleValue.Location = new Point(100, 266);
            lblDetailsTitleValue.Name = "lblDetailsTitleValue";
            lblDetailsTitleValue.Size = new Size(66, 17);
            lblDetailsTitleValue.TabIndex = 4;
            lblDetailsTitleValue.Text = "Some title";
            // 
            // lblDetailsCityValue
            // 
            lblDetailsCityValue.Anchor = AnchorStyles.Top;
            lblDetailsCityValue.AutoSize = true;
            lblDetailsCityValue.BackColor = Color.Transparent;
            lblDetailsCityValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsCityValue.ForeColor = SystemColors.ControlText;
            lblDetailsCityValue.Location = new Point(100, 292);
            lblDetailsCityValue.Name = "lblDetailsCityValue";
            lblDetailsCityValue.Size = new Size(64, 17);
            lblDetailsCityValue.TabIndex = 4;
            lblDetailsCityValue.Text = "Some city";
            // 
            // lblDetailsPhoneValue
            // 
            lblDetailsPhoneValue.Anchor = AnchorStyles.Top;
            lblDetailsPhoneValue.AutoSize = true;
            lblDetailsPhoneValue.BackColor = Color.Transparent;
            lblDetailsPhoneValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsPhoneValue.ForeColor = SystemColors.ControlText;
            lblDetailsPhoneValue.Location = new Point(100, 318);
            lblDetailsPhoneValue.Name = "lblDetailsPhoneValue";
            lblDetailsPhoneValue.Size = new Size(82, 17);
            lblDetailsPhoneValue.TabIndex = 4;
            lblDetailsPhoneValue.Text = "Some phone";
            // 
            // lblDetailsEmailValue
            // 
            lblDetailsEmailValue.Anchor = AnchorStyles.Top;
            lblDetailsEmailValue.AutoSize = true;
            lblDetailsEmailValue.BackColor = Color.Transparent;
            lblDetailsEmailValue.Font = new Font("Segoe UI", 9.75F);
            lblDetailsEmailValue.ForeColor = SystemColors.ControlText;
            lblDetailsEmailValue.Location = new Point(100, 344);
            lblDetailsEmailValue.Name = "lblDetailsEmailValue";
            lblDetailsEmailValue.Size = new Size(76, 17);
            lblDetailsEmailValue.TabIndex = 4;
            lblDetailsEmailValue.Text = "Some email";
            // 
            // lboxSpecialties
            // 
            lboxSpecialties.BackColor = SystemColors.GradientInactiveCaption;
            lboxSpecialties.BorderStyle = BorderStyle.None;
            lboxSpecialties.Font = new Font("Segoe UI", 9.75F);
            lboxSpecialties.FormattingEnabled = true;
            lboxSpecialties.ItemHeight = 17;
            lboxSpecialties.Location = new Point(100, 368);
            lboxSpecialties.Name = "lboxSpecialties";
            lboxSpecialties.SelectionMode = SelectionMode.None;
            lboxSpecialties.Size = new Size(204, 153);
            lboxSpecialties.Sorted = true;
            lboxSpecialties.TabIndex = 11;
            // 
            // lblHireDate
            // 
            lblHireDate.Anchor = AnchorStyles.Top;
            lblHireDate.AutoSize = true;
            lblHireDate.BackColor = Color.Transparent;
            lblHireDate.Font = new Font("Segoe UI", 9.75F);
            lblHireDate.ForeColor = SystemColors.ControlText;
            lblHireDate.Location = new Point(100, 370);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(74, 17);
            lblHireDate.TabIndex = 4;
            lblHireDate.Text = "15-05-2024";
            // 
            // EmployeeCardDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pboxDetails);
            Controls.Add(lblFullname);
            Controls.Add(lboxSpecialties);
            Controls.Add(lblSpecialities);
            Controls.Add(lblHireDate);
            Controls.Add(lblDetailsEmailValue);
            Controls.Add(lblDetailsTitle);
            Controls.Add(lblDetailsPhoneValue);
            Controls.Add(lblDetailsCity);
            Controls.Add(lblDetailsPhone);
            Controls.Add(lblDetailsCityValue);
            Controls.Add(lblDetailsEmail);
            Controls.Add(lblDetailsTitleValue);
            Name = "EmployeeCardDisplay";
            Size = new Size(323, 523);
            ((System.ComponentModel.ISupportInitialize)pboxDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSpecialities;
        private Label lblDetailsTitle;
        private Label lblDetailsCity;
        private Label lblDetailsPhone;
        private Label lblDetailsEmail;
        private Label lblFullname;
        private FontAwesome.Sharp.IconPictureBox pboxDetails;
        private Label lblDetailsTitleValue;
        private Label lblDetailsCityValue;
        private Label lblDetailsPhoneValue;
        private Label lblDetailsEmailValue;
        private ListBox lboxSpecialties;
        private Label lblHireDate;
    }
}
