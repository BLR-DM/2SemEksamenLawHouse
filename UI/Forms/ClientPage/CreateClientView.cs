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

namespace UI.Forms.ClientPage
{
    public partial class CreateClientView : Form
    {
        ClientBL clientBL;
        List<PhoneUI> phoneUIList;
        PhoneUI phoneUI;
        public CreateClientView()
        {
            InitializeComponent();
            clientBL = new ClientBL();

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




        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            btnCreate.Enabled = false;

            ClientUI clientUI = new ClientUI()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                AddressLine = txtAddress.Text,
                PostalCode = Convert.ToInt32(txtPostal.Text),
                City = txtCity.Text,
                ClientSub = 0,
            };

            LoginDetailsUI loginDetailsUI = new LoginDetailsUI()
            {
                Username = clientUI.Email,
                Password = "0000",
                CreationDate = DateTime.Now,
            };
            if(txtPassword.Text != null && txtPassword.Text == txtConfirmPassword.Text)
            {
                loginDetailsUI.Password = txtPassword.Text;
            }

            bool success = await clientBL.CreateAsync(clientUI, loginDetailsUI, phoneUIList);

            btnCreate.Enabled = true;

        }

        private void BtnAddPhone_Click(object? sender, EventArgs e)
        {
            PhoneUI tempPhone = new PhoneUI()
            {
                PhoneNumber = Convert.ToInt32(txtPhone.Text),
            };
            phoneUIList.Add(tempPhone);
            txtPhone.Clear();

            rtxtPhoneNumbers.Text = string.Join("\n", phoneUIList.Select(p => p.PhoneNumber));
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            lblNameView.Text = string.Join(" ", txtFirstname.Text, txtLastname.Text);
        }
        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            lblNameView.Text = string.Join(" ", txtFirstname.Text, txtLastname.Text);

        }
        private void txtEmail_TextChanged(object? sender, EventArgs e)
        {
            lblEmailView.Text = txtEmail.Text;
        }
        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            lblAddressView.Text = string.Join(", ", txtAddress.Text, txtPostal.Text, txtCity.Text);
        }
        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            lblAddressView.Text = string.Join(", ", txtAddress.Text, txtPostal.Text, txtCity.Text);
        }
        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            lblAddressView.Text = string.Join(", ", txtAddress.Text, txtPostal.Text, txtCity.Text);
        }
        private void TxtPhone_TextChanged(object? sender, EventArgs e)
        {
            
        }
    }
}
