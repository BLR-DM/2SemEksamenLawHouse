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

namespace UI.Forms.CasePage
{
    public partial class CreateCasePage : Form
    {
        CaseBL caseBL;
        CaseTypeBL caseTypeBL;
        List<CaseTypeUI> caseTypeUIList;
        ClientUI selectedClient;
        LawyerUI selectedLawyer;
        public CreateCasePage()
        {
            InitializeComponent();
            caseBL = new CaseBL();
            caseTypeBL = new CaseTypeBL();

            btnAddClient.Click += BtnAddClient_Click;
            btnAddLawyer.Click += BtnAddLawyer_Click;
            btnCreateCase.Click += BtnCreateCase_Click;

            SetComboBox();
        }

        private async void BtnCreateCase_Click(object? sender, EventArgs e)
        {
            btnCreateCase.Enabled = false;

            CaseTypeUI selectedCaseType = (CaseTypeUI)cboxCaseType.SelectedItem;

            if (selectedCaseType == null)
            {
                MessageBox.Show("Please select a case type.");
                btnCreateCase.Enabled = true; 
                return;
            }

            CaseUI caseUI = new CaseUI()
            {
                Title = txtTitle.Text,
                CreationDate = DateTime.Now,
                EndDate = dtpEstimatedEndDate.Value,
                EstHours = float.Parse(txtEstimatedHours.Text),
                Status = "Active",
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
            AddLawyerView addLawyerView = new AddLawyerView();

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

        }
    }
}
