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
    public partial class CaseDetailsView : Form
    {
        ClientUI selectedClient;
        CaseUI selectedCase;
        LawyerUI selectedLawyer;

        List<CaseServiceUI> caseServiceList;
        List<CaseTypeUI> caseTypeUIList;

        ClientBL clientBL;
        LawyerBL lawyerBL;
        ServiceBL serviceBL;
        CaseServiceBL caseServiceBL;
        CaseTypeBL caseTypeBL;
        public CaseDetailsView(CaseUI selectedCase)
        {
            InitializeComponent();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
            serviceBL = new ServiceBL();
            caseServiceBL = new CaseServiceBL();
            caseTypeBL = new CaseTypeBL();
            this.selectedCase = selectedCase;

            dgvServices.CellDoubleClick += DgvServices_CellDoubleClick;
            btnAddService.Click += BtnAddService_Click;

            SetData();
            SetDgv();
            SetComboBox();

        }

        private void BtnAddService_Click(object? sender, EventArgs e)
        {
            
            AddServiceView addServiceView = new AddServiceView();
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

        public async Task SetData()
        {
            selectedClient = await clientBL.GetClientAsync(selectedCase.ClientID);

            txtClientFirstname.Text = selectedClient.Firstname;
            txtClientLastName.Text = selectedClient.Lastname;
            txtClientEmail.Text = selectedClient.Email;
            txtClientAddress.Text = selectedClient.AddressLine;
            txtClientPhoneNumber1.Text = selectedClient.MainPhone.ToString();
            txtClientPostalCode.Text = selectedClient.PostalCode.ToString();

            selectedLawyer = await lawyerBL.GetLawyerAsync(selectedCase.LawyerID);
            txtLawyerFirstName.Text = selectedLawyer.Firstname;
            txtLawyerLastName.Text = selectedLawyer.Lastname;
            txtLawyerPhone.Text = selectedLawyer.PhoneNumber.ToString();

            txtTitle.Text = selectedCase.Title;
            dtpEstimatedEndDate.Value = selectedCase.EndDate;
            txtEstimatedHours.Text = selectedCase.EstHours.ToString();


        }

        public async Task SetDgv()
        {
            caseServiceList = await caseServiceBL.GetCaseServicesAsync(selectedCase.CaseID);

            dgvServices.DataSource = caseServiceList;

            dgvServices.Columns["CaseServiceID"].Visible = false;
            dgvServices.Columns["ServiceID"].Visible = false;
            dgvServices.Columns["LawyerID"].Visible = false;
            dgvServices.Columns["CaseID"].Visible = false;

            dgvServices.Columns["ServiceName"].DisplayIndex = 0;
            dgvServices.Columns["ServiceType"].DisplayIndex = 1;
            dgvServices.Columns["Date"].DisplayIndex = 2;
            dgvServices.Columns["TotalPrice"].DisplayIndex = 3;
            dgvServices.Columns["Units"].DisplayIndex = 4;

            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public async void SetComboBox()
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
