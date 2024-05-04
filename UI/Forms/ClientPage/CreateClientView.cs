using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.ClientPage
{
    public partial class CreateClientView : Form
    {
        public CreateClientView()
        {
            InitializeComponent();

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
            throw new NotImplementedException();
        }

        private void BtnAddPhone_Click(object? sender, EventArgs e)
        {

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
