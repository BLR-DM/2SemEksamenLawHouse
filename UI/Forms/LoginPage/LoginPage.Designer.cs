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
        pboxLogo = new PictureBox();
        btnClose = new FontAwesome.Sharp.IconButton();
        pboxUser = new FontAwesome.Sharp.IconPictureBox();
        pnlLineUser = new Panel();
        lblUser = new Label();
        pboxPassword = new FontAwesome.Sharp.IconPictureBox();
        lblPassword = new Label();
        pnlLinePassword = new Panel();
        lblLogin = new Label();
        btnLogin = new FontAwesome.Sharp.IconButton();
        tboxUser = new TextBox();
        tboxPassword = new TextBox();
        pboxEye = new FontAwesome.Sharp.IconPictureBox();
        ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pboxUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pboxPassword).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pboxEye).BeginInit();
        SuspendLayout();
        // 
        // pboxLogo
        // 
        pboxLogo.Anchor = AnchorStyles.Top;
        pboxLogo.Image = Properties.Resources.lawhouseLogo;
        pboxLogo.Location = new Point(139, 101);
        pboxLogo.Name = "pboxLogo";
        pboxLogo.Size = new Size(266, 73);
        pboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
        pboxLogo.TabIndex = 0;
        pboxLogo.TabStop = false;
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
        pboxUser.Location = new Point(36, 347);
        pboxUser.Name = "pboxUser";
        pboxUser.Size = new Size(48, 48);
        pboxUser.SizeMode = PictureBoxSizeMode.Zoom;
        pboxUser.TabIndex = 2;
        pboxUser.TabStop = false;
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
        // pboxPassword
        // 
        pboxPassword.BackColor = SystemColors.GradientInactiveCaption;
        pboxPassword.ForeColor = Color.FromArgb(45, 93, 134);
        pboxPassword.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
        pboxPassword.IconColor = Color.FromArgb(45, 93, 134);
        pboxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pboxPassword.IconSize = 48;
        pboxPassword.Location = new Point(36, 484);
        pboxPassword.Name = "pboxPassword";
        pboxPassword.Size = new Size(48, 48);
        pboxPassword.SizeMode = PictureBoxSizeMode.Zoom;
        pboxPassword.TabIndex = 2;
        pboxPassword.TabStop = false;
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
        // tboxUser
        // 
        tboxUser.BackColor = SystemColors.GradientInactiveCaption;
        tboxUser.BorderStyle = BorderStyle.None;
        tboxUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tboxUser.Location = new Point(97, 369);
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
        tboxPassword.Location = new Point(97, 507);
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
        pboxEye.ForeColor = Color.FromArgb(45, 93, 134);
        pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
        pboxEye.IconColor = Color.FromArgb(45, 93, 134);
        pboxEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
        pboxEye.IconSize = 40;
        pboxEye.Location = new Point(467, 492);
        pboxEye.Name = "pboxEye";
        pboxEye.Size = new Size(40, 40);
        pboxEye.TabIndex = 7;
        pboxEye.TabStop = false;
        // 
        // LoginPage
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.GradientInactiveCaption;
        ClientSize = new Size(544, 805);
        ControlBox = false;
        Controls.Add(pboxEye);
        Controls.Add(tboxPassword);
        Controls.Add(tboxUser);
        Controls.Add(btnLogin);
        Controls.Add(lblPassword);
        Controls.Add(lblLogin);
        Controls.Add(lblUser);
        Controls.Add(pnlLinePassword);
        Controls.Add(pnlLineUser);
        Controls.Add(pboxPassword);
        Controls.Add(pboxUser);
        Controls.Add(btnClose);
        Controls.Add(pboxLogo);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginPage";
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
        ((System.ComponentModel.ISupportInitialize)pboxUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)pboxPassword).EndInit();
        ((System.ComponentModel.ISupportInitialize)pboxEye).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pboxLogo;
    private FontAwesome.Sharp.IconButton btnClose;
    private FontAwesome.Sharp.IconPictureBox pboxUser;
    private Panel pnlLineUser;
    private Label lblUser;
    private FontAwesome.Sharp.IconPictureBox pboxPassword;
    private Label lblPassword;
    private Panel pnlLinePassword;
    private Label lblLogin;
    private FontAwesome.Sharp.IconButton btnLogin;
    private TextBox tboxUser;
    private TextBox tboxPassword;
    private FontAwesome.Sharp.IconPictureBox pboxEye;
}
