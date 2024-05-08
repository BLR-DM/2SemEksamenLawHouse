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

namespace UI.Forms.CasePage
{
    public partial class AddServiceView : Form
    {
        LawyerUI selectedLawyer;

        List<ServiceUI> serviceList;

        ServiceBL serviceBL;
        public AddServiceView()
        {
            InitializeComponent();

            serviceBL = new ServiceBL();
            cboServices.SelectedIndexChanged += CboServices_SelectedIndexChanged;
            txtUnits.TextChanged += TxtUnits_TextChanged;
            btnAddLawyer.Click += BtnAddLawyer_Click;

            SetComboBox();

            txtUnits.Enabled = false;
            txtServiceDescription.Enabled = false;
        }

        private void BtnAddLawyer_Click(object? sender, EventArgs e)
        {
            AddLawyerView addLawyerView = new AddLawyerView();
            addLawyerView.LawyerSelected += AddLawyerView_LawyerSelected;

            addLawyerView.ShowDialog();
            
        }

        private void AddLawyerView_LawyerSelected(object? sender, LawyerUI e)
        {
            txtLawyerFirstName.Text = e.Firstname;
            txtLawyerLastName.Text = e.Lastname;
            txtLawyerPhone.Text = e.PhoneNumber.ToString();

            selectedLawyer = e;
        }

        private void TxtUnits_TextChanged(object? sender, EventArgs e)
        {
            if(cboServices.SelectedIndex != null)
            {
                txtUnits.ForeColor = default(Color);
                ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;
                if(int.TryParse(txtUnits.Text, out int units))
                {
                    float totalPrice = CalculateTotalPrice(selectedService.Price, units);

                    txtTotalPrice.Text = totalPrice.ToString("C");
                }
                else
                {
                    txtUnits.ForeColor = Color.Red;
                }
            }
        }

        private void CboServices_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ServiceUI selectedService = (ServiceUI)cboServices.SelectedItem;

            if (int.TryParse(txtUnits.Text, out int units))
            {
                float totalPrice = CalculateTotalPrice(selectedService.Price, units);

                txtTotalPrice.Text = totalPrice.ToString("C");
            }

            if (selectedService.PriceType == "Fixed")
            {
                lblUnites.Visible = false;
                txtUnits.Visible = false;
                txtUnits.Text = "1";

                txtUnits.Enabled = true;
                txtServiceDescription.Enabled = true;
            }
            else if(selectedService.PriceType == "Hourly")
            {
                lblUnites.Visible = true;
                lblUnites.Text = "Hours";
                txtUnits.Visible = true;

                txtUnits.Enabled = true;
                txtServiceDescription.Enabled = true;
            }
            else if(selectedService.PriceType == "Kilometer")
            {
                lblUnites.Visible = true;
                lblUnites.Text = "Kilometers";
                txtUnits.Visible = true;

                txtUnits.Enabled = true;
                txtServiceDescription.Enabled = true;
            }
            else
            {
                txtUnits.Enabled = false;
                txtServiceDescription.Enabled = false;
            }

            txtPrice.Text = selectedService.Price.ToString("C");
            txtServiceDescription.Text = selectedService.Description;
        }

        public float CalculateTotalPrice(float unitPrice, int units)
        {
            return unitPrice * units;
        }

        public async Task SetComboBox()
        {
            serviceList = await serviceBL.GetServicesAsync();

            cboServices.DisplayMember = "Name";

            foreach(ServiceUI service in serviceList)
            {
                cboServices.Items.Add(service);
            }
        }
    }
}
