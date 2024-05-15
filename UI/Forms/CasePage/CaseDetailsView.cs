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
using UI.Toolbox;

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

        bool isClient;

        bool isEstimatedEndDateValid;
        public CaseDetailsView(int selectedCaseID, bool isClient)
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
            this.isClient = isClient;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            dgvServices.CellDoubleClick += DgvServices_CellDoubleClick;
            btnAddService.Click += BtnAddService_Click;
            btnUpdateCase.Click += BtnUpdateCase_Click;
            btnUpdateCaseStatus.Click += BtnCloseCase_Click;
            txtTitle.TextChanged += TxtTitle_TextChanged;
            dtpEstimatedEndDate.ValueChanged += DtpEstimatedEndDate_ValueChanged;
            txtEstimatedHours.TextChanged += TxtEstimatedHours_TextChanged;


            btnUpdateCase.Enabled = false;

            InitializeData();

            //fjerner knapper hvis brugeren er client
            if (isClient)
            {
                btnAddService.Visible = false;
                btnUpdateCase.Visible = false;
                btnUpdateCaseStatus.Visible = false;
            }

        }

        private async void BtnCloseCase_Click(object? sender, EventArgs e)
        {
            if (caseServiceList.Count == 0)
            {
                MessageBox.Show("Cannot close case without any services connected");
                return;
            }

            foreach (CaseServiceUI caseServiceUI in caseServiceList)
            {
                if (caseServiceUI.Status == "Active")
                {
                    MessageBox.Show("Cannot close case with active services");
                    return;
                }
            }
            btnUpdateCaseStatus.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Do you wanna close this case", "Close case", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                selectedCase.Status = "Closed";
                selectedCase.EndDate = DateTime.Now;
                if (await caseBL.UpdateCaseSync(selectedCase))
                {
                    MessageBox.Show("Case closed");
                }
                else
                {
                    MessageBox.Show("Failed to close the case");
                    btnUpdateCaseStatus.Enabled = true;
                }
            }
        }

        public async Task InitializeData()
        {
            await SetCaseDataAsync();
            await SetDgvAsync();
            await SetComboBox();
            await SetClientDataAsync();
            await SetLawyerDataAsync();
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
            CaseTypeUI selectedCaseType = cboxCaseType.SelectedItem as CaseTypeUI;

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

                CaseTypeID = selectedCaseType.CaseTypeID,
                LawyerID = selectedCase.LawyerID,
                ClientID = selectedCase.ClientID,
            };

            bool succes = await caseBL.UpdateCaseSync(caseUpdate);
            if (succes)
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
            if (e.RowIndex >= 0)
            {
                ServiceDetailsView serviceDetailsView;

                DataGridViewRow selectedRow = dgvServices.Rows[e.RowIndex];
                if (selectedRow.Cells["PriceType"].Value.ToString() != null)
                {
                    CaseServiceUI selectedCaseService = caseServiceList[e.RowIndex] as CaseServiceUI;
                    
                    if (isClient)
                    {
                        serviceDetailsView = new ServiceDetailsView(this, selectedCaseService, true);
                    }
                    else
                    {
                       serviceDetailsView = new ServiceDetailsView(this, selectedCaseService, false);
                    }
                    serviceDetailsView.ShowDialog();
                }

            }
        }

        public async Task SetCaseDataAsync()
        {
            selectedCase = await caseBL.GetCaseAsync(selectedCaseID);

            if (selectedCase != null)
            {
                txtTitle.Text = selectedCase.Title;
                dtpEstimatedEndDate.Value = selectedCase.EndDate;
                txtEstimatedHours.Text = selectedCase.EstimatedHours.ToString();
                txtTotalPrice.Text = selectedCase.TotalPrice.ToString();
                txtDescription.Text = selectedCase.Description;
                lblStatus.Text = selectedCase.Status;
                txtCaseID.Text = selectedCase.CaseID.ToString();

                if (selectedCase.Status == "Closed")
                {
                    lblEstimatedEndDate.Text = "End Date";
                }
                else
                {

                }
            }

        }

        public async Task SetClientDataAsync()
        {
            selectedClient = await clientBL.GetClientAsync(selectedCase.ClientID);
            pnlClientInformation.Controls.Add(new ClientInformation(selectedClient));
        }

        public async Task SetLawyerDataAsync()
        {
            selectedLawyer = await lawyerBL.GetLawyerAsync(selectedCase.LawyerID);
            pnlLawyerInformation.Controls.Add(new LawyerInformation(selectedLawyer));
        }

        public async Task SetDgvAsync()
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
            dgvServices.Columns["StartDate"].DisplayIndex = 4;
            dgvServices.Columns["StartDate"].DefaultCellStyle.Format = "yyyy/MM/dd";
            dgvServices.Columns["EndDate"].DefaultCellStyle.Format = "yyyy/MM/dd";


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

            cboxCaseType.SelectedItem = caseTypeUIList.Where(ct => ct.CaseTypeID == selectedCase.CaseTypeID).FirstOrDefault();
        }

    }

}
