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
    public partial class CreateCasePage : Form
    {
        CaseBL caseBL;
        CaseTypeBL caseTypeBL;
        List<CaseTypeUI> caseTypeUIList;
        public CreateCasePage()
        {
            InitializeComponent();
            caseBL = new CaseBL();
            caseTypeBL = new CaseTypeBL();

            btnAddClient.Click += BtnAddClient_Click;
            btnAddLawyer.Click += BtnAddLawyer_Click;
            btnCreateCase.Click += BtnCreateCase_Click;

            SetComboBox();
        }

        private async void BtnCreateCase_Click(object? sender, EventArgs e)
        {
            btnCreateCase.Enabled = false;

            CaseTypeUI selectedCaseType = (CaseTypeUI)cboxCaseType.SelectedItem;

            if (selectedCaseType == null)
            {
                MessageBox.Show("Please select a case type.");
                btnCreateCase.Enabled = true; 
                return;
            }

            CaseUI caseUI = new CaseUI()
            {
                Title = txtTitle.Text,
                CreationDate = DateTime.Now,
                EndDate = dtpEstimatedEndDate.Value,
                EstHours = int.Parse(txtEstimatedHours.Text),
                Status = "On going",
                TotalPrice = 0,
                CaseTypeID = selectedCaseType.CaseTypeID,

                LawyerID = 1,
                ClientID = 1,
            };

            bool succes = await caseBL.CreateCase(caseUI);

            btnCreateCase.Enabled = true;
        }

        public async void SetComboBox()
        {
            caseTypeUIList = await caseTypeBL.GetCaseTypeAsync();

            cboxCaseType.DisplayMember = "Title";

            foreach(CaseTypeUI caseTypeUI in caseTypeUIList)
            {
                cboxCaseType.Items.Add(caseTypeUI);
            }
        }

        private void BtnAddLawyer_Click(object? sender, EventArgs e)
        {
            new AddLawyerView().ShowDialog();
        }

        private void BtnAddClient_Click(object? sender, EventArgs e)
        {
            new AddClientView().ShowDialog();
        }
    }
}
