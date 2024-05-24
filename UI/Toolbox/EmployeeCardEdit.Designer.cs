namespace UI.Toolbox
{
    partial class EmployeeCardEdit
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
            pboxDetails = new FontAwesome.Sharp.IconPictureBox();
            txtAddress = new TextBox();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            cboxTitles = new ComboBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            txtPostal = new TextBox();
            txtLastname = new TextBox();
            txtFirstname = new TextBox();
            lblLastname = new Label();
            lblFirstname = new Label();
            lblCity = new Label();
            lblDetailsTitle = new Label();
            lblPostal = new Label();
            lblAddress = new Label();
            lblDetailsPhone = new Label();
            lblDetailsEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxDetails).BeginInit();
            SuspendLayout();
            // 
            // pboxDetails
            // 
            pboxDetails.BackColor = Color.Transparent;
            pboxDetails.BackgroundImageLayout = ImageLayout.Center;
            pboxDetails.ForeColor = SystemColors.ActiveCaptionText;
            pboxDetails.IconChar = FontAwesome.Sharp.IconChar.BlackTie;
            pboxDetails.IconColor = SystemColors.ActiveCaptionText;
            pboxDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxDetails.IconSize = 136;
            pboxDetails.Location = new Point(91, 3);
            pboxDetails.Name = "pboxDetails";
            pboxDetails.Size = new Size(139, 136);
            pboxDetails.SizeMode = PictureBoxSizeMode.CenterImage;
            pboxDetails.TabIndex = 30;
            pboxDetails.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(113, 290);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(179, 23);
            txtAddress.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.FromArgb(45, 93, 134);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdate.IconColor = Color.Black;
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.IconSize = 70;
            btnUpdate.Location = new Point(73, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 33);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // cboxTitles
            // 
            cboxTitles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTitles.FormattingEnabled = true;
            cboxTitles.Location = new Point(113, 203);
            cboxTitles.Name = "cboxTitles";
            cboxTitles.Size = new Size(178, 23);
            cboxTitles.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(113, 232);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 16;
            // 
            // txtCity
            // 
            txtCity.Enabled = false;
            txtCity.Location = new Point(113, 350);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 25;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(113, 321);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(56, 23);
            txtPostal.TabIndex = 22;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(113, 174);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(100, 23);
            txtLastname.TabIndex = 14;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(113, 145);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(100, 23);
            txtFirstname.TabIndex = 13;
            // 
            // lblLastname
            // 
            lblLastname.Anchor = AnchorStyles.Top;
            lblLastname.AutoSize = true;
            lblLastname.BackColor = Color.Transparent;
            lblLastname.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(16, 175);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(76, 19);
            lblLastname.TabIndex = 19;
            lblLastname.Text = "Lastname:";
            // 
            // lblFirstname
            // 
            lblFirstname.Anchor = AnchorStyles.Top;
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = Color.Transparent;
            lblFirstname.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(16, 146);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(78, 19);
            lblFirstname.TabIndex = 20;
            lblFirstname.Text = "Firstname:";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top;
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblCity.Location = new Point(53, 351);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(39, 19);
            lblCity.TabIndex = 23;
            lblCity.Text = "City:";
            // 
            // lblDetailsTitle
            // 
            lblDetailsTitle.Anchor = AnchorStyles.Top;
            lblDetailsTitle.AutoSize = true;
            lblDetailsTitle.BackColor = Color.Transparent;
            lblDetailsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsTitle.Location = new Point(51, 204);
            lblDetailsTitle.Name = "lblDetailsTitle";
            lblDetailsTitle.Size = new Size(42, 19);
            lblDetailsTitle.TabIndex = 21;
            lblDetailsTitle.Text = "Title:";
            // 
            // lblPostal
            // 
            lblPostal.Anchor = AnchorStyles.Top;
            lblPostal.AutoSize = true;
            lblPostal.BackColor = Color.Transparent;
            lblPostal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(38, 322);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(54, 19);
            lblPostal.TabIndex = 24;
            lblPostal.Text = "Postal:";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(25, 291);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(67, 19);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "Address:";
            // 
            // lblDetailsPhone
            // 
            lblDetailsPhone.Anchor = AnchorStyles.Top;
            lblDetailsPhone.AutoSize = true;
            lblDetailsPhone.BackColor = Color.Transparent;
            lblDetailsPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsPhone.Location = new Point(39, 233);
            lblDetailsPhone.Name = "lblDetailsPhone";
            lblDetailsPhone.Size = new Size(55, 19);
            lblDetailsPhone.TabIndex = 26;
            lblDetailsPhone.Text = "Phone:";
            // 
            // lblDetailsEmail
            // 
            lblDetailsEmail.Anchor = AnchorStyles.Top;
            lblDetailsEmail.AutoSize = true;
            lblDetailsEmail.BackColor = Color.Transparent;
            lblDetailsEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDetailsEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblDetailsEmail.Location = new Point(45, 262);
            lblDetailsEmail.Name = "lblDetailsEmail";
            lblDetailsEmail.Size = new Size(49, 19);
            lblDetailsEmail.TabIndex = 28;
            lblDetailsEmail.Text = "Email:";
            // 
            // EmployeeCardEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(pboxDetails);
            Controls.Add(txtAddress);
            Controls.Add(btnUpdate);
            Controls.Add(cboxTitles);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(txtPostal);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(lblCity);
            Controls.Add(lblDetailsTitle);
            Controls.Add(lblPostal);
            Controls.Add(lblAddress);
            Controls.Add(lblDetailsPhone);
            Controls.Add(lblDetailsEmail);
            Name = "EmployeeCardEdit";
            Size = new Size(296, 442);
            ((System.ComponentModel.ISupportInitialize)pboxDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox pboxDetails;
        private TextBox txtAddress;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private ComboBox cboxTitles;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtCity;
        private TextBox txtPostal;
        private TextBox txtLastname;
        private TextBox txtFirstname;
        private Label lblLastname;
        private Label lblFirstname;
        private Label lblCity;
        private Label lblDetailsTitle;
        private Label lblPostal;
        private Label lblAddress;
        private Label lblDetailsPhone;
        private Label lblDetailsEmail;
    }
}
