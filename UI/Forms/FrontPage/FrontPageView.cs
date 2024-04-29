namespace UI.Forms.FrontPage
{
    public partial class FrontPageView : Form
    {
        public FrontPageView()
        {
            InitializeComponent();
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
