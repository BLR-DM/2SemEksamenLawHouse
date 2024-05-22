using BusinessLogic;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminCUDLawyerTitle : Form
    {
        LawyerTitleBL lawyerTitleBL;
        public AdminCUDLawyerTitle()
        {
            lawyerTitleBL = new LawyerTitleBL();
            InitializeComponent();

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            btnCreate.Click += BtnCreate_Click;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            LawyerTitleUI lawyerTitleUI = new LawyerTitleUI()
            {
                Title = txtTitle.Text
            };

            bool test = await lawyerTitleBL.CreateLawyerTitleAsync(lawyerTitleUI);

            if (test)
            {
                MessageBox.Show($"Lawyer Title \"{lawyerTitleUI.Title}\" was created!");
                this.Close();
            }
            else
                MessageBox.Show("Failed!");
        }

        LawyerTitleUI lawyerTitleUpdate;
        public AdminCUDLawyerTitle(LawyerTitleUI lawyerTitleUI)
        {
            lawyerTitleUpdate = lawyerTitleUI;

            lawyerTitleBL = new LawyerTitleBL();

            InitializeComponent();
            btnCreate.Visible = false;
            btnUpdate.Enabled = false;
            txtTitle.Text = lawyerTitleUI.Title;

            txtTitle.TextChanged += TxtTitle_TextChanged;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            lawyerTitleUpdate.Title = txtTitle.Text;

            bool isUpdated = await lawyerTitleBL.UpdateLawyerTitleAsync(lawyerTitleUpdate);

            if (isUpdated)
            {
                MessageBox.Show($"LawyerTitle has been updated to: \"{lawyerTitleUpdate.Title}\"!");
                this.Close();
            }
            else
                MessageBox.Show("Failed!");
        }

        private void TxtTitle_TextChanged(object? sender, EventArgs e)
        {
            btnUpdate.Enabled = txtTitle.Text != lawyerTitleUpdate.Title && !string.IsNullOrEmpty(txtTitle.Text);
        }


    }
}
