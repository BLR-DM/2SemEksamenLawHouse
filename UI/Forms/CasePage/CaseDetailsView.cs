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
        List<CaseTypeUI> caseTypeUIList;

        ClientBL clientBL;
        LawyerBL lawyerBL;
        ServiceBL serviceBL;
        CaseTypeBL caseTypeBL;
        public CaseDetailsView(CaseUI selectedCase)
        {
            InitializeComponent();
            clientBL = new ClientBL();
            lawyerBL = new LawyerBL();
            serviceBL = new ServiceBL();
            caseTypeBL = new CaseTypeBL();
            this.selectedCase = selectedCase;

            SetData();
            SetDgv();
            SetComboBox();

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

            txtTitle.Text = selectedCase.Title;
            dtpEstimatedEndDate.Value = selectedCase.EndDate;
            txtEstimatedHours.Text = selectedCase.EstHours.ToString();


        }

        public async Task SetDgv()
        {
            serviceList = await serviceBL.GetServicesForCaseAsync(selectedCase.CaseID);

            dgvServices.DataSource = serviceList;


            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public async void SetComboBox()
        {
            caseTypeUIList = await caseTypeBL.GetCaseTypeAsync();

            cboxCaseType.DisplayMember = "Title";

            foreach (CaseTypeUI caseTypeUI in caseTypeUIList)
            {
                cboxCaseType.Items.Add(caseTypeUI);
            }
        }

    }
}
