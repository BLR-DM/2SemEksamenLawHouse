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

namespace UI.Forms.AdminPage
{
    public partial class AdminCreateService : Form
    {
        ServicePriceTypeBL servicePriceTypeBL;
        ServiceBL serviceBL;

        public AdminCreateService()
        {
            InitializeComponent();

            servicePriceTypeBL = new ServicePriceTypeBL();
            serviceBL = new ServiceBL();

            SetComboBox();

            btnCreate.Click += BtnCreate_Click;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            ServicePriceTypeUI priceType = (ServicePriceTypeUI)cboPriceTypes.SelectedItem;

            ServiceUI newService = new ServiceUI()
            {
                Name = txtServiceName.Text,
                Description = txtDescription.Text,
                Price = float.Parse(txtPrice.Text),
                ServicePriceTypeID = priceType.ServicePriceTypeID,
            };

            bool succes = await serviceBL.CreateServiceAsync(newService);
            if(succes)
            {
                MessageBox.Show("comon now dawg");
            }
            else
            {
                MessageBox.Show("gg");
            }


        }

        public async Task SetComboBox()
        {
            List<ServicePriceTypeUI> priceTypeList = await servicePriceTypeBL.GetServicePriceTypeAsync();

            cboPriceTypes.DisplayMember = "PriceType";

            foreach(ServicePriceTypeUI priceType in priceTypeList)
            {
                cboPriceTypes.Items.Add(priceType);
            }

        }
    }
}
