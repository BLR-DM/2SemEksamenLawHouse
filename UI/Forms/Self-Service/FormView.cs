using BusinessLogic;
using EntityModels;
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
    public partial class FormView : System.Windows.Forms.Form
    {
        FormDocumentBL formBL;
        ClientFormDocumentBL clientFormBL;
        List<FormDocumentUI> formUIs;
        List<FormDocumentUI> boughtForms;
        ClientUI client;
        FormDocumentUI selectedForm;
        public FormView(ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            formBL = new FormDocumentBL();
            clientFormBL = new ClientFormDocumentBL();
            btnBuy.Visible = false;
            dgvForms.CellClick += DgvForms_CellClick;
            btnBuy.Click += BtnBuy_Click;
            btnResendMail.Click += BtnResendMail_Click;

            GetSetData();
        }

        private void BtnResendMail_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($"The form has been resent to: {client.Email}");
        }

        private async Task GetBoughtFormsAsync()
        {
            boughtForms = await formBL.GetBoughtFormDocumentsAsync(client.PersonID);
        }

        private async void BtnBuy_Click(object? sender, EventArgs e)
        {
            btnBuy.Enabled = false;

            ClientFormDocumentUI clientFormBought = new ClientFormDocumentUI()
            {
                BuyDate = DateTime.Now,
                ClientID = client.PersonID,
                FormDocumentID = selectedForm.FormDocumentID,
            };
            bool success = await clientFormBL.BuyFormDocumentAsync(clientFormBought);
            if (success)
            {
                MessageBox.Show($"Form has been bought and sent to: {client.Email}");
                await GetBoughtFormsAsync();
                SetDetails();

            }
            else
            {
                MessageBox.Show("ERROR! Form not bought");
            }

            btnBuy.Enabled = true;
        }

        private void DgvForms_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedForm = formUIs[e.RowIndex];
                SetDetails();
            }
        }


        private async void GetSetData()
        {
            SetDetails();
            await GetBoughtFormsAsync();
            await SetDGVFormAsync();
        }

        private void SetDetails()
        {

            if (dgvForms.SelectedRows.Count == 0)
            {
                lblTitle.Visible = false;
                lblTitlelbl.Visible = false;
                txtDescription.Visible = false;
                lblDescriptionlbl.Visible = false;
                lblPrice.Visible = false;
                lblPricelbl.Visible = false;
                btnBuy.Visible = false;
                btnResendMail.Visible = false;

                txtSelectForm.Visible = true;
                return;
            }

            lblTitle.Visible = true;
            lblTitlelbl.Visible = true;
            txtDescription.Visible = true;
            lblDescriptionlbl.Visible = true;
            lblPrice.Visible = true;
            lblPricelbl.Visible = true;

            txtSelectForm.Visible = false;


            lblTitle.Text = selectedForm.Name;
            txtDescription.Text = selectedForm.Description;
            lblPrice.Text = selectedForm.Price.ToString() + "$";

            bool formIsBought = boughtForms.FirstOrDefault(f => f.FormDocumentID == selectedForm.FormDocumentID) != null ? true : false;
            if (formIsBought)
            {
                btnBuy.Visible = false;
                btnResendMail.Visible = true;
            }
            else
            {
                btnBuy.Visible = true;
                btnResendMail.Visible = false;
            }
        }


        private async Task SetDGVFormAsync()
        {
            formUIs = await formBL.GetFormDocumentAsync();
            dgvForms.DataSource = formUIs;
            dgvForms.Columns["FormDocumentID"].Visible = false;
            dgvForms.Columns["Description"].Visible = false;
            dgvForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForms.ReadOnly = true;
            dgvForms.RowHeadersVisible = false;
            dgvForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
