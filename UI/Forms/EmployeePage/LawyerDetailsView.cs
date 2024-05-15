using UIModels;
using BusinessLogic;
using UI.Toolbox;

namespace UI.Forms.EmployeePage
{
    public partial class LawyerDetailsView : Form
    {
        LawyerBL lawyerBL;
        LawyerUI lawyerUI;
        CaseServiceBL caseServiceBL;
        List<CaseServiceUI> caseServices;
        int lawyerID;
        public LawyerDetailsView(int lawyerID, bool isMyPage)
        {
            this.lawyerID = lawyerID;
            
            lawyerBL = new LawyerBL();
            lawyerUI = new LawyerUI();
            //caseServiceBL = new CaseServiceBL();
            //caseServices = new List<CaseServiceUI>();

            InitializeComponent();

            CheckUser(isMyPage);

            pnlEdit.Visible = false;
            btnCancel.Visible = false;

            Load += MyPageLawyerView_Load;
            chboxShowAll.CheckedChanged += ChboxClosed_CheckedChanged;
            btnEditDetails.Click += BtnEditDetails_Click;
            pnlEdit.VisibleChanged += PnlEdit_VisibleChanged;
            btnCancel.Click += BtnCancel_Click;
        }

        private void CheckUser(bool myPage)
        {
            if (!myPage)
            {
                btnEditDetails.Visible = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private async void MyPageLawyerView_Load(object? sender, EventArgs e)
        {
            lawyerUI = await GetLawyerAsync();
            if (lawyerUI != null)
            {
                DisplayLawyer(lawyerUI);
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
            pnlEdit.Controls.Add(new LawyerCardEdit(lawyerUI));
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
            pnlLawyerDetails.Controls.Add(new EmployeeCardDisplay(lawyerUI));
        }

        private async Task<LawyerUI> GetLawyerAsync()
        {
            return await lawyerBL.GetLawyerWithCollectionsAsync(lawyerID);
        }

        private void SetDgvData(bool check)
        {
            dgvCases.DataSource = lawyerUI.Cases;
            //dgvServices.DataSource = caseServices;
            dgvServices.DataSource = lawyerUI.CaseServices;

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
