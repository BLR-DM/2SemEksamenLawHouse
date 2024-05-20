using BusinessLogic;
using UIModels;
using UI.Forms.ClientPage;
using UI.Forms.Self_Service;
using UI.Forms.CasePage;
using UI.Forms.AdminPage;
using UI.Forms.EmployeePage;
using EntityModels;
using UI.Forms.SubscriptionPage;
using BusinessLogic.Validation;

namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        Color rgbColorBlue;

        //nuvaerende bruger
        PersonUI currentUser;
        ClientUI clientUI;
        LawyerUI lawyerUI;
        SecretaryUI secretaryUI;
        EmployeeUI employeeUI;


        PersonBL personBL;
        ClientBL clientBL;
        EmployeeBL employeeBL;
        LawyerBL lawyerBL;
        SecretaryBL secretaryBL;

        CaseBL caseBL;
        CaseTypeBL caseTypeBL;
        SpecialityBL specialityBL;
        CaseServiceBL caseServiceBL;
        CaseValidator cValidator;
        ServiceBL serviceBL;


        FormDocumentBL formBL;
        SubscriptionBL subscriptionBL;
        ServiceEntryBL serviceEntryBL;

        PersonValidator pValidator;
        OverallValidator oaValidator;

        public FrontPageView(int loginDetailsID)
        {
            personBL = new PersonBL();
            employeeBL = new EmployeeBL();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
            secretaryBL = new SecretaryBL();
            caseBL = new CaseBL();
            formBL = new FormDocumentBL();
            subscriptionBL = new SubscriptionBL();
            pValidator = new PersonValidator();
            oaValidator = new OverallValidator();
            serviceEntryBL = new ServiceEntryBL();
            caseTypeBL = new CaseTypeBL();
            specialityBL = new SpecialityBL();
            caseServiceBL = new CaseServiceBL();
            serviceBL = new ServiceBL();
            cValidator = new CaseValidator();

            
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            GetPersonAsync(loginDetailsID);

            InitializeComponent();
            pnlContext.Controls.Clear();

            lblCurrentPage.Text = string.Empty;

            btnForms.Visible = btnEmployees.Visible = btnClients.Visible = btnAdminPage.Visible =
            btnAdminPage.Visible = btnCalculations.Visible = btnCase.Visible = btnLawyers.Visible =
            btnMyPageClient.Visible = btnMyPageLawyer.Visible = btnSubscribe.Visible = false;
            btnClose.Click += BtnClose_Click;
            btnMyPageClient.Click += BtnMyPageClient_Click;
            btnClients.Click += BtnClients_Click;
            btnLawyers.Click += BtnLawyers_Click;
            btnForms.Click += BtnForms_Click;
            btnCase.Click += BtnCase_Click;
            btnAdminPage.Click += BtnAdminPage_Click;
            btnEmployees.Click += BtnEmployees_Click;
            btnMyPageLawyer.Click += BtnMyPageLawyer_Click;
            btnCalculations.Click += BtnCalculations_Click;
            btnSubscribe.Click += BtnSubscribe_Click;
        }

        public async Task GetPersonAsync(int id)
        {

            if (currentUser == null)
            {
                currentUser = await personBL.GetPersonAsync(id); 
            }

            if (currentUser != null)
            {
                lblCurrentUser.Text = currentUser.GetType().Name;// slet
                lblCurrentUserName.Text = currentUser.Firstname; // slet

                if (currentUser is ClientUI clientUI)
                {
                    this.clientUI = clientUI;
                    await SetupClientFormAsync();
                }
                else if (currentUser is LawyerUI lawyer)
                {
                    this.lawyerUI = lawyer;
                    await SetupLawyerFormAsync();
                }
                else if (currentUser is SecretaryUI secretary)
                {
                    this.secretaryUI = secretary;
                    await SetupEmployeeFormAsync();
                }
                else if (currentUser is EmployeeUI employeeUI)
                {
                    this.employeeUI = employeeUI;
                    await SetupEmployeeFormAsync();
                }
            }
        }


        private async Task SetupClientFormAsync()
        {
            // Knapper
            btnMyPageClient.Visible = true;
            btnLawyers.Visible = true;
            btnForms.Visible = true;
            btnSubscribe.Visible = true;
            btnCalculations.Visible = true;

            SetNavBtnColor(btnMyPageClient);

            //set mypage
            ClientDetails cdMyPage = new ClientDetails(this, currentUser, clientUI, clientBL, caseBL, formBL, subscriptionBL, pValidator, serviceEntryBL, lawyerBL, caseTypeBL, caseServiceBL, cValidator, serviceBL, specialityBL); 
            if (pnlContext.Controls.Count == 0 || pnlContext.Controls[0].GetType() != typeof(ClientDetails))
            {
                PnlContextChange(cdMyPage);
            }

           
        }

        private async Task SetupLawyerFormAsync()
        {
            // Knapper
            btnMyPageLawyer.Visible = true;
            btnEmployees.Visible = true;
            btnCase.Visible = true;
            btnClients.Visible = true;
            btnAdminPage.Visible = true; // sortByNameCount

            SetNavBtnColor(btnMyPageLawyer);

            //set mypage
            LawyerDetailsView lawyerDetailsView = new LawyerDetailsView(lawyerUI, true, lawyerUI, serviceEntryBL, clientBL, lawyerBL, caseBL, caseTypeBL, caseServiceBL,
                        cValidator, serviceBL, specialityBL);
            if (pnlContext.Controls.Count == 0 || pnlContext.Controls[0].GetType() != typeof(LawyerDetailsView))
            {
                PnlContextChange(lawyerDetailsView);
            }

            if (lawyerUI.Admin)
            {
                btnAdminPage.Visible = true;
            }
        }

        private async Task SetupEmployeeFormAsync()
        {
            // Knapper
            btnMyPageLawyer.Visible = true;
            btnEmployees.Visible = true;
            btnCase.Visible = true;
            btnClients.Visible = true;
            btnAdminPage.Visible = true; // sortByNameCount

            SetNavBtnColor(btnMyPageLawyer);
        }

        public void PnlContextChange(Form f)
        {
            //clearer controls fra panelForm
            pnlContext.Controls.Clear();
            f.TopLevel = false;
            //tilføj form som control til panelet
            pnlContext.Controls.Add(f);
            f.Show();
            pnlContext.Show();
        }

        private void SetNavBtnColor(Button btn)
        {
            foreach(Button buttonnis in pnlLeft.Controls)
            {
                buttonnis.BackColor = Color.FromArgb(194, 205, 240);
            }

            btn.BackColor = Color.FromArgb(174, 183, 212);
        }

        private void BtnCalculations_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            CalculationsView calculationsView = new CalculationsView(oaValidator, clientUI);
            PnlContextChange(calculationsView);
            SetNavBtnColor(btnCalculations);


        }

        private void BtnMyPageLawyer_Click(object? sender, EventArgs e)
        {
            if (currentUser is LawyerUI)
            {
                lblCurrentPage.Text = (sender as Button).Text;
                LawyerDetailsView myPageLawyer = new LawyerDetailsView(lawyerUI, true, employeeUI, serviceEntryBL, clientBL, lawyerBL,
                                caseBL, caseTypeBL, caseServiceBL, cValidator, serviceBL, specialityBL);
                PnlContextChange(myPageLawyer);
                SetNavBtnColor(btnMyPageLawyer); 
            }
            else if (currentUser is SecretaryUI)
            {
                lblCurrentPage.Text = (sender as Button).Text;
                EmployeeDetailsView myPageEmployee = new EmployeeDetailsView(secretaryUI, true, employeeUI);
                PnlContextChange(myPageEmployee);
                SetNavBtnColor(btnMyPageLawyer);
            }
            else
            {
                lblCurrentPage.Text = (sender as Button).Text;
                EmployeeDetailsView myPageEmployee = new EmployeeDetailsView(employeeUI, true, employeeUI);
                PnlContextChange(myPageEmployee);
                SetNavBtnColor(btnMyPageLawyer);
            }
        }

        private void BtnEmployees_Click(object? sender, EventArgs e)
        {
            if (currentUser is LawyerUI)
            {
                lblCurrentPage.Text = (sender as Button).Text;
                EmployeesOverview employeesOverview = new EmployeesOverview(currentUser.PersonID, lawyerUI, employeeBL, secretaryBL, serviceEntryBL,
                    clientBL, lawyerBL, caseBL, caseTypeBL, caseServiceBL, cValidator, serviceBL, specialityBL);
                PnlContextChange(employeesOverview);
                SetNavBtnColor(btnEmployees); 
            }
            else
            {
                lblCurrentPage.Text = (sender as Button).Text;
                EmployeesOverview employeesOverview = new EmployeesOverview(currentUser.PersonID, employeeUI, employeeBL, secretaryBL, serviceEntryBL,
                    clientBL, lawyerBL, caseBL, caseTypeBL, caseServiceBL, cValidator, serviceBL, specialityBL);
                PnlContextChange(employeesOverview);
                SetNavBtnColor(btnEmployees);
            }
        }

        private void BtnAdminPage_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            AdminPageView apv = new AdminPageView();
            PnlContextChange(apv);
            SetNavBtnColor(btnAdminPage);
        }

        private void BtnCase_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            CasePageView casePageView = new CasePageView(this, serviceEntryBL, caseBL, caseTypeBL, lawyerBL, clientBL, specialityBL, caseServiceBL, serviceBL, cValidator);
            PnlContextChange(casePageView);
            SetNavBtnColor(btnCase);
        }

        private void BtnLawyers_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            EmployeesView employeesView = new EmployeesView();
            PnlContextChange(employeesView);
            SetNavBtnColor(btnLawyers);
        }

        private void BtnForms_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            FormView fv = new FormView(clientUI);
            PnlContextChange(fv);
            SetNavBtnColor(btnForms);
        }

        private void BtnClients_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            ClientsView cv = new ClientsView(this, currentUser, clientBL, formBL, caseBL, subscriptionBL, pValidator, serviceEntryBL, lawyerBL, caseTypeBL, caseServiceBL, cValidator, serviceBL, specialityBL);
            PnlContextChange(cv);
            SetNavBtnColor(btnClients);
        }

        private void BtnMyPageClient_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            ClientDetails cdMyPage = new ClientDetails(this, currentUser, clientUI, clientBL, caseBL, formBL, subscriptionBL, pValidator, serviceEntryBL, lawyerBL, caseTypeBL, caseServiceBL, cValidator, serviceBL, specialityBL);
            PnlContextChange(cdMyPage);
            SetNavBtnColor(btnMyPageClient);
        }

        private void BtnSubscribe_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            SubscriptionView subscriptionView = new SubscriptionView(this, clientUI);
            PnlContextChange(subscriptionView);
            SetNavBtnColor(btnSubscribe);
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
