using BusinessLogic;
using UIModels;
using BusinessLogic.Validation;
using UI.Forms.LoginPage;
using BusinessLogic.HelpServices;

namespace UI.Forms.CreateUserPage
{
    public partial class CreateUserView : Form
    {
        ClientBL clientBL;
        List<PhoneUI> phoneUIs;
        PersonValidator pValidator;
        Color validFormat;
        Color invalidFormat;
        Color rgbColorBlue;

        LoginPageView loginPage;
        public CreateUserView(LoginPageView loginPage, PersonValidator personValidator)
        {
            clientBL = new ClientBL();
            pValidator = personValidator;
            this.loginPage = loginPage;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;
            rgbColorBlue = Color.FromArgb(45, 93, 134); // Brugerdefineret blå farve

            InitializeComponent();

            btnCreate.Enabled = false;

            lblCancel.Click += LblCancel_Click;
            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            pboxEye.Click += PboxEye_Click;
            btnCreate.Click += BtnCreate_Click;
            pnlLoginInfo.Paint += PnlLoginInfo_Paint;

            // Validering events
            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtEmailConfirm.TextChanged += TxtEmailConfirm_TextChanged;
            txtPhoneMain.TextChanged += TxtPhoneMain_TextChanged;
            txtPhoneAlt.TextChanged += TxtPhoneAlt_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            txtPasswordConfirm.TextChanged += TxtPasswordConfirm_TextChanged;
            lblHelp.Click += LblHelp_Click;
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            if (!OpenPDF.ShowPDF(lblHelp.Tag.ToString()))
                MessageBox.Show("Could not open pdf");
        }

        private void PnlLoginInfo_Paint(object? sender, PaintEventArgs e)
        {
            // Brugerdefineret panel border farve
            ControlPaint.DrawBorder(e.Graphics, pnlLoginInfo.ClientRectangle, rgbColorBlue, ButtonBorderStyle.Solid);
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            // Opret Client UI
            ClientUI client = new ClientUI()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmailConfirm.Text.ToLower(),
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = txtCity.Text,
            };

            // Opret LoginDetails UI
            LoginDetailsUI loginDetails = new LoginDetailsUI()
            {
                Username = txtUsername.Text.ToLower(),
                Password = txtPasswordConfirm.Text,
                CreationDate = DateTime.Now, // Oprettelses dato sat til Now
            };

            phoneUIs = new List<PhoneUI>();

            // Opret Phone UI
            PhoneUI phoneUI = new PhoneUI { PhoneNumber = int.Parse(txtPhoneMain.Text) };

            phoneUIs.Add(phoneUI);

            // Opret PhoneAlt UI - Alternativ telefonnummer tilføjes til listen
            if (!string.IsNullOrWhiteSpace(txtPhoneAlt.Text) && pValidator.ValidPhone(txtPhoneAlt.Text))
            {
                PhoneUI phoneUIAlt = new PhoneUI { PhoneNumber = int.Parse(txtPhoneAlt.Text) };
                phoneUIs.Add(phoneUIAlt);
            }

            bool result = await clientBL.CreateClientAsync(client, loginDetails, phoneUIs);

            if (result)
            {
                MessageBox.Show($"Client '{client}' successfully added!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Ved successful oprettes, åbnes loginsiden med brugerensemail tastet ind i "username" feltet
                loginPage.GetCreatedUsername(client.Email); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add client. Please check the entered details and try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnCreate.Enabled = true;
        }

        private void LblCancel_MouseHover(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Underline);
        }

        private void LblCancel_MouseLeave(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Regular);
        }

        private void PboxEye_Click(object? sender, EventArgs e)
        {
            // Skjul / vis kodeord
            if (pboxEye.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.PasswordChar = '\0';
                txtPasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                pboxEye.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.PasswordChar = '\u2022';
                txtPasswordConfirm.PasswordChar = '\u2022';
            }
        }
        private void LblCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Ved lukning af form, vis skjulte loginside
            base.OnFormClosing(e);
            loginPage.Show();
        }

        // Validering events


        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void TxtPasswordConfirm_TextChanged(object? sender, EventArgs e)
        {
            ValidatePasswords();
        }

        private void TxtPassword_TextChanged(object? sender, EventArgs e)
        {
            ValidatePasswords();
        }
        private void ValidatePasswords()
        {
            bool primaryPasswordValid = pValidator.ValidPassword(txtPassword.Text);

            // Tjek om confirm password er indtastet og om primary password er korrekt format
            if (!string.IsNullOrEmpty(txtPasswordConfirm.Text))
            {
                bool confirmationPasswordValid = pValidator.ValidPassword(txtPasswordConfirm.Text);
                bool passwordsMatch = txtPasswordConfirm.Text == txtPassword.Text;

                // Hvis begge koder er identiske og valide = validFormat ellers invalidFormat
                txtPassword.ForeColor = (primaryPasswordValid && passwordsMatch) ? validFormat : invalidFormat;
                txtPasswordConfirm.ForeColor = (confirmationPasswordValid && passwordsMatch) ? validFormat : invalidFormat;
            }
            else
            {
                // Hvis ikke confirm password er indtastet, behold standard farve
                txtPassword.ForeColor = primaryPasswordValid ? validFormat : invalidFormat;
                txtPasswordConfirm.ForeColor = Color.Black;
            }
            UpdateCreateButtonState();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            // By registreres ud fra postnummer vha. statisk hjælpe-klasse
            txtCity.Text = GetCityFromPostalCode.SetCityFromPostalCode(txtPostal.Text);

            UpdateCreateButtonState();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void TxtPhoneAlt_TextChanged(object? sender, EventArgs e)
        {
            ValidatePhoneNumbers(txtPhoneAlt, txtPhoneMain);
        }

        private void TxtPhoneMain_TextChanged(object? sender, EventArgs e)
        {
            ValidatePhoneNumbers(txtPhoneMain, txtPhoneAlt);
        }

        private void ValidatePhoneNumbers(TextBox mainPhone, TextBox altPhone)
        {
            if (pValidator.ValidPhone(mainPhone.Text))
                mainPhone.ForeColor = (mainPhone.Text == altPhone.Text) ? invalidFormat : validFormat;
            else
                mainPhone.ForeColor = invalidFormat;

            UpdateCreateButtonState();
        }

        private void TxtEmailConfirm_TextChanged(object? sender, EventArgs e)
        {
            ValidateEmails(txtEmailConfirm, txtEmail);
        }

        private void TxtEmail_TextChanged(object? sender, EventArgs e)
        {
            ValidateEmails(txtEmail, txtEmailConfirm);
        }

        private void ValidateEmails(TextBox email, TextBox emailConfirm)
        {
            bool isEmailValid = pValidator.ValidEmail(email.Text);
            email.ForeColor = isEmailValid ? validFormat : invalidFormat;

            bool isConfirmEmailValid = pValidator.ValidEmail(emailConfirm.Text);
            emailConfirm.ForeColor = isConfirmEmailValid ? validFormat : invalidFormat;

            if (isEmailValid && isConfirmEmailValid)
            {
                if (email.Text == emailConfirm.Text)
                {
                    txtUsername.Text = email.Text;
                    email.ForeColor = validFormat;
                    emailConfirm.ForeColor = validFormat;
                }
                else
                {
                    txtUsername.Text = string.Empty;
                    if (!string.IsNullOrEmpty(emailConfirm.Text))
                    {
                        email.ForeColor = invalidFormat;
                        emailConfirm.ForeColor = invalidFormat;
                    }
                }
            }
            else
                txtUsername.Text = string.Empty;

            UpdateCreateButtonState();
        }

        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void UpdateCreateButtonState()
        {
            btnCreate.Enabled =
                txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtAddress.ForeColor == validFormat &&
                txtPostal.ForeColor == validFormat &&
                txtPhoneMain.ForeColor == validFormat &&
                (string.IsNullOrEmpty(txtPhoneAlt.Text) || txtPhoneAlt.ForeColor == validFormat) &&
                txtCity.ForeColor == validFormat &&
                txtEmail.ForeColor == validFormat &&
                txtEmailConfirm.ForeColor == validFormat &&
                txtPassword.ForeColor == validFormat &&
                txtPasswordConfirm.ForeColor == validFormat && 
                txtPassword.Text == txtPasswordConfirm.Text;
        }
    }
}
