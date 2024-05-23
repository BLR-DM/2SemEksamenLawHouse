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
using UI.Forms.FrontPage;
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


        private async void BtnBuy_Click(object? sender, EventArgs e)
        {
            btnBuy.Enabled = false;

            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to buy the form {selectedForm.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //opretter ny clientformDocumentUI
                ClientFormDocumentUI clientFormBought = new ClientFormDocumentUI()
                {
                    BuyDate = DateTime.Now,
                    ClientID = client.PersonID,
                    FormDocumentID = selectedForm.FormDocumentID,
                };


                //opretter koebet i db
                bool success = await clientFormBL.BuyFormDocumentAsync(clientFormBought);

                if (success)
                {
                    await GetBoughtFormsAsync();
                    SetDetails();
                    MessageBox.Show($"Form has been bought and sent to: {client.Email}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnBuy.Enabled = true;
        }

        //setter detaljer for den valgte form i dgv
        private void DgvForms_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedForm = formUIs[e.RowIndex];
                SetDetails();
            }
        }

        //henter formularer og setter details for formularer
        private async void GetSetData()
        {
            SetDetails();
            await GetBoughtFormsAsync();
            await SetDGVFormAsync();
        }

        private void SetDetails()
        {
            //hvis ingen formular er valgt skal den ik vise noget details
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

            //ellers vis detaljer
            lblTitle.Visible = true;
            lblTitlelbl.Visible = true;
            txtDescription.Visible = true;
            lblDescriptionlbl.Visible = true;
            lblPrice.Visible = true;
            lblPricelbl.Visible = true;

            txtSelectForm.Visible = false;

            //set txt til formularens details
            lblTitle.Text = selectedForm.Name;
            txtDescription.Text = selectedForm.Description;
            lblPrice.Text = selectedForm.Price.ToString() + "$";

            //tjekker om den valgte form allerede er købt
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

        //henter de forms som clienten har købt
        private async Task GetBoughtFormsAsync()
        {
            boughtForms = await formBL.GetBoughtFormDocumentsAsync(client.PersonID);
        }

        
        private void BtnResendMail_Click(object? sender, EventArgs e)
        {
            //gensend mail til clientens mail
            MessageBox.Show($"The form has been resent to: {client.Email}");
        }

        //setup for formular dgv
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

            dgvForms.AllowUserToResizeColumns = false;
            dgvForms.AllowUserToResizeRows = false;

            dgvForms.EnableHeadersVisualStyles = false;
            dgvForms.RowHeadersVisible = false;

            dgvForms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvForms.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvForms.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvForms.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
