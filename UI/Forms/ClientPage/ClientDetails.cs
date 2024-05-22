using BusinessLogic;
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

        Color validFormat;
        Color invalidFormat;

        List<PhoneUI> phoneNumbers;
        List<PhoneUI> deletedNumbers;
        List<FormDocumentUI> boughtForms;
        List<ClientSubscriptionUI> subscriptions;
        List<CaseUI> cases;

        public ClientDetails(FrontPageView fpv, PersonUI currenUser, ClientUI client)
        {
            InitializeComponent();
            this.frontPageView = fpv;
            this.currentUser = currenUser;
            this.client = client;

            clientBL = new ClientBL();
            formBL = new FormDocumentBL();
            subscriptionBL = new SubscriptionBL();
            pValidator = new PersonValidator();
            caseBL = new CaseBL();

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

        //load event
        private async void ClientDetails_Load(object? sender, EventArgs e)
        {
            //kalder metode saet detaljer for client
            SetDetails(client);

            //kalder metode til at hente clients subs
            await GetClientSubscriptionsAsync();

            //kalder metode til at setup boughtformsdgv
            await SetBoughtFormsDGVAsync();

            //kalder metode til at setup casesdgv
            await SetCasesDGVAsync();
        }

        private async void BtnUpdate_ClickAsync(object? sender, EventArgs e)
        {
            //disabler update knap
            btnUpdate.Enabled = false;

            bool numberDeleted = true;
            bool clientUpdated;
            
            //opreter ny client med gamle/nye vaerdier alt efter indput
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


            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to update the client: {txtFirstname.Text}?",
                                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //opdaterer clienten
                clientUpdated = await clientBL.UpdateClientAsync(tempC, phoneNumbers);

                //hvis der er 1 eller flere slette numre
                if (deletedNumbers.Count > 0)
                {
                    //slet telefonnumre
                    numberDeleted = await clientBL.DeletePhoneNumbersAsync(deletedNumbers);
                }

                //tjekker om der er ny tilføjet numre
                List<PhoneUI> newNumbers = phoneNumbers.Where(p => p.ClientID == 0).ToList();
                if (newNumbers.Count > 0)
                {
                    //hent clientens telefonnumre
                    phoneNumbers = await clientBL.GetClientPhonesAsync(client.PersonID);
                }

                //tester om client er opdaterert og telefonnumre er slettet
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

            }

            //Hvis update sker på "mypage" så henter den brugerens detaljer igen
            if(currentUser is ClientUI) { frontPageView.GetPersonAsync(currentUser.LoginDetailsID); }

            //enable update knap
            btnUpdate.Enabled = true;

        }

        private void txtAddPhone_TextChanged(object? sender, EventArgs e)
        {
            //validerer på tlfnr indput og disabler/enabler addknap 
            txtAddPhone.ForeColor = pValidator.ValidPhone(txtAddPhone.Text) ? validFormat : invalidFormat;
            if (txtAddPhone.ForeColor == validFormat)
            {
                btnAddPhone.Enabled = true;
            }
            else
                btnAddPhone.Enabled = false;
        }

        private async void BtnDeletePhone_Click(object? sender, EventArgs e)
        {
            //sletter det valgte telefonummer og tilføjer til deletedphones
            if (dgvPhoneNumbers.SelectedRows.Count > 0)
            {
                //gemmer det valgte telefonnummer
                DataGridViewRow selectedRow = dgvPhoneNumbers.SelectedRows[0];
                PhoneUI selectedPhone = selectedRow.DataBoundItem as PhoneUI;

                //fjerner valgte nr fra telefonummer list
                phoneNumbers.Remove(selectedPhone);

                //tilføjer til liste over slettet numre
                deletedNumbers.Add(selectedPhone);

                //saetter deltajer for telefonnumre
                await SetPhoneDetailsAsync();
            }
        }

        private async void BtnAddPhone_Click(object? sender, EventArgs e)
        {
            //opretter nyt tlfnummer med indtastet nr
            PhoneUI tempP = new PhoneUI()
            {
                PhoneNumber = int.Parse(txtAddPhone.Text),
            };

            //tilføjer nummer til telefonnummer list
            phoneNumbers.Add(tempP);

            //clear txtphone
            txtAddPhone.Clear();

            //saetter telefonummer details
            await SetPhoneDetailsAsync();
        }

        private void BtnDeletePhoneEnabled()
        {
            //tester på om clienten har over 1 numre
            if (phoneNumbers.Count < 2)
            {
                btnDeletePhone.Enabled = false;
            }
            else
            {
                btnDeletePhone.Enabled = true;
            }
        }

        private async Task GetClientSubscriptionsAsync()
        {
            //henter clientens subscriptions
            subscriptions = await subscriptionBL.GetClientSubscriptionsAsync(client.PersonID);

            //henter subscription hvis gyldig findes
            ClientSubscriptionUI? activeSubscription = subscriptions.FirstOrDefault(cs => cs.EndDate >= DateTime.Now && cs.StartDate <= DateTime.Now);

            //hvis der er en gyldig sub
            if (activeSubscription != null)
            {
                //henter tid indtil sub udløber
                TimeSpan timeTillExpiration = activeSubscription.EndDate - DateTime.Now;
                int daysUntilExpiration = (int)timeTillExpiration.TotalDays;
                
                //saetter text til hvornår sub udløber
                lblSubscribed.Text = lblSubscribed.Text + $" - Expires in: {daysUntilExpiration} Days";
            }

        }

        private void BtnSubscriptionDetails_Click(object? sender, EventArgs e)
        {
            //aabner details view på clientens subscriptions
            SubscriptionDetailsView subscriptionDetailsView = new SubscriptionDetailsView(client, subscriptions);
            subscriptionDetailsView.ShowDialog();
        }

        private async void SetDetails(ClientUI client)
        {
            //udfylder alle txtfelter med info for client
            txtFirstname.Text = client.Firstname;
            txtLastname.Text = client.Lastname;
            txtEmail.Text = client.Email;
            txtAddress.Text = client.AddressLine;
            txtPostal.Text = client.PostalCode.ToString();
            lblCity.Text = client.City;
            if (client.IsSubscribed == false) { lblSubscribed.Text = "No"; }
            else if (client.IsSubscribed == true) { lblSubscribed.Text = "Yes"; }
            else { lblSubscribed.Text = "Undefined"; }

            //kalder metode til at saette telefon details
            await SetPhoneDetailsAsync();
        }

        //saet telefon details
        private async Task SetPhoneDetailsAsync()
        {
            //sætter dgvphonenumbers til null
            dgvPhoneNumbers.DataSource = null;

            //hvis list af telefonnumre er null så hent
            if (phoneNumbers == null)
            {
                phoneNumbers = await clientBL.GetClientPhonesAsync(client.PersonID);
            }

            //kalder metode for at enable/disable deletephone knap
            BtnDeletePhoneEnabled();

            //setup for dgvPhonenumbers
            dgvPhoneNumbers.DataSource = phoneNumbers;
            dgvPhoneNumbers.Columns["PhoneID"].Visible = false;
            dgvPhoneNumbers.Columns["ClientID"].Visible = false;
            dgvPhoneNumbers.ColumnHeadersVisible = false;
            dgvPhoneNumbers.RowHeadersVisible = false;
            dgvPhoneNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        
        public async Task SetBoughtFormsDGVAsync()
        {
            //henter clientens købte forms
            boughtForms = await formBL.GetBoughtFormDocumentsAsync(client.PersonID);

            //setup for købte forms dgv
            dgvBoughtForms.DataSource = boughtForms;
            dgvBoughtForms.Columns["FormDocumentID"].Visible = false;
            dgvBoughtForms.Columns["Description"].Visible = false;
            dgvBoughtForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoughtForms.ReadOnly = true;
            dgvBoughtForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBoughtForms.EnableHeadersVisualStyles = false;
            dgvBoughtForms.RowHeadersVisible = false;

            dgvBoughtForms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvBoughtForms.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);


        }
        private void DgvBoughtForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                //gemmer den valgte form
                FormDocumentUI selectedForm = boughtForms[e.RowIndex];
                //åbner details for den valgte form
                FormDetails formDetails = new FormDetails(selectedForm, client);
                formDetails.ShowDialog();
            }
        }

        public async Task SetCasesDGVAsync()
        {
            //henter alle cases hvor clienten er tilknyttet
            cases = await caseBL.GetCasesAsync(client.PersonID);

            //setup cases dgv
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
            dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCases.EnableHeadersVisualStyles = false;
            dgvCases.RowHeadersVisible = false;

            dgvCases.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvCases.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

        }

        private void DgvCases_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //declare
                CaseDetailsView caseDetailsView;
                
                //gemmer valgte case
                CaseUI selectedCase = cases[e.RowIndex];

                //tester på om den nuvrende bruger er client eller ik og instanciere caseDetailsView
                if(currentUser is ClientUI)
                    caseDetailsView = new CaseDetailsView(selectedCase.CaseID, true, true);
                else
                    caseDetailsView = new CaseDetailsView(selectedCase.CaseID, false, true);

                //åben details på casen
                caseDetailsView.ShowDialog();
            }
        }


        private void btnUpdateEnabled()
        {
            //tester på at alle indputs er valid og enabler/disabler update knap
            btnUpdate.Enabled =
                txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtEmail.ForeColor == validFormat &&
                txtAddress.ForeColor == validFormat &&
                txtPostal.ForeColor == validFormat
                ? true : false;
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            //test på firstname input
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }
        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            //test på lastname input
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }
        private void txtEmail_TextChanged(object? sender, EventArgs e)
        {
            //test på email input
            txtEmail.ForeColor = pValidator.ValidEmail(txtEmail.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            //test på address input
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            //test på postal input
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

    }
}
