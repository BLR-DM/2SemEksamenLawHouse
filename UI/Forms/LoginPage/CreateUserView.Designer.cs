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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserView));
            pboxEye = new FontAwesome.Sharp.IconPictureBox();
            lblCreate = new Label();
            lblName = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPostal = new Label();
            txtPostal = new TextBox();
            lblFirstname = new Label();
            lblLastname = new Label();
            pnlTop = new Panel();
            txtEmailConfirm = new TextBox();
            lblConfirmEmail = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPasswordConfirm = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            lblPhone = new Label();
            txtPhoneMain = new TextBox();
            lblPhoneMain = new Label();
            lblEmailEnter = new Label();
            lblCity = new Label();
            txtCity = new TextBox();
            pnlLoginInfo = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            lblPasswordEnter = new Label();
            btnCreate = new FontAwesome.Sharp.IconButton();
            lblCancel = new Label();
            Password = new ToolTip(components);
            txtPhoneAlt = new TextBox();
            lblAltPhone = new Label();
            lblAltPhonenumber = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            altPhone = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pboxEye).BeginInit();
            pnlLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
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
            pboxEye.Location = new Point(463, 106);
            pboxEye.Name = "pboxEye";
            pboxEye.Size = new Size(32, 32);
            pboxEye.SizeMode = PictureBoxSizeMode.AutoSize;
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
            lblName.Location = new Point(33, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Firstname";
            // 
            // txtFirstname
            // 
            txtFirstname.Anchor = AnchorStyles.Top;
            txtFirstname.BackColor = Color.White;
            txtFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(33, 145);
            txtFirstname.MaxLength = 50;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(230, 27);
            txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Top;
            txtLastname.BackColor = Color.White;
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(272, 145);
            txtLastname.MaxLength = 50;
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(230, 27);
            txtLastname.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(33, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(33, 225);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(33, 360);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top;
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(33, 385);
            txtAddress.MaxLength = 50;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(470, 27);
            txtAddress.TabIndex = 7;
            // 
            // lblPostal
            // 
            lblPostal.Anchor = AnchorStyles.Top;
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(33, 440);
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
            txtPostal.Location = new Point(33, 465);
            txtPostal.MaxLength = 50;
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(94, 27);
            txtPostal.TabIndex = 8;
            // 
            // lblFirstname
            // 
            lblFirstname.Anchor = AnchorStyles.Top;
            lblFirstname.AutoSize = true;
            lblFirstname.BackColor = SystemColors.GradientInactiveCaption;
            lblFirstname.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.ForeColor = Color.FromArgb(45, 93, 134);
            lblFirstname.Location = new Point(33, 175);
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
            lblLastname.Location = new Point(272, 175);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(55, 13);
            lblLastname.TabIndex = 4;
            lblLastname.Text = "Lastname";
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = SystemColors.GradientActiveCaption;
            pnlTop.Location = new Point(12, 12);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(520, 77);
            pnlTop.TabIndex = 8;
            // 
            // txtEmailConfirm
            // 
            txtEmailConfirm.Anchor = AnchorStyles.Top;
            txtEmailConfirm.BackColor = Color.White;
            txtEmailConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailConfirm.Location = new Point(273, 225);
            txtEmailConfirm.MaxLength = 50;
            txtEmailConfirm.Name = "txtEmailConfirm";
            txtEmailConfirm.Size = new Size(230, 27);
            txtEmailConfirm.TabIndex = 4;
            // 
            // lblConfirmEmail
            // 
            lblConfirmEmail.Anchor = AnchorStyles.Top;
            lblConfirmEmail.AutoSize = true;
            lblConfirmEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblConfirmEmail.Font = new Font("Segoe UI", 8.25F);
            lblConfirmEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblConfirmEmail.Location = new Point(272, 255);
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
            lblUsername.Location = new Point(17, 11);
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
            txtUsername.Location = new Point(16, 35);
            txtUsername.MaxLength = 50;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(231, 20);
            txtUsername.TabIndex = 0;
            txtUsername.TabStop = false;
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.BackColor = SystemColors.GradientInactiveCaption;
            lblPasswordConfirm.Font = new Font("Segoe UI", 8.25F);
            lblPasswordConfirm.ForeColor = Color.FromArgb(45, 93, 134);
            lblPasswordConfirm.Location = new Point(255, 139);
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
            lblPassword.Location = new Point(34, 605);
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
            txtPassword.Location = new Point(34, 629);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPasswordConfirm.BackColor = Color.White;
            txtPasswordConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordConfirm.Location = new Point(273, 629);
            txtPasswordConfirm.MaxLength = 50;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '•';
            txtPasswordConfirm.Size = new Size(200, 27);
            txtPasswordConfirm.TabIndex = 11;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top;
            lblPhone.AutoSize = true;
            lblPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhone.Location = new Point(33, 280);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 21);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone number";
            // 
            // txtPhoneMain
            // 
            txtPhoneMain.Anchor = AnchorStyles.Top;
            txtPhoneMain.BackColor = Color.White;
            txtPhoneMain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneMain.Location = new Point(33, 305);
            txtPhoneMain.MaxLength = 50;
            txtPhoneMain.Name = "txtPhoneMain";
            txtPhoneMain.Size = new Size(230, 27);
            txtPhoneMain.TabIndex = 5;
            // 
            // lblPhoneMain
            // 
            lblPhoneMain.Anchor = AnchorStyles.Top;
            lblPhoneMain.AutoSize = true;
            lblPhoneMain.BackColor = SystemColors.GradientInactiveCaption;
            lblPhoneMain.Font = new Font("Segoe UI", 8.25F);
            lblPhoneMain.ForeColor = Color.FromArgb(45, 93, 134);
            lblPhoneMain.Location = new Point(33, 335);
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
            lblEmailEnter.Location = new Point(33, 255);
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
            lblCity.Location = new Point(272, 440);
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
            txtCity.Location = new Point(272, 465);
            txtCity.MaxLength = 50;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(230, 27);
            txtCity.TabIndex = 9;
            // 
            // pnlLoginInfo
            // 
            pnlLoginInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLoginInfo.BackColor = Color.Transparent;
            pnlLoginInfo.Controls.Add(txtUsername);
            pnlLoginInfo.Controls.Add(iconPictureBox1);
            pnlLoginInfo.Controls.Add(pboxEye);
            pnlLoginInfo.Controls.Add(label1);
            pnlLoginInfo.Controls.Add(lblPasswordEnter);
            pnlLoginInfo.Controls.Add(lblPasswordConfirm);
            pnlLoginInfo.Controls.Add(lblUsername);
            pnlLoginInfo.Location = new Point(17, 521);
            pnlLoginInfo.Name = "pnlLoginInfo";
            pnlLoginInfo.Size = new Size(511, 168);
            pnlLoginInfo.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.None;
            iconPictureBox1.ForeColor = Color.FromArgb(45, 93, 134);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            iconPictureBox1.IconColor = Color.FromArgb(45, 93, 134);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(94, 84);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            Password.SetToolTip(iconPictureBox1, resources.GetString("iconPictureBox1.ToolTip"));
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI", 8.25F);
            label1.ForeColor = Color.FromArgb(45, 93, 134);
            label1.Location = new Point(16, 58);
            label1.Name = "label1";
            label1.Size = new Size(162, 13);
            label1.TabIndex = 4;
            label1.Text = "Username is the entered email";
            // 
            // lblPasswordEnter
            // 
            lblPasswordEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPasswordEnter.AutoSize = true;
            lblPasswordEnter.BackColor = SystemColors.GradientInactiveCaption;
            lblPasswordEnter.Font = new Font("Segoe UI", 8.25F);
            lblPasswordEnter.ForeColor = Color.FromArgb(45, 93, 134);
            lblPasswordEnter.Location = new Point(16, 139);
            lblPasswordEnter.Name = "lblPasswordEnter";
            lblPasswordEnter.Size = new Size(87, 13);
            lblPasswordEnter.TabIndex = 4;
            lblPasswordEnter.Text = "Enter password";
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
            btnCreate.Location = new Point(168, 723);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(209, 50);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // lblCancel
            // 
            lblCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCancel.AutoSize = true;
            lblCancel.BackColor = SystemColors.GradientInactiveCaption;
            lblCancel.Cursor = Cursors.Hand;
            lblCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCancel.ForeColor = Color.FromArgb(45, 93, 134);
            lblCancel.Location = new Point(55, 739);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(58, 21);
            lblCancel.TabIndex = 0;
            lblCancel.Text = "Cancel";
            // 
            // Password
            // 
            Password.ToolTipIcon = ToolTipIcon.Info;
            Password.ToolTipTitle = "Password";
            // 
            // txtPhoneAlt
            // 
            txtPhoneAlt.Anchor = AnchorStyles.Top;
            txtPhoneAlt.BackColor = Color.White;
            txtPhoneAlt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneAlt.Location = new Point(272, 305);
            txtPhoneAlt.MaxLength = 50;
            txtPhoneAlt.Name = "txtPhoneAlt";
            txtPhoneAlt.Size = new Size(230, 27);
            txtPhoneAlt.TabIndex = 6;
            // 
            // lblAltPhone
            // 
            lblAltPhone.Anchor = AnchorStyles.Top;
            lblAltPhone.AutoSize = true;
            lblAltPhone.BackColor = SystemColors.GradientInactiveCaption;
            lblAltPhone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAltPhone.ForeColor = Color.FromArgb(45, 93, 134);
            lblAltPhone.Location = new Point(272, 280);
            lblAltPhone.Name = "lblAltPhone";
            lblAltPhone.Size = new Size(141, 21);
            lblAltPhone.TabIndex = 4;
            lblAltPhone.Text = "Alternative phone";
            // 
            // lblAltPhonenumber
            // 
            lblAltPhonenumber.Anchor = AnchorStyles.Top;
            lblAltPhonenumber.AutoSize = true;
            lblAltPhonenumber.BackColor = SystemColors.GradientInactiveCaption;
            lblAltPhonenumber.Font = new Font("Segoe UI", 8.25F);
            lblAltPhonenumber.ForeColor = Color.FromArgb(45, 93, 134);
            lblAltPhonenumber.Location = new Point(273, 335);
            lblAltPhonenumber.Name = "lblAltPhonenumber";
            lblAltPhonenumber.Size = new Size(141, 13);
            lblAltPhonenumber.TabIndex = 4;
            lblAltPhonenumber.Text = "Additional phone number";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.BackgroundImageLayout = ImageLayout.None;
            iconPictureBox2.ForeColor = Color.FromArgb(45, 93, 134);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            iconPictureBox2.IconColor = Color.FromArgb(45, 93, 134);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 25;
            iconPictureBox2.Location = new Point(413, 280);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(25, 25);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            altPhone.SetToolTip(iconPictureBox2, "Additional phone numbers can be added\r\nafter account creation in the 'My Page' section.");
            // 
            // CreateUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(544, 805);
            ControlBox = false;
            Controls.Add(btnCreate);
            Controls.Add(iconPictureBox2);
            Controls.Add(txtLastname);
            Controls.Add(txtCity);
            Controls.Add(txtPostal);
            Controls.Add(txtAddress);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(txtEmailConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneAlt);
            Controls.Add(txtPhoneMain);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstname);
            Controls.Add(lblCity);
            Controls.Add(lblPostal);
            Controls.Add(lblAddress);
            Controls.Add(lblCreate);
            Controls.Add(lblCancel);
            Controls.Add(lblPassword);
            Controls.Add(lblAltPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblAltPhonenumber);
            Controls.Add(lblPhoneMain);
            Controls.Add(lblEmailEnter);
            Controls.Add(lblConfirmEmail);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(lblName);
            Controls.Add(pnlTop);
            Controls.Add(pnlLoginInfo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateUserView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pboxEye).EndInit();
            pnlLoginInfo.ResumeLayout(false);
            pnlLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox pboxEye;
        private Label lblCreate;
        private Label lblName;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPostal;
        private TextBox txtPostal;
        private Label lblFirstname;
        private Label lblLastname;
        private Panel pnlTop;
        private TextBox txtEmailConfirm;
        private Label lblConfirmEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPasswordConfirm;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Label lblPhone;
        private TextBox txtPhoneMain;
        private Label lblPhoneMain;
        private Label lblEmailEnter;
        private Label lblCity;
        private TextBox txtCity;
        private Panel pnlLoginInfo;
        private FontAwesome.Sharp.IconButton btnCreate;
        private Label lblCancel;
        private Label lblPasswordEnter;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ToolTip Password;
        private Label label1;
        private TextBox txtPhoneAlt;
        private Label lblAltPhone;
        private Label lblAltPhonenumber;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private ToolTip altPhone;
    }
}