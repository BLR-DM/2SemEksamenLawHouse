using UIModels;
using BusinessLogic;
using UI.Toolbox;

namespace UI.Forms.EmployeePage
{
    public partial class LawyerDetailsView : Form
    {
        LawyerUI displayedLawyerUI;
        bool isMyPage;
        bool isAdmin;
        public LawyerDetailsView(LawyerUI displayedLawyerUI, bool isMyPage, EmployeeUI currentUser)
        {
            this.displayedLawyerUI = displayedLawyerUI;
            this.isMyPage = isMyPage;

            if (currentUser is LawyerUI lawyerUI)
            {
                isAdmin = lawyerUI.Admin;
            }

            InitializeComponent();

            pnlEdit.Visible = false;
            btnCancel.Visible = false;

            Load += LawyerDetailsView_Load;
            chboxServicesShowAll.CheckedChanged += ChboxClosed_CheckedChanged;
            chboxCasesShowAll.CheckedChanged += ChboxCasesShowAll_CheckedChanged;
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

            btnEditDetails.Visible = isMyPage || isAdmin;
        }
        private async void LawyerDetailsView_Load(object? sender, EventArgs e)
        {
            chboxServicesShowAll.Checked = false;

            if (displayedLawyerUI != null)
            {
                DisplayLawyer(displayedLawyerUI);
                SetCasesDgv(chboxCasesShowAll.Checked);
                SetServicesDgv(chboxServicesShowAll.Checked);
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

        private void ChboxCasesShowAll_CheckedChanged(object? sender, EventArgs e)
        {
            SetCasesDgv(chboxCasesShowAll.Checked);
        }

        private void ChboxClosed_CheckedChanged(object? sender, EventArgs e)
        {
            SetServicesDgv(chboxServicesShowAll.Checked);
        }

        private void DisplayLawyer(LawyerUI lawyer)
        {
            pnlLawyerDetails.Controls.Clear();
            pnlLawyerDetails.Controls.Add(new EmployeeCardDisplay(displayedLawyerUI));
        }
        private void SetCasesDgv(bool serviceShowAllCheck)
        {
            if (serviceShowAllCheck)
                dgvCases.DataSource = displayedLawyerUI.Cases;
            else
                dgvCases.DataSource = displayedLawyerUI.Cases
                    .Where(c => c.Status == "Open")
                    .ToList();
        }
            private void SetServicesDgv(bool serviceShowAllCheck)
        {

            if (serviceShowAllCheck)
                dgvServices.DataSource = displayedLawyerUI.CaseServices;
            else
                dgvServices.DataSource = displayedLawyerUI.CaseServices
                    .Where(cs => cs.Status == "Open")
                    .ToList();
        }
    }
}
