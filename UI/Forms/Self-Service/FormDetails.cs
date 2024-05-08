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

        //FORM DETAILS FOR Købte formularer
        public FormDetails(FormUI form, ClientUI client)
        {
            InitializeComponent();
            this.form = form;
            this.client = client;
            btnResendMail.Click += BtnResendMail_Click;
            SetDetails();
        }

        private void BtnResendMail_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($"The form has been resent to: {client.Email}");
        }

       

        //set details for formens informationer
        private void SetDetails()
        {
            lblTitle.Text = form.Name;
            txtDescription.Text = form.Description;
            lblPrice.Text = form.Price.ToString() + "$";
        }
    }
}
