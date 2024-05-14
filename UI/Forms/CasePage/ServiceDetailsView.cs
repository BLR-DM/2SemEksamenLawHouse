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
using UI.Toolbox;

namespace UI.Forms.CasePage
{
    public partial class ServiceDetailsView : Form
    {
        CaseServiceUI selectedCaseService;
        ServiceUI selectedService;

        List<ServiceEntryUI> serviceEntryUIs;

        LawyerBL lawyerBL;
        ServiceBL serviceBL;
        ServiceEntryBL serviceEntryBL;
        public ServiceDetailsView(CaseServiceUI selectedCaseService)
        {
            InitializeComponent();

            this.selectedCaseService = selectedCaseService;

            lawyerBL = new LawyerBL();
            serviceBL = new ServiceBL();
            serviceEntryBL = new ServiceEntryBL();

            btnSubmit.Click += BtnSubmit_Click;

            SetDgv();
            SetCaseInformation();
            SetLawyerInformation();
        }

        private async void BtnSubmit_Click(object? sender, EventArgs e)
        {
            ServiceEntryUI serviceEntryUI = new ServiceEntryUI()
            {
                HoursWorked = float.Parse(txtHoursWorked.Text),
                Date = DateTime.Now,
                CaseServiceID = selectedCaseService.CaseServiceID,
            };

            bool succes = await serviceEntryBL.CreateServiceEntryAsync(serviceEntryUI);
            SetDgv();
            SetCaseInformation();
            if(succes)
            {
                MessageBox.Show("Doner");
            }
            else
            {
                MessageBox.Show("Fejl");
            }
        }

        public async Task SetCaseInformation()
        {
            selectedService = await serviceBL.GetServiceAsync(selectedCaseService.ServiceID);

            txtServiceName.Text = selectedService.Name;
            txtPrice.Text = selectedService.Price.ToString();
            txtTotalHours.Text = serviceEntryUIs.Sum(cs => cs.HoursWorked).ToString();

            txtServiceDescription.Text = selectedCaseService.Description;
            txtUnits.Text = selectedCaseService.Units.ToString();
            txtTotalPrice.Text = selectedCaseService.TotalPrice.ToString();

        }

        public async Task SetDgv()
        {
            serviceEntryUIs = await serviceEntryBL.GetServiceEntryUIAsync(selectedCaseService.CaseServiceID);

            dgvServiceEntry.DataSource = serviceEntryUIs;
            dgvServiceEntry.Columns["ServiceEntryID"].Visible = false;
            dgvServiceEntry.Columns["CaseServiceID"].Visible = false;
            dgvServiceEntry.Columns["CaseService"].Visible = false;

            dgvServiceEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public async Task SetLawyerInformation()
        {
            LawyerUI assignedLawyer = await lawyerBL.GetLawyerAsync(selectedCaseService.LawyerID);

            pnlLawyerInformation.Controls.Add(new LawyerInformation(assignedLawyer));
        }
    }
}
