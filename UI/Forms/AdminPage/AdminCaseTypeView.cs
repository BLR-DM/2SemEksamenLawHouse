using BusinessLogic;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminCaseTypeView : Form
    {
        CaseTypeBL caseTypeBL;
        List<CaseTypeUI> caseTypeUIs;
        public AdminCaseTypeView()
        {
            InitializeComponent();

            caseTypeBL = new CaseTypeBL();
            SetDgv();

            dgvCaseType.CellDoubleClick += DgvCaseType_CellDoubleClick;
        }

        private void DgvCaseType_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                CaseTypeUI selectedCaseType = caseTypeUIs[e.RowIndex] as CaseTypeUI;
                if(selectedCaseType != null)
                {
                    AdminCUDCaseType adminCUDCaseType = new AdminCUDCaseType(selectedCaseType);
                    adminCUDCaseType.ShowDialog();
                }
            }
        }

        private async void SetDgv()
        {
            caseTypeUIs = await caseTypeBL.GetCaseTypeAsync();

            dgvCaseType.DataSource = caseTypeUIs;

            dgvCaseType.Columns["CaseTypeID"].Visible = false;

            dgvCaseType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaseType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCaseType.EnableHeadersVisualStyles = false;

            dgvCaseType.RowHeadersVisible = false;

            dgvCaseType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvCaseType.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvCaseType.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvCaseType.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
