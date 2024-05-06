using BusinessLogic;
using UIModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.LoginPage;
using BusinessLogic.Validation;

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
        public CreateUserView()
        {
            clientBL = new ClientBL();
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            InitializeComponent();

            lblCancel.Click += LblCancel_Click;
            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            pboxEye.Click += PboxEye_Click;
            btnCreate.Click += BtnCreate_Click;
            pnlLoginInfo.Paint += PnlLoginInfo_Paint;

            // Validering events
            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtEmail.Leave += TxtEmail_Leave;
            txtEmailConfirm.Leave += TxtEmailConfirm_Leave;
            txtPhoneMain.Leave += TxtPhoneMain_Leave;
            txtPhoneAlt.Leave += TxtPhoneAlt_Leave;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.Leave += TxtPostal_Leave;
            txtCity.TextChanged += TxtCity_TextChanged;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            txtPasswordConfirm.TextChanged += TxtPasswordConfirm_TextChanged;

        }

        private void PnlLoginInfo_Paint(object? sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlLoginInfo.ClientRectangle, rgbColorBlue, ButtonBorderStyle.Solid);
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
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
                CreationDate = DateTime.Now,
            };

            phoneUIs = new List<PhoneUI>();

            // Opret Phone UI
            PhoneUI phoneUI = new PhoneUI { PhoneNumber = int.Parse(txtPhoneMain.Text) };

            phoneUIs.Add(phoneUI);

            // Opret PhoneAlt UI
            if (!string.IsNullOrWhiteSpace(txtPhoneAlt.Text))
            {
                PhoneUI phoneUIAlt = new PhoneUI { PhoneNumber = int.Parse(txtPhoneAlt.Text) };
                phoneUIs.Add(phoneUIAlt);
            }

            bool result = await clientBL.CreateClientAsync(client, loginDetails, phoneUIs);

            if (result)
                MessageBox.Show("CLIENT ADDED!");
            else
                MessageBox.Show("Failed!");
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


        // Validering events


        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
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
            txtPassword.ForeColor = primaryPasswordValid ? validFormat : invalidFormat;

            // Tjek om confirm password er indtastet og om primary password er korrekt format
            if (!string.IsNullOrEmpty(txtPasswordConfirm.Text))
            {
                bool confirmationPasswordValid = pValidator.ValidPassword(txtPasswordConfirm.Text);
                bool sameAsPrimary = txtPasswordConfirm.Text == txtPassword.Text;

                // This begge koder er identiske og valide = validFormat ellers invalidFormat
                if (confirmationPasswordValid && sameAsPrimary)
                {
                    txtPasswordConfirm.ForeColor = validFormat;
                    txtPassword.ForeColor = validFormat;
                }
                else
                {
                    txtPasswordConfirm.ForeColor = invalidFormat;
                    txtPassword.ForeColor = invalidFormat;
                }
            }
            else
            {
                // Hvis ikke confirm password er indtastet, behold standard farve
                txtPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void TxtPostal_Leave(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
        }

        private void TxtPhoneAlt_Leave(object? sender, EventArgs e)
        {
            if (pValidator.ValidPhone(txtPhoneAlt.Text))
            {
                if (txtPhoneAlt.Text == txtPhoneMain.Text)
                {
                    txtPhoneAlt.ForeColor = invalidFormat;
                }
                else
                {
                    txtPhoneAlt.ForeColor = validFormat;
                }
            }
            else
            {
                txtPhoneAlt.ForeColor = invalidFormat;
            }
        }

        private void TxtPhoneMain_Leave(object? sender, EventArgs e)
        {
            if (pValidator.ValidPhone(txtPhoneMain.Text))
            {
                if (txtPhoneAlt.Text == txtPhoneMain.Text)
                {
                    txtPhoneMain.ForeColor = invalidFormat;
                }
                else
                {
                    txtPhoneMain.ForeColor = validFormat;
                }
            }
            else
            {
                txtPhoneMain.ForeColor = invalidFormat;
            }
        }

        private void TxtEmailConfirm_Leave(object? sender, EventArgs e)
        {
            if (pValidator.ValidEmail(txtEmailConfirm.Text))
            {
                txtEmailConfirm.ForeColor = validFormat;

                if (txtEmailConfirm.Text == txtEmail.Text)
                {
                    txtUsername.Text = txtEmailConfirm.Text;
                    txtEmailConfirm.ForeColor = txtEmail.ForeColor = validFormat;
                }
                else
                {
                    txtUsername.Text = string.Empty;
                    txtEmailConfirm.ForeColor = txtEmail.ForeColor = invalidFormat;
                }
            }
            else
            {
                txtEmailConfirm.ForeColor = invalidFormat;
                txtEmailConfirm.ForeColor = txtEmail.ForeColor = invalidFormat;
                txtUsername.Text = string.Empty;
            }
        }

        private void TxtEmail_Leave(object? sender, EventArgs e)
        {
            if (pValidator.ValidEmail(txtEmail.Text))
            {
                txtEmail.ForeColor = validFormat;

                if (txtEmailConfirm.Text == txtEmail.Text)
                {
                    txtUsername.Text = txtEmail.Text;
                }
                else
                {
                    txtUsername.Text = string.Empty;
                }
            }
            else
            {
                txtEmail.ForeColor = invalidFormat;
                txtUsername.Text = string.Empty;
            }
        }

        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
        }
    }
}
