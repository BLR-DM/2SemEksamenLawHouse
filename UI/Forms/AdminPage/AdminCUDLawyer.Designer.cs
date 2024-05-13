namespace UI.Forms.AdminPage
{
    partial class AdminCUDLawyer
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
            lblFirstname = new Label();
            lblLastname = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            lblName = new Label();
            lblPhoneMain = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            lblPostal = new Label();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblOptional = new Label();
            lblHireDate = new Label();
            lblTitle = new Label();
            lblSpeciality = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            dtpHireDate = new DateTimePicker();
            pnlLogin = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmailLogin = new TextBox();
            lblEmailLogin = new Label();
            lblInvalidDate = new Label();
            btnToday = new Button();
            btnCreate = new FontAwesome.Sharp.IconButton();
            cboxTitles = new ComboBox();
            cboxSpecialities = new ComboBox();
            btnAddSpeciality = new Button();
            lboxSpecialities = new ListBox();
            btnRemoveSpeciality = new Button();
            lblAddedSpecialities = new Label();
            lblTitleSelect = new Label();
            label1 = new Label();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(28, 67);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(57, 13);
            lblFirstname.TabIndex = 25;
            lblFirstname.Text = "Firstname";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI", 8.25F);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(253, 67);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 18;
            lblLastname.Text = "Lastname";
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = Color.White;
            txtFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(28, 37);
            txtFirstname.MaxLength = 50;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(200, 27);
            txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            txtLastname.BackColor = Color.White;
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(253, 37);
            txtLastname.MaxLength = 50;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(200, 27);
            txtLastname.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(28, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 29;
            lblName.Text = "Name";
            // 
            // lblPhoneMain
            // 
            lblPhoneMain.AutoSize = true;
            lblPhoneMain.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneMain.Font = new Font("Segoe UI", 8.25F);
            lblPhoneMain.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneMain.Location = new Point(28, 144);
            lblPhoneMain.Name = "lblPhoneMain";
            lblPhoneMain.Size = new Size(151, 13);
            lblPhoneMain.TabIndex = 22;
            lblPhoneMain.Text = "Enter 8-digit phone number";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(28, 90);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 24;
            lblPhone.Text = "Phone number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(28, 114);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(28, 241);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 23;
            lblAddress.Text = "Address";
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(28, 311);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 26;
            lblPostal.Text = "Postal code";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(28, 265);
            txtAddress.MaxLength = 50;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(425, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtPostal
            // 
            txtPostal.BackColor = Color.White;
            txtPostal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostal.Location = new Point(28, 336);
            txtPostal.MaxLength = 50;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(94, 27);
            txtPostal.TabIndex = 5;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = SystemColors.GradientInactiveCaption;
            lblCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblCity.Location = new Point(253, 311);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(38, 21);
            lblCity.TabIndex = 31;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(253, 336);
            txtCity.MaxLength = 50;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 27);
            txtCity.TabIndex = 6;
            // 
            // lblOptional
            // 
            lblOptional.AutoSize = true;
            lblOptional.BackColor = SystemColors.GradientInactiveCaption;
            lblOptional.Font = new Font("Segoe UI", 8.25F);
            lblOptional.ForeColor = Color.FromArgb(45, 93, 134);
            lblOptional.Location = new Point(240, 69);
            lblOptional.Name = "lblOptional";
            lblOptional.Size = new Size(53, 13);
            lblOptional.TabIndex = 43;
            lblOptional.Text = "Optional";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.BackColor = SystemColors.GradientInactiveCaption;
            lblHireDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHireDate.ForeColor = Color.FromArgb(45, 93, 134);
            lblHireDate.Location = new Point(28, 549);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(78, 21);
            lblHireDate.TabIndex = 13;
            lblHireDate.Text = "Hire date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.GradientInactiveCaption;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitle.Location = new Point(28, 386);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 29;
            lblTitle.Text = "Title";
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.BackColor = SystemColors.GradientInactiveCaption;
            lblSpeciality.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSpeciality.ForeColor = Color.FromArgb(45, 93, 134);
            lblSpeciality.Location = new Point(28, 462);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(92, 21);
            lblSpeciality.TabIndex = 29;
            lblSpeciality.Text = "Specialities";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(28, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(28, 195);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "auto-generated";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 17;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(28, 573);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(226, 23);
            dtpHireDate.TabIndex = 10;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtEmailLogin);
            pnlLogin.Controls.Add(lblEmailLogin);
            pnlLogin.Location = new Point(12, 624);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(459, 93);
            pnlLogin.TabIndex = 34;
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
            // lblInvalidDate
            // 
            lblInvalidDate.AutoSize = true;
            lblInvalidDate.BackColor = SystemColors.GradientInactiveCaption;
            lblInvalidDate.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInvalidDate.ForeColor = Color.OrangeRed;
            lblInvalidDate.Location = new Point(29, 599);
            lblInvalidDate.Name = "lblInvalidDate";
            lblInvalidDate.Size = new Size(111, 13);
            lblInvalidDate.TabIndex = 22;
            lblInvalidDate.Text = "Invalid date selection!";
            // 
            // btnToday
            // 
            btnToday.Location = new Point(270, 573);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(61, 23);
            btnToday.TabIndex = 0;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
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
            btnCreate.Location = new Point(152, 742);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 50);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // cboxTitles
            // 
            cboxTitles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTitles.FormattingEnabled = true;
            cboxTitles.Location = new Point(29, 410);
            cboxTitles.Name = "cboxTitles";
            cboxTitles.Size = new Size(200, 23);
            cboxTitles.TabIndex = 7;
            // 
            // cboxSpecialities
            // 
            cboxSpecialities.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSpecialities.FormattingEnabled = true;
            cboxSpecialities.Location = new Point(29, 486);
            cboxSpecialities.Name = "cboxSpecialities";
            cboxSpecialities.Size = new Size(200, 23);
            cboxSpecialities.TabIndex = 8;
            // 
            // btnAddSpeciality
            // 
            btnAddSpeciality.Location = new Point(170, 512);
            btnAddSpeciality.Name = "btnAddSpeciality";
            btnAddSpeciality.Size = new Size(58, 23);
            btnAddSpeciality.TabIndex = 9;
            btnAddSpeciality.Text = "Add >>";
            btnAddSpeciality.TextAlign = ContentAlignment.MiddleRight;
            btnAddSpeciality.UseVisualStyleBackColor = true;
            // 
            // lboxSpecialities
            // 
            lboxSpecialities.FormattingEnabled = true;
            lboxSpecialities.ItemHeight = 15;
            lboxSpecialities.Location = new Point(253, 460);
            lboxSpecialities.Name = "lboxSpecialities";
            lboxSpecialities.Size = new Size(201, 49);
            lboxSpecialities.TabIndex = 0;
            // 
            // btnRemoveSpeciality
            // 
            btnRemoveSpeciality.Location = new Point(253, 512);
            btnRemoveSpeciality.Name = "btnRemoveSpeciality";
            btnRemoveSpeciality.Size = new Size(78, 23);
            btnRemoveSpeciality.TabIndex = 0;
            btnRemoveSpeciality.Text = "<< Remove";
            btnRemoveSpeciality.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveSpeciality.UseVisualStyleBackColor = true;
            // 
            // lblAddedSpecialities
            // 
            lblAddedSpecialities.AutoSize = true;
            lblAddedSpecialities.BackColor = SystemColors.GradientInactiveCaption;
            lblAddedSpecialities.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddedSpecialities.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddedSpecialities.Location = new Point(253, 444);
            lblAddedSpecialities.Name = "lblAddedSpecialities";
            lblAddedSpecialities.Size = new Size(100, 13);
            lblAddedSpecialities.TabIndex = 25;
            lblAddedSpecialities.Text = "Added specialities";
            // 
            // lblTitleSelect
            // 
            lblTitleSelect.AutoSize = true;
            lblTitleSelect.BackColor = SystemColors.GradientInactiveCaption;
            lblTitleSelect.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleSelect.ForeColor = Color.FromArgb(45, 93, 134);
            lblTitleSelect.Location = new Point(29, 436);
            lblTitleSelect.Name = "lblTitleSelect";
            lblTitleSelect.Size = new Size(60, 13);
            lblTitleSelect.TabIndex = 25;
            lblTitleSelect.Text = "Select title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(29, 512);
            label1.Name = "label1";
            label1.Size = new Size(87, 13);
            label1.TabIndex = 25;
            label1.Text = "Add specialities";
            // 
            // AdminCUDLawyer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(483, 815);
            Controls.Add(lboxSpecialities);
            Controls.Add(cboxSpecialities);
            Controls.Add(cboxTitles);
            Controls.Add(btnCreate);
            Controls.Add(btnRemoveSpeciality);
            Controls.Add(btnAddSpeciality);
            Controls.Add(btnToday);
            Controls.Add(pnlLogin);
            Controls.Add(dtpHireDate);
            Controls.Add(txtFirstname);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(lblTitleSelect);
            Controls.Add(lblAddedSpecialities);
            Controls.Add(lblFirstname);
            Controls.Add(lblEmail);
            Controls.Add(lblLastname);
            Controls.Add(txtLastname);
            Controls.Add(lblSpeciality);
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
            Name = "AdminCUDLawyer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCUDLawyer";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstname;
        private Label lblLastname;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private Label lblName;
        private Label lblPhoneMain;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private Label lblPostal;
        private TextBox txtAddress;
        private TextBox txtPostal;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblOptional;
        private Label label2;
        private Label lblHireDate;
        private Label lblTitle;
        private Label lblSpeciality;
        private Label lblEmail;
        private TextBox txtEmail;
        private DateTimePicker dtpHireDate;
        private Panel pnlLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtEmailLogin;
        private Label lblEmailLogin;
        private Label lblInvalidDate;
        private Button btnToday;
        private FontAwesome.Sharp.IconButton btnCreate;
        private ComboBox cboxTitles;
        private ComboBox cboxSpecialities;
        private Button btnAddSpeciality;
        private ListBox lboxSpecialities;
        private Button btnRemoveSpeciality;
        private Label lblAddedSpecialities;
        private Label lblTitleSelect;
        private Label label1;
    }
}