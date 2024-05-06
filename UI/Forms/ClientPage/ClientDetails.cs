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
    public partial class ClientDetails : Form
    {
        ClientBL clientBL;
        ClientUI client;
        List<PhoneUI> phoneNumbers;
        List<PhoneUI> deletedNumbers;
        public ClientDetails(ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            clientBL = new ClientBL();
            deletedNumbers = new List<PhoneUI>();

            //Events
            btnUpdate.Click += BtnUpdate_ClickAsync;
            btnAddPhone.Click += BtnAddPhone_Click;
            btnDeletePhone.Click += BtnDeletePhone_Click;

            SetDetails(client);
        }

        private void BtnDeletePhone_Click(object? sender, EventArgs e)
        {

            //sletter det valgte telefonummer og tilføjer til deletedphones
            if (dgvPhoneNumbers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhoneNumbers.SelectedRows[0];
                PhoneUI selectedPhone = selectedRow.DataBoundItem as PhoneUI;

                phoneNumbers.Remove(selectedPhone);
                deletedNumbers.Add(selectedPhone);

                SetPhoneDetails();
            }
        }

        private void BtnAddPhone_Click(object? sender, EventArgs e)
        {
            PhoneUI tempP = new PhoneUI()
            {
                PhoneNumber = int.Parse(txtAddPhone.Text),
            };
            phoneNumbers.Add(tempP);
            txtAddPhone.Clear();
            SetPhoneDetails();
        }

        private async void BtnUpdate_ClickAsync(object? sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            ClientUI tempC = new ClientUI()
            {
                PersonID = client.PersonID,
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = lblCity.Text,
                ClientSub = client.ClientSub,
                LoginDetailsID = client.LoginDetailsID,
            };

            await clientBL.UpdateClientAsync(tempC, phoneNumbers);
            if (deletedNumbers.Count > 0)
            {
                await clientBL.DeletePhoneNumbersAsync(deletedNumbers);
            }

            btnUpdate.Enabled = true;

        }

        private async void SetDetails(ClientUI client)
        {
            txtFirstname.Text = client.Firstname;
            txtLastname.Text = client.Lastname;
            txtEmail.Text = client.Email;
            txtAddress.Text = client.AddressLine;
            txtPostal.Text = client.PostalCode.ToString();
            lblCity.Text = client.City;
            if (client.ClientSub == 0) { lblSubscribed.Text = "No"; }
            else if (client.ClientSub == 1) { lblSubscribed.Text = "Yes"; }
            else { lblSubscribed.Text = "Undefined"; }

            await SetPhoneDetails();
        }

        private async Task SetPhoneDetails()
        {
            dgvPhoneNumbers.DataSource = null;
            if (phoneNumbers == null)
            {
                phoneNumbers = await clientBL.GetClientPhonesAsync(client.PersonID);
            }

            dgvPhoneNumbers.DataSource = phoneNumbers;
            dgvPhoneNumbers.Columns["PhoneID"].Visible = false;
            dgvPhoneNumbers.Columns["ClientID"].Visible = false;
            dgvPhoneNumbers.ColumnHeadersVisible = false;
            dgvPhoneNumbers.RowHeadersVisible = false;
            dgvPhoneNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
