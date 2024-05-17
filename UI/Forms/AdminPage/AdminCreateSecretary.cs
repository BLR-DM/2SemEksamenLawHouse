using BusinessLogic.Validation;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;
using EntityModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminCreateSecretary : Form
    {
        Color validFormat;
        Color invalidFormat;
        SecretaryBL secretaryBL;
        LawyerTitleBL lawyerTitleBL;
        PersonValidator pValidator;

        List<LawyerTitleUI> lawyerTitles;

        string emailDomain;
        public AdminCreateSecretary()
        {
            secretaryBL = new SecretaryBL();
            lawyerTitleBL = new LawyerTitleBL();
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            emailDomain = "@lawhouse.com";

            InitializeComponent();

            Load += AdminCreateSecretary_Load;

            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;
            dtpHireDate.ValueChanged += DtpHireDate_ValueChanged;
            btnToday.Click += BtnToday_Click;
            btnCreate.Click += BtnCreate_Click;
            
        }

        private async void AdminCreateSecretary_Load(object? sender, EventArgs e)
        {
            lblInvalidDate.Hide();
            btnCreate.Enabled = false;
            txtPassword.Text = "0000";

            await FillTitleComboBox();
        }

        private async Task FillTitleComboBox()
        {
            lawyerTitles = await lawyerTitleBL.GetLawyerTitles();

            foreach (LawyerTitleUI title in lawyerTitles)
            {
                cboxTitles.Items.Add(title.Title);
            }
        }

        private void SetEmail()
        {
            if (txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtPhone.ForeColor == validFormat)
            {
                string email =
                    ($"{txtFirstname.Text.Substring(0, 2)}" +
                    $"{txtLastname.Text.Substring(0, 2)}" +
                    $"{txtPhone.Text.Substring(0, 4)}" +
                    $"{emailDomain}").ToLower();

                if (pValidator.ValidEmail(email))
                {
                    txtEmail.Text = email;
                    txtEmailLogin.Text = txtEmail.Text;
                }
            }
            else
            {
                txtEmail.Text = string.Empty;
            }
            UpdateCreateButtonState();
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            btnCreate.Enabled = false;

            SecretaryUI secretaryUI = new SecretaryUI()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                PhoneNumber = int.Parse(txtPhone.Text),
                Email = txtEmailLogin.Text,
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = txtCity.Text,
                LawyerTitleID = lawyerTitles.FirstOrDefault(x => x.Title == cboxTitles.SelectedItem).LawyerTitleID,
                HireDate = dtpHireDate.Value
            };

            LoginDetailsUI loginDetailsUI = new LoginDetailsUI()
            {
                Username = txtEmailLogin.Text,
                Password = txtPassword.Text,
                CreationDate = DateTime.Now,
            };


            bool test = await secretaryBL.CreateSecretaryAsync(secretaryUI, loginDetailsUI);
            btnCreate.Enabled = true;

            if (test)
                MessageBox.Show("Secretary Created!");
            else
                MessageBox.Show("Failed!");
        }

        private void BtnToday_Click(object? sender, EventArgs e)
        {
            dtpHireDate.Value = DateTime.Now;
        }

        private void DtpHireDate_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpHireDate.Value > DateTime.Now)
                lblInvalidDate.Show();
            else
                lblInvalidDate.Hide();

            UpdateCreateButtonState();
        }

        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            UpdateCreateButtonState();
        }

        private void TxtPhone_TextChanged(object? sender, EventArgs e)
        {
            txtPhone.ForeColor = pValidator.ValidPhone(txtPhone.Text) ? validFormat : invalidFormat;
            SetEmail();
            UpdateCreateButtonState();
        }

        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            SetEmail();
            UpdateCreateButtonState();
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            SetEmail();
            UpdateCreateButtonState();
        }

        private void UpdateCreateButtonState()
        {
            btnCreate.Enabled =
                txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtAddress.ForeColor == validFormat &&
                txtPostal.ForeColor == validFormat &&
                txtPhone.ForeColor == validFormat &&
                txtCity.ForeColor == validFormat &&
                cboxTitles.SelectedItem != null &&
                lblInvalidDate.Visible == false;
        }
    }
}
