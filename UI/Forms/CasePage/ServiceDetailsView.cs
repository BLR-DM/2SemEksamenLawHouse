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
using BusinessLogic.Validation;
using EntityModels;

namespace UI.Forms.CasePage
{
    public partial class ServiceDetailsView : Form
    {
        CaseServiceUI selectedCaseService;
        ServiceUI selectedService;
        CaseDetailsView caseDetailsView;

        List<ServiceEntryUI> serviceEntryUIs;

        Color validFormat;
        Color invalidFormat;

        LawyerBL lawyerBL;
        ServiceBL serviceBL;
        ServiceEntryBL serviceEntryBL;
        CaseServiceBL caseServiceBL;

        CaseValidator cValidator;
        
        public ServiceDetailsView(CaseDetailsView caseDetailsView, CaseServiceUI selectedCaseService, bool isClient)
        {
            InitializeComponent();

            this.selectedCaseService = selectedCaseService;
            this.caseDetailsView = caseDetailsView;

            lawyerBL = new LawyerBL();
            serviceBL = new ServiceBL();
            serviceEntryBL = new ServiceEntryBL();
            caseServiceBL = new CaseServiceBL();
            cValidator = new CaseValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnSubmit.Click += BtnSubmit_Click;
            btnClose.Click += BtnClose_Click;
            txtHoursWorked.TextChanged += TxtHoursWorked_TextChanged;

            btnSubmit.Enabled = false;

            CheckStatus();
            SetDgvAsync();
            SetCaseInformationAsync();
            SetLawyerInformationAsync();


            //fjerner knapper hvis bruger er client
            if (isClient)
            {
                btnSubmit.Visible = false;
                txtHoursWorked.Visible = false;
                lblHoursWorked.Visible = false;
            }

            if(selectedCaseService.PriceType == "Kilometer")
            {
                pnlTasks.Enabled = false;
                btnClose.Enabled = false;
            }
        }

        public void CheckStatus()
        {
            if(selectedCaseService.Status == "Closed")
            {
                txtHoursWorked.Enabled = false;
                btnClose .Enabled = false;
                btnSubmit .Enabled = false;
            }
        }

        private async void BtnClose_Click(object? sender, EventArgs e)
        {
            if(serviceEntryUIs.Count == 0)
            {
                MessageBox.Show("Must add entrys to close this service");
                return;
            }
            
            btnClose.Enabled = false;
            DialogResult dialogResult = MessageBox.Show("Do you wanna close this service", "Close service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                selectedCaseService.Status = "Closed";
                selectedCaseService.EndDate = DateTime.Now;
                if (await caseServiceBL.UpdateCaseServicesAsync(selectedCaseService))
                {
                    MessageBox.Show("Service closed");
                    txtHoursWorked.Enabled = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("fejl");
                    btnClose.Enabled = true;
                }

            }
            else
                btnClose.Enabled = true;
        }

        private void TxtHoursWorked_TextChanged(object? sender, EventArgs e)
        {
            txtHoursWorked.ForeColor = cValidator.ValidEstimatedHours(txtHoursWorked.Text) ? validFormat : invalidFormat;
            BtnSubmitEnabled();
        }

        public void BtnSubmitEnabled()
        {
            btnSubmit.Enabled =
                txtHoursWorked.ForeColor == validFormat;
        }
        protected async override void OnClosing(CancelEventArgs e)
        {
            await caseDetailsView.SetDgvAsync();
            await caseDetailsView.SetCaseDataAsync();
            base.OnClosing(e);
        }

        private async void BtnSubmit_Click(object? sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            ServiceEntryUI serviceEntryUI = new ServiceEntryUI()
            {
                HoursWorked = float.Parse(txtHoursWorked.Text),
                Date = DateTime.Now,
                CaseServiceID = selectedCaseService.CaseServiceID,
            };

            if(selectedCaseService.PriceType == "Hourly")
            {
                selectedCaseService.HoursWorked = selectedCaseService.HoursWorked + serviceEntryUI.HoursWorked;
                selectedCaseService.Units = selectedCaseService.HoursWorked;
                selectedCaseService.TotalPrice = selectedCaseService.Units * selectedService.Price;
            }
            else if(selectedCaseService.PriceType == "Fixed")
            {
                selectedCaseService.HoursWorked = selectedCaseService.HoursWorked + serviceEntryUI.HoursWorked;
                selectedCaseService.Units = 1;
                selectedCaseService.TotalPrice = selectedCaseService.TotalPrice;
            }
            
            

            bool succes = await serviceEntryBL.CreateServiceEntryAsync(serviceEntryUI);
            bool succes1 = await caseServiceBL.UpdateCaseServicesAsync(selectedCaseService);
            await SetDgvAsync();
            await SetCaseInformationAsync();

            if(succes && succes1)
            {
                MessageBox.Show("Entry submitted");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            btnSubmit.Enabled = true;
        }

        public async Task SetCaseInformationAsync()
        {
            selectedService = await serviceBL.GetServiceAsync(selectedCaseService.ServiceID);

            txtServiceName.Text = selectedService.Name;
            txtPrice.Text = selectedService.Price.ToString();

            txtServiceDescription.Text = selectedCaseService.Description;


            if (selectedCaseService.PriceType == "Hourly")
            {
                txtTotalHours.Text = serviceEntryUIs.Sum(cs => cs.HoursWorked).ToString();
                txtUnits.Text = txtTotalHours.Text;
            }
            else if (selectedCaseService.PriceType == "Fixed")
            {
                txtUnits.Text = "1";
                txtTotalHours.Text = serviceEntryUIs.Sum(cs => cs.HoursWorked).ToString();
            }
            else if (selectedCaseService.PriceType == "Kilometer")
            {
                lblUnites.Text = "Kilometer";
                lblPrice.Text = "Price/km";
                txtTotalHours.Text = selectedCaseService.HoursWorked.ToString();
                txtUnits.Text = selectedCaseService.Units.ToString();
            }
            txtTotalPrice.Text = selectedCaseService.TotalPrice.ToString();

        }

        public async Task SetDgvAsync()
        {
            serviceEntryUIs = await serviceEntryBL.GetServiceEntryUIAsync(selectedCaseService.CaseServiceID);

            dgvServiceEntry.DataSource = serviceEntryUIs;
            dgvServiceEntry.Columns["ServiceEntryID"].Visible = false;
            dgvServiceEntry.Columns["CaseServiceID"].Visible = false;
            dgvServiceEntry.Columns["CaseService"].Visible = false;

            dgvServiceEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public async Task SetLawyerInformationAsync()
        {
            LawyerUI assignedLawyer = await lawyerBL.GetLawyerAsync(selectedCaseService.LawyerID);

            pnlLawyerInformation.Controls.Add(new LawyerInformation(assignedLawyer));
        }
    }
}
