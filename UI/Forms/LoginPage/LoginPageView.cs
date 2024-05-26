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

            // Deaktiver Login knap og errors
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
                // Valider kodeord format
                bool isPasswordValid = pValidator.ValidPassword(txtPassword.Text);
                lblPasswordError.Visible = !isPasswordValid; // Vis kodeord fejl-besked ved ikke valid format
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
                lblUsernameError.Visible = false;

            UpdateLoginButton();
        }

        private void TxtUsername_TextChanged(object? sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 4)
            {
                // Valider email format
                bool isEmailValid = pValidator.ValidEmail(txtUsername.Text);
                lblUsernameError.Visible = !isEmailValid; // Vis username fejl-besked ved ikke valid format
            }

            if (string.IsNullOrEmpty(txtUsername.Text)) 
                lblUsernameError.Visible = false;

            UpdateLoginButton();
        }

        private void UpdateLoginButton()
        {
            // Aktiver Login knap, hvis både email og kodeord er valid format
            btnLogin.Enabled = pValidator.ValidEmail(txtUsername.Text) 
                && pValidator.ValidPassword(txtPassword.Text);
        }

        private void LblForgotPassword_Click(object? sender, EventArgs e)
        {
            new ForgotPasswordView(loginBL, pValidator).ShowDialog(); // Simluering af glemt kodeord funktion
        }

        private void LblRegister_Click(object? sender, EventArgs e)
        {
            this.Hide();
            new CreateUserView(this, pValidator).ShowDialog(); // Åbn "opret bruger form" inkl. denne form
        }

        // public metode, så den kan kaldes efter oprettelse af bruger
        public void GetCreatedUsername(string username)
        {
            txtUsername.Text = username;
        }

        private async void BtnLogin_Click(object? sender, EventArgs e)
        {
            // Deaktiver Login knap, så det ikke er muligt at spamme knappen ved Login forsøg
            btnLogin.Enabled = false;

            // Returner LoginDetailsID og tjek for korrekt loginoplysninger
            int userID = await loginBL.CheckUsernameAndPasswordAsync(txtUsername.Text, txtPassword.Text);

            if (userID > 0)
            {
                new FrontPageView(userID).Show(); // Åbn programmets main page og medtag ID'et på bruger
                Hide();
            }
            else
            {
                // Neutral besked ved forkert loginoplysninger, for at undlade at informere brugeren om
                // brugernavn/email eksisterer i systemet
                MessageBox.Show("Invalid username or password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnLogin.Enabled = true; // Aktiver knap efter lukning af MessageBox
            }
        }

        private void PBoxEye_Click(object? sender, EventArgs e) // Skjul visning af brugerens kodeord
        {
            if (pboxEye.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.PasswordChar = '\0'; // Deaktiver funktionen
            }
            else
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.PasswordChar = '\u2022'; // Unicode for "bullet point" karakteren '•'
            }
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
