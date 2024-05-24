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
                    this.Close();
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
        }
    }
}
