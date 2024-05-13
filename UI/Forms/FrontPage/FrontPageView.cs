using BusinessLogic;
using UIModels;
using UI.Forms.ClientPage;
using UI.Forms.Self_Service;
using UI.Forms.CasePage;
using UI.Forms.AdminPage;
using UI.Forms.EmployeePage;

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
            btnClose.Click += BtnClose_Click;
            btnMyPageClient.Click += BtnMyPageClient_Click;
            btnClients.Click += BtnClients_Click;
            btnLawyers.Click += BtnLawyers_Click;
            btnForms.Click += BtnForms_Click;
            btnCase.Click += BtnCase_Click;
            btnAdminPage.Click += BtnAdminPage_Click;
            btnEmployees.Click += BtnEmployees_Click;
            btnMyPageLawyer.Click += BtnMyPageLawyer_Click;
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

        public async Task GetPersonAsync(int id)
        {
            currentUser = await personBL.GetPersonAsync(id);
            if (currentUser != null)
            {
                lblCurrentUser.Text = currentUser.GetType().Name;
                lblCurrentUserName.Text = currentUser.Firstname; 
            }
            await SetupForm();
        }

        public async Task SetupForm()
        {
            if (currentUser is ClientUI)
            {
                clientUI = await clientBL.GetClientAsync(currentUser.PersonID);
                btnAdminPage.Hide();
                btnEmployees.Hide();
                btnMyPageLawyer.Hide();
                if(clientUI.ClientSub == false)
                {
                    btnCalculations.Hide();
                }
                //MessageBox.Show("person is a client");

            }
            if (currentUser is LawyerUI)
            {
                lawyerUI = await lawyerBL.GetLawyerAsync(currentUser.PersonID);
                btnMyPageClient.Hide();
                btnLawyers.Hide();
                //MessageBox.Show("person is a lawyerUI");
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
    }
}
