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
    public partial class CaseDetailsView : Form
    {
        ClientUI selectedClient;
        CaseUI selectedCase;
        LawyerUI selectedLawyer;
        List<ServiceUI> serviceList;
        List<CaseServiceUI> caseServiceList;

        ClientBL clientBL;
        LawyerBL lawyerBL;
        ServiceBL serviceBL;
        CaseServiceBL caseServiceBL;
        public CaseDetailsView(CaseUI selectedCase)
        {
            InitializeComponent();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
            serviceBL = new ServiceBL();
            caseServiceBL = new CaseServiceBL();
            this.selectedCase = selectedCase;

            SetData();
            SetDgv();
        }

        public async Task SetData()
        {
            selectedClient = await clientBL.GetClientAsync(selectedCase.ClientID);

            txtClientFirstname.Text = selectedClient.Firstname;
            txtClientLastName.Text = selectedClient.Lastname;
            txtClientEmail.Text = selectedClient.Email;
            txtClientAddress.Text = selectedClient.AddressLine;
            txtClientPhoneNumber1.Text = selectedClient.MainPhone.ToString();
            txtClientPostalCode.Text = selectedClient.PostalCode.ToString();

            selectedLawyer = await lawyerBL.GetLawyerAsync(selectedCase.LawyerID);
            txtLawyerFirstName.Text = selectedLawyer.Firstname;
            txtLawyerLastName.Text = selectedLawyer.Lastname;
            txtLawyerPhone.Text = selectedLawyer.PhoneNumber.ToString();

           

        }

        public async Task SetDgv()
        {
            caseServiceList = await caseServiceBL.GetCaseServicesAsync();
            serviceList = await serviceBL.GetServicesAsync();
           
            List<ServiceUI> filteredServices = new List<ServiceUI>();

            foreach(ServiceUI serviceUI in serviceList)
            {
                if(caseServiceList.Any(cs => cs.ServiceID == serviceUI.ServiceID && cs.CaseID == selectedCase.CaseID))
                {
                    filteredServices.Add(serviceUI);
                }
            }

            dgvServices.DataSource = filteredServices;

            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
