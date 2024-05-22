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

            bool result = await lawyerTitleBL.CreateLawyerTitleAsync(lawyerTitleUI);

            if (result)
            {
                MessageBox.Show($"Lawyer Title \"{lawyerTitleUI.Title}\" was created!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        LawyerTitleUI selectedTitle;
        public AdminCUDLawyerTitle(LawyerTitleUI lawyerTitleUI)
        {
            selectedTitle = lawyerTitleUI;

            lawyerTitleBL = new LawyerTitleBL();

            InitializeComponent();
            btnCreate.Visible = false;
            btnUpdate.Enabled = false;
            txtTitle.Text = lawyerTitleUI.Title;

            txtTitle.TextChanged += TxtTitle_TextChanged;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to update the title to: {txtTitle.Text}?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                selectedTitle.Title = txtTitle.Text;

                bool result = await lawyerTitleBL.DeleteLawyerTitleAsync(selectedTitle);        

                if (result)
                {
                    MessageBox.Show($"LawyerTitle has been updated to: \"{selectedTitle.Title}\"!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to delete \"{selectedTitle.Title}\"?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                bool result = await lawyerTitleBL.DeleteLawyerTitleAsync(selectedTitle);

                if (result)
                {
                    MessageBox.Show($"\"{selectedTitle.Title}\" was succesfully deleted from the system!", "Deleted", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Could not delete the title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtTitle_TextChanged(object? sender, EventArgs e)
        {
            btnUpdate.Enabled = txtTitle.Text != selectedTitle.Title && !string.IsNullOrEmpty(txtTitle.Text);
        }
    }
}
