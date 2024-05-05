using BusinessLogic;
using UIModels;

namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        Color rgbColorBlue;
        int loginDetailsID;
        PersonBL personBL;
        PersonUI personUI;

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
            personUI = await personBL.GetPersonAsync(id);
            SetFormType();
        }

        public void SetFormType()
        {
            if (personUI is ClientUI)
            {
                MessageBox.Show("person is a client");
            }
            if (personUI is LawyerUI)
            {
                MessageBox.Show("person is a lawyer");
            }
        }
    }
}
