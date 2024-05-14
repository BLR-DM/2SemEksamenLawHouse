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


        PersonBL personBL;
        ClientBL clientBL;
        LawyerBL lawyerBL;
        FormDocumentBL formBL;
        SubscriptionBL subscriptionBL;

        PersonValidator pValidator;
        OverallValidator oaValidator;

        public FrontPageView(int loginDetailsID)
        {
            personBL = new PersonBL();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
            formBL = new FormDocumentBL();
            subscriptionBL = new SubscriptionBL();
            pValidator = new PersonValidator();
            oaValidator = new OverallValidator();


            rgbColorBlue = Color.FromArgb(45, 93, 134);

            GetPersonAsync(loginDetailsID);

            InitializeComponent();

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

                if (currentUser is ClientUI)
                {
                    await SetupClientFormAsync();
                }
                if (currentUser is LawyerUI)
                {
                    await SetupLawyerFormAsync();
                }
            }
        }

        private async Task SetupClientFormAsync()
        {
            clientUI = await clientBL.GetClientAsync(currentUser.PersonID);

            // Knapper
            btnMyPageClient.Visible = true;
            btnLawyers.Visible = true;
            btnForms.Visible = true;
            btnSubscribe.Visible = true;

            //set mypage
            ClientDetails cdMyPage;
                cdMyPage = new ClientDetails(this, currentUser, clientUI, clientBL, formBL, subscriptionBL, pValidator); 
            if (pnlContext.Controls[0].GetType() != typeof(ClientDetails))
            {
                PnlContextChange(cdMyPage);
            }


            if (clientUI.IsSubscribed == true)
            {
                btnCalculations.Visible = true; // Vis med restrictions
            }
        }

        private async Task SetupLawyerFormAsync()
        {
            lawyerUI = await lawyerBL.GetLawyerAsync(currentUser.PersonID);

            // Knapper
            btnMyPageLawyer.Visible = true;
            btnEmployees.Visible = true;
            btnCase.Visible = true;
            btnClients.Visible = true;
            btnAdminPage.Visible = true; // test
            
            if (lawyerUI.Admin)
            {
                btnAdminPage.Visible = true;
            }
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
        private void BtnCalculations_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            CalculationsView calculationsView = new CalculationsView(oaValidator);
            PnlContextChange(calculationsView);
        }

        private void BtnMyPageLawyer_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            MyPageLawyerView myPageLawyer = new MyPageLawyerView(lawyerUI.PersonID);
            PnlContextChange(myPageLawyer);
        }

        private void BtnEmployees_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            EmployeesOverview employeesOverview = new EmployeesOverview();
            PnlContextChange(employeesOverview);
        }

        private void BtnAdminPage_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            AdminPageView apv = new AdminPageView();
            PnlContextChange(apv);
        }

        private void BtnCase_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            CasePageView casePageView = new CasePageView(this);
            PnlContextChange(casePageView);
        }

        private void BtnLawyers_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            EmployeesView employeesView = new EmployeesView();
            PnlContextChange(employeesView);
        }

        private void BtnForms_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            FormView fv = new FormView(clientUI);
            PnlContextChange(fv);
        }

        private void BtnClients_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            ClientsView cv = new ClientsView(this, currentUser, clientBL, formBL, subscriptionBL, pValidator);
            PnlContextChange(cv);
        }

        private void BtnMyPageClient_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            ClientDetails cdMyPage = new ClientDetails(this, currentUser, clientUI, clientBL, formBL, subscriptionBL, pValidator);
            PnlContextChange(cdMyPage);
        }

        private void BtnSubscribe_Click(object? sender, EventArgs e)
        {
            lblCurrentPage.Text = (sender as Button).Text;
            SubscriptionView subscriptionView = new SubscriptionView(this, clientUI);
            PnlContextChange(subscriptionView);
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
