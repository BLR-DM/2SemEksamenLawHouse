using BusinessLogic;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminCUDForm : Form
    {
        FormDocumentBL formBL;
        //
        //Create
        //
        public AdminCUDForm()
        {
            InitializeComponent();

            formBL = new FormDocumentBL();


            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            btnCreateForm.Click += BtnCreateForm_Click;
        }

        private async void BtnCreateForm_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to create the form: {txtName.Text}?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                FormDocumentUI formToCreate = new FormDocumentUI()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = float.Parse(txtPrice.Text)
                };

                bool isCreated = await formBL.CreateFormDocumentAsync(formToCreate);

                if (isCreated)
                {
                    MessageBox.Show($"The form {txtName.Text} has been created!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //
        // Update og Delete
        //

        FormDocumentUI form;
        public AdminCUDForm(FormDocumentUI form)
        {
            InitializeComponent();
            this.form = form;
            formBL = new FormDocumentBL();

            btnCreateForm.Visible = false;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;

            this.form = form;

            txtName.Text = form.Name;
            txtDescription.Text = form.Description;
            txtPrice.Text = form.Price.ToString();
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to update the form: {txtName.Text}?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                FormDocumentUI formToUpdate = new FormDocumentUI()
                {
                    FormDocumentID = form.FormDocumentID,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = float.Parse(txtPrice.Text)
                };

                bool isUpdated = await formBL.UpdateFormDocumentAsync(formToUpdate);

                if (isUpdated)
                {
                    MessageBox.Show($"The form {txtName.Text} has been updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to DELETE the form: {txtName.Text}?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                bool isDeleted = await formBL.DeleteFormDocumentAsync(form);

                if (isDeleted)
                {
                    MessageBox.Show($"The form {txtName.Text} has been deleted!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
