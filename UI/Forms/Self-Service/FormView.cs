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
using UIModels;

namespace UI.Forms.Self_Service
{
    public partial class FormView : Form
    {
        FormBL formBL;
        List<FormUI> formUIs;
        public FormView()
        {
            InitializeComponent();
            formBL = new FormBL();


            SetDGVsAsync();
        }

        private async void SetDGVsAsync()
        {
            await SetDGVFormAsync();
        }

        private async Task SetDGVFormAsync()
        {
            formUIs = await formBL.GetFormAsync();
            dgvFormular.DataSource = formUIs;
            dgvFormular.Columns["FormularID"].Visible = false;
            dgvFormular.Columns["Description"].Visible = false;
            dgvFormular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFormular.RowHeadersVisible = false;
            dgvFormular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
