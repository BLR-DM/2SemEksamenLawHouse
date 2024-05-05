using BusinessLogic;
using UI.Forms.CreateUserPage;
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.LoginPage
{
    public partial class LoginPageView : Form
    {
        Color rgbColorBlue;
        LoginBL loginBL;

        public LoginPageView()
        {
            loginBL = new LoginBL();

            rgbColorBlue = Color.FromArgb(45, 93, 134);

            InitializeComponent();    
            btnClose.Click += BtnClose_Click;
            pboxEye.Click += PBoxEye_Click;
            btnLogin.Click += BtnLogin_Click;
            lblRegister.Click += LblRegister_Click;
            lblForgotPassword.Click += LblForgotPassword_Click;
        }

        private void LblForgotPassword_Click(object? sender, EventArgs e)
        {
            new ForgotPasswordView(loginBL).ShowDialog();
        }

        private void LblRegister_Click(object? sender, EventArgs e)
        {
            new CreateUserView().ShowDialog();
        }

        private async void BtnLogin_Click(object? sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            bool userFound = await loginBL.CheckUsernameAsync(txtUsername.Text);

            if (!userFound)
            {
                MessageBox.Show("Username doesn't exist!");
                btnLogin.Enabled = true;
                return;
            }

            int userID = await loginBL.CheckUsernameAndPasswordAsync(txtUsername.Text, txtPassword.Text);

            if (userID == 0)
            {
                MessageBox.Show("Wrong password!");
                btnLogin.Enabled = true;
                return;
            }
            // if negativ = exception

            new FrontPageView(userID).Show();
            Hide();

            
            //if (!isMatch)
            //{
            //    MessageBox.Show("Wrong password!");
            //    return;
            //}

            //new FrontPageView().Show();
            //Hide();
        }

        private void PBoxEye_Click(object? sender, EventArgs e)
        {
            if (pboxEye.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.PasswordChar = '\0'; // Default password char
            }
            else
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.PasswordChar = '\u2022'; // Unicode for bullet point '•'
            }
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
