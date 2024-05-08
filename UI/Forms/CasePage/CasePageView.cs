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
    public partial class CasePageView : Form
    {
        CaseTypeBL caseTypeBL;
        LawyerBL lawyerBL;
        CaseBL caseBL;
        List<CaseTypeUI> caseTypeList;
        List<LawyerUI> lawyerList;
        List<CaseUI> originalCaseList;
        public CasePageView()
        {
            InitializeComponent();
            caseTypeBL = new CaseTypeBL();
            lawyerBL = new LawyerBL();
            caseBL = new CaseBL();

            dgvCaseList.CellDoubleClick += DgvCaseList_CellDoubleClick;

            SetComboBox();
            SetDgv();

        }

        private void DgvCaseList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                CaseUI selectedCase = originalCaseList[e.RowIndex] as CaseUI;
                CaseDetailsView detailsView = new CaseDetailsView(selectedCase);
                detailsView.ShowDialog();
                

            }
        }

        public async Task SetComboBox()
        {
            caseTypeList = await caseTypeBL.GetCaseTypeAsync();

            cboCaseType.DisplayMember = "Title";

            foreach(CaseTypeUI caseTypeUI in caseTypeList)
            {
                cboCaseType.Items.Add(caseTypeUI);
            }

            lawyerList = await lawyerBL.GetLawyersAsync();

            cboLawyers.DisplayMember = "Firstname";

            foreach(LawyerUI lawyerUI in lawyerList)
            {
                cboLawyers.Items.Add(lawyerUI);
            }
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
    }
}
