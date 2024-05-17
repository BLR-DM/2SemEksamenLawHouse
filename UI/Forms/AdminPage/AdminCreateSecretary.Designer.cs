namespace UI.Forms.AdminPage
{
    partial class AdminCreateSecretary
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
            cboxTitles = new ComboBox();
            btnCreate = new FontAwesome.Sharp.IconButton();
            btnToday = new Button();
            pnlLogin = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmailLogin = new TextBox();
            lblEmailLogin = new Label();
            dtpHireDate = new DateTimePicker();
            txtFirstname = new TextBox();
            txtEmail = new TextBox();
            lblTitleSelect = new Label();
            lblFirstname = new Label();
            lblEmail = new Label();
            lblLastname = new Label();
            txtLastname = new TextBox();
            lblTitle = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblInvalidDate = new Label();
            lblPhoneMain = new Label();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            lblAddress = new Label();
            lblCity = new Label();
            lblHireDate = new Label();
            lblPostal = new Label();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // cboxTitles
            // 
            cboxTitles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTitles.FormattingEnabled = true;
            cboxTitles.Location = new Point(29, 417);
            cboxTitles.Name = "cboxTitles";
            cboxTitles.Size = new Size(200, 23);
            cboxTitles.TabIndex = 44;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Bottom;
            btnCreate.BackColor = Color.FromArgb(45, 93, 134);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCreate.IconColor = Color.Black;
            btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreate.IconSize = 70;
            btnCreate.Location = new Point(152, 683);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 50);
            btnCreate.TabIndex = 48;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(270, 511);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(61, 23);
            btnToday.TabIndex = 37;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtEmailLogin);
            pnlLogin.Controls.Add(lblEmailLogin);
            pnlLogin.Location = new Point(12, 562);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(459, 93);
            pnlLogin.TabIndex = 66;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(241, 43);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.GradientInactiveCaption;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblPassword.Location = new Point(241, 19);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 32;
            lblPassword.Text = "Password";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.BackColor = Color.White;
            txtEmailLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailLogin.Location = new Point(16, 43);
            txtEmailLogin.MaxLength = 50;
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.PlaceholderText = "auto-generated";
            txtEmailLogin.ReadOnly = true;
            txtEmailLogin.Size = new Size(200, 27);
            txtEmailLogin.TabIndex = 29;
            // 
            // lblEmailLogin
            // 
            lblEmailLogin.AutoSize = true;
            lblEmailLogin.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmailLogin.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmailLogin.Location = new Point(16, 19);
            lblEmailLogin.Name = "lblEmailLogin";
            lblEmailLogin.Size = new Size(48, 21);
            lblEmailLogin.TabIndex = 30;
            lblEmailLogin.Text = "Email";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(28, 511);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(226, 23);
            dtpHireDate.TabIndex = 47;
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = Color.White;
            txtFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(28, 44);
            txtFirstname.MaxLength = 50;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(200, 27);
            txtFirstname.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(28, 202);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "auto-generated";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 50;
            // 
            // lblTitleSelect
            // 
            lblTitleSelect.AutoSize = true;
            lblTitleSelect.BackColor = SystemColors.GradientInactiveCaption;
            lblTitleSelect.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleSelect.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitleSelect.Location = new Point(29, 443);
            lblTitleSelect.Name = "lblTitleSelect";
            lblTitleSelect.Size = new Size(60, 13);
            lblTitleSelect.TabIndex = 59;
            lblTitleSelect.Text = "Select title";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(28, 74);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(57, 13);
            lblFirstname.TabIndex = 57;
            lblFirstname.Text = "Firstname";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(28, 178);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 61;
            lblEmail.Text = "Email";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI", 8.25F);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(253, 74);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 51;
            lblLastname.Text = "Lastname";
            // 
            // txtLastname
            // 
            txtLastname.BackColor = Color.White;
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(253, 44);
            txtLastname.MaxLength = 50;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(200, 27);
            txtLastname.TabIndex = 39;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitle.Location = new Point(28, 393);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 64;
            lblTitle.Text = "Title";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(28, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 63;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(28, 97);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 55;
            lblPhone.Text = "Phone number";
            // 
            // lblInvalidDate
            // 
            lblInvalidDate.AutoSize = true;
            lblInvalidDate.BackColor = SystemColors.GradientInactiveCaption;
            lblInvalidDate.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInvalidDate.ForeColor = Color.OrangeRed;
            lblInvalidDate.Location = new Point(29, 537);
            lblInvalidDate.Name = "lblInvalidDate";
            lblInvalidDate.Size = new Size(111, 13);
            lblInvalidDate.TabIndex = 52;
            lblInvalidDate.Text = "Invalid date selection!";
            // 
            // lblPhoneMain
            // 
            lblPhoneMain.AutoSize = true;
            lblPhoneMain.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneMain.Font = new Font("Segoe UI", 8.25F);
            lblPhoneMain.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneMain.Location = new Point(28, 151);
            lblPhoneMain.Name = "lblPhoneMain";
            lblPhoneMain.Size = new Size(151, 13);
            lblPhoneMain.TabIndex = 53;
            lblPhoneMain.Text = "Enter 8-digit phone number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(28, 121);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 40;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(253, 343);
            txtCity.MaxLength = 50;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 27);
            txtCity.TabIndex = 43;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(28, 248);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 54;
            lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = SystemColors.GradientInactiveCaption;
            lblCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblCity.Location = new Point(253, 318);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(38, 21);
            lblCity.TabIndex = 65;
            lblCity.Text = "City";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.BackColor = SystemColors.GradientInactiveCaption;
            lblHireDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHireDate.ForeColor = Color.FromArgb(45, 93, 134);
            lblHireDate.Location = new Point(28, 487);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(78, 21);
            lblHireDate.TabIndex = 49;
            lblHireDate.Text = "Hire date";
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(28, 318);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 60;
            lblPostal.Text = "Postal code";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(28, 272);
            txtAddress.MaxLength = 50;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(425, 27);
            txtAddress.TabIndex = 41;
            // 
            // txtPostal
            // 
            txtPostal.BackColor = Color.White;
            txtPostal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostal.Location = new Point(28, 343);
            txtPostal.MaxLength = 50;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(94, 27);
            txtPostal.TabIndex = 42;
            // 
            // AdminCreateSecretary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(483, 759);
            Controls.Add(cboxTitles);
            Controls.Add(btnCreate);
            Controls.Add(btnToday);
            Controls.Add(pnlLogin);
            Controls.Add(dtpHireDate);
            Controls.Add(txtFirstname);
            Controls.Add(txtEmail);
            Controls.Add(lblTitleSelect);
            Controls.Add(lblFirstname);
            Controls.Add(lblEmail);
            Controls.Add(lblLastname);
            Controls.Add(txtLastname);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(lblPhone);
            Controls.Add(lblInvalidDate);
            Controls.Add(lblPhoneMain);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(lblAddress);
            Controls.Add(lblCity);
            Controls.Add(lblHireDate);
            Controls.Add(lblPostal);
            Controls.Add(txtAddress);
            Controls.Add(txtPostal);
            Name = "AdminCreateSecretary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCreateSecretary";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxTitles;
        private FontAwesome.Sharp.IconButton btnCreate;
        private Button btnToday;
        private Panel pnlLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmailLogin;
        private Label lblEmailLogin;
        private DateTimePicker dtpHireDate;
        private TextBox txtFirstname;
        private TextBox txtEmail;
        private Label lblTitleSelect;
        private Label lblFirstname;
        private Label lblEmail;
        private Label lblLastname;
        private TextBox txtLastname;
        private Label lblTitle;
        private Label lblName;
        private Label lblPhone;
        private Label lblInvalidDate;
        private Label lblPhoneMain;
        private TextBox txtPhone;
        private TextBox txtCity;
        private Label lblAddress;
        private Label lblCity;
        private Label lblHireDate;
        private Label lblPostal;
        private TextBox txtAddress;
        private TextBox txtPostal;
    }
}