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
        FormBL formBL;
        ClientFormBL clientFormBL;
        List<FormUI> formUIs;
        List<FormUI> boughtForms;
        ClientUI client;
        FormUI selectedForm;
        public FormView(ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            formBL = new FormBL();
            clientFormBL = new ClientFormBL();
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
            boughtForms = await formBL.GetBoughtFormsAsync(client.PersonID);
        }

        private async void BtnBuy_Click(object? sender, EventArgs e)
        {

            ClientFormUI clientFormBought = new ClientFormUI()
            {
                BuyDate = DateTime.Now,
                ClientID = client.PersonID,
                FormID = selectedForm.FormID,
            };
            bool success = await clientFormBL.BuyForm(clientFormBought);
            if (success)
            {
                MessageBox.Show($"Form has been bought and sent to: {client.Email}");
                await GetBoughtFormsAsync();
            }
            else
            {
                MessageBox.Show("ERROR! Form not bought");
            }
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
            
            if(dgvForms.SelectedRows.Count == 0)
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

            bool formIsBought = boughtForms.FirstOrDefault(f => f.FormID == selectedForm.FormID) != null ? true : false;
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
