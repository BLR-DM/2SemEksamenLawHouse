﻿using BusinessLogic;
using UI.Forms.CreateUserPage;
using UI.Forms.FrontPage;
using BusinessLogic.Validation;
using BusinessLogic.HelpServices;

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

            // Deaktiver Login knap og fejl-tekst
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
            lblHelp.Click += LblHelp_Click;
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            if (!OpenPDF.ShowPDF(lblHelp.Tag.ToString())) // Fejl-besked, hvis PDF ikke kunne åbnes
                MessageBox.Show("Could not open pdf");
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
            // Simulering af glemt kodeord funktion
            new ForgotPasswordView(loginBL, pValidator).ShowDialog(); 
        }

        private void LblRegister_Click(object? sender, EventArgs e)
        {
            this.Hide();
            // Åbn "opret bruger form" inkl. denne form
            new CreateUserView(this, pValidator).ShowDialog(); 
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
            btnLogin.Enabled = true; // Aktiver knap efter lukning af MessageBox

            if (userID > 0)
            {
                new FrontPageView(userID, this).Show(); // Åbn programmets main page og medtag ID'et på bruger
                Hide(); // Skjul loginpage
                txtPassword.Text = string.Empty; // Slet koden
            }
            else
            {
                // Neutral besked ved forkert loginoplysninger, for at undlade at informere brugeren om
                // brugernavn/email eksisterer i systemet
                MessageBox.Show("Invalid username or password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
