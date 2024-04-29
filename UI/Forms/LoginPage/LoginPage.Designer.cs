using System.Windows.Forms;

namespace UI.Forms.LoginPage;

partial class LoginPage
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pBoxLogo = new PictureBox();
        btnClose = new FontAwesome.Sharp.IconButton();
        pBoxUser = new FontAwesome.Sharp.IconPictureBox();
        pnlLineUser = new Panel();
        lblUser = new Label();
        pBoxPassword = new FontAwesome.Sharp.IconPictureBox();
        lblPassword = new Label();
        pnlLinePassword = new Panel();
        lblLogin = new Label();
        btnLogin = new FontAwesome.Sharp.IconButton();
        tBoxUser = new TextBox();
        tBoxPassword = new TextBox();
        pBoxEye = new FontAwesome.Sharp.IconPictureBox();
        ((System.ComponentModel.ISupportInitialize)pBoxLogo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pBoxUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pBoxPassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pBoxEye).BeginInit();
        SuspendLayout();
        // 
        // pBoxLogo
        // 
        pBoxLogo.Anchor = AnchorStyles.Top;
        pBoxLogo.Image = Properties.Resources.lawhouseLogo;
        pBoxLogo.Location = new Point(139, 101);
        pBoxLogo.Name = "pBoxLogo";
        pBoxLogo.Size = new Size(266, 73);
        pBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pBoxLogo.TabIndex = 0;
        pBoxLogo.TabStop = false;
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
        // pBoxUser
        // 
        pBoxUser.BackColor = SystemColors.GradientInactiveCaption;
        pBoxUser.ForeColor = Color.FromArgb(45, 93, 134);
        pBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
        pBoxUser.IconColor = Color.FromArgb(45, 93, 134);
        pBoxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pBoxUser.IconSize = 48;
        pBoxUser.Location = new Point(36, 347);
        pBoxUser.Name = "pBoxUser";
        pBoxUser.Size = new Size(48, 48);
        pBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
        pBoxUser.TabIndex = 2;
        pBoxUser.TabStop = false;
        // 
        // pnlLineUser
        // 
        pnlLineUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlLineUser.BackColor = Color.FromArgb(45, 93, 134);
        pnlLineUser.Location = new Point(37, 398);
        pnlLineUser.Name = "pnlLineUser";
        pnlLineUser.Size = new Size(471, 3);
        pnlLineUser.TabIndex = 3;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.BackColor = SystemColors.GradientInactiveCaption;
        lblUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblUser.ForeColor = Color.FromArgb(45, 93, 134);
        lblUser.Location = new Point(90, 335);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(98, 25);
        lblUser.TabIndex = 4;
        lblUser.Text = "Username";
        // 
        // pBoxPassword
        // 
        pBoxPassword.BackColor = SystemColors.GradientInactiveCaption;
        pBoxPassword.ForeColor = Color.FromArgb(45, 93, 134);
        pBoxPassword.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
        pBoxPassword.IconColor = Color.FromArgb(45, 93, 134);
        pBoxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pBoxPassword.IconSize = 48;
        pBoxPassword.Location = new Point(36, 484);
        pBoxPassword.Name = "pBoxPassword";
        pBoxPassword.Size = new Size(48, 48);
        pBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
        pBoxPassword.TabIndex = 2;
        pBoxPassword.TabStop = false;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.BackColor = SystemColors.GradientInactiveCaption;
        lblPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPassword.ForeColor = Color.FromArgb(45, 93, 134);
        lblPassword.Location = new Point(90, 472);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(91, 25);
        lblPassword.TabIndex = 4;
        lblPassword.Text = "Password";
        // 
        // pnlLinePassword
        // 
        pnlLinePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pnlLinePassword.BackColor = Color.FromArgb(45, 93, 134);
        pnlLinePassword.Location = new Point(37, 535);
        pnlLinePassword.Name = "pnlLinePassword";
        pnlLinePassword.Size = new Size(471, 3);
        pnlLinePassword.TabIndex = 3;
        // 
        // lblLogin
        // 
        lblLogin.Anchor = AnchorStyles.Top;
        lblLogin.AutoSize = true;
        lblLogin.BackColor = SystemColors.GradientInactiveCaption;
        lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblLogin.ForeColor = Color.FromArgb(45, 93, 134);
        lblLogin.Location = new Point(234, 194);
        lblLogin.Name = "lblLogin";
        lblLogin.Size = new Size(76, 25);
        lblLogin.TabIndex = 4;
        lblLogin.Text = "LOG IN";
        // 
        // btnLogin
        // 
        btnLogin.Anchor = AnchorStyles.Bottom;
        btnLogin.BackColor = Color.FromArgb(45, 93, 134);
        btnLogin.FlatAppearance.BorderSize = 0;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
        btnLogin.ForeColor = Color.White;
        btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
        btnLogin.IconColor = Color.Black;
        btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
        btnLogin.IconSize = 70;
        btnLogin.Location = new Point(196, 670);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(152, 50);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        // 
        // tBoxUser
        // 
        tBoxUser.BackColor = SystemColors.GradientInactiveCaption;
        tBoxUser.BorderStyle = BorderStyle.None;
        tBoxUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tBoxUser.Location = new Point(97, 369);
        tBoxUser.MaxLength = 50;
        tBoxUser.Name = "tBoxUser";
        tBoxUser.PlaceholderText = "Email address";
        tBoxUser.Size = new Size(321, 20);
        tBoxUser.TabIndex = 1;
        // 
        // tBoxPassword
        // 
        tBoxPassword.BackColor = SystemColors.GradientInactiveCaption;
        tBoxPassword.BorderStyle = BorderStyle.None;
        tBoxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tBoxPassword.Location = new Point(97, 507);
        tBoxPassword.MaxLength = 50;
        tBoxPassword.Name = "tBoxPassword";
        tBoxPassword.PasswordChar = '•';
        tBoxPassword.PlaceholderText = "Password";
        tBoxPassword.Size = new Size(321, 20);
        tBoxPassword.TabIndex = 2;
        // 
        // pBoxEye
        // 
        pBoxEye.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pBoxEye.BackColor = SystemColors.GradientInactiveCaption;
        pBoxEye.ForeColor = Color.FromArgb(45, 93, 134);
        pBoxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
        pBoxEye.IconColor = Color.FromArgb(45, 93, 134);
        pBoxEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pBoxEye.IconSize = 40;
        pBoxEye.Location = new Point(467, 492);
        pBoxEye.Name = "pBoxEye";
        pBoxEye.Size = new Size(40, 40);
        pBoxEye.TabIndex = 7;
        pBoxEye.TabStop = false;
        // 
        // LoginPage
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        ClientSize = new Size(544, 805);
        ControlBox = false;
        Controls.Add(pBoxEye);
        Controls.Add(tBoxPassword);
        Controls.Add(tBoxUser);
        Controls.Add(btnLogin);
        Controls.Add(lblPassword);
        Controls.Add(lblLogin);
        Controls.Add(lblUser);
        Controls.Add(pnlLinePassword);
        Controls.Add(pnlLineUser);
        Controls.Add(pBoxPassword);
        Controls.Add(pBoxUser);
        Controls.Add(btnClose);
        Controls.Add(pBoxLogo);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginPage";
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)pBoxLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)pBoxUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)pBoxPassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)pBoxEye).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pBoxLogo;
    private FontAwesome.Sharp.IconButton btnClose;
    private FontAwesome.Sharp.IconPictureBox pBoxUser;
    private Panel pnlLineUser;
    private Label lblUser;
    private FontAwesome.Sharp.IconPictureBox pBoxPassword;
    private Label lblPassword;
    private Panel pnlLinePassword;
    private Label lblLogin;
    private FontAwesome.Sharp.IconButton btnLogin;
    private TextBox tBoxUser;
    private TextBox tBoxPassword;
    private FontAwesome.Sharp.IconPictureBox pBoxEye;
}
