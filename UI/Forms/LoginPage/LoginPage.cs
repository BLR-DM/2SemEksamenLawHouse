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
        Color rgbColorBlue;

        public LoginPage()
        {
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            InitializeComponent();
            Load += FormLoginPage_Load;            
            btnClose.Click += BtnClose_Click;
            pBoxEye.Click += PBoxEye_Click;
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
                tBoxPassword.PasswordChar = '\0'; // Default password char
            }
            else
            {
                pBoxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                tBoxPassword.PasswordChar = '\u2022'; // Unicode for bullet point '•'
            }
        }
    }
}
