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
        List<FormUI> boughtForms;
        ClientUI client;
        public FormView(ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            formBL = new FormBL();

            dgvForms.CellDoubleClick += DgvForms_CellDoubleClick;
            dgvBoughtForms.CellDoubleClick += DgvBoughtForms_CellDoubleClick;
            SetDGVsAsync();
        }

        private void DgvBoughtForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormUI selectedForm = boughtForms[e.RowIndex];
                FormDetails fdBought = new FormDetails(selectedForm, client);
                fdBought.ShowDialog();
            }
        }

        private void DgvForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormUI selectedForm = formUIs[e.RowIndex];
                FormDetails fd = new FormDetails(this, selectedForm, client, boughtForms);
                fd.ShowDialog();
            }
        }

        private async void SetDGVsAsync()
        {
            await SetDGVFormAsync();
            await SetBoughtFormsDGVAsync();
        }

        public async Task SetBoughtFormsDGVAsync()
        {
            boughtForms = await formBL.GetBoughtFormsAsync(client.PersonID);
            dgvBoughtForms.DataSource = boughtForms;
            dgvBoughtForms.Columns["FormID"].Visible = false;
            dgvBoughtForms.Columns["Description"].Visible = false;
            dgvBoughtForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoughtForms.ReadOnly = true;
            dgvBoughtForms.RowHeadersVisible = false;
            dgvBoughtForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
