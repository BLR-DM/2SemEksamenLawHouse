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
    public partial class CaseDetailsView : Form
    {
        ClientUI selectedClient;
        int selectedCaseID;
        LawyerUI selectedLawyer;
        CaseUI selectedCase;

        List<CaseServiceUI> caseServiceList;
        List<CaseTypeUI> caseTypeUIList;

        Color validFormat;
        Color invalidFormat;

        ClientBL clientBL;
        LawyerBL lawyerBL;
        CaseBL caseBL;
        ServiceBL serviceBL;
        CaseServiceBL caseServiceBL;
        CaseTypeBL caseTypeBL;
        CaseValidator cValidator;

        bool isEstimatedEndDateValid;
        public CaseDetailsView(int selectedCaseID)
        {
            InitializeComponent();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
            caseBL = new CaseBL();
            serviceBL = new ServiceBL();
            caseServiceBL = new CaseServiceBL();
            caseTypeBL = new CaseTypeBL();
            cValidator = new CaseValidator();
            this.selectedCaseID = selectedCaseID;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            dgvServices.CellDoubleClick += DgvServices_CellDoubleClick;
            btnAddService.Click += BtnAddService_Click;
            btnUpdateCase.Click += BtnUpdateCase_Click;
            btnCloseCase.Click += BtnCloseCase_Click;
            txtTitle.TextChanged += TxtTitle_TextChanged;
            dtpEstimatedEndDate.ValueChanged += DtpEstimatedEndDate_ValueChanged;
            txtEstimatedHours.TextChanged += TxtEstimatedHours_TextChanged;
           

            btnUpdateCase.Enabled = false;

            InitializeData();

        }

        private async void BtnCloseCase_Click(object? sender, EventArgs e)
        {
            btnCloseCase.Enabled = false;

            selectedCase.Status = "Finished";

            bool succes = await caseBL.UpdateCaseSync(selectedCase);

            if(succes)
            {
                MessageBox.Show("Jeow");
            }
            else
            {
                MessageBox.Show("niks");
            }

        }

        public async Task InitializeData()
        {
            await SetCaseData();
            SetDgv();
            SetComboBox();
            SetClientData();
            SetLawyerData();
        }

        private void TxtEstimatedHours_TextChanged(object? sender, EventArgs e)
        {
            txtEstimatedHours.ForeColor = cValidator.ValidEstimatedHours(txtEstimatedHours.Text) ? validFormat : invalidFormat;
            BtnUpdateEnabled();
        }

        private void DtpEstimatedEndDate_ValueChanged(object? sender, EventArgs e)
        {
            isEstimatedEndDateValid = cValidator.ValidEndDate(dtpEstimatedEndDate.Value);
            BtnUpdateEnabled();
        }

        private void TxtTitle_TextChanged(object? sender, EventArgs e)
        {
            txtTitle.ForeColor = cValidator.ValidTitle(txtTitle.Text) ? validFormat : invalidFormat;
            BtnUpdateEnabled();
        }

        private async void BtnUpdateCase_Click(object? sender, EventArgs e)
        {
            btnUpdateCase.Enabled = false;

            CaseUI caseUpdate = new CaseUI()
            {
                CaseID = selectedCase.CaseID,
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                CreationDate = selectedCase.CreationDate,
                EndDate = dtpEstimatedEndDate.Value,
                EstimatedHours = float.Parse(txtEstimatedHours.Text),
                Status = selectedCase.Status,
                TotalPrice = selectedCase.TotalPrice,

                CaseTypeID = selectedCase.CaseTypeID,
                LawyerID = selectedCase.LawyerID,
                ClientID = selectedCase.ClientID,
            };

            bool succes = await caseBL.UpdateCaseSync(caseUpdate);
            if(succes)
            {
                MessageBox.Show("Case updated");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
            btnUpdateCase.Enabled = true;

        }

        public bool BtnUpdateEnabled()
        {
            return btnUpdateCase.Enabled =
                txtTitle.ForeColor == validFormat &&
                txtEstimatedHours.ForeColor == validFormat &&
                isEstimatedEndDateValid;

        }

        private void BtnAddService_Click(object? sender, EventArgs e)
        {
            
            AddServiceView addServiceView = new AddServiceView(selectedCase, this);
            addServiceView.ShowDialog();
        }

        private void DgvServices_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                CaseServiceUI selectedCaseService = caseServiceList[e.RowIndex] as CaseServiceUI;
                ServiceDetailsView serviceDetailsView = new ServiceDetailsView(selectedCaseService);
                serviceDetailsView.ShowDialog();

            }
        }

        public async Task SetCaseData()
        {
            selectedCase = await caseBL.GetCaseAsync(selectedCaseID);

            txtTitle.Text = selectedCase.Title;
            dtpEstimatedEndDate.Value = selectedCase.EndDate;
            txtEstimatedHours.Text = selectedCase.EstimatedHours.ToString();
            txtTotalPrice.Text = selectedCase.TotalPrice.ToString();
            txtDescription.Text = selectedCase.Description;


        }

        public async Task SetClientData()
        {
            selectedClient = await clientBL.GetClientAsync(selectedCase.ClientID);
            txtClientFirstname.Text = selectedClient.Firstname;
            txtClientLastName.Text = selectedClient.Lastname;
            txtClientEmail.Text = selectedClient.Email;
            txtClientAddress.Text = selectedClient.AddressLine;
            txtClientPhoneNumber1.Text = selectedClient.MainPhone.ToString();
            txtClientPostalCode.Text = selectedClient.PostalCode.ToString();
        }

        public async Task SetLawyerData()
        {
            selectedLawyer = await lawyerBL.GetLawyerAsync(selectedCase.LawyerID);
            txtLawyerFirstName.Text = selectedLawyer.Firstname;
            txtLawyerLastName.Text = selectedLawyer.Lastname;
            txtLawyerPhone.Text = selectedLawyer.PhoneNumber.ToString();
        }


        public async Task SetDgv()
        {

            caseServiceList = await caseServiceBL.GetCaseServicesAsync(selectedCase.CaseID);

            dgvServices.DataSource = caseServiceList;

            dgvServices.Columns["CaseServiceID"].Visible = false;
            dgvServices.Columns["ServiceID"].Visible = false;
            dgvServices.Columns["LawyerID"].Visible = false;
            dgvServices.Columns["CaseID"].Visible = false;
            dgvServices.Columns["Description"].Visible = false;


            dgvServices.Columns["ServiceName"].DisplayIndex = 0;
            dgvServices.Columns["TotalPrice"].DisplayIndex = 1;
            dgvServices.Columns["Units"].DisplayIndex = 2;
            dgvServices.Columns["PriceType"].DisplayIndex = 3;
            dgvServices.Columns["Date"].DisplayIndex = 4;

            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public async Task SetComboBox()
        {
            caseTypeUIList = await caseTypeBL.GetCaseTypeAsync();

            cboxCaseType.DisplayMember = "Title";

            foreach (CaseTypeUI caseTypeUI in caseTypeUIList)
            {
                cboxCaseType.Items.Add(caseTypeUI);
            }

            cboxCaseType.SelectedIndex = selectedCase.CaseTypeID;
        }

    }
}
