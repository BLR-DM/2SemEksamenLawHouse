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
    public partial class FormDetails : Form
    {
        FormView fv;
        FormUI form;
        ClientFormBL clientFormBL;
        List<FormUI> boughtForms;
        ClientUI client;

        //FORM DETAILS FOR IKKE KØBTE FORMULARER
        public FormDetails(FormView fv, FormUI form, ClientUI client, List<FormUI> boughtForms)
        {
            InitializeComponent();
            this.fv = fv;
            this.form = form;
            this.client = client;
            this.boughtForms = boughtForms;
            clientFormBL = new ClientFormBL();
            btnResendMail.Hide();
            btnBuy.Click += BtnBuy_Click;

            SetDetails();
        }

        private async void BtnBuy_Click(object? sender, EventArgs e)
        {
            bool formIsBought = boughtForms.FirstOrDefault(f => f.FormID == form.FormID) != null ? true : false;
            if (formIsBought)
            {
                MessageBox.Show("You already own this form");
                return;
            }

            ClientFormUI clientFormBought = new ClientFormUI()
            {
                BuyDate = DateTime.Now,
                ClientID = client.PersonID,
                FormID = form.FormID,
            };
            bool success = await clientFormBL.BuyForm(clientFormBought);
            if (success)
            {
                MessageBox.Show("Form has been bought");
                await fv.SetBoughtFormsDGVAsync();
            }
            else
            {
                MessageBox.Show("ERROR! Form not bought");
            }
            this.Close();
        }


        //FORM DETAILS FOR Købte formularer
        public FormDetails(FormUI form, ClientUI client)
        {
            InitializeComponent();
            this.form = form;
            this.client = client;
            btnBuy.Hide();
            btnResendMail.Click += BtnResendMail_Click;
            SetDetails();
        }

        private void BtnResendMail_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($"The form has been resent to: {client.Email}");
        }

       

        //delt setdetails for formens informationer
        private void SetDetails()
        {
            lblTitle.Text = form.Name;
            txtDescription.Text = form.Description;
            lblPrice.Text = form.Price.ToString() + "$";
        }
    }
}
