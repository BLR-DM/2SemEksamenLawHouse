using BusinessLogic;
using EntityModels;
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
            ckboxFinsished.CheckedChanged += CkboxFinsished_CheckedChanged;
            ckboxActive.CheckedChanged += CkboxActive_CheckedChanged;
            cboLawyers.SelectionChangeCommitted += CboLawyers_SelectionChangeCommitted;
            cboCaseType.SelectionChangeCommitted += CboCaseType_SelectionChangeCommitted;

            SetLawyerComboBox();
            SetCaseTypeComboBox();
            SetDgv();

        }

        private void CboCaseType_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            SortDgv();
        }

        private void CboLawyers_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            SortDgv();
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
            CreateCasePage createCasePage = new CreateCasePage();
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
                        CaseDetailsView detailsView = new CaseDetailsView(id);
                        f1.PnlContextChange(detailsView);
                    }
                }
            }
        }

        public async Task SetCaseTypeComboBox()
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
        public async Task SetLawyerComboBox()
        {

            lawyerList = await lawyerBL.GetLawyersAsync();

            cboLawyers.DisplayMember = "Firstname";

            cboLawyers.Items.Add(new LawyerUI { PersonID = -1, Firstname = "Cases for all lawyers" });

            foreach(LawyerUI lawyerUI in lawyerList)
            {
                cboLawyers.Items.Add(lawyerUI);
            }

            cboLawyers.SelectedIndex = 0;
        }


        public async Task SetDgv()
        {
            originalCaseList = await caseBL.GetCasesAsync();
            dgvCaseList.DataSource = originalCaseList;

            int count = originalCaseList.Count;
            lblNumberOfCases.Text = $"{count} Cases";

            dgvCaseList.Columns["CaseTypeID"].Visible = false;
            dgvCaseList.Columns["LawyerID"].Visible = false;

            dgvCaseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void SortDgv()
        {
            filteredCases = new List<CaseUI>(originalCaseList);

            if(!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Title.StartsWith(txtTitle.Text)).ToList();
            }

            if(ckboxActive.Checked && ckboxFinsished.Checked)
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Status == "Active" || caseUI.Status == "Finished").ToList();
            }
            else if(ckboxActive.Checked && !ckboxFinsished.Checked)
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Status == "Active").ToList();
            }
            else if(!ckboxActive.Checked && ckboxFinsished.Checked)
            {
                filteredCases = filteredCases.Where(caseUI => caseUI.Status == "Finished").ToList();
            }

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

            dgvCaseList.DataSource = filteredCases;
            dgvCaseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            int count = filteredCases.Count;
            lblNumberOfCases.Text = $"{count} Cases";
        }
    }
}
