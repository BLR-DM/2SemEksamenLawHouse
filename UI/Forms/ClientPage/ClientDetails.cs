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
using UI.Forms.CasePage;
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
        CaseBL caseBL;
        FormDocumentBL formBL;
        SubscriptionBL subscriptionBL;
        PersonValidator pValidator;
        ServiceEntryBL serviceEntryBL;

        Color validFormat;
        Color invalidFormat;

        List<PhoneUI> phoneNumbers;
        List<PhoneUI> deletedNumbers;
        List<FormDocumentUI> boughtForms;
        List<ClientSubscriptionUI> subscriptions;
        List<CaseUI> cases;

        public ClientDetails(FrontPageView fpv, PersonUI currenUser, ClientUI client, ClientBL clientBL, CaseBL caseBL, FormDocumentBL formBL, SubscriptionBL subscriptionBL, PersonValidator pValidator, ServiceEntryBL serviceEntryBL)
        {
            InitializeComponent();
            this.frontPageView = fpv;
            this.currentUser = currenUser;
            this.client = client;
            this.clientBL = clientBL;
            this.formBL = formBL;
            this.subscriptionBL = subscriptionBL;
            this.pValidator = pValidator;
            this.caseBL = caseBL;
            this.serviceEntryBL = serviceEntryBL;

            deletedNumbers = new List<PhoneUI>();
            subscriptions = new List<ClientSubscriptionUI>();
            cases = new List<CaseUI>();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            txtEmail.Enabled = false;

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
            btnSubscriptionDetails.Click += BtnSubscriptionDetails_Click;
            dgvCases.CellDoubleClick += DgvCases_CellDoubleClick;

            Load += ClientDetails_Load;

        }

        private void BtnSubscriptionDetails_Click(object? sender, EventArgs e)
        {
            SubscriptionDetailsView subscriptionDetailsView = new SubscriptionDetailsView(client, subscriptions);
            subscriptionDetailsView.ShowDialog();
        }

        private async void ClientDetails_Load(object? sender, EventArgs e)
        {
            SetDetails(client);
            await GetClientSubscriptionsAsync();
            await SetBoughtFormsDGVAsync();
            await SetCasesDGVAsync();
        }


        private async Task GetClientSubscriptionsAsync()
        {
            subscriptions = await subscriptionBL.GetClientSubscriptionsAsync(client.PersonID);
            ClientSubscriptionUI? activeSubscription = subscriptions.FirstOrDefault(cs => cs.EndDate >= DateTime.Now && cs.StartDate <= DateTime.Now);

            if(activeSubscription != null)
            {
                TimeSpan timeTillExpiration = activeSubscription.EndDate - DateTime.Now;
                int daysUntilExpiration = (int)timeTillExpiration.TotalDays;
                lblSubscribed.Text = lblSubscribed.Text + $" - Expires in: {daysUntilExpiration} Days";
            }
            
        }


        private async void BtnDeletePhone_Click(object? sender, EventArgs e)
        {
            //sletter det valgte telefonummer og tilføjer til deletedphones
            if (dgvPhoneNumbers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhoneNumbers.SelectedRows[0];
                PhoneUI selectedPhone = selectedRow.DataBoundItem as PhoneUI;

                phoneNumbers.Remove(selectedPhone);
                deletedNumbers.Add(selectedPhone);

                await SetPhoneDetailsAsync();
            }
        }

        private async void BtnAddPhone_Click(object? sender, EventArgs e)
        {
            PhoneUI tempP = new PhoneUI()
            {
                PhoneNumber = int.Parse(txtAddPhone.Text),
            };
            phoneNumbers.Add(tempP);
            txtAddPhone.Clear();
            await SetPhoneDetailsAsync();
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

            await SetPhoneDetailsAsync();
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
        private void DgvBoughtForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormDocumentUI selectedForm = boughtForms[e.RowIndex];
                FormDetails formDetails = new FormDetails(selectedForm, client);
                formDetails.ShowDialog();
            }
        }

        public async Task SetCasesDGVAsync()
        {
            cases = await caseBL.GetCasesAsync(client.PersonID);
            dgvCases.DataSource = cases;
            dgvCases.Columns[2].Visible = false;
            dgvCases.Columns[3].Visible = false;
            dgvCases.Columns[4].Visible = false;
            dgvCases.Columns[8].Visible = false;
            dgvCases.Columns[9].Visible = false;
            dgvCases.Columns[10].Visible = false;
            dgvCases.Columns[11].Visible = false;
            dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCases.ReadOnly = true;
            dgvCases.RowHeadersVisible = false;
            dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void DgvCases_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CaseDetailsView caseDetailsView;
                CaseUI selectedCase = cases[e.RowIndex];
                if(currentUser is ClientUI)
                {
                    caseDetailsView = new CaseDetailsView(selectedCase.CaseID, true, serviceEntryBL);
                }
                else
                {
                    caseDetailsView = new CaseDetailsView(selectedCase.CaseID, false, serviceEntryBL);
                }
                frontPageView.PnlContextChange(caseDetailsView);
            }
        }


        private async Task SetPhoneDetailsAsync()
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
