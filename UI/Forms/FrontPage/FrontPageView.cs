using BusinessLogic;
using UIModels;
using UI.Forms.ClientPage;
using UI.Forms.Self_Service;
using UI.Forms.CasePage;
using UI.Forms.AdminPage;
using UI.Forms.EmployeePage;
using EntityModels;

namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        Color rgbColorBlue;
        PersonBL personBL;
        ClientBL clientBL;
        LawyerBL lawyerBL;
        PersonUI currentUser;
        ClientUI clientUI;
        LawyerUI lawyerUI;

        public FrontPageView(int loginDetailsID)
        {
            personBL = new PersonBL();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();

            rgbColorBlue = Color.FromArgb(45, 93, 134);

            GetPersonAsync(loginDetailsID);

            InitializeComponent();
            btnForms.Visible = btnEmployees.Visible = btnClients.Visible = btnAdminPage.Visible =
            btnAdminPage.Visible = btnCalculations.Visible = btnCase.Visible = btnLawyers.Visible =
            btnMyPageClient.Visible = btnMyPageLawyer.Visible = false;
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
        }

        public async Task GetPersonAsync(int id)
        {
            currentUser = await personBL.GetPersonAsync(id);

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
            
            if (clientUI.ClientSub == true)
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
            CalculationsView calculationsView = new CalculationsView();
            PnlContextChange(calculationsView);
        }

        private void BtnMyPageLawyer_Click(object? sender, EventArgs e)
        {
            MyPageLawyerView myPageLawyer = new MyPageLawyerView(lawyerUI.PersonID);
            PnlContextChange(myPageLawyer);
        }

        private void BtnEmployees_Click(object? sender, EventArgs e)
        {
            EmployeesOverview employeesOverview = new EmployeesOverview();
            PnlContextChange(employeesOverview);
        }

        private void BtnAdminPage_Click(object? sender, EventArgs e)
        {
            AdminPageView apv = new AdminPageView();
            PnlContextChange(apv);
        }

        private void BtnCase_Click(object? sender, EventArgs e)
        {
            CasePageView casePageView = new CasePageView(this);
            PnlContextChange(casePageView);
        }

        private void BtnLawyers_Click(object? sender, EventArgs e)
        {
            EmployeesView employeesView = new EmployeesView();
            PnlContextChange(employeesView);
        }

        private void BtnForms_Click(object? sender, EventArgs e)
        {
            FormView fv = new FormView(clientUI);
            PnlContextChange(fv);
        }

        private void BtnClients_Click(object? sender, EventArgs e)
        {
            ClientsView cv = new ClientsView(this, currentUser);
            PnlContextChange(cv);
        }

        private void BtnMyPageClient_Click(object? sender, EventArgs e)
        {
            ClientDetails cdMyPage = new ClientDetails(this, currentUser, clientUI);
            PnlContextChange(cdMyPage);
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
