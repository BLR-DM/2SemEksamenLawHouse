using BusinessLogic;
using BusinessLogic.Validation;
using UIModels;
using UI.Toolbox;
using System.Globalization;
using BusinessLogic.HelpServices;

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

        //Konstanter for forskellige typer af pricetypes
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
            txtHoursWorked.TextChanged += TxtHoursWorked_TextChanged;
            txtTotalPrice.TextChanged += TxtTotalPrice_TextChanged;
            btnCalculation.Click += BtnCalculate_Click;
            lblHelp.Click += LblHelp_Click;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            SetComboBox();


            pnlLawyerInformation.Controls.Add(new LawyerInformation());

            HideServiceDetails();
        }

        private void HideServiceDetails()
        {
            lblUnites.Visible = false;
            txtUnits.Visible = false;
            lblHoursWorked.Visible = false;
            txtHoursWorked.Visible = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;
            lblTotalPrice.Visible = false;
            txtTotalPrice.Visible = false;

            btnAddService.Enabled = false;
            btnCalculation.Visible = false;
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;

            //Åbner den PDF-fil som er baseret på den pricetype der er valgt for den enkelte service
            if (selectedService != null)
            {
                if (selectedService.PriceType == serviceKilometer)
                {
                    OpenPDF.ShowPDF("AddServiceKilometerHelp");
                }
                else if (selectedService.PriceType == serviceHourly)
                {
                    OpenPDF.ShowPDF("AddServiceHourlyHelp");
                }
                else if (selectedService.PriceType == serviceFixed)
                {
                    OpenPDF.ShowPDF("AddServiceFixedHelp");
                } 
            }
            else
            {
                MessageBox.Show("Pick a service first");
            }
            
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {

            DistanceCalculatorView distanceCalculator = new DistanceCalculatorView(cValidator);
            distanceCalculator.saveResult += DistanceCalculator_saveResult;
            distanceCalculator.ShowDialog();
        }

        //Event handler for gemt resultat fra distance calculater
        private void DistanceCalculator_saveResult(object? sender, string e)
        {
            txtUnits.Text = e.ToString();
        }

        private void TxtTotalPrice_TextChanged(object? sender, EventArgs e)
        {
            //Tekstboksens farve ændres baseret på om den er valid og opdaterer btnEnabled true/false
            txtTotalPrice.ForeColor = cValidator.ValidUnits(txtTotalPrice.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtHoursWorked_TextChanged(object? sender, EventArgs e)
        {
            //Tekstboksens farve ændres baseret på om den er valid og opdaterer btnEnabled true/false
            txtHoursWorked.ForeColor = cValidator.ValidUnits(txtHoursWorked.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtServiceDescription_TextChanged(object? sender, EventArgs e)
        {
            //Tekstboksens farve ændres baseret på om den er valid og opdaterer btnEnabled true/false
            txtServiceDescription.ForeColor = cValidator.ValidDescription(txtServiceDescription.Text) ? validFormat : invalidFormat;
            BtnCreateEnabled();
        }

        private void TxtUnits_TextChanged(object? sender, EventArgs e)
        {

            txtUnits.ForeColor = cValidator.ValidUnits(txtUnits.Text) ? validFormat : invalidFormat;

            //Tjekker om service er valgt
            if (cboServices.SelectedIndex != null)
            {
                txtUnits.ForeColor = validFormat;

                //Hent den valgte service
                selectedService = (ServiceUI)cboServices.SelectedItem;

                //Kontroller om units kan konverteres til float
                if (float.TryParse(txtUnits.Text, out float units))
                {
                    //Beregner og opdater den totale pris baseret på price og units
                    float totalPrice = CalculateTotalPrice(selectedService.Price, units);
                    txtTotalPrice.Text = totalPrice.ToString("F2");
                }
                else
                {
                    txtUnits.ForeColor = invalidFormat;
                }
            }

            BtnCreateEnabled();
        }

        private void BtnCreateEnabled()
        {
            //Metode til at opdatere om knappen er enabled ud fra om tekstboksene er valid


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
            //Henter den service der er valgt fra comboboxen
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;
            //Disabler knappen
            btnAddService.Enabled = false;

            //Opretter en ny caseserive
            CaseServiceUI caseServiceUI = new CaseServiceUI()
            {
                Description = txtServiceDescription.Text,
                StartDate = DateTime.Now, // sortByNameCount

                CaseID = selectedCase.CaseID,
                ServiceID = selectedService.ServiceID,
                LawyerID = selectedLawyer.PersonID,
            };

            //Forskellig oprettelse ift hvilken pricetype servicen har
            if (selectedService.PriceType == serviceKilometer)
            {
                caseServiceUI.Status = "Closed";
                caseServiceUI.TotalPrice = float.Parse(txtTotalPrice.Text);
                caseServiceUI.HoursWorked = float.Parse(txtHoursWorked.Text);
                caseServiceUI.EndDate = DateTime.Now;
                caseServiceUI.Units = float.Parse(txtUnits.Text, CultureInfo.InvariantCulture);
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

            //Opdater den tidligere form
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
            //Clear først panel, hvis det allerede skulle være fyldt
            pnlLawyerInformation.Controls.Clear();
            //Adder knappen
            pnlLawyerInformation.Controls.Add(btnAddLawyer);
            //Tilføjer den nye lawyers informationer 
            pnlLawyerInformation.Controls.Add(new LawyerInformation(e));
            //den hentede lawyer gemmes i ny variabel
            selectedLawyer = e;
            BtnCreateEnabled();
        }

  
        //Event handler for comboboxen
        private void CboServices_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;
            BtnCreateEnabled();

            if (float.TryParse(txtUnits.Text, out float units))
            {
                float totalPrice = CalculateTotalPrice(selectedService.Price, units);

                txtTotalPrice.Text = totalPrice.ToString();
            }
            //Visibility og adfærd på vorskkelige lbl, txt og buttons sættes forskelligt baseret på hvilken service der er valgt
            if (selectedService.PriceType == serviceKilometer)
            {
                SetDataKilometerPriceType();
            }
            else if (selectedService.PriceType == serviceFixed)
            {
                SetDataFixedPriceType();
            }
            else if (selectedService.PriceType == serviceHourly)
            {
                SetDataHourlyPriceType();
            }


            txtPrice.Text = selectedService.Price.ToString("C");
        }

        //adfærd for kilmoter
        private void SetDataKilometerPriceType()
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

            btnCalculation.Visible = true;

            txtServiceDescription.Size = new System.Drawing.Size(287, 169);
        }

        //adfærd for hourly
        private void SetDataHourlyPriceType()
        {
            lblUnites.Visible = false;
            txtUnits.Visible = false;

            lblPrice.Visible = false;
            txtPrice.Visible = false;

            lblTotalPrice.Visible = false;
            txtTotalPrice.Visible = false;

            lblHoursWorked.Visible = false;
            txtHoursWorked.Visible = false;

            btnCalculation.Visible = false;

            txtServiceDescription.Size = new System.Drawing.Size(429, 169);
        }

        //adfærd for fixed
        private void SetDataFixedPriceType()
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

            btnCalculation.Visible = false;

            txtServiceDescription.Size = new System.Drawing.Size(287, 169);
        }

        //Metode til at beregne den totale pris
        private float CalculateTotalPrice(float unitPrice, float units)
        {
            return unitPrice * units;
        }

        //Sætter comboboxen med services
        private async Task SetComboBox()
        {
            serviceList = await serviceBL.GetServicesAsync();

            //Viser navnet
            cboServices.DisplayMember = "Name";

            foreach (ServiceUI service in serviceList)
            {
                cboServices.Items.Add(service);
            }
        }
    }
}
