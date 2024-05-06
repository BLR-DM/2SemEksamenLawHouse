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
    public partial class FormularView : Form
    {
        FormularBL formularBL;
        List<FormularUI> formularUIs;
        public FormularView()
        {
            InitializeComponent();
            formularBL = new FormularBL();


            SetDGVsAsync();
        }

        private async void SetDGVsAsync()
        {
            await SetDGVFormularAsync();
        }

        private async Task SetDGVFormularAsync()
        {
            formularUIs = await formularBL.GetFormularsAsync();
            dgvFormular.DataSource = formularUIs;
            dgvFormular.Columns["FormularID"].Visible = false;
            dgvFormular.Columns["Description"].Visible = false;
            dgvFormular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFormular.RowHeadersVisible = false;
            dgvFormular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
