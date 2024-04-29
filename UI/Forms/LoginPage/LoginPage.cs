using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.LoginPage
{
    public partial class LoginPage : Form
    {
        bool success;
        Color rgbColorBlue;

        public LoginPage()
        {
            success = false;
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            InitializeComponent();
            Load += FormLoginPage_Load;
            StartPosition = FormStartPosition.CenterScreen;
            btnClose.Click += BtnClose_Click;
            pBoxEye.Click += PBoxEye_Click;

            // Close button prop
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconSize = 30;

            // Icons
            pBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            pBoxUser.IconColor = rgbColorBlue;
            pnlLineUser.BackColor = rgbColorBlue;
            pBoxPassword.IconChar = FontAwesome.Sharp.IconChar.UnlockKeyhole;
            pnlLinePassword.BackColor = rgbColorBlue;
            btnLogin.BackColor = rgbColorBlue;
            btnLogin.ForeColor = Color.White;
            pBoxEye.IconColor = rgbColorBlue;
            pBoxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
            tBoxPassword.PasswordChar = '\u2022'; // Unicode for bullet point (•)           

        }

        private void FormLoginPage_Load(object? sender, EventArgs e)
        {

        }

        private void PBoxEye_Click(object? sender, EventArgs e)
        {
            HideShowPassword();
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideShowPassword()
        {
            if (pBoxEye.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                pBoxEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                tBoxPassword.PasswordChar = '\0';
            }
            else
            {
                pBoxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                tBoxPassword.PasswordChar = '\u2022';
            }
        }
    }
}
