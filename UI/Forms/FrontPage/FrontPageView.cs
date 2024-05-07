﻿using BusinessLogic;
using UIModels;
using UI.Forms.ClientPage;

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
        }

        private void BtnLawyers_Click(object? sender, EventArgs e)
        {
            EmployeesView employeesView = new EmployeesView(this);
            PnlContextChange(employeesView);
        }

        private void BtnClients_Click(object? sender, EventArgs e)
        {
            ClientsView cv = new ClientsView(this);
            PnlContextChange(cv);
        }

        private void BtnMyPageClient_Click(object? sender, EventArgs e)
        {
            MyPageView mpv = new MyPageView(clientUI);
            PnlContextChange(mpv);
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
                //MessageBox.Show("person is a client");

            }
            if (currentUser is LawyerUI)
            {
                lawyerUI = await lawyerBL.GetLawyerAsync(currentUser.PersonID);
                btnMyPageClient.Hide();
                btnLawyers.Hide();
                //MessageBox.Show("person is a lawyer");
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
