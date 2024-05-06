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
        Color rgbColorBlue;
        Color validFormat;
        Color invalidFormat;
        public CreateUserView()
        {
            clientBL = new ClientBL();
            pValidator = new PersonValidator();

            rgbColorBlue = Color.FromArgb(45, 93, 134);
            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            InitializeComponent();

            lblCancel.Click += LblCancel_Click;
            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            pboxEye.Click += PboxEye_Click;
            btnCreate.Click += BtnCreate_Click;

            // Validerings events
            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtEmail.Leave += TxtEmail_Leave;
            txtEmailConfirm.Leave += TxtEmailConfirm_Leave;
            txtPhoneMain.Leave += TxtPhoneMain_Leave;
            txtPhoneAlt.Leave += TxtPhoneAlt_Leave;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.Leave += TxtPostal_Leave;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            txtPasswordConfirm.TextChanged += TxtPasswordConfirm_TextChanged;
            txtPassword.GotFocus += TxtPassword_GotFocus;
        }

        private void TxtPassword_GotFocus(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtPasswordConfirm_TextChanged(object? sender, EventArgs e)
        {
            txtPasswordConfirm.ForeColor = pValidator.ValidPassword(txtPasswordConfirm.Text) ? validFormat : invalidFormat;
        }

        private void TxtPassword_TextChanged(object? sender, EventArgs e)
        {
            txtPassword.ForeColor = pValidator.ValidPassword(txtPassword.Text) ? validFormat : invalidFormat;
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
            txtPhoneAlt.ForeColor = pValidator.ValidPhone(txtPhoneAlt.Text) ? validFormat : invalidFormat;
        }

        private void TxtPhoneMain_Leave(object? sender, EventArgs e)
        {
            txtPhoneMain.ForeColor = pValidator.ValidPhone(txtPhoneMain.Text) ? validFormat : invalidFormat;
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

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            // Opret Client UI
            ClientUI client = new ClientUI()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmailConfirm.Text,
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = txtCity.Text,
            };

            // Opret LoginDetails UI
            LoginDetailsUI loginDetails = new LoginDetailsUI()
            {
                Username = txtUsername.Text,
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
    }
}
