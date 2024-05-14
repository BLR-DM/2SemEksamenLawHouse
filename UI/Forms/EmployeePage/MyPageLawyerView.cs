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
using BusinessLogic;
using UI.Toolbox;
using EntityModels;

namespace UI.Forms.EmployeePage
{
    public partial class MyPageLawyerView : Form
    {
        LawyerBL lawyerBL;
        LawyerUI lawyerUI;
        CaseServiceBL caseServiceBL;
        List<CaseServiceUI> caseServices;
        int id;
        public MyPageLawyerView(int id)
        {
            this.id = id;
            lawyerBL = new LawyerBL();
            lawyerUI = new LawyerUI();
            //caseServiceBL = new CaseServiceBL();
            //caseServices = new List<CaseServiceUI>();

            InitializeComponent();

            
            Load += MyPageLawyerView_Load;
            chboxShowAll.CheckedChanged += ChboxClosed_CheckedChanged;
            btnEditDetails.Click += BtnEditDetails_Click;
        }

        private void BtnEditDetails_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ChboxClosed_CheckedChanged(object? sender, EventArgs e)
        {
            SetDgvData(chboxShowAll.Checked);
        }



        //private async Task GetCaseServices()
        //{
        //    caseServices = await caseServiceBL.GetCaseServicesForLawyerAsync(id);
        //}

        private async void MyPageLawyerView_Load(object? sender, EventArgs e)
        {
            lawyerUI = await GetLawyer();
            if (lawyerUI != null)
            {
                DisplayLawyer(lawyerUI);
                SetDgvData(chboxShowAll.Checked);
            }
        }

        private void DisplayLawyer(LawyerUI lawyer)
        {
            pnlLawyerDetails.Controls.Clear();
            pnlLawyerDetails.Controls.Add(new EmployeeCardDisplay(lawyerUI));
        }

        private async Task<LawyerUI> GetLawyer()
        {
            return await lawyerBL.GetLawyerWithCollectionsAsync(id);
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
