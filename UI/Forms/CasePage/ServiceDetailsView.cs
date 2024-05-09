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
    public partial class ServiceDetailsView : Form
    {
        CaseServiceUI selectedCaseService;
        ServiceUI selectedService;

        LawyerUI selectedLawyer;

        LawyerBL lawyerBL;
        ServiceBL serviceBL;
        public ServiceDetailsView(CaseServiceUI selectedCaseService)
        {
            InitializeComponent();

            this.selectedCaseService = selectedCaseService;

            lawyerBL = new LawyerBL();
            serviceBL = new ServiceBL();

            SetLawyerInformation();
            SetCaseInformation();

        }

        public async Task SetLawyerInformation()
        {
            selectedLawyer = await lawyerBL.GetLawyerAsync(selectedCaseService.LawyerID);

            txtLawyerFirstName.Text = selectedLawyer.Firstname;
            txtLawyerLastName.Text = selectedLawyer.Lastname;
            txtLawyerPhone.Text = selectedLawyer.PhoneNumber.ToString();
        }

        public async Task SetCaseInformation()
        {
            selectedService = await serviceBL.GetServiceAsync(selectedCaseService.ServiceID);

            txtServiceName.Text = selectedService.Name;
            txtPrice.Text = selectedService.Price.ToString();
            txtPriceType.Text = selectedService.PriceType;

            txtServiceDescription.Text = selectedCaseService.Description;
            txtUnits.Text = selectedCaseService.Units.ToString();
            txtTotalPrice.Text = selectedCaseService.TotalPrice.ToString();
            txtDate.Text = selectedCaseService.Date.ToString();
        }
    }
}
