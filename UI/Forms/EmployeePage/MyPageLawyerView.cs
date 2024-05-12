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

namespace UI.Forms.EmployeePage
{
    public partial class MyPageLawyerView : Form
    {
        LawyerBL lawyerBL;
        LawyerUI lawyer;
        CaseServiceBL caseServiceBL;
        List<CaseServiceUI> caseServices;
        int id;
        public MyPageLawyerView(int id)
        {
            this.id = id;
            lawyerBL = new LawyerBL();
            lawyer = new LawyerUI();
            //caseServiceBL = new CaseServiceBL();
            //caseServices = new List<CaseServiceUI>();

            InitializeComponent();

            
            Load += MyPageLawyerView_Load;
            chboxShowAll.CheckedChanged += ChboxClosed_CheckedChanged;
        }

        private void ChboxClosed_CheckedChanged(object? sender, EventArgs e)
        {
            SetDgvData(chboxShowAll.Checked);
        }

        private async Task GetLawyer()
        {
            lawyer = await lawyerBL.GetLawyerWithCollectionsAsync(id);
        }

        //private async Task GetCaseServices()
        //{
        //    caseServices = await caseServiceBL.GetCaseServicesForLawyerAsync(id);
        //}

        private async void MyPageLawyerView_Load(object? sender, EventArgs e)
        {
            await GetLawyer();
            //await GetCaseServices();
            if (lawyer != null)
            {
                SetDgvData(chboxShowAll.Checked);
            }
        }

        private void SetDgvData(bool check)
        {
            dgvCases.DataSource = lawyer.Cases;
            //dgvServices.DataSource = caseServices;
            dgvServices.DataSource = lawyer.CaseServices;

            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    try
                    {
                        bool status = (bool)row.Cells["Status"].Value;
                        dgvServices.CurrentCell = null;
                        row.Visible = check || status;
                    }
                    catch (Exception)
                    {
                       
                    }
                }
            }
            
        }
    }
}
