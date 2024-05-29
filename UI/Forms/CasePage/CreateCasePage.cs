using BusinessLogic;
using BusinessLogic.HelpServices;
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
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class CreateCasePage : Form
    {
        CaseBL caseBL;
        CaseTypeBL caseTypeBL;

        List<CaseTypeUI> caseTypeUIList;
        ClientUI selectedClient;
        LawyerUI selectedLawyer;
        CaseValidator cValidator;

        FrontPageView f1;
        CasePageView casePageView;

        Color validFormat;
        Color invalidFormat;

        bool isEstimatedEndDateValid;
        public CreateCasePage(FrontPageView f1, CasePageView casePageView)
        {
            InitializeComponent();
            caseBL = new CaseBL();
            caseTypeBL = new CaseTypeBL();
            cValidator = new CaseValidator();

            this.f1 = f1;
            this.casePageView = casePageView;

            btnAddClient.Click += BtnAddClient_Click;
            btnAddLawyer.Click += BtnAddLawyer_Click;
            btnCreateCase.Click += BtnCreateCase_Click;
            txtTitle.TextChanged += TxtTitle_TextChanged;
            txtEstimatedHours.TextChanged += TxtEstimatedHours_TextChanged;
            cboxCaseType.SelectedIndexChanged += CboxCaseType_SelectedIndexChanged;
            dtpEstimatedEndDate.ValueChanged += DtpEstimatedEndDate_ValueChanged;
            txtDescription.TextChanged += TxtDescription_TextChanged;
            lblHelp.Click += LblHelp_Click;


            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCreateCase.Enabled = false;
            SetComboBox();
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("CreateCaseViewHelp");
        }

        private void TxtDescription_TextChanged(object? sender, EventArgs e)
        {
            txtDescription.ForeColor = cValidator.ValidDescription(txtDescription.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void DtpEstimatedEndDate_ValueChanged(object? sender, EventArgs e)
        {
            isEstimatedEndDateValid = cValidator.ValidEndDate(dtpEstimatedEndDate.Value);
            BtnCreateEnabled();
        }

        private void CboxCaseType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            BtnCreateEnabled();
        }

        private void TxtEstimatedHours_TextChanged(object? sender, EventArgs e)
        {
            txtEstimatedHours.ForeColor = cValidator.ValidEstimatedHours(txtEstimatedHours.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtTitle_TextChanged(object? sender, EventArgs e)
        {
            txtTitle.ForeColor = cValidator.ValidTitle(txtTitle.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }


        private bool BtnCreateEnabled()
        {
            //Håndterer adfærden på CreateCase knappen, så den kun er enabled, hvis alle felter overholder valideringen
            return btnCreateCase.Enabled =
                txtTitle.ForeColor == validFormat &&
                cboxCaseType.SelectedItem != null &&
                txtEstimatedHours.ForeColor == validFormat &&
                isEstimatedEndDateValid &&
                txtDescription.ForeColor == validFormat &&
                selectedClient != null &&
                selectedLawyer != null;
        }

        private async void BtnCreateCase_Click(object? sender, EventArgs e)
        {
            btnCreateCase.Enabled = false;

            CaseTypeUI selectedCaseType = (CaseTypeUI)cboxCaseType.SelectedItem;

            CaseUI caseUI = new CaseUI()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                CreationDate = DateTime.Now,
                EndDate = dtpEstimatedEndDate.Value,
                EstimatedHours = float.Parse(txtEstimatedHours.Text),
                Status = "Open",
                TotalPrice = 0,

                CaseTypeID = selectedCaseType.CaseTypeID,
                LawyerID = selectedLawyer.PersonID,
                ClientID = selectedClient.PersonID,
            };

            DialogResult dialogResult = MessageBox.Show("Do you wish to create this new case?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bool succes = await caseBL.CreateCaseAsync(caseUI);
                if (succes)
                {
                    MessageBox.Show("Case created");
                    await casePageView.SetDgvAsync();
                    f1.PnlContextChange(casePageView);
                }
                else
                {
                    MessageBox.Show("Error! Couldnt create case");
                } 
            }

            btnCreateCase.Enabled = true; 
        }


        private async void SetComboBox()
        {
            caseTypeUIList = await caseTypeBL.GetCaseTypeAsync();

            cboxCaseType.DisplayMember = "Title";

            foreach(CaseTypeUI caseTypeUI in caseTypeUIList)
            {
                cboxCaseType.Items.Add(caseTypeUI);
            }
        }

        private void BtnAddLawyer_Click(object? sender, EventArgs e)
        {
            AddLawyerView addLawyerView = new AddLawyerView();

            addLawyerView.LawyerSelected += AddLawyerView_LawyerSelected;

            addLawyerView.ShowDialog();
        }

        private void AddLawyerView_LawyerSelected(object? sender, LawyerUI e)
        {
            //metoden er en event handler som bliver kaldt, når hændelsen LawyerSelected bliver kaldt fra AddLawyerView, hvor LawyerUI e er dataen fra den selectedlawyer i AddLawyerView.

            txtLawyerFirstName.Text = e.Firstname;
            txtLawyerLastName.Text = e.Lastname;
            txtLawyerEmail.Text = e.Email;
            txtLawyerPhone.Text = e.PhoneNumber.ToString();

            //gemmer den valgte advokat i en variabel selectedLawyer for senere brug
            selectedLawyer = e;

            BtnCreateEnabled();
        }

        private void BtnAddClient_Click(object? sender, EventArgs e)
        {
            AddClientView addClientView = new AddClientView();

            addClientView.ClientSelected += AddClientView_ClientSelected;
           
            addClientView.ShowDialog();

        }

        private void AddClientView_ClientSelected(object? sender, ClientUI e)
        {

            txtClientFirstname.Text = e.Firstname;
            txtClientLastName.Text = e.Lastname;
            txtClientAddress.Text = e.AddressLine;
            txtClientPhoneNumber1.Text = e.MainPhone.ToString();
            txtClientPostalCode.Text = e.PostalCode.ToString();
            txtClientEmail.Text = e.Email;

            selectedClient = e;
            BtnCreateEnabled();
        }
    }
}
