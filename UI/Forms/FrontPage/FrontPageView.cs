using BusinessLogic;
using UIModels;

namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        Color rgbColorBlue;
        int loginDetailsID;
        PersonBL personBL;
        PersonUI currentUser;

        public FrontPageView(int id)
        {
            personBL = new PersonBL();

            loginDetailsID = id;
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            GetPersonAsync(loginDetailsID);

            InitializeComponent();
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task GetPersonAsync(int id)
        {
            currentUser = await personBL.GetPersonAsync(id);
            SetFormType();
        }

        public void SetFormType()
        {
            if (currentUser is ClientUI)
            {
                MessageBox.Show("person is a client");
            }
            if (currentUser is LawyerUI)
            {
                MessageBox.Show("person is a lawyer");
            }
        }
    }
}
