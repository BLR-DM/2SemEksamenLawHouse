using BusinessLogic.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.AdminPage
{
    public partial class AdminCUDLawyer : Form
    {
        Color validFormat;
        Color invalidFormat;
        PersonValidator pValidator;
        string emailDomain;
        public AdminCUDLawyer()
        {
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            emailDomain = "@lawhouse.com";

            InitializeComponent();
            lblInvalidDate.Hide();
            btnCreate.Enabled = false;
            txtPassword.Text = "0000";

            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;
            txtTitel.TextChanged += TxtTitel_TextChanged;
            dtpHireDate.ValueChanged += DtpHireDate_ValueChanged;
            btnToday.Click += BtnToday_Click;
            btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            btnCreateEnabled();
        }

        private void TxtTitel_TextChanged(object? sender, EventArgs e)
        {
            txtTitel.ForeColor = pValidator.ValidName(txtTitel.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtPhone_TextChanged(object? sender, EventArgs e)
        {
            txtPhone.ForeColor = pValidator.ValidPhone(txtPhone.Text) ? validFormat : invalidFormat;
            SetEmail();
        }

        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            SetEmail();
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            SetEmail();
        }

        private void SetEmail()
        {
            if (txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtPhone.ForeColor == validFormat)
            {
                string email = 
                    ($"{txtFirstname.Text.Substring(0,2)}" +
                    $"{txtLastname.Text.Substring(0,2)}" +
                    $"{txtPhone.Text.Substring(0,4)}" +
                    $"{emailDomain}").ToLower();

                if (pValidator.ValidEmail(email))
                {
                    txtEmail.Text = email;
                    txtEmailLogin.Text = email;
                }
            }
            else
            {
                txtEmail.Text = string.Empty;
            }
            btnCreateEnabled();
        }

        private void btnCreateEnabled()
        {
            btnCreate.Enabled =
                    txtFirstname.ForeColor == validFormat &&
                    txtLastname.ForeColor == validFormat &&
                    txtAddress.ForeColor == validFormat &&
                    txtPostal.ForeColor == validFormat &&
                    txtCity.ForeColor == validFormat &&
                    lblInvalidDate.Visible == false;
        }
    }
}
