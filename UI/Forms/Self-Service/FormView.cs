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

namespace UI.Forms.Self_Service
{
    public partial class FormView : Form
    {
        FormBL formBL;
        List<FormUI> formUIs;
        int clientID;
        public FormView(int clientID)
        {
            InitializeComponent();
            this.clientID = clientID;
            formBL = new FormBL();

            dgvForms.CellDoubleClick += DgvForms_CellDoubleClick;

            SetDGVsAsync();
        }

        private void DgvForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormUI selectedForm = formUIs[e.RowIndex];
                FormDetails fd = new FormDetails(selectedForm, clientID);
                fd.ShowDialog();
            }
        }

        private async void SetDGVsAsync()
        {
            await SetDGVFormAsync();
        }

        private async Task SetDGVFormAsync()
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
