namespace UI.Forms.AdminPage
{
    public partial class AdminPageView : Form
    {
        public AdminPageView()
        {
            InitializeComponent();

            btnCreateForm.Click += BtnCreateForm_Click;
            btnUpdateForm.Click += BtnUpdateForm_Click;
            btnDeleteForm.Click += BtnDeleteForm_Click;
            btnCreateLawyer.Click += BtnCreateLawyer_Click;
            btnCreateSecretary.Click += BtnCreateSecretary_Click;
            btnCreateService.Click += BtnCreateService_Click;
        }

        private void BtnCreateService_Click(object? sender, EventArgs e)
        {
            new AdminCreateService().ShowDialog();
        }

        private void BtnCreateSecretary_Click(object? sender, EventArgs e)
        {
            new AdminCreateSecretary().ShowDialog();
        }

        private void BtnCreateLawyer_Click(object? sender, EventArgs e)
        {
            new AdminCreateLawyer().ShowDialog();
        }

        private void BtnCreateForm_Click(object? sender, EventArgs e)
        {
            AdminCUDForm createForm = new AdminCUDForm();
            createForm.ShowDialog();
        }

        private void BtnUpdateForm_Click(object? sender, EventArgs e)
        {
            AdminFormsView afv = new AdminFormsView();
            afv.ShowDialog();
        }
        private void BtnDeleteForm_Click(object? sender, EventArgs e)
        {
            AdminFormsView afv = new AdminFormsView();
            afv.ShowDialog();
        }
    }
}
