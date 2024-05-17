using UIModels;
using BusinessLogic;
using UI.Toolbox;

namespace UI.Forms.EmployeePage
{
    public partial class LawyerDetailsView : Form
    {
        LawyerBL lawyerBL;
        LawyerUI displayedLawyerUI;
        CaseServiceBL caseServiceBL;
        List<CaseServiceUI> caseServices;
        bool isMyPage;
        bool isAdmin;
        LawyerUI currentUser;
        EmployeeUI employeeUI;
        public LawyerDetailsView(LawyerUI displayedLawyerUI, bool isMyPage, EmployeeUI currentUser)
        {
            this.displayedLawyerUI = displayedLawyerUI;
            this.isMyPage = isMyPage;

            if (currentUser is LawyerUI lawyerUI)
            {;
                isAdmin = lawyerUI.Admin;
            }
            else
                employeeUI = currentUser;

            lawyerBL = new LawyerBL();
            
            //caseServiceBL = new CaseServiceBL();
            //caseServices = new List<CaseServiceUI>();

            InitializeComponent();

            pnlEdit.Visible = false;
            btnCancel.Visible = false;

            Load += MyPageLawyerView_Load;
            chboxShowAll.CheckedChanged += ChboxClosed_CheckedChanged;
            btnEditDetails.Click += BtnEditDetails_Click;
            pnlEdit.VisibleChanged += PnlEdit_VisibleChanged;
            btnCancel.Click += BtnCancel_Click;

            CheckUser();
        }

        private void CheckUser()
        {
            if (!isMyPage)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                StartPosition = FormStartPosition.CenterScreen;
            }

            if (isMyPage || isAdmin)
            {
                btnEditDetails.Visible = true;
            }
            else
                btnEditDetails.Visible = false;
        }
        private async void MyPageLawyerView_Load(object? sender, EventArgs e)
        {
            //displayedLawyerUI = await GetLawyerAsync();
            if (displayedLawyerUI != null)
            {
                DisplayLawyer(displayedLawyerUI);
                SetDgvData(chboxShowAll.Checked);
            }
        }

        private void PnlEdit_VisibleChanged(object? sender, EventArgs e)
        {
            if (!pnlEdit.Visible)
            {
                btnCancel.Visible = false;
                btnEditDetails.Enabled = true;
            }
            else
                btnCancel.Visible = true;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void BtnEditDetails_Click(object? sender, EventArgs e)
        {
            btnEditDetails.Enabled = false;

            pnlEdit.Controls.Clear();
            pnlEdit.Controls.Add(new LawyerCardEdit(displayedLawyerUI, isAdmin));
            pnlEdit.Visible = true;            
        }

        private void ChboxClosed_CheckedChanged(object? sender, EventArgs e)
        {
            SetDgvData(chboxShowAll.Checked);
        }


        //private async Task GetCaseServices()
        //{
        //    caseServices = await caseServiceBL.GetCaseServicesForLawyerAsync(lawyerID);
        //}

        private void DisplayLawyer(LawyerUI lawyer)
        {
            pnlLawyerDetails.Controls.Clear();
            pnlLawyerDetails.Controls.Add(new EmployeeCardDisplay(displayedLawyerUI));
        }

        private async Task<LawyerUI> GetLawyerAsync()
        {
            return await lawyerBL.GetLawyerWithCollectionsAsync(displayedLawyerUI.PersonID);
        }

        private void SetDgvData(bool check)
        {
            dgvCases.DataSource = displayedLawyerUI.Cases;
            //dgvServices.DataSource = caseServices;
            dgvServices.DataSource = displayedLawyerUI.CaseServices;

            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"].Value.ToString();
                    dgvServices.CurrentCell = null;
                    row.Visible = check || status == "Active";
                }
            }
        }
    }
}
