using BusinessLogic;
using BusinessLogic.Validation;
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

namespace UI.Forms.AdminPage
{
    public partial class AdminCUDCaseType : Form
    {
        CaseTypeBL caseTypeBL;
        CaseValidator cValidator;

        Color validFormat;
        Color invalidFormat;
        public AdminCUDCaseType()
        {
            InitializeComponent();

            caseTypeBL = new CaseTypeBL();
            cValidator = new CaseValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCreate.Click += BtnCreate_Click;
            txtCaseType.TextChanged += TxtCaseType_TextChanged;

            btnCreate.Enabled = false;
            btnUpdate.Visible = false;
        }

        private void TxtCaseType_TextChanged(object? sender, EventArgs e)
        {
            txtCaseType.ForeColor = cValidator.ValidTitle(txtCaseType.Text) ? validFormat : invalidFormat;
            if (txtCaseType.ForeColor == validFormat)
            {
                btnCreate.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            CaseTypeUI caseTypeUI = new CaseTypeUI()
            {
                Title = txtCaseType.Text,
            };

            bool succes = await caseTypeBL.CreateCaseTypeAsync(caseTypeUI);

            if (succes)
            {
                MessageBox.Show("Casetype has been created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create casetype");
                btnCreate.Enabled = true;
            }
        }


        //Update

        CaseTypeUI selectedCaseType;

        public AdminCUDCaseType(CaseTypeUI selectedCaseType)
        {
            InitializeComponent();
            this.selectedCaseType = selectedCaseType;

            caseTypeBL = new CaseTypeBL();
            cValidator = new CaseValidator();

            txtCaseType.Text = selectedCaseType.Title;
            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnUpdate.Click += BtnUpdate_Click;
            txtCaseType.TextChanged += TxtCaseType_TextChanged;

            btnCreate.Visible = false;
            btnUpdate.Enabled = false;

        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            CaseTypeUI caseTypeUI = new CaseTypeUI()
            {
                Title = txtCaseType.Text,
            };

            bool succes = await caseTypeBL.UpdateCaseTypeAsync(caseTypeUI);
          

            if (succes)
            {
                MessageBox.Show("Casetype has been updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update the casetype");
                btnUpdate.Enabled = true;
            }
        }
    }
}