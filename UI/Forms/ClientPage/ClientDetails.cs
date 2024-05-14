using BusinessLogic;
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
using UI.Forms.FrontPage;
using UI.Forms.Self_Service;
using UI.Forms.SubscriptionPage;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class ClientDetails : Form
    {
        FrontPageView frontPageView;
        PersonUI currentUser;
        ClientUI client;
        ClientBL clientBL;
        FormDocumentBL formBL;
        PersonValidator pValidator;

        Color validFormat;
        Color invalidFormat;

        List<PhoneUI> phoneNumbers;
        List<PhoneUI> deletedNumbers;
        List<FormDocumentUI> boughtForms;

        public ClientDetails(FrontPageView fpv, PersonUI currenUser, ClientUI client, ClientBL clientBL, FormDocumentBL formBL, PersonValidator pValidator)
        {
            InitializeComponent();
            this.frontPageView = fpv;
            this.currentUser = currenUser;
            this.client = client;
            this.clientBL = clientBL;
            this.formBL = formBL;
            this.pValidator = pValidator;

            deletedNumbers = new List<PhoneUI>();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnAddPhone.Enabled = false;

            //Events
            btnUpdate.Click += BtnUpdate_ClickAsync;
            btnAddPhone.Click += BtnAddPhone_Click;
            btnDeletePhone.Click += BtnDeletePhone_Click;
            dgvBoughtForms.CellDoubleClick += DgvBoughtForms_CellDoubleClick;
            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtAddPhone.TextChanged += txtAddPhone_TextChanged;

            SetDetails(client);
            SetBoughtFormsDGVAsync();

        }

        private void DgvBoughtForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormDocumentUI selectedForm = boughtForms[e.RowIndex];
                FormDetails formDetails = new FormDetails(selectedForm, client);
                formDetails.ShowDialog();
            }
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

            bool numberDeleted = true;
            bool clientUpdated;
            
            ClientUI tempC = new ClientUI()
            {
                PersonID = client.PersonID,
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = lblCity.Text,
                IsSubscribed = client.IsSubscribed,
                LoginDetailsID = client.LoginDetailsID,
            };

            clientUpdated = await clientBL.UpdateClientAsync(tempC, phoneNumbers);

            List<PhoneUI> newNumbers = phoneNumbers.Where(p => p.ClientID == 0).ToList();
            if (newNumbers.Count > 0)
            {
                phoneNumbers = await clientBL.GetClientPhonesAsync(client.PersonID);
            }

            if (deletedNumbers.Count > 0)
            {
                numberDeleted = await clientBL.DeletePhoneNumbersAsync(deletedNumbers);
            }

            if (clientUpdated && numberDeleted)
            {
                lblSuccess.ForeColor = Color.Green;
                //resetter listen for deleted numbers
                deletedNumbers = new List<PhoneUI>();
                lblSuccess.Text = "Saved";
            }
            else
            {
                lblSuccess.ForeColor = Color.Red;
                lblSuccess.Text = "Save Failed";
            }


            //Hvis update sker på "mypage" så henter den brugerens detaljer igen
            if(currentUser is ClientUI) { frontPageView.GetPersonAsync(currentUser.LoginDetailsID); }

            btnUpdate.Enabled = true;

        }

        private void btnUpdateEnabled()
        {
            btnUpdate.Enabled =
                txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtEmail.ForeColor == validFormat &&
                txtAddress.ForeColor == validFormat &&
                txtPostal.ForeColor == validFormat
                ? true : false;
        }


        private void txtAddPhone_TextChanged(object? sender, EventArgs e)
        {
            txtAddPhone.ForeColor = pValidator.ValidPhone(txtAddPhone.Text) ? validFormat : invalidFormat;
            if (txtAddPhone.ForeColor == validFormat)
            {
                btnAddPhone.Enabled = true;
            }
            else
                btnAddPhone.Enabled = false;
        }

        private async void SetDetails(ClientUI client)
        {
            txtFirstname.Text = client.Firstname;
            txtLastname.Text = client.Lastname;
            txtEmail.Text = client.Email;
            txtAddress.Text = client.AddressLine;
            txtPostal.Text = client.PostalCode.ToString();
            lblCity.Text = client.City;
            if (client.IsSubscribed == false) { lblSubscribed.Text = "No"; }
            else if (client.IsSubscribed == true) { lblSubscribed.Text = "Yes"; }
            else { lblSubscribed.Text = "Undefined"; }

            await SetPhoneDetails();
        }

        public async Task SetBoughtFormsDGVAsync()
        {
            boughtForms = await formBL.GetBoughtFormDocumentsAsync(client.PersonID);
            dgvBoughtForms.DataSource = boughtForms;
            dgvBoughtForms.Columns["FormDocumentID"].Visible = false;
            dgvBoughtForms.Columns["Description"].Visible = false;
            dgvBoughtForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoughtForms.ReadOnly = true;
            dgvBoughtForms.RowHeadersVisible = false;
            dgvBoughtForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }
        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void txtEmail_TextChanged(object? sender, EventArgs e)
        {
            txtEmail.ForeColor = pValidator.ValidEmail(txtEmail.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

    }
}
