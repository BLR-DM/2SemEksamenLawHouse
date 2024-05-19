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
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class CreateCasePage : Form
    {
        CaseBL caseBL;
        CaseTypeBL caseTypeBL;
        SpecialityBL specialityBL;
        LawyerBL lawyerBL;
        ClientBL clientBL;

        List<CaseTypeUI> caseTypeUIList;
        ClientUI selectedClient;
        LawyerUI selectedLawyer;
        CaseValidator cValidator;

        Color validFormat;
        Color invalidFormat;

        bool isEstimatedEndDateValid;
        public CreateCasePage(CaseBL caseBL, CaseTypeBL caseTypeBL, SpecialityBL specialityBL, LawyerBL lawyerBL, ClientBL clientBL)
        {
            InitializeComponent();
            this.caseBL = caseBL;
            this.caseTypeBL = caseTypeBL;
            this.specialityBL = specialityBL;
            this.lawyerBL = lawyerBL;
            this.clientBL = clientBL;

            cValidator = new CaseValidator();

            btnAddClient.Click += BtnAddClient_Click;
            btnAddLawyer.Click += BtnAddLawyer_Click;
            btnCreateCase.Click += BtnCreateCase_Click;
            txtTitle.TextChanged += TxtTitle_TextChanged;
            txtEstimatedHours.TextChanged += TxtEstimatedHours_TextChanged;
            cboxCaseType.SelectedIndexChanged += CboxCaseType_SelectedIndexChanged;
            dtpEstimatedEndDate.ValueChanged += DtpEstimatedEndDate_ValueChanged;
            txtDescription.TextChanged += TxtDescription_TextChanged;


            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCreateCase.Enabled = false;
            SetComboBox();
        }

        private void TxtDescription_TextChanged(object? sender, EventArgs e)
        {
            txtDescription.ForeColor = cValidator.ValidDescription(txtDescription.Text) ? validFormat : invalidFormat;
        }

        private void DtpEstimatedEndDate_ValueChanged(object? sender, EventArgs e)
        {
            isEstimatedEndDateValid = cValidator.ValidEndDate(dtpEstimatedEndDate.Value);
            btnCreateEnablid();
        }

        private void CboxCaseType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            btnCreateEnablid();
        }

        private void TxtEstimatedHours_TextChanged(object? sender, EventArgs e)
        {
            txtEstimatedHours.ForeColor = cValidator.ValidEstimatedHours(txtEstimatedHours.Text) ? validFormat : invalidFormat;
            btnCreateEnablid();
        }

        private void TxtTitle_TextChanged(object? sender, EventArgs e)
        {
            txtTitle.ForeColor = cValidator.ValidTitle(txtTitle.Text) ? validFormat : invalidFormat;
            btnCreateEnablid();
        }


        public bool btnCreateEnablid()
        {
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

            bool succes = await caseBL.CreateCase(caseUI);
            if (succes)
            {
                MessageBox.Show("Case created");
            }
            else
            {
                MessageBox.Show("FEJL");
            }

            btnCreateCase.Enabled = true;
        }


        public async void SetComboBox()
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
            AddLawyerView addLawyerView = new AddLawyerView(lawyerBL, specialityBL);

            addLawyerView.LawyerSelected += AddLawyerView_LawyerSelected;

            addLawyerView.ShowDialog();
        }

        private void AddLawyerView_LawyerSelected(object? sender, LawyerUI e)
        {
            txtLawyerFirstName.Text = e.Firstname;
            txtLawyerLastName.Text = e.Lastname;
            txtLawyerEmail.Text = e.Email;
            txtLawyerPhone.Text = e.PhoneNumber.ToString();

            selectedLawyer = e;
            btnCreateEnablid();
        }

        private void BtnAddClient_Click(object? sender, EventArgs e)
        {
            AddClientView addClientView = new AddClientView(clientBL);

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
            btnCreateEnablid();
        }
    }
}
