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
            btnClose = new FontAwesome.Sharp.IconButton();
            pboxUser = new FontAwesome.Sharp.IconPictureBox();
            pboxPassword = new FontAwesome.Sharp.IconPictureBox();
            pnlLineUser = new Panel();
            pnlLinePassword = new Panel();
            lblUser = new Label();
            lblPassword = new Label();
            tboxUser = new TextBox();
            tboxPassword = new TextBox();
            pboxEye = new FontAwesome.Sharp.IconPictureBox();
            lblCreate = new Label();
            lblName = new Label();
            tboxFirstname = new TextBox();
            tboxLastname = new TextBox();
            lblEmail = new Label();
            textBox1 = new TextBox();
            lblAddress = new Label();
            textBox2 = new TextBox();
            lblPostal = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pboxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxEye).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(499, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 28);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pboxUser
            // 
            pboxUser.BackColor = SystemColors.GradientInactiveCaption;
            pboxUser.ForeColor = Color.FromArgb(45, 93, 134);
            pboxUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            pboxUser.IconColor = Color.FromArgb(45, 93, 134);
            pboxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxUser.IconSize = 48;
            pboxUser.Location = new Point(31, 557);
            pboxUser.Name = "pboxUser";
            pboxUser.Size = new Size(48, 48);
            pboxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pboxUser.TabIndex = 2;
            pboxUser.TabStop = false;
            // 
            // pboxPassword
            // 
            pboxPassword.BackColor = SystemColors.GradientInactiveCaption;
            pboxPassword.ForeColor = Color.FromArgb(45, 93, 134);
            pboxPassword.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            pboxPassword.IconColor = Color.FromArgb(45, 93, 134);
            pboxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxPassword.IconSize = 48;
            pboxPassword.Location = new Point(31, 694);
            pboxPassword.Name = "pboxPassword";
            pboxPassword.Size = new Size(48, 48);
            pboxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pboxPassword.TabIndex = 2;
            pboxPassword.TabStop = false;
            // 
            // pnlLineUser
            // 
            pnlLineUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLineUser.BackColor = Color.FromArgb(45, 93, 134);
            pnlLineUser.Location = new Point(32, 608);
            pnlLineUser.Name = "pnlLineUser";
            pnlLineUser.Size = new Size(471, 3);
            pnlLineUser.TabIndex = 3;
            // 
            // pnlLinePassword
            // 
            pnlLinePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLinePassword.BackColor = Color.FromArgb(45, 93, 134);
            pnlLinePassword.Location = new Point(32, 745);
            pnlLinePassword.Name = "pnlLinePassword";
            pnlLinePassword.Size = new Size(471, 3);
            pnlLinePassword.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.GradientInactiveCaption;
            lblUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(45, 93, 134);
            lblUser.Location = new Point(85, 545);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(98, 25);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.GradientInactiveCaption;
            lblPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblPassword.Location = new Point(85, 682);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // tboxUser
            // 
            tboxUser.BackColor = SystemColors.GradientInactiveCaption;
            tboxUser.BorderStyle = BorderStyle.None;
            tboxUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxUser.Location = new Point(92, 579);
            tboxUser.MaxLength = 50;
            tboxUser.Name = "tboxUser";
            tboxUser.PlaceholderText = "Email address";
            tboxUser.Size = new Size(321, 20);
            tboxUser.TabIndex = 1;
            // 
            // tboxPassword
            // 
            tboxPassword.BackColor = SystemColors.GradientInactiveCaption;
            tboxPassword.BorderStyle = BorderStyle.None;
            tboxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxPassword.Location = new Point(92, 717);
            tboxPassword.MaxLength = 50;
            tboxPassword.Name = "tboxPassword";
            tboxPassword.PasswordChar = '•';
            tboxPassword.PlaceholderText = "Password";
            tboxPassword.Size = new Size(321, 20);
            tboxPassword.TabIndex = 2;
            // 
            // pboxEye
            // 
            pboxEye.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pboxEye.BackColor = SystemColors.GradientInactiveCaption;
            pboxEye.Cursor = Cursors.Hand;
            pboxEye.ForeColor = Color.FromArgb(45, 93, 134);
            pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            pboxEye.IconColor = Color.FromArgb(45, 93, 134);
            pboxEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pboxEye.IconSize = 40;
            pboxEye.Location = new Point(462, 702);
            pboxEye.Name = "pboxEye";
            pboxEye.Size = new Size(40, 40);
            pboxEye.TabIndex = 7;
            pboxEye.TabStop = false;
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top;
            lblCreate.AutoSize = true;
            lblCreate.BackColor = SystemColors.GradientInactiveCaption;
            lblCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreate.ForeColor = Color.FromArgb(45, 93, 134);
            lblCreate.Location = new Point(207, 34);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(131, 25);
            lblCreate.TabIndex = 4;
            lblCreate.Text = "CREATE USER";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.GradientInactiveCaption;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 93, 134);
            lblName.Location = new Point(33, 131);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // tboxFirstname
            // 
            tboxFirstname.BackColor = Color.White;
            tboxFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxFirstname.Location = new Point(33, 155);
            tboxFirstname.MaxLength = 50;
            tboxFirstname.Name = "tboxFirstname";
            tboxFirstname.PlaceholderText = "First";
            tboxFirstname.Size = new Size(200, 27);
            tboxFirstname.TabIndex = 1;
            // 
            // tboxLastname
            // 
            tboxLastname.BackColor = Color.White;
            tboxLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tboxLastname.Location = new Point(317, 155);
            tboxLastname.MaxLength = 50;
            tboxLastname.Name = "tboxLastname";
            tboxLastname.PlaceholderText = "Last";
            tboxLastname.Size = new Size(185, 27);
            tboxLastname.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(33, 206);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(33, 230);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 27);
            textBox1.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(45, 93, 134);
            lblAddress.Location = new Point(33, 281);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 21);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(33, 305);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(470, 27);
            textBox2.TabIndex = 4;
            // 
            // lblPostal
            // 
            lblPostal.AutoSize = true;
            lblPostal.BackColor = SystemColors.GradientInactiveCaption;
            lblPostal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPostal.ForeColor = Color.FromArgb(45, 93, 134);
            lblPostal.Location = new Point(33, 356);
            lblPostal.Name = "lblPostal";
            lblPostal.Size = new Size(94, 21);
            lblPostal.TabIndex = 4;
            lblPostal.Text = "Postal code";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(33, 380);
            textBox3.MaxLength = 50;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 27);
            textBox3.TabIndex = 5;
            // 
            // CreateUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(544, 805);
            ControlBox = false;
            Controls.Add(pboxEye);
            Controls.Add(btnClose);
            Controls.Add(tboxPassword);
            Controls.Add(pboxUser);
            Controls.Add(tboxLastname);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tboxFirstname);
            Controls.Add(tboxUser);
            Controls.Add(pboxPassword);
            Controls.Add(pnlLineUser);
            Controls.Add(lblPostal);
            Controls.Add(pnlLinePassword);
            Controls.Add(lblAddress);
            Controls.Add(lblCreate);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblUser);
            Controls.Add(lblPassword);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateUserView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pboxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconPictureBox pboxUser;
        private FontAwesome.Sharp.IconPictureBox pboxPassword;
        private Panel pnlLineUser;
        private Panel pnlLinePassword;
        private Label lblUser;
        private Label lblPassword;
        private TextBox tboxUser;
        private TextBox tboxPassword;
        private FontAwesome.Sharp.IconPictureBox pboxEye;
        private Label lblCreate;
        private Label lblName;
        private TextBox tboxFirstname;
        private TextBox tboxLastname;
        private Label lblEmail;
        private TextBox textBox1;
        private Label lblAddress;
        private TextBox textBox2;
        private Label lblPostal;
        private TextBox textBox3;
    }
}