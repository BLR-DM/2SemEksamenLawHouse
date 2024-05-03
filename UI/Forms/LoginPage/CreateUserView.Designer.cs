namespace UI.Forms.CreateUserPage
{
    partial class CreateUserView
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
            pboxEye = new FontAwesome.Sharp.IconPictureBox();
            lblCreate = new Label();
            lblName = new Label();
            tboxFirstname = new TextBox();
            tboxLastname = new TextBox();
            lblEmail = new Label();
            tboxEmail = new TextBox();
            lblAddress = new Label();
            tboxAddress = new TextBox();
            lblPostal = new Label();
            txtPostal = new TextBox();
            lblFirstname = new Label();
            lblLastname = new Label();
            panel1 = new Panel();
            tboxEmailConfirm = new TextBox();
            lblConfirmEmail = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPasswordConfirm = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            lblPhone = new Label();
            tboxPhoneMain = new TextBox();
            tboxPhoneAlt = new TextBox();
            lblPhoneAlt = new Label();
            lblPhoneMain = new Label();
            lblEmailEnter = new Label();
            lblCity = new Label();
            txtCity = new TextBox();
            pnlLine = new Panel();
            btnCreate = new FontAwesome.Sharp.IconButton();
            lblCancel = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxEye).BeginInit();
            pnlLine.SuspendLayout();
            SuspendLayout();
            // 
            // pboxEye
            // 
            pboxEye.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pboxEye.BackColor = SystemColors.GradientInactiveCaption;
            pboxEye.Cursor = Cursors.Hand;
            pboxEye.ForeColor = Color.FromArgb(45, 93, 134);
            pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            pboxEye.IconColor = Color.FromArgb(45, 93, 134);
            pboxEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxEye.IconSize = 40;
            pboxEye.Location = new Point(457, 96);
            pboxEye.Name = "pboxEye";
            pboxEye.Size = new Size(40, 40);
            pboxEye.TabIndex = 7;
            pboxEye.TabStop = false;
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top;
            lblCreate.AutoSize = true;
            lblCreate.BackColor = SystemColors.GradientActiveCaption;
            lblCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreate.Location = new Point(207, 39);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(131, 25);
            lblCreate.TabIndex = 4;
            lblCreate.Text = "CREATE USER";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(33, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // tboxFirstname
            // 
            tboxFirstname.Anchor = AnchorStyles.Top;
            tboxFirstname.BackColor = Color.White;
            tboxFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxFirstname.Location = new Point(33, 150);
            tboxFirstname.MaxLength = 50;
            tboxFirstname.Name = "tboxFirstname";
            tboxFirstname.Size = new Size(230, 27);
            tboxFirstname.TabIndex = 1;
            // 
            // tboxLastname
            // 
            tboxLastname.Anchor = AnchorStyles.Top;
            tboxLastname.BackColor = Color.White;
            tboxLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxLastname.Location = new Point(272, 150);
            tboxLastname.MaxLength = 50;
            tboxLastname.Name = "tboxLastname";
            tboxLastname.Size = new Size(230, 27);
            tboxLastname.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(33, 205);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // tboxEmail
            // 
            tboxEmail.Anchor = AnchorStyles.Top;
            tboxEmail.BackColor = Color.White;
            tboxEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxEmail.Location = new Point(33, 230);
            tboxEmail.MaxLength = 50;
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(230, 27);
            tboxEmail.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(33, 365);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // tboxAddress
            // 
            tboxAddress.Anchor = AnchorStyles.Top;
            tboxAddress.BackColor = Color.White;
            tboxAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxAddress.Location = new Point(33, 390);
            tboxAddress.MaxLength = 50;
            tboxAddress.Name = "tboxAddress";
            tboxAddress.Size = new Size(470, 27);
            tboxAddress.TabIndex = 4;
            // 
            // lblPostal
            // 
            lblPostal.Anchor = AnchorStyles.Top;
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(33, 445);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 4;
            lblPostal.Text = "Postal code";
            // 
            // txtPostal
            // 
            txtPostal.Anchor = AnchorStyles.Top;
            txtPostal.BackColor = Color.White;
            txtPostal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostal.Location = new Point(33, 470);
            txtPostal.MaxLength = 50;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(94, 27);
            txtPostal.TabIndex = 5;
            // 
            // lblFirstname
            // 
            lblFirstname.Anchor = AnchorStyles.Top;
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(33, 180);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(57, 13);
            lblFirstname.TabIndex = 4;
            lblFirstname.Text = "Firstname";
            // 
            // lblLastname
            // 
            lblLastname.Anchor = AnchorStyles.Top;
            lblLastname.AutoSize = true;
            lblLastname.BackColor = SystemColors.GradientInactiveCaption;
            lblLastname.Font = new Font("Segoe UI", 8.25F);
            lblLastname.ForeColor = Color.FromArgb(45, 93, 134);
            lblLastname.Location = new Point(272, 180);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 4;
            lblLastname.Text = "Lastname";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 77);
            panel1.TabIndex = 8;
            // 
            // tboxEmailConfirm
            // 
            tboxEmailConfirm.Anchor = AnchorStyles.Top;
            tboxEmailConfirm.BackColor = Color.White;
            tboxEmailConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxEmailConfirm.Location = new Point(273, 230);
            tboxEmailConfirm.MaxLength = 50;
            tboxEmailConfirm.Name = "tboxEmailConfirm";
            tboxEmailConfirm.Size = new Size(230, 27);
            tboxEmailConfirm.TabIndex = 3;
            // 
            // lblConfirmEmail
            // 
            lblConfirmEmail.Anchor = AnchorStyles.Top;
            lblConfirmEmail.AutoSize = true;
            lblConfirmEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblConfirmEmail.Font = new Font("Segoe UI", 8.25F);
            lblConfirmEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblConfirmEmail.Location = new Point(272, 260);
            lblConfirmEmail.Name = "lblConfirmEmail";
            lblConfirmEmail.Size = new Size(78, 13);
            lblConfirmEmail.TabIndex = 4;
            lblConfirmEmail.Text = "Confirm email";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.GradientInactiveCaption;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(45, 93, 134);
            lblUsername.Location = new Point(33, 550);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 21);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtUsername.BackColor = SystemColors.GradientActiveCaption;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(34, 574);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(231, 20);
            txtUsername.TabIndex = 1;
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.BackColor = SystemColors.GradientInactiveCaption;
            lblPasswordConfirm.Font = new Font("Segoe UI", 8.25F);
            lblPasswordConfirm.ForeColor = Color.FromArgb(45, 93, 134);
            lblPasswordConfirm.Location = new Point(264, 131);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(101, 13);
            lblPasswordConfirm.TabIndex = 4;
            lblPasswordConfirm.Text = "Confirm password";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.GradientInactiveCaption;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblPassword.Location = new Point(34, 616);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(34, 640);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPasswordConfirm.BackColor = Color.White;
            txtPasswordConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordConfirm.Location = new Point(273, 640);
            txtPasswordConfirm.MaxLength = 50;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(186, 27);
            txtPasswordConfirm.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top;
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(33, 285);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone number";
            // 
            // tboxPhoneMain
            // 
            tboxPhoneMain.Anchor = AnchorStyles.Top;
            tboxPhoneMain.BackColor = Color.White;
            tboxPhoneMain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxPhoneMain.Location = new Point(33, 310);
            tboxPhoneMain.MaxLength = 50;
            tboxPhoneMain.Name = "tboxPhoneMain";
            tboxPhoneMain.Size = new Size(230, 27);
            tboxPhoneMain.TabIndex = 3;
            // 
            // tboxPhoneAlt
            // 
            tboxPhoneAlt.Anchor = AnchorStyles.Top;
            tboxPhoneAlt.BackColor = Color.White;
            tboxPhoneAlt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxPhoneAlt.Location = new Point(272, 310);
            tboxPhoneAlt.MaxLength = 50;
            tboxPhoneAlt.Name = "tboxPhoneAlt";
            tboxPhoneAlt.Size = new Size(230, 27);
            tboxPhoneAlt.TabIndex = 3;
            // 
            // lblPhoneAlt
            // 
            lblPhoneAlt.Anchor = AnchorStyles.Top;
            lblPhoneAlt.AutoSize = true;
            lblPhoneAlt.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneAlt.Font = new Font("Segoe UI", 8.25F);
            lblPhoneAlt.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneAlt.Location = new Point(272, 340);
            lblPhoneAlt.Name = "lblPhoneAlt";
            lblPhoneAlt.Size = new Size(142, 13);
            lblPhoneAlt.TabIndex = 4;
            lblPhoneAlt.Text = "Alternative phone number";
            // 
            // lblPhoneMain
            // 
            lblPhoneMain.Anchor = AnchorStyles.Top;
            lblPhoneMain.AutoSize = true;
            lblPhoneMain.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneMain.Font = new Font("Segoe UI", 8.25F);
            lblPhoneMain.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneMain.Location = new Point(33, 340);
            lblPhoneMain.Name = "lblPhoneMain";
            lblPhoneMain.Size = new Size(151, 13);
            lblPhoneMain.TabIndex = 4;
            lblPhoneMain.Text = "Enter 8-digit phone number";
            // 
            // lblEmailEnter
            // 
            lblEmailEnter.Anchor = AnchorStyles.Top;
            lblEmailEnter.AutoSize = true;
            lblEmailEnter.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailEnter.Font = new Font("Segoe UI", 8.25F);
            lblEmailEnter.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmailEnter.Location = new Point(33, 260);
            lblEmailEnter.Name = "lblEmailEnter";
            lblEmailEnter.Size = new Size(64, 13);
            lblEmailEnter.TabIndex = 4;
            lblEmailEnter.Text = "Enter email";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Top;
            lblCity.AutoSize = true;
            lblCity.BackColor = SystemColors.GradientInactiveCaption;
            lblCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(45, 93, 134);
            lblCity.Location = new Point(272, 445);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(38, 21);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Top;
            txtCity.BackColor = Color.White;
            txtCity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(272, 470);
            txtCity.MaxLength = 50;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(230, 27);
            txtCity.TabIndex = 5;
            // 
            // pnlLine
            // 
            pnlLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLine.BackColor = Color.Transparent;
            pnlLine.BorderStyle = BorderStyle.FixedSingle;
            pnlLine.Controls.Add(pboxEye);
            pnlLine.Controls.Add(lblPasswordConfirm);
            pnlLine.Location = new Point(16, 538);
            pnlLine.Name = "pnlLine";
            pnlLine.Size = new Size(516, 162);
            pnlLine.TabIndex = 3;
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
            btnCreate.Location = new Point(168, 728);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(209, 50);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // lblCancel
            // 
            lblCancel.Anchor = AnchorStyles.Bottom;
            lblCancel.AutoSize = true;
            lblCancel.BackColor = SystemColors.GradientInactiveCaption;
            lblCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCancel.ForeColor = Color.FromArgb(45, 93, 134);
            lblCancel.Location = new Point(55, 744);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(58, 21);
            lblCancel.TabIndex = 4;
            lblCancel.Text = "Cancel";
            // 
            // CreateUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(544, 805);
            ControlBox = false;
            Controls.Add(txtUsername);
            Controls.Add(btnCreate);
            Controls.Add(tboxLastname);
            Controls.Add(txtCity);
            Controls.Add(txtPostal);
            Controls.Add(tboxAddress);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(tboxPhoneAlt);
            Controls.Add(tboxEmailConfirm);
            Controls.Add(txtPassword);
            Controls.Add(tboxPhoneMain);
            Controls.Add(tboxEmail);
            Controls.Add(tboxFirstname);
            Controls.Add(lblCity);
            Controls.Add(lblPostal);
            Controls.Add(lblAddress);
            Controls.Add(lblCreate);
            Controls.Add(lblCancel);
            Controls.Add(lblPassword);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneMain);
            Controls.Add(lblPhoneAlt);
            Controls.Add(lblEmailEnter);
            Controls.Add(lblConfirmEmail);
            Controls.Add(lblLastname);
            Controls.Add(lblUsername);
            Controls.Add(lblFirstname);
            Controls.Add(lblName);
            Controls.Add(panel1);
            Controls.Add(pnlLine);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateUserView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pboxEye).EndInit();
            pnlLine.ResumeLayout(false);
            pnlLine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox pboxEye;
        private Label lblCreate;
        private Label lblName;
        private TextBox tboxFirstname;
        private TextBox tboxLastname;
        private Label lblEmail;
        private TextBox tboxEmail;
        private Label lblAddress;
        private TextBox tboxAddress;
        private Label lblPostal;
        private TextBox txtPostal;
        private Label lblFirstname;
        private Label lblLastname;
        private Panel panel1;
        private TextBox tboxEmailConfirm;
        private Label lblConfirmEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPasswordConfirm;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Label lblPhone;
        private TextBox tboxPhoneMain;
        private TextBox tboxPhoneAlt;
        private Label lblPhoneAlt;
        private Label lblPhoneMain;
        private Label lblEmailEnter;
        private Label lblCity;
        private TextBox txtCity;
        private Panel pnlLine;
        private FontAwesome.Sharp.IconButton btnCreate;
        private Label lblCancel;
    }
}