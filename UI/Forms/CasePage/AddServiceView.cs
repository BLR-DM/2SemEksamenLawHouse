using BusinessLogic;
using BusinessLogic.Validation;
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
    public partial class AddServiceView : Form
    {
        LawyerUI selectedLawyer;
        ServiceUI selectedService;
        CaseUI selectedCase;
        CaseDetailsView caseDetailsView;

        List<ServiceUI> serviceList;

        ServiceBL serviceBL;
        CaseServiceBL caseServiceBL;
        CaseValidator cValidator;

        Color validFormat;
        Color invalidFormat;
        public AddServiceView(CaseUI selectedCase, CaseDetailsView caseDetailsView)
        {
            InitializeComponent();
            this.selectedCase = selectedCase;
            this.caseDetailsView = caseDetailsView;

            serviceBL = new ServiceBL();
            caseServiceBL = new CaseServiceBL();
            cValidator = new CaseValidator();
            

            cboServices.SelectedIndexChanged += CboServices_SelectedIndexChanged;
            txtUnits.TextChanged += TxtUnits_TextChanged;
            btnAddLawyer.Click += BtnAddLawyer_Click;
            btnAddService.Click += BtnAddService_Click;
            txtServiceDescription.TextChanged += TxtServiceDescription_TextChanged;
            txtUnits.TextChanged += TxtUnits_TextChanged1;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            SetComboBox();

            txtUnits.Enabled = false;
            txtServiceDescription.Enabled = false;
            btnAddService.Enabled = false;
        }

        private void TxtUnits_TextChanged1(object? sender, EventArgs e)
        {
            txtUnits.ForeColor = cValidator.ValidUnits(txtUnits.Text) ? validFormat : invalidFormat;
            btnCreateEnablid();
        }

        private void TxtServiceDescription_TextChanged(object? sender, EventArgs e)
        {
            txtServiceDescription.ForeColor = cValidator.ValidDescription(txtServiceDescription.Text) ? validFormat : invalidFormat;
            btnCreateEnablid();
        }

        public void btnCreateEnablid()
        {
            btnAddService.Enabled =
                txtUnits.ForeColor == validFormat &&
                txtServiceDescription.ForeColor == validFormat &&
                cboServices.SelectedItem != null &&
                selectedLawyer != null;
        }
        

        private async void BtnAddService_Click(object? sender, EventArgs e)
        {
            btnAddService.Enabled = false;

            CaseServiceUI caseServiceUI = new CaseServiceUI()
            {
                Description = txtServiceDescription.Text,
                Units = float.Parse(txtUnits.Text),
                TotalPrice = float.Parse(txtTotalPrice.Text),
                Status = "Active", // test
                StartDate = DateTime.Now, // test
                EndDate = DateTime.Now,

                CaseID = selectedCase.CaseID,
                ServiceID = selectedService.ServiceID,
                LawyerID = selectedLawyer.PersonID,
            };

            bool succes = await caseServiceBL.CreateCaseServiceAsync(caseServiceUI);
            if (succes)
            {
                MessageBox.Show("Du er dejlig Rasmus");
            }
            else
            {
                MessageBox.Show("Du dum");
            }

            caseDetailsView.SetDgv();
            caseDetailsView.SetCaseData();
            this.Close();

        }

        private void BtnAddLawyer_Click(object? sender, EventArgs e)
        {
            AddLawyerView addLawyerView = new AddLawyerView();
            addLawyerView.LawyerSelected += AddLawyerView_LawyerSelected;

            addLawyerView.ShowDialog();
            
        }

        private void AddLawyerView_LawyerSelected(object? sender, LawyerUI e)
        {
            txtLawyerFirstName.Text = e.Firstname;
            txtLawyerLastName.Text = e.Lastname;
            txtLawyerPhone.Text = e.PhoneNumber.ToString();

            selectedLawyer = e;
            btnCreateEnablid();
        }

        private void TxtUnits_TextChanged(object? sender, EventArgs e)
        {
            if(cboServices.SelectedIndex != null)
            {
                txtUnits.ForeColor = default(Color);
                selectedService = (ServiceUI)cboServices.SelectedItem;
                if(int.TryParse(txtUnits.Text, out int units))
                {
                    float totalPrice = CalculateTotalPrice(selectedService.Price, units);

                    txtTotalPrice.Text = totalPrice.ToString();
                }
                else
                {
                    txtUnits.ForeColor = Color.Red;
                }
            }
        }

        private void CboServices_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;
            btnCreateEnablid();

            if (int.TryParse(txtUnits.Text, out int units))
            {
                float totalPrice = CalculateTotalPrice(selectedService.Price, units);

                txtTotalPrice.Text = totalPrice.ToString();
            }

            if (selectedService.PriceType == "Fixed")
            {
                lblUnites.Visible = false;
                txtUnits.Visible = false;
                txtUnits.Text = "1";

                lblHoursWorked.Visible = true;
                txtHoursWorked.Visible = true;

                txtHoursWorked.Enabled = true;
                txtUnits.Enabled = true;
                txtServiceDescription.Enabled = true;
            }
            else if(selectedService.PriceType == "Hourly")
            {
                lblHoursWorked.Visible = false;
                txtHoursWorked.Visible = false;
                txtHoursWorked.Text = txtUnits.Text;

                lblUnites.Visible = true;
                lblUnites.Text = "Hours";
                txtUnits.Visible = true;


                txtUnits.Enabled = true;
                txtServiceDescription.Enabled = true;
            }
            else if(selectedService.PriceType == "Kilometer")
            {
                lblUnites.Visible = true;
                lblUnites.Text = "Kilometers";
                txtUnits.Visible = true;

                txtUnits.Enabled = true;
                txtServiceDescription.Enabled = true;

                txtHoursWorked.Enabled = true;
                lblHoursWorked.Visible = true;
                txtHoursWorked.Visible = true;
            }
            else
            {
                txtUnits.Enabled = false;
                txtServiceDescription.Enabled = false;
            }


            txtPrice.Text = selectedService.Price.ToString("C");
        }

        public float CalculateTotalPrice(float unitPrice, int units)
        {
            return unitPrice * units;
        }

        public async Task SetComboBox()
        {
            serviceList = await serviceBL.GetServicesAsync();

            cboServices.DisplayMember = "Name";

            foreach(ServiceUI service in serviceList)
            {
                cboServices.Items.Add(service);
            }
        }
    }
}
