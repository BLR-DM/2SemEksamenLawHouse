using BusinessLogic;
using BusinessLogic.Validation;
using UIModels;
using UI.Toolbox;

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


        const string serviceKilometer = "Kilometer";
        const string serviceFixed = "Fixed";
        const string serviceHourly = "Hourly";


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
            txtHoursWorked.TextChanged += TxtHoursWorked_TextChanged;
            txtTotalPrice.TextChanged += TxtTotalPrice_TextChanged;
            btnCalc.Click += BtnCalculate_Click;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            SetComboBox();


            pnlLawyerInformation.Controls.Add(new LawyerInformation());

            lblUnites.Visible = false;
            txtUnits.Visible = false;
            lblHoursWorked.Visible = false;
            txtHoursWorked.Visible = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;
            lblTotalPrice.Visible = false;
            txtTotalPrice.Visible = false;

            btnAddService.Enabled = false;
            btnCalc.Visible = false;
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {

            DistanceCalculatorView distanceCalculator = new DistanceCalculatorView(cValidator);
            distanceCalculator.saveResult += DistanceCalculator_saveResult;
            distanceCalculator.ShowDialog();
        }

        private void DistanceCalculator_saveResult(object? sender, string e)
        {
            txtUnits.Text = e;
        }

        private void TxtTotalPrice_TextChanged(object? sender, EventArgs e)
        {
            txtTotalPrice.ForeColor = cValidator.ValidUnits(txtTotalPrice.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtHoursWorked_TextChanged(object? sender, EventArgs e)
        {
            txtHoursWorked.ForeColor = cValidator.ValidUnits(txtHoursWorked.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtUnits_TextChanged1(object? sender, EventArgs e)
        {
            txtUnits.ForeColor = cValidator.ValidUnits(txtUnits.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtServiceDescription_TextChanged(object? sender, EventArgs e)
        {
            txtServiceDescription.ForeColor = cValidator.ValidDescription(txtServiceDescription.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        public void BtnCreateEnabled()
        {
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;
            if (selectedService == null)
            {
                btnAddService.Enabled = false;
                return;
            }

            if (selectedService.PriceType == serviceKilometer)
            {
                btnAddService.Enabled =
                                txtUnits.ForeColor == validFormat &&
                                txtServiceDescription.ForeColor == validFormat &&
                                cboServices.SelectedItem != null &&
                                selectedLawyer != null &&
                                txtHoursWorked.ForeColor == validFormat;
            }
            else if (selectedService.PriceType == serviceFixed)
            {
                btnAddService.Enabled =
                                txtTotalPrice.ForeColor == validFormat &&
                                txtServiceDescription.ForeColor == validFormat &&
                                cboServices.SelectedItem != null &&
                                selectedLawyer != null;
            }
            else if (selectedService.PriceType == serviceHourly)
            {
                btnAddService.Enabled =
                                txtServiceDescription.ForeColor == validFormat &&
                                cboServices.SelectedItem != null &&
                                selectedLawyer != null;
            }

        }


        private async void BtnAddService_Click(object? sender, EventArgs e)
        {
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;
            btnAddService.Enabled = false;

            CaseServiceUI caseServiceUI = new CaseServiceUI()
            {
                Description = txtServiceDescription.Text,
                StartDate = DateTime.Now, // sortByNameCount

                CaseID = selectedCase.CaseID,
                ServiceID = selectedService.ServiceID,
                LawyerID = selectedLawyer.PersonID,
            };

            if (selectedService.PriceType == serviceKilometer)
            {
                caseServiceUI.Status = "Closed";
                caseServiceUI.TotalPrice = float.Parse(txtTotalPrice.Text);
                caseServiceUI.HoursWorked = float.Parse(txtHoursWorked.Text);
                caseServiceUI.EndDate = DateTime.Now;
                caseServiceUI.Units = float.Parse(txtUnits.Text);
            }
            else if (selectedService.PriceType == serviceFixed)
            {
                caseServiceUI.Status = "Open";
                caseServiceUI.TotalPrice = float.Parse(txtTotalPrice.Text);
                caseServiceUI.HoursWorked = 0;
                caseServiceUI.EndDate = null;
                caseServiceUI.Units = 1;
            }
            else if (selectedService.PriceType == serviceHourly)
            {
                caseServiceUI.Status = "Open";
                caseServiceUI.TotalPrice = 0;
                caseServiceUI.HoursWorked = 0;
                caseServiceUI.EndDate = null;
                caseServiceUI.Units = 0;
            }

            bool succes = await caseServiceBL.CreateCaseServiceAsync(caseServiceUI);
            if (succes)
            {
                MessageBox.Show("Service has been added");
            }
            else
            {
                MessageBox.Show("Failed to add the service");
            }

            await caseDetailsView.SetCaseDataAsync();
            caseDetailsView.SetDgvAsync();
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
            pnlLawyerInformation.Controls.Clear();
            pnlLawyerInformation.Controls.Add(btnAddLawyer);
            pnlLawyerInformation.Controls.Add(new LawyerInformation(e));
            selectedLawyer = e;
            BtnCreateEnabled();
        }

        private void TxtUnits_TextChanged(object? sender, EventArgs e)
        {
            if (cboServices.SelectedIndex != null)
            {
                txtUnits.ForeColor = default(Color);
                selectedService = (ServiceUI)cboServices.SelectedItem;
                if (float.TryParse(txtUnits.Text, out float units))
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
            BtnCreateEnabled();

            if (int.TryParse(txtUnits.Text, out int units))
            {
                float totalPrice = CalculateTotalPrice(selectedService.Price, units);

                txtTotalPrice.Text = totalPrice.ToString();
            }

            if (selectedService.PriceType == serviceKilometer)
            {
                lblUnites.Visible = true;
                txtUnits.Visible = true;

                lblPrice.Text = "Price/km";
                lblPrice.Visible = true;
                txtPrice.Visible = true;

                lblTotalPrice.Text = "Total price";
                lblTotalPrice.Visible = true;
                txtTotalPrice.Visible = true;
                txtTotalPrice.Enabled = false;

                lblHoursWorked.Visible = true;
                txtHoursWorked.Visible = true;

                btnCalc.Visible = true;

                txtServiceDescription.Size = new System.Drawing.Size(287, 169);
            }
            else if (selectedService.PriceType == serviceFixed)
            {
                lblPrice.Text = "Listed price";
                lblPrice.Visible = true;
                txtPrice.Visible = true;

                lblTotalPrice.Text = "Agreed price";
                lblTotalPrice.Visible = true;
                txtTotalPrice.Visible = true;
                txtTotalPrice.Enabled = true;

                lblHoursWorked.Visible = false;
                txtHoursWorked.Visible = false;

                lblUnites.Visible = false;
                txtUnits.Visible = false;

                btnCalc.Visible = false;

                txtServiceDescription.Size = new System.Drawing.Size(287, 169);
            }
            else if (selectedService.PriceType == serviceHourly)
            {
                lblUnites.Visible = false;
                txtUnits.Visible = false;

                lblPrice.Visible = false;
                txtPrice.Visible = false;

                lblTotalPrice.Visible = false;
                txtTotalPrice.Visible = false;

                lblHoursWorked.Visible = false;
                txtHoursWorked.Visible = false;

                btnCalc.Visible = false;

                txtServiceDescription.Size = new System.Drawing.Size(429, 169);

            }


            txtPrice.Text = selectedService.Price.ToString("C");
        }

        public float CalculateTotalPrice(float unitPrice, float units)
        {
            return unitPrice * units;
        }

        public async Task SetComboBox()
        {
            serviceList = await serviceBL.GetServicesAsync();

            cboServices.DisplayMember = "Name";

            foreach (ServiceUI service in serviceList)
            {
                cboServices.Items.Add(service);
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
