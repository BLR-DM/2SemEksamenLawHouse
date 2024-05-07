namespace UI.Forms.ClientPage
{
    partial class CreateClientView
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
            btnCreate = new FontAwesome.Sharp.IconButton();
            txtLastname = new TextBox();
            txtPostal = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFirstname = new TextBox();
            lblPostal = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblPhoneMain = new Label();
            label2 = new Label();
            lblLastname = new Label();
            lblFirstname = new Label();
            lblName = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            rtxtPhoneNumbers = new RichTextBox();
            lblPhoneNumbersView = new Label();
            lblAddressView = new Label();
            lblEmailView = new Label();
            lblNameView = new Label();
            lblUsernameView = new Label();
            label7 = new Label();
            btnAddPhone = new FontAwesome.Sharp.IconButton();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblOptional = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnCreate.Location = new Point(599, 508);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(254, 50);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // txtLastname
            // 
            txtLastname.BackColor = Color.White;
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(259, 54);
            txtLastname.MaxLength = 50;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(200, 27);
            txtLastname.TabIndex = 13;
            // 
            // txtPostal
            // 
            txtPostal.BackColor = Color.White;
            txtPostal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostal.Location = new Point(34, 444);
            txtPostal.MaxLength = 50;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(94, 27);
            txtPostal.TabIndex = 30;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(34, 380);
            txtAddress.MaxLength = 50;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(425, 27);
            txtAddress.TabIndex = 27;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(34, 229);
            txtPhone.MaxLength = 50;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(34, 143);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtFirstname
            // 
            txtFirstname.BackColor = Color.White;
            txtFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(34, 54);
            txtFirstname.MaxLength = 50;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(200, 27);
            txtFirstname.TabIndex = 12;
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(34, 419);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 26;
            lblPostal.Text = "Postal code";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(34, 356);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 23;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(34, 205);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 24;
            lblPhone.Text = "Phone number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(34, 119);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // lblPhoneMain
            // 
            lblPhoneMain.AutoSize = true;
            lblPhoneMain.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneMain.Font = new Font("Segoe UI", 8.25F);
            lblPhoneMain.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneMain.Location = new Point(34, 259);
            lblPhoneMain.Name = "lblPhoneMain";
            lblPhoneMain.Size = new Size(151, 13);
            lblPhoneMain.TabIndex = 22;
            lblPhoneMain.Text = "Enter 8-digit phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 8.25F);
            label2.ForeColor = Color.FromArgb(45, 93, 134);
            label2.Location = new Point(34, 173);
            label2.Name = "label2";
            label2.Size = new Size(64, 13);
            label2.TabIndex = 20;
            label2.Text = "Enter email";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI", 8.25F);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(259, 84);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 18;
            lblLastname.Text = "Lastname";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(34, 84);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(57, 13);
            lblFirstname.TabIndex = 25;
            lblFirstname.Text = "Firstname";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(34, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 29;
            lblName.Text = "Firstname";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(259, 444);
            txtCity.MaxLength = 50;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(200, 27);
            txtCity.TabIndex = 32;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = SystemColors.GradientInactiveCaption;
            lblCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblCity.Location = new Point(259, 419);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(38, 21);
            lblCity.TabIndex = 31;
            lblCity.Text = "City";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(rtxtPhoneNumbers);
            panel2.Controls.Add(lblPhoneNumbersView);
            panel2.Controls.Add(lblAddressView);
            panel2.Controls.Add(lblEmailView);
            panel2.Controls.Add(lblNameView);
            panel2.Location = new Point(507, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 248);
            panel2.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(45, 93, 134);
            label4.Location = new Point(16, 97);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 40;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(45, 93, 134);
            label3.Location = new Point(16, 53);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 39;
            label3.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 38;
            label1.Text = "Firstname:";
            // 
            // rtxtPhoneNumbers
            // 
            rtxtPhoneNumbers.Location = new Point(192, 141);
            rtxtPhoneNumbers.Name = "rtxtPhoneNumbers";
            rtxtPhoneNumbers.Size = new Size(183, 83);
            rtxtPhoneNumbers.TabIndex = 35;
            rtxtPhoneNumbers.Text = "";
            // 
            // lblPhoneNumbersView
            // 
            lblPhoneNumbersView.AutoSize = true;
            lblPhoneNumbersView.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneNumbersView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhoneNumbersView.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneNumbersView.Location = new Point(16, 139);
            lblPhoneNumbersView.Name = "lblPhoneNumbersView";
            lblPhoneNumbersView.Size = new Size(127, 21);
            lblPhoneNumbersView.TabIndex = 34;
            lblPhoneNumbersView.Text = "Phone Numbers";
            // 
            // lblAddressView
            // 
            lblAddressView.AutoSize = true;
            lblAddressView.BackColor = SystemColors.GradientInactiveCaption;
            lblAddressView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddressView.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddressView.Location = new Point(96, 97);
            lblAddressView.Name = "lblAddressView";
            lblAddressView.Size = new Size(38, 21);
            lblAddressView.TabIndex = 34;
            lblAddressView.Text = "test";
            // 
            // lblEmailView
            // 
            lblEmailView.AutoSize = true;
            lblEmailView.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmailView.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmailView.Location = new Point(96, 53);
            lblEmailView.Name = "lblEmailView";
            lblEmailView.Size = new Size(38, 21);
            lblEmailView.TabIndex = 34;
            lblEmailView.Text = "test";
            // 
            // lblNameView
            // 
            lblNameView.AutoSize = true;
            lblNameView.BackColor = SystemColors.GradientInactiveCaption;
            lblNameView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNameView.ForeColor = Color.FromArgb(45, 93, 134);
            lblNameView.Location = new Point(96, 11);
            lblNameView.Name = "lblNameView";
            lblNameView.Size = new Size(38, 21);
            lblNameView.TabIndex = 34;
            lblNameView.Text = "test";
            // 
            // lblUsernameView
            // 
            lblUsernameView.AutoSize = true;
            lblUsernameView.BackColor = SystemColors.GradientInactiveCaption;
            lblUsernameView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsernameView.ForeColor = Color.FromArgb(45, 93, 134);
            lblUsernameView.Location = new Point(617, 382);
            lblUsernameView.Name = "lblUsernameView";
            lblUsernameView.Size = new Size(38, 21);
            lblUsernameView.TabIndex = 35;
            lblUsernameView.Text = "test";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Segoe UI", 8.25F);
            label7.ForeColor = Color.FromArgb(45, 93, 134);
            label7.Location = new Point(240, 259);
            label7.Name = "label7";
            label7.Size = new Size(28, 13);
            label7.TabIndex = 37;
            label7.Text = "Add";
            // 
            // btnAddPhone
            // 
            btnAddPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPhone.BackgroundImageLayout = ImageLayout.Center;
            btnAddPhone.Cursor = Cursors.Hand;
            btnAddPhone.FlatAppearance.BorderSize = 0;
            btnAddPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPhone.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAddPhone.IconColor = Color.Black;
            btnAddPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddPhone.IconSize = 25;
            btnAddPhone.Location = new Point(240, 228);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(28, 28);
            btnAddPhone.TabIndex = 38;
            btnAddPhone.TabStop = false;
            btnAddPhone.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(739, 444);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(208, 27);
            txtConfirmPassword.TabIndex = 39;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(524, 444);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 27);
            txtPassword.TabIndex = 40;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.GradientInactiveCaption;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblPassword.Location = new Point(524, 419);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 41;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = SystemColors.GradientInactiveCaption;
            lblConfirmPassword.Font = new Font("Segoe UI", 8.25F);
            lblConfirmPassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblConfirmPassword.Location = new Point(739, 474);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(101, 13);
            lblConfirmPassword.TabIndex = 42;
            lblConfirmPassword.Text = "Confirm password";
            // 
            // lblOptional
            // 
            lblOptional.AutoSize = true;
            lblOptional.BackColor = SystemColors.GradientInactiveCaption;
            lblOptional.Font = new Font("Segoe UI", 8.25F);
            lblOptional.ForeColor = Color.FromArgb(45, 93, 134);
            lblOptional.Location = new Point(524, 474);
            lblOptional.Name = "lblOptional";
            lblOptional.Size = new Size(53, 13);
            lblOptional.TabIndex = 43;
            lblOptional.Text = "Optional";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 93, 134);
            label5.Location = new Point(524, 382);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 44;
            label5.Text = "Username:";
            // 
            // CreateClientView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(982, 574);
            Controls.Add(label5);
            Controls.Add(lblOptional);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(btnAddPhone);
            Controls.Add(lblUsernameView);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtLastname);
            Controls.Add(txtPostal);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstname);
            Controls.Add(lblPostal);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneMain);
            Controls.Add(label2);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(lblName);
            Controls.Add(btnCreate);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateClientView";
            Text = "CreateClientPage";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCreate;
        private TextBox txtLastname;
        private TextBox txtPostal;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFirstname;
        private Label lblPostal;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblPhoneMain;
        private Label label2;
        private Label lblLastname;
        private Label lblFirstname;
        private Label lblName;
        private TextBox txtCity;
        private Label lblCity;
        private Panel panel2;
        private Label lblAddressView;
        private Label lblPhoneNumbersView;
        private Label lblEmailView;
        private Label lblNameView;
        private Label lblUsernameView;
        private Label label7;
        private RichTextBox rtxtPhoneNumbers;
        private FontAwesome.Sharp.IconButton btnAddPhone;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblOptional;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
    }
}