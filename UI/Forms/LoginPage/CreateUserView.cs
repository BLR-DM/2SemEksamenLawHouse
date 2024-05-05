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
using Microsoft.IdentityModel.Tokens;

namespace UI.Forms.CreateUserPage
{
    public partial class CreateUserView : Form
    {
        ClientBL clientBL;
        List<PhoneUI> phoneUIs;
        public CreateUserView()
        {
            clientBL = new ClientBL();

            InitializeComponent();

            lblCancel.Click += LblCancel_Click;
            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            pboxEye.Click += PboxEye_Click;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtEmailConfirm.TextChanged += TxtEmailConfirm_TextChanged;
            btnCreate.Click += BtnCreate_Click;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            phoneUIs = new List<PhoneUI>();

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

            // Opret Phone UI
            PhoneUI phoneUI = new PhoneUI { PhoneNumber = int.Parse(txtPhoneMain.Text) };

            phoneUIs.Add(phoneUI);

            // Opret PhoneAlt UI
            if (!txtPhoneAlt.Text.IsNullOrEmpty())
            {
                PhoneUI phoneUIAlt = new PhoneUI { PhoneNumber = int.Parse(txtPhoneAlt.Text) };
                phoneUIs.Add(phoneUIAlt);
            }

            bool result = await clientBL.CreateAsync(client, loginDetails, phoneUIs);

            if (result)
                MessageBox.Show("CLIENT ADDED!");
            else
                MessageBox.Show("Failed!");
        }

        private void TxtEmailConfirm_TextChanged(object? sender, EventArgs e)
        {
            // Husk validering
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
            // Husk validering
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
    }
}
