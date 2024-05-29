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
using BusinessLogic.HelpServices;

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

        ServiceEntryBL serviceEntryBL;
        CaseServiceBL caseServiceBL;

        CaseValidator cValidator;

        const string serviceKilometer = "Kilometer";
        const string serviceFixed = "Fixed";
        const string serviceHourly = "Hourly";

        public ServiceDetailsView(CaseDetailsView caseDetailsView, CaseServiceUI selectedCaseService, bool isClient)
        {
            InitializeComponent();

            this.selectedCaseService = selectedCaseService;
            this.caseDetailsView = caseDetailsView;

            serviceEntryBL = new ServiceEntryBL();
            caseServiceBL = new CaseServiceBL();
            cValidator = new CaseValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnSubmit.Click += BtnSubmit_Click;
            btnClose.Click += BtnClose_Click;
            txtHoursWorked.TextChanged += TxtHoursWorked_TextChanged;
            lblHelp.Click += LblHelp_Click;

            btnSubmit.Enabled = false;

            CheckStatus();
            SetDgvStyle();
            SetDgvAsync();
            SetLawyerInformationAsync();


            //fjerner knapper hvis bruger er client
            if (isClient)
            {
                btnSubmit.Visible = false;
                txtHoursWorked.Visible = false;
                lblHoursWorked.Visible = false;
                btnClose.Visible = false;
            }

            if(selectedCaseService.PriceType == serviceKilometer)
            {
                pnlTasks.Enabled = false;
                btnClose.Enabled = false;
            }
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            if(selectedCaseService.PriceType == serviceHourly)
            {
                OpenPDF.ShowPDF("ServiceDetailsHourlyHelp");
            }
            else if(selectedCaseService.PriceType == serviceFixed)
            {
                OpenPDF.ShowPDF("ServiceDetailsFixedHelp");
            }
            else if(selectedCaseService.PriceType == serviceKilometer)
            {
                OpenPDF.ShowPDF("ServiceDetailsKilometerHelp");
            }
        }

        private void CheckStatus()
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
                    MessageBox.Show("Failed to close the service");
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

        private void BtnSubmitEnabled()
        {
            btnSubmit.Enabled =
                txtHoursWorked.ForeColor == validFormat;
        }
        protected async override void OnClosing(CancelEventArgs e)
        {
            //Når formen lukkes så opdateres detailview for casen
            await caseDetailsView.SetCaseDataAsync();
            caseDetailsView.SetDgvAsync();
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

            //forskellig opdatering ift til om pricetype er hourly eller fixed
            if(selectedCaseService.PriceType == serviceHourly)
            {
                selectedCaseService.HoursWorked = selectedCaseService.HoursWorked + serviceEntryUI.HoursWorked;
                selectedCaseService.Units = selectedCaseService.HoursWorked;
                selectedCaseService.TotalPrice = selectedCaseService.Units * selectedService.Price;
            }
            else if(selectedCaseService.PriceType == serviceFixed)
            {
                selectedCaseService.HoursWorked = selectedCaseService.HoursWorked + serviceEntryUI.HoursWorked;
                selectedCaseService.Units = 1;
                selectedCaseService.TotalPrice = selectedCaseService.TotalPrice;
            }
            
            DialogResult dialogResult = MessageBox.Show($"Do you want to add {txtHoursWorked.Text} hours", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bool succes = await serviceEntryBL.CreateServiceEntryAsync(serviceEntryUI);
                bool succesCaseService = await caseServiceBL.UpdateCaseServicesAsync(selectedCaseService);
                await SetDgvAsync();
                await SetCaseInformationAsync();

                if (succes && succesCaseService)
                {
                    MessageBox.Show("Entry submitted");
                }
                else
                {
                    MessageBox.Show("Error!");
                } 
            }
            btnSubmit.Enabled = true;
        }

        private async Task SetCaseInformationAsync()
        {
            selectedService = selectedCaseService.Service;

            txtServiceName.Text = selectedService.Name;
            txtPrice.Text = selectedService.Price.ToString();
            txtTotalPrice.Text = selectedCaseService.TotalPrice.ToString();

            txtServiceDescription.Text = selectedCaseService.Description;

            //forksellig adfærd ift til pricetypen
            if (selectedCaseService.PriceType == serviceHourly)
            {
                SetDataHourly();
            }
            else if (selectedCaseService.PriceType == serviceFixed)
            {
                SetDataFixed();
            }
            else if (selectedCaseService.PriceType == serviceKilometer)
            {
                SetDataKilometer();
            }
        }

        private void SetDataHourly()
        {
            txtTotalHours.Text = serviceEntryUIs.Sum(cs => cs.HoursWorked).ToString();
            txtUnits.Text = txtTotalHours.Text;

            lblPrice.Text = "Price/hour";
            lblTotalPrice.Text = "Total Price";

            txtUnits.Visible = false;
            lblUnites.Visible = false;
        }

        private void SetDataFixed()
        {
            txtUnits.Visible = false;
            lblUnites.Visible = false;

            lblPrice.Text = "Listed Price";
            lblTotalPrice.Text = "Agreed Price";

            txtTotalHours.Text = serviceEntryUIs.Sum(cs => cs.HoursWorked).ToString();
        }

        private void SetDataKilometer()
        {
            lblUnites.Text = "Kilometer";
            lblPrice.Text = "Price/km";

            txtTotalHours.Text = selectedCaseService.HoursWorked.ToString();
            txtUnits.Text = selectedCaseService.Units.ToString();
        }

        private async Task SetDgvAsync()
        {
            serviceEntryUIs = await serviceEntryBL.GetServiceEntryUIAsync(selectedCaseService.CaseServiceID);
            await SetCaseInformationAsync();

            dgvServiceEntry.DataSource = serviceEntryUIs;
            dgvServiceEntry.Columns["ServiceEntryID"].Visible = false;
            dgvServiceEntry.Columns["CaseServiceID"].Visible = false;
            dgvServiceEntry.Columns["CaseService"].Visible = false;

        }

        private void SetDgvStyle()
        {
            dgvServiceEntry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceEntry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvServiceEntry.EnableHeadersVisualStyles = false;

            dgvServiceEntry.RowHeadersVisible = false;

            dgvServiceEntry.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvServiceEntry.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvServiceEntry.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvServiceEntry.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private async Task SetLawyerInformationAsync()
        {
            //Sætter den assigned lawyer til det panel
            pnlLawyerInformation.Controls.Add(new LawyerInformation(selectedCaseService.Lawyer));
        }
    }
}
