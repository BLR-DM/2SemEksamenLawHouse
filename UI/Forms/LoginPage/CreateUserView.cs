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
using UI.Forms.LoginPage;

namespace UI.Forms.CreateUserPage
{
    public partial class CreateUserView : Form
    {
        LoginPageView loginPage;
        public CreateUserView(LoginPageView login)
        {
            loginPage = login;
            InitializeComponent();

            lblCancel.Click += LblCancel_Click;
            pboxEye.Click += PboxEye_Click;
            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtEmailConfirm.TextChanged += TxtEmailConfirm_TextChanged;
            btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            // Create UI
            Client client = new Client()
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                Email = txtEmail.Text,
                Phones = new List<Phone>()
                {
                    new Phone() { PhoneNumber = int.Parse(txtPhoneMain.Text) }
                },
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = txtCity.Text,
                LoginDetails = new LoginDetails()
                {
                    UserName = txtUsername.Text,
                    PassWord = txtPasswordConfirm.Text,
                }
            };
        }

        private void TxtEmailConfirm_TextChanged(object? sender, EventArgs e)
        {
            // Assign only after valid email
            if (txtEmail.Text == txtEmailConfirm.Text)
            {
                txtUsername.Text = txtEmailConfirm.Text;
            }
            else
            {
                txtUsername.Text = "";
            }
        }

        private void TxtEmail_TextChanged(object? sender, EventArgs e)
        {
            // Assign only after valid email
            if (txtEmail.Text == txtEmailConfirm.Text)
            {
                txtUsername.Text = txtEmailConfirm.Text;
            }
            else
            {
                txtUsername.Text = "";
            }
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            loginPage.Show();
        }
    }
}
