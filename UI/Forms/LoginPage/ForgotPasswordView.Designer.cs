namespace UI.Forms.LoginPage
{
    partial class ForgotPasswordView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordView));
            pnlTop = new Panel();
            lblRecoverPassword = new Label();
            lblCancel = new Label();
            lblContext = new Label();
            lblEmailEnter = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnRetrievePassword = new FontAwesome.Sharp.IconButton();
            pnlLineUser = new Panel();
            lblHelp = new Label();
            SuspendLayout();
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
            // lblRecoverPassword
            // 
            lblRecoverPassword.Anchor = AnchorStyles.Top;
            lblRecoverPassword.AutoSize = true;
            lblRecoverPassword.BackColor = SystemColors.GradientActiveCaption;
            lblRecoverPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecoverPassword.ForeColor = Color.FromArgb(45, 93, 134);
            lblRecoverPassword.Location = new Point(170, 39);
            lblRecoverPassword.Name = "lblRecoverPassword";
            lblRecoverPassword.Size = new Size(205, 25);
            lblRecoverPassword.TabIndex = 4;
            lblRecoverPassword.Text = "RECOVER PASSWORD";
            // 
            // lblCancel
            // 
            lblCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCancel.AutoSize = true;
            lblCancel.BackColor = SystemColors.GradientInactiveCaption;
            lblCancel.Cursor = Cursors.Hand;
            lblCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCancel.ForeColor = Color.FromArgb(45, 93, 134);
            lblCancel.Location = new Point(54, 419);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(58, 21);
            lblCancel.TabIndex = 0;
            lblCancel.Text = "Cancel";
            // 
            // lblContext
            // 
            lblContext.Anchor = AnchorStyles.Top;
            lblContext.AutoSize = true;
            lblContext.BackColor = SystemColors.GradientInactiveCaption;
            lblContext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblContext.ForeColor = Color.FromArgb(45, 93, 134);
            lblContext.Location = new Point(16, 118);
            lblContext.Name = "lblContext";
            lblContext.Size = new Size(512, 126);
            lblContext.TabIndex = 4;
            lblContext.Text = resources.GetString("lblContext.Text");
            // 
            // lblEmailEnter
            // 
            lblEmailEnter.Anchor = AnchorStyles.Top;
            lblEmailEnter.AutoSize = true;
            lblEmailEnter.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailEnter.Font = new Font("Segoe UI", 8.25F);
            lblEmailEnter.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmailEnter.Location = new Point(16, 355);
            lblEmailEnter.Name = "lblEmailEnter";
            lblEmailEnter.Size = new Size(64, 13);
            lblEmailEnter.TabIndex = 4;
            lblEmailEnter.Text = "Enter email";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.GradientInactiveCaption;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 93, 134);
            lblEmail.Location = new Point(16, 300);
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
            txtEmail.Location = new Point(16, 325);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(506, 27);
            txtEmail.TabIndex = 3;
            // 
            // btnRetrievePassword
            // 
            btnRetrievePassword.Anchor = AnchorStyles.Bottom;
            btnRetrievePassword.BackColor = Color.FromArgb(45, 93, 134);
            btnRetrievePassword.Cursor = Cursors.Hand;
            btnRetrievePassword.FlatAppearance.BorderSize = 0;
            btnRetrievePassword.FlatStyle = FlatStyle.Flat;
            btnRetrievePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRetrievePassword.ForeColor = Color.White;
            btnRetrievePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRetrievePassword.IconColor = Color.Black;
            btnRetrievePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRetrievePassword.IconSize = 70;
            btnRetrievePassword.Location = new Point(168, 403);
            btnRetrievePassword.Name = "btnRetrievePassword";
            btnRetrievePassword.Size = new Size(209, 50);
            btnRetrievePassword.TabIndex = 12;
            btnRetrievePassword.Text = "Retrieve Password";
            btnRetrievePassword.UseVisualStyleBackColor = false;
            // 
            // pnlLineUser
            // 
            pnlLineUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLineUser.BackColor = Color.FromArgb(45, 93, 134);
            pnlLineUser.Location = new Point(18, 273);
            pnlLineUser.Name = "pnlLineUser";
            pnlLineUser.Size = new Size(504, 3);
            pnlLineUser.TabIndex = 3;
            // 
            // lblHelp
            // 
            lblHelp.AutoSize = true;
            lblHelp.Cursor = Cursors.Hand;
            lblHelp.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHelp.ForeColor = Color.DarkBlue;
            lblHelp.Location = new Point(466, 463);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new Size(66, 15);
            lblHelp.TabIndex = 54;
            lblHelp.Tag = "RecoverPasswordViewHelp";
            lblHelp.Text = "Need help?";
            // 
            // ForgotPasswordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(544, 487);
            ControlBox = false;
            Controls.Add(lblHelp);
            Controls.Add(lblRecoverPassword);
            Controls.Add(btnRetrievePassword);
            Controls.Add(pnlTop);
            Controls.Add(lblCancel);
            Controls.Add(lblContext);
            Controls.Add(txtEmail);
            Controls.Add(lblEmailEnter);
            Controls.Add(lblEmail);
            Controls.Add(pnlLineUser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPasswordView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblRecoverPassword;
        private Label lblCancel;
        private Label lblContext;
        private Label lblEmailEnter;
        private Label lblEmail;
        private TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnRetrievePassword;
        private Panel pnlLineUser;
        private Label lblHelp;
    }
}