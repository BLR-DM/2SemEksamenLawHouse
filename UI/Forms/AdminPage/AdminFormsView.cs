using BusinessLogic;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminFormsView : Form
    {
        List<FormDocumentUI> formDocumentUIs;
        FormDocumentBL formBL;
        public AdminFormsView()
        {
            InitializeComponent();
            formBL = new FormDocumentBL();
            SetDgvFormAsync();

            dgvForms.CellDoubleClick += DgvForms_CellDoubleClick;
        }

        private void DgvForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormDocumentUI selectedForm = formDocumentUIs[e.RowIndex] as FormDocumentUI;
                AdminCUDForm aCUDform = new AdminCUDForm(selectedForm);
                aCUDform.ShowDialog();
                this.Close();
                
            }
        }

        private async void SetDgvFormAsync()
        {
            formDocumentUIs = await formBL.GetFormDocumentAsync();
            dgvForms.DataSource = formDocumentUIs;
            dgvForms.Columns["FormDocumentID"].Visible = false;
            dgvForms.Columns["Description"].Visible = false;
            dgvForms.MultiSelect = false;
            dgvForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForms.ReadOnly = true;
            dgvForms.RowHeadersVisible = false;
            dgvForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
