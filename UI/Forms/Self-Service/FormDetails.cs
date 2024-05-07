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
        FormUI form;
        ClientFormBL clientFormBL;
        int clientID;
        public FormDetails(FormUI form, int clientID)
        {
            InitializeComponent();
            this.form = form;
            this.clientID = clientID;
            clientFormBL = new ClientFormBL();
            btnBuy.Click += BtnBuy_Click;

            SetDetails();
        }

        private void BtnBuy_Click(object? sender, EventArgs e)
        {
            
            this.Close();
        }

        private void SetDetails()
        {
            lblTitle.Text = form.Name;
            txtDescription.Text = form.Description;
            lblPrice.Text = form.Price.ToString() + "$";
        }
    }
}
