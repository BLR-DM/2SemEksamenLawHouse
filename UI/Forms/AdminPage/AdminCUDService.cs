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
    public partial class AdminCUDService : Form
    {
        ServicePriceTypeBL servicePriceTypeBL;
        ServiceBL serviceBL;

        public AdminCUDService()
        {
            InitializeComponent();

            servicePriceTypeBL = new ServicePriceTypeBL();
            serviceBL = new ServiceBL();

            SetComboBox();

            btnCreate.Click += BtnCreate_Click;

            btnUpdate.Visible = false;
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
                MessageBox.Show("Service Created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create the service");
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

            if (selectedService != null)
            {
                cboPriceTypes.SelectedItem = priceTypeList.Where(pt => pt.ServicePriceTypeID == selectedService.ServicePriceTypeID).FirstOrDefault();
            }

        }


        //Update og delete

        ServiceUI selectedService;
        public AdminCUDService(ServiceUI selectedService)
        {
            InitializeComponent();
            servicePriceTypeBL = new ServicePriceTypeBL();
            serviceBL = new ServiceBL();
            this.selectedService = selectedService;

            btnCreate.Visible = false;

            txtDescription.Text = selectedService.Description;
            txtPrice.Text = selectedService.Price.ToString();
            txtServiceName.Text = selectedService.Name;

            SetComboBox();

            btnUpdate.Click += BtnUpdate_Click;
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            ServicePriceTypeUI priceType = (ServicePriceTypeUI)cboPriceTypes.SelectedItem;

            ServiceUI serviceToUpdate = new ServiceUI()
            {
                ServiceID = selectedService.ServiceID,
                Name = txtServiceName.Text,
                Price = float.Parse(txtPrice.Text),
                Description = txtDescription.Text,
                ServicePriceTypeID = priceType.ServicePriceTypeID,
            };

            bool succes = await serviceBL.UpdateServiceAsync(serviceToUpdate);
            if (succes)
            {
                MessageBox.Show("Service updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Service failed to update");
            }
        }
    }
}
