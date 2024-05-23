using BusinessLogic;
using UI.Forms.CreateUserPage;
using UI.Forms.FrontPage;
using BusinessLogic.Validation;


namespace UI.Forms.LoginPage
{
    public partial class LoginPageView : Form
    {
        LoginBL loginBL;
        PersonValidator pValidator;

        public LoginPageView()
        {
            loginBL = new LoginBL();
            pValidator = new PersonValidator();

            InitializeComponent();

            btnLogin.Enabled = false;
            lblPasswordError.Visible = false;
            lblUsernameError.Visible = false;

            btnClose.Click += BtnClose_Click;
            pboxEye.Click += PBoxEye_Click;
            btnLogin.Click += BtnLogin_Click;
            lblRegister.Click += LblRegister_Click;
            lblForgotPassword.Click += LblForgotPassword_Click;
            txtUsername.TextChanged += TxtUsername_TextChanged;
            txtPassword.TextChanged += TxtPassword_TextChanged;
        }

        private void TxtPassword_TextChanged(object? sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 3)
            {
                bool isPasswordValid = pValidator.ValidPassword(txtPassword.Text);
                lblPasswordError.Visible = !isPasswordValid; 
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
                lblUsernameError.Visible = false;

            UpdateLoginButton();
        }

        private void TxtUsername_TextChanged(object? sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 4)
            {
                bool isEmailValid = pValidator.ValidEmail(txtUsername.Text);
                lblUsernameError.Visible = !isEmailValid; 
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
                lblUsernameError.Visible = false;

            UpdateLoginButton();
        }

        private void UpdateLoginButton()
        {
            btnLogin.Enabled = pValidator.ValidEmail(txtUsername.Text) 
                && pValidator.ValidPassword(txtPassword.Text);
        }

        private void LblForgotPassword_Click(object? sender, EventArgs e)
        {
            new ForgotPasswordView(loginBL).ShowDialog();
        }

        private void LblRegister_Click(object? sender, EventArgs e)
        {
            this.Hide();
            new CreateUserView(this).ShowDialog();
        }

        public void GetCreatedUsername(string username)
        {
            txtUsername.Text = username;
        }

        private async void BtnLogin_Click(object? sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            try
            {
                int userID = await loginBL.CheckUsernameAndPasswordAsync(txtUsername.Text, txtPassword.Text);

                if (userID > 0)
                {
                    new FrontPageView(userID).Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogin.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to log in. Please try again later, or contact Support.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLogin.Enabled = true;
            }
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
