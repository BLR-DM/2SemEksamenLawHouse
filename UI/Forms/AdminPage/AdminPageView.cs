using BusinessLogic.API;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminPageView : Form
    {
        DistanceMatrixBL apiTestBL;
        public AdminPageView()
        {
            apiTestBL = new DistanceMatrixBL();
            InitializeComponent();

            btnCreateForm.Click += BtnCreateForm_Click;
            btnUpdateForm.Click += BtnUpdateForm_Click;
            btnDeleteForm.Click += BtnDeleteForm_Click;
            btnCreateLawyer.Click += BtnCreateLawyer_Click;
            btnCreateSecretary.Click += BtnCreateSecretary_Click;
            btnCreateService.Click += BtnCreateService_Click;
            btnUpdateService.Click += BtnUpdateService_Click;
            btnCreateLawyerTitle.Click += BtnCreateLawyerTitle_Click;
            btnUpdateLawyerTitle.Click += BtnUpdateTitle_Click;
            btnDeleteLawyerTitle.Click += BtnDeleteLawyerTitle_Click;
            btnCreateSpeciality.Click += BtnCreateSpeciality_Click;
            btnUpdateSpeciality.Click += BtnUpdateSpeciality_Click;
            btnDeleteSpeciality.Click += BtnDeleteSpeciality_Click;
            btnSearch.Click += BtnSearch_Click;
        }

        private async void BtnSearch_Click(object? sender, EventArgs e)
        {
            DistanceMatrix test = new DistanceMatrix() {};

            test = await apiTestBL.GetDistance(txtOrigin.Text, txtDestination.Text);

            if (test != null)
            {
                txtResult.Text = test.rows[0].elements[0].distance.text; 
            }
            btnCreateCaseType.Click += BtnCreateCaseType_Click;
            btnUpdateCaseType.Click += BtnUpdateCaseType_Click;
        }

        private void BtnUpdateCaseType_Click(object? sender, EventArgs e)
        {
            new AdminCaseTypeView().ShowDialog();
        }

        private void BtnCreateCaseType_Click(object? sender, EventArgs e)
        {
            new AdminCUDCaseType().ShowDialog();
        }

        private void BtnDeleteSpeciality_Click(object? sender, EventArgs e)
        {
            new AdminSpecialityView().ShowDialog();
        }

        private void BtnUpdateSpeciality_Click(object? sender, EventArgs e)
        {
            new AdminSpecialityView().ShowDialog();
        }

        private void BtnCreateSpeciality_Click(object? sender, EventArgs e)
        {
            new AdminCUDSpeciality().ShowDialog();
        }

        private void BtnDeleteLawyerTitle_Click(object? sender, EventArgs e)
        {
            new AdminLawyerTitlesView().ShowDialog();
        }

        private void BtnUpdateTitle_Click(object? sender, EventArgs e)
        {
            new AdminLawyerTitlesView().ShowDialog();
        }

        private void BtnCreateLawyerTitle_Click(object? sender, EventArgs e)
        {
            new AdminCUDLawyerTitle().ShowDialog();
        }

        private void BtnUpdateService_Click(object? sender, EventArgs e)
        {
            new AdminServiceView().ShowDialog();
        }

        private void BtnCreateService_Click(object? sender, EventArgs e)
        {
            new AdminCUDService().ShowDialog();
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
