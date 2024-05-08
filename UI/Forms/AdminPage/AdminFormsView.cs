using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.ClientPage;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminFormsView : Form
    {
        List<FormUI> formUIs;
        FormBL formBL;
        public AdminFormsView()
        {
            InitializeComponent();
            formBL = new FormBL();
            SetDgvFormAsync();

            dgvForms.CellDoubleClick += DgvForms_CellDoubleClick;
        }

        private void DgvForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormUI selectedForm = formUIs[e.RowIndex];
                AdminCUDForm aCUDform = new AdminCUDForm(selectedForm);
                aCUDform.ShowDialog();
                this.Close();
                
            }
        }

        private async void SetDgvFormAsync()
        {
            formUIs = await formBL.GetFormAsync();
            dgvForms.DataSource = formUIs;
            dgvForms.Columns["FormID"].Visible = false;
            dgvForms.Columns["Description"].Visible = false;
            dgvForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForms.ReadOnly = true;
            dgvForms.RowHeadersVisible = false;
            dgvForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
