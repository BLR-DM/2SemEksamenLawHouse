using BusinessLogic;
using BusinessLogic.HelpServices;
using BusinessLogic.Validation;
using EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Converters;
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class CreateClientView : Form
    {
        FrontPageView frontPageView;

        PersonUI currentUser;

        ClientBL clientBL;
        PersonValidator pValidator;

        Color validFormat;
        Color invalidFormat;

        List<PhoneUI> phoneUIList;
        PhoneUI phoneUI;

        //valid booleans
        bool isPhoneAdded;
        bool passwordIsValid;

        public CreateClientView(FrontPageView frontPageView, PersonUI currentUser)
        {
            InitializeComponent();
            this.frontPageView = frontPageView;
            this.currentUser = currentUser;
            clientBL =  new ClientBL();
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnAddPhone.Enabled = false;
            passwordIsValid = true;
            txtCity.Enabled = false;

            phoneUIList = new List<PhoneUI>();


            //Events
            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            btnAddPhone.Click += BtnAddPhone_Click;
            btnCreate.Click += BtnCreate_Click;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            txtConfirmPassword.TextChanged += TxtConfirmPassword_TextChanged;
            

            BtnCreateEnabled();


        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            //disable create knap
            btnCreate.Enabled = false;

            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to create {txtFirstname.Text}?", 
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //ny clientUI
                ClientUI clientUI = new ClientUI()
                {
                    Firstname = txtFirstname.Text,
                    Lastname = txtLastname.Text,
                    Email = txtEmail.Text.ToLower(),
                    AddressLine = txtAddress.Text,
                    PostalCode = int.Parse(txtPostal.Text),
                    City = txtCity.Text,
                    IsSubscribed = false,
                };

                //ny logindetailsUI
                LoginDetailsUI loginDetailsUI = new LoginDetailsUI()
                {
                    Username = clientUI.Email.ToLower(),
                    Password = "0000",
                    CreationDate = DateTime.Now,
                };

                //saet ny kode til bruger hvis kode er indtastet
                if (txtPassword.Text != null && txtPassword.Text == txtConfirmPassword.Text)
                {
                    loginDetailsUI.Password = txtPassword.Text;
                }

                //opretter klient i systemet
                bool result = await clientBL.CreateClientAsync(clientUI, loginDetailsUI, phoneUIList);

                if (result)
                {
                    MessageBox.Show($"{txtFirstname.Text} Has been created! ", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ClientsView cv = new ClientsView(frontPageView, currentUser);
                    frontPageView.PnlContextChange(cv);
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnAddPhone_Click(object? sender, EventArgs e)
        {
            //opretter ny tlf nummer
            PhoneUI tempPhone = new PhoneUI()
            {
                PhoneNumber = Convert.ToInt32(txtPhone.Text),
            };
            //tilfoejer nr til list af tlfnr
            phoneUIList.Add(tempPhone);

            //true - der er tilfoejet et nr
            isPhoneAdded = true;

            BtnCreateEnabled();
            
            //clear txt for tlfnr
            txtPhone.Clear();
            //disabler addphoneknap
            btnAddPhone.Enabled = false;

            rtxtPhoneNumbers.Text = string.Join("\n", phoneUIList.Select(p => p.PhoneNumber));// CHANGE?
        }

        private void ValidatePasswords() 
        {
            //hvis begge felter for password er tomme return
            if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                passwordIsValid = true;
                return;
            }

            passwordIsValid = false;

            //test om kode er valid
            bool primaryPasswordValid = pValidator.ValidPassword(txtPassword.Text);
            txtPassword.ForeColor = primaryPasswordValid ? validFormat : invalidFormat;

            // Tjek om confirm password er indtastet
            if (!string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                //tjek om confirm password er valid input
                bool confirmationPasswordValid = pValidator.ValidPassword(txtConfirmPassword.Text);
                //tjek om confirmpassword of password matcher
                bool sameAsPrimary = txtConfirmPassword.Text == txtPassword.Text;

                // This begge koder er identiske og valide = validFormat ellers invalidFormat
                if (confirmationPasswordValid && sameAsPrimary)
                {
                    txtConfirmPassword.ForeColor = validFormat;
                    txtPassword.ForeColor = validFormat;
                    passwordIsValid = true;
                }
                else
                {
                    txtConfirmPassword.ForeColor = invalidFormat;
                    txtPassword.ForeColor = invalidFormat;
                }
            }
            else
            {
                // Hvis ikke confirm password er indtastet, behold standard farve
                txtConfirmPassword.ForeColor = Color.Black;
            }
        }

        //metode til at enable/disable create knap alt efter input
        private void BtnCreateEnabled()
        {
            btnCreate.Enabled =
                txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtEmail.ForeColor == validFormat &&
                isPhoneAdded &&
                txtAddress.ForeColor == validFormat &&
                txtPostal.ForeColor == validFormat &&
                txtCity.ForeColor == validFormat &&
                passwordIsValid
                ? true : false;
        }


        //masse metoder der validerer indput
        private void TxtConfirmPassword_TextChanged(object? sender, EventArgs e)
        {
            ValidatePasswords();
            BtnCreateEnabled();
        }
        private void TxtPassword_TextChanged(object? sender, EventArgs e)
        {
            ValidatePasswords();
            BtnCreateEnabled();
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            lblNameView.Text = string.Join(" ", txtFirstname.Text, txtLastname.Text);
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }
        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            lblNameView.Text = string.Join(" ", txtFirstname.Text, txtLastname.Text);
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();

        }
        private void txtEmail_TextChanged(object? sender, EventArgs e)
        {
            lblEmailView.Text = txtEmail.Text;
            lblUsernameView.Text = txtEmail.Text;
            txtEmail.ForeColor = pValidator.ValidEmail(txtEmail.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }
        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            lblAddressView.Text = string.Join(", ", txtAddress.Text, txtPostal.Text, txtCity.Text);
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }
        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            lblAddressView.Text = string.Join(", ", txtAddress.Text, txtPostal.Text, txtCity.Text);
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;

            if(txtPostal.ForeColor == validFormat)
            {
                txtCity.Text = GetCityFromPostalCode.SetCityFromPostalCode(int.Parse(txtPostal.Text));
            }

            BtnCreateEnabled();
        }
        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            lblAddressView.Text = string.Join(", ", txtAddress.Text, txtPostal.Text, txtCity.Text);
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }
        private void TxtPhone_TextChanged(object? sender, EventArgs e)
        {
            txtPhone.ForeColor = pValidator.ValidPhone(txtPhone.Text) ? validFormat : invalidFormat;
            if (txtPhone.ForeColor == validFormat)
            {
                btnAddPhone.Enabled = true;
            }
            else
                btnAddPhone.Enabled = false;
        }

    }
}
