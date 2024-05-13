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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
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
            txtFirstname.TabIndex = 12;
            // 
            // txtLastname
            // 
            txtLastname.BackColor = Color.White;
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(253, 37);
            txtLastname.MaxLength = 50;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(200, 27);
            txtLastname.TabIndex = 13;
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
            txtPhone.TabIndex = 16;
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
            txtAddress.TabIndex = 27;
            // 
            // txtPostal
            // 
            txtPostal.BackColor = Color.White;
            txtPostal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostal.Location = new Point(28, 336);
            txtPostal.MaxLength = 50;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(94, 27);
            txtPostal.TabIndex = 30;
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
            txtCity.TabIndex = 32;
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
            lblHireDate.Location = new Point(28, 527);
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
            lblSpeciality.Location = new Point(28, 457);
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
            dtpHireDate.Location = new Point(28, 551);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(230, 23);
            dtpHireDate.TabIndex = 33;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtEmailLogin);
            pnlLogin.Controls.Add(lblEmailLogin);
            pnlLogin.Location = new Point(12, 602);
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
            txtPassword.TabIndex = 31;
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
            lblInvalidDate.Location = new Point(29, 577);
            lblInvalidDate.Name = "lblInvalidDate";
            lblInvalidDate.Size = new Size(111, 13);
            lblInvalidDate.TabIndex = 22;
            lblInvalidDate.Text = "Invalid date selection!";
            // 
            // btnToday
            // 
            btnToday.Location = new Point(276, 551);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(61, 23);
            btnToday.TabIndex = 35;
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
            btnCreate.Location = new Point(152, 716);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(179, 50);
            btnCreate.TabIndex = 36;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(29, 410);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 37;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(29, 481);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(247, 410);
            button1.Name = "button1";
            button1.Size = new Size(61, 23);
            button1.TabIndex = 35;
            button1.Text = "Today";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(247, 481);
            button2.Name = "button2";
            button2.Size = new Size(61, 23);
            button2.TabIndex = 35;
            button2.Text = "Today";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminCUDLawyer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(483, 784);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnCreate);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnToday);
            Controls.Add(pnlLogin);
            Controls.Add(dtpHireDate);
            Controls.Add(txtFirstname);
            Controls.Add(txtEmail);
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
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
    }
}