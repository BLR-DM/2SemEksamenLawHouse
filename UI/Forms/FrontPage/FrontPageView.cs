using BusinessLogic;
using UIModels;
using UI.Forms.ClientPage;
using UI.Forms.Self_Service;
using UI.Forms.CasePage;
using UI.Forms.AdminPage;
using UI.Forms.EmployeePage;
using UI.Forms.SubscriptionPage;
using BusinessLogic.Validation;
using UI.Forms.LoginPage;

namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        //nuvaerende bruger
        PersonUI currentUser;
        ClientUI clientUI;
        LawyerUI lawyerUI;
        SecretaryUI secretaryUI;
        EmployeeUI employeeUI;


        PersonBL personBL;
        ClientBL clientBL;

        OverallValidator oaValidator;
        LoginPageView loginPage;

        int loginDetailsID;

        public FrontPageView(int loginDetailsID, LoginPageView loginPage)
        {
            personBL = new PersonBL();
            clientBL = new ClientBL();

            this.loginDetailsID = loginDetailsID;
            this.loginPage = loginPage;

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
            lblSignOut.Click += LblSignOut_Click;
        }


        private void LblSignOut_Click(object? sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        public async Task GetPersonAsync(int loginDetailsID)
        {

            if (currentUser == null)
            {
                currentUser = await personBL.GetPersonAsync(loginDetailsID);
            }

            if (currentUser != null)
            {
                lblLoggedInAs.Text = $"Logged in as: {currentUser.Firstname} {currentUser.Lastname}";

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
            this.clientUI = await clientBL.GetClientAsync(clientUI.PersonID);

            // Knapper
            btnMyPageClient.Visible = true;
            btnLawyers.Visible = true;
            btnForms.Visible = true;
            btnSubscribe.Visible = true;
            btnCalculations.Visible = true;

            SetNavBtnColor(btnMyPageClient);

            //set mypage
            ClientDetails cdMyPage = new ClientDetails(this, currentUser, clientUI);
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
            btnAdminPage.Visible = false;

            SetNavBtnColor(btnMyPageLawyer);

            //set mypage
            LawyerDetailsView lawyerDetailsView = new LawyerDetailsView(lawyerUI.PersonID, true, lawyerUI);
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

            //set mypage
            EmployeeDetailsView employeeDetailsView = new EmployeeDetailsView(employeeUI.PersonID, true, employeeUI);
            if (pnlContext.Controls.Count == 0 || pnlContext.Controls[0].GetType() != typeof(EmployeeDetailsView))
            {
                PnlContextChange(employeeDetailsView);
            }
        }

        public void PnlContextChange(Form f)
        {
            //clear controls fra panelForm
            pnlContext.Controls.Clear();
            f.TopLevel = false;
            //tilføj form som control til panelet
            pnlContext.Controls.Add(f);
            f.Show();
            pnlContext.Show();
        }

        private void SetNavBtnColor(Button btn)
        {
            foreach (Button buttonnis in pnlLeft.Controls)
            {
                buttonnis.BackColor = Color.FromArgb(194, 205, 240);
            }

            btn.BackColor = Color.FromArgb(174, 183, 212);
            lblCurrentPage.Text = btn.Text;
        }

        private void BtnCalculations_Click(object? sender, EventArgs e)
        {
            CalculationsView calculationsView = new CalculationsView(clientUI);
            PnlContextChange(calculationsView);
            SetNavBtnColor(btnCalculations);
        }

        private void BtnMyPageLawyer_Click(object? sender, EventArgs e)
        {
            if (currentUser is LawyerUI)
            {
                LawyerDetailsView myPageLawyer = new LawyerDetailsView(lawyerUI.PersonID, true, lawyerUI);
                PnlContextChange(myPageLawyer);
                SetNavBtnColor(btnMyPageLawyer);
            }
            else if (currentUser is SecretaryUI)
            {
                EmployeeDetailsView myPageEmployee = new EmployeeDetailsView(secretaryUI.PersonID, true, employeeUI);
                PnlContextChange(myPageEmployee);
                SetNavBtnColor(btnMyPageLawyer);
            }
            else
            {
                EmployeeDetailsView myPageEmployee = new EmployeeDetailsView(employeeUI.PersonID, true, employeeUI);
                PnlContextChange(myPageEmployee);
                SetNavBtnColor(btnMyPageLawyer);
            }
        }

        private void BtnEmployees_Click(object? sender, EventArgs e)
        {
            if (currentUser is LawyerUI)
            {
                EmployeesOverview employeesOverview = new EmployeesOverview(lawyerUI);
                PnlContextChange(employeesOverview);
                SetNavBtnColor(btnEmployees);
            }
            else
            {
                EmployeesOverview employeesOverview = new EmployeesOverview(employeeUI);
                PnlContextChange(employeesOverview);
                SetNavBtnColor(btnEmployees);
            }
        }

        private void BtnAdminPage_Click(object? sender, EventArgs e)
        {
            AdminPageView apv = new AdminPageView();
            PnlContextChange(apv);
            SetNavBtnColor(btnAdminPage);
        }

        private void BtnCase_Click(object? sender, EventArgs e)
        {
            CasePageView casePageView = new CasePageView(this);
            PnlContextChange(casePageView);
            SetNavBtnColor(btnCase);
        }

        private void BtnLawyers_Click(object? sender, EventArgs e)
        {
            EmployeesView employeesView = new EmployeesView();
            PnlContextChange(employeesView);
            SetNavBtnColor(btnLawyers);
        }

        private void BtnForms_Click(object? sender, EventArgs e)
        {
            FormView fv = new FormView(clientUI);
            PnlContextChange(fv);
            SetNavBtnColor(btnForms);
        }

        private void BtnClients_Click(object? sender, EventArgs e)
        {
            ClientsView cv = new ClientsView(this, currentUser);
            PnlContextChange(cv);
            SetNavBtnColor(btnClients);
        }

        private void BtnMyPageClient_Click(object? sender, EventArgs e)
        {
            ClientDetails cdMyPage = new ClientDetails(this, currentUser, clientUI);
            PnlContextChange(cdMyPage);
            SetNavBtnColor(btnMyPageClient);
        }

        private void BtnSubscribe_Click(object? sender, EventArgs e)
        {
            SubscriptionView subscriptionView = new SubscriptionView(this, clientUI);
            PnlContextChange(subscriptionView);
            SetNavBtnColor(btnSubscribe);
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLoggedInAs_Click(object sender, EventArgs e)
        {

        }
    }
}
