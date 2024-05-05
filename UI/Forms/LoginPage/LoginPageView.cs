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
        }

        private void LblRegister_Click(object? sender, EventArgs e)
        {
            new CreateUserView(this).Show();
            Hide();
        }

        private async void BtnLogin_Click(object? sender, EventArgs e)
        {
            bool test = await loginBL.CheckUsernameAsync(txtUsername.Text);

            if (!test)
            {
                MessageBox.Show("Username doesn't exist!");
                return;
            }

            int result = await loginBL.CheckUsernameAndPasswordAsync(txtUsername.Text, txtPassword.Text);

            if (result == 0)
            {
                MessageBox.Show("Wrong password!");
                return;
            }
            // if negativ = exception

            new FrontPageView(result).Show();
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
