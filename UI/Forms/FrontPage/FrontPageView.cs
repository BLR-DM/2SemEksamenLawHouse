using BusinessLogic;
using UIModels;

namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        Color rgbColorBlue;
        int loginDetailsID;
        PersonBL personBL;
        PersonUI person;

        public FrontPageView(int id)
        {
            personBL = new PersonBL();

            loginDetailsID = id;
            rgbColorBlue = Color.FromArgb(45, 93, 134);

            person = GetPersonAsync(id);

            InitializeComponent();
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task<PersonUI> GetPersonAsync(int id)
        {
            return await personBL.GetPersonAsync(id);
        }
    }
}
