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
        CaseBl caseBL;
        public CreateCasePage()
        {
            InitializeComponent();
            caseBL = new CaseBl();

            btnAddClient.Click += BtnAddClient_Click;
            btnAddLawyer.Click += BtnAddLawyer_Click;
            btnCreateCase.Click += BtnCreateCase_Click;
        }

        private async void BtnCreateCase_Click(object? sender, EventArgs e)
        {
            btnCreateCase.Enabled = false;

            CaseUI caseUI = new CaseUI()
            {
                Title = txtTitle.Text,
                CreationDate = DateTime.Now,
                EndDate = dtpEstimatedEndDate.Value,
                EstHours = int.Parse(txtEstimatedHours.Text),
                Status = "On going",
                TotalPrice = 0,

                LawyerID = 1,
                ClientID = 1,
            };

            bool succes = await caseBL.CreateCase(caseUI);
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
