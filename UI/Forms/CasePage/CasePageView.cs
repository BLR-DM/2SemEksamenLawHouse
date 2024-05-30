using BusinessLogic;
using BusinessLogic.HelpServices;
using System.Data;
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class CasePageView : Form
    {
        CaseTypeBL caseTypeBL;
        LawyerBL lawyerBL;
        CaseBL caseBL;
        FrontPageView f1;

        List<CaseTypeUI> caseTypeList;
        List<LawyerUI> lawyerList;
        List<CaseUI> originalCaseList;
        List<CaseUI> filteredCases;

        public CasePageView(FrontPageView f1)
        {
            InitializeComponent();
            caseTypeBL = new CaseTypeBL();
            lawyerBL = new LawyerBL();
            caseBL = new CaseBL();


            this.f1 = f1;

            dgvCaseList.CellDoubleClick += DgvCaseList_CellDoubleClick;
            btnCreateCase.Click += BtnCreateCase_Click;
            txtTitle.TextChanged += TxtTitle_TextChanged;
            ckboxClosed.CheckedChanged += CkboxFinsished_CheckedChanged;
            ckboxActive.CheckedChanged += CkboxActive_CheckedChanged;
            cboLawyers.SelectionChangeCommitted += CboLawyers_SelectionChangeCommitted;
            cboCaseType.SelectionChangeCommitted += CboCaseType_SelectionChangeCommitted;
            lblHelp.Click += LblHelp_Click;

            SetLawyerComboBoxAsync();
            SetCaseTypeComboBoxAsync();
            SetDgvAsync();
            SetDgvStyle();

        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("CasePageViewHelp");
        }

        private void CboCaseType_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            lblNumberOfCases.Focus();
            SortDgv();
            dgvCaseList.CurrentCell = null;
        }

        private void CboLawyers_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            lblNumberOfCases.Focus();
            SortDgv();
            dgvCaseList.CurrentCell = null;
        }

        private void CkboxActive_CheckedChanged(object? sender, EventArgs e)
        {
            SortDgv();
        }

        private void CkboxFinsished_CheckedChanged(object? sender, EventArgs e)
        {
            SortDgv();
        }

        private void TxtTitle_TextChanged(object? sender, EventArgs e)
        {
            SortDgv();
        }

        private void BtnCreateCase_Click(object? sender, EventArgs e)
        {
            CreateCasePage createCasePage = new CreateCasePage(f1, this);
            f1.PnlContextChange(createCasePage);
        }

        private void DgvCaseList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCaseList.Rows[e.RowIndex];
                if (selectedRow.Cells["CaseID"] != null)
                {
                    if (int.TryParse(selectedRow.Cells["CaseID"].Value.ToString(), out int id))
                    {
                        CaseDetailsView detailsView = new CaseDetailsView(id, false, false);
                        f1.PnlContextChange(detailsView);
                    }
                }
            }
        }

        private async Task SetCaseTypeComboBoxAsync()
        {
            caseTypeList = await caseTypeBL.GetCaseTypeAsync();

            cboCaseType.DisplayMember = "Title";

            cboCaseType.Items.Add(new CaseTypeUI { CaseTypeID = -1, Title = "Cases for all casetypes" });

            foreach (CaseTypeUI caseTypeUI in caseTypeList)
            {
                cboCaseType.Items.Add(caseTypeUI);
            }

            cboCaseType.SelectedIndex = 0;
        }
        private async Task SetLawyerComboBoxAsync()
        {

            lawyerList = await lawyerBL.GetLawyersAsync();

            cboLawyers.Items.Add(new LawyerUI { PersonID = -1, Firstname = "Cases for all lawyers" });

            foreach(LawyerUI lawyerUI in lawyerList)
            {
                cboLawyers.Items.Add(lawyerUI);
            }

            cboLawyers.SelectedIndex = 0;
        }


        public async Task SetDgvAsync()
        {
            originalCaseList = await caseBL.GetCasesAsync();
            dgvCaseList.DataSource = originalCaseList;

            int count = originalCaseList.Count;
            lblNumberOfCases.Text = $"{count} Cases";

            dgvCaseList.Columns["CaseTypeID"].Visible = false;
            dgvCaseList.Columns["LawyerID"].Visible = false;
            dgvCaseList.Columns["CaseServices"].Visible = false;
            dgvCaseList.Columns["CaseType"].Visible = false;
            dgvCaseList.Columns["Lawyer"].Visible = false;
            dgvCaseList.Columns["Client"].Visible = false;


            dgvCaseList.Columns["EndDate"].DefaultCellStyle.Format = "d";
            dgvCaseList.Columns["CreationDate"].DefaultCellStyle.Format = "d";
        }

        private void SetDgvStyle()
        {
            dgvCaseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvCaseList.EnableHeadersVisualStyles = false;

            dgvCaseList.RowHeadersVisible = false;

            dgvCaseList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvCaseList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvCaseList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvCaseList.DefaultCellStyle.SelectionForeColor = Color.Black;
        }


        private void SortDgv()
        {
            //ny liste filteredCase som arver fra den originale list
            filteredCases = new List<CaseUI>(originalCaseList);

            //tester på title
            if(!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.CaseID.ToString().StartsWith(txtTitle.Text)).ToList();
            }

            //tester på checkboxene
            if(ckboxActive.Checked && ckboxClosed.Checked)
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Status == "Open" || caseUI.Status == "Closed").ToList();
            }
            else if(ckboxActive.Checked && !ckboxClosed.Checked)
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Status == "Open").ToList();
            }
            else if(!ckboxActive.Checked && ckboxClosed.Checked)
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Status == "Closed").ToList();
            }

            //tester på combox
            if(cboCaseType.SelectedItem != null && cboCaseType.SelectedIndex != 0)
            {
                CaseTypeUI selectedCaseType = (CaseTypeUI)cboCaseType.SelectedItem;

                filteredCases = filteredCases.Where(caseUI => caseUI.CaseTypeID == selectedCaseType.CaseTypeID).ToList();
            }
            if(cboLawyers.SelectedItem != null && cboLawyers.SelectedIndex != 0)
            {
                LawyerUI selectedLawyer = (LawyerUI)cboLawyers.SelectedItem;

                filteredCases = filteredCases.Where(caseUI => caseUI.LawyerID == selectedLawyer.PersonID).ToList();
            }

            //sætter dgv'et til den sorterede liste
            dgvCaseList.DataSource = filteredCases;
            dgvCaseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            int count = filteredCases.Count;
            lblNumberOfCases.Text = $"{count} Cases";
        }
    }
}
