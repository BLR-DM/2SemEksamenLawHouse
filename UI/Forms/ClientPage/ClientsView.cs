
using BusinessLogic;
using BusinessLogic.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class ClientsView : Form
    {
        FrontPageView frontPageView;
        PersonUI currentUser;
        ClientBL clientBL;
        FormDocumentBL formBL;
        CaseBL caseBL;
        SubscriptionBL subscriptionBL;

        PersonValidator pValidator;

        List<ClientUI> originalClientsList;
        List<ClientUI> filteredClients;

        public ClientsView(FrontPageView fpv, PersonUI currentUser)
        {
            InitializeComponent();
            
            this.frontPageView = fpv;
            this.currentUser = currentUser;

            clientBL = new ClientBL();
            formBL = new FormDocumentBL();
            pValidator = new PersonValidator();
            subscriptionBL = new SubscriptionBL();
            caseBL = new CaseBL();

            //Events
            Load += ClientsView_Load;
            txtSearchPhone.TextChanged += TxtSearchPhone_TextChanged;
            txtSearchPostal.TextChanged += TxtSearchPostal_TextChanged;
            dgvClients.CellDoubleClick += DgvClients_CellDoubleClick;
            btnCreate.Click += BtnCreate_Click;
            dgvClients.DataSourceChanged += DgvClients_DataSourceChanged;
            ckboxSubscribed.CheckedChanged += CkboxSubscribed_CheckedChanged;
            ckboxNotSubscribed.CheckedChanged += CkboxNotSubscribed_CheckedChanged;
        }

        private void CkboxNotSubscribed_CheckedChanged(object? sender, EventArgs e)
        {
            SortDgvData();
        }

        private void CkboxSubscribed_CheckedChanged(object? sender, EventArgs e)
        {
            SortDgvData();
        }

        private void DgvClients_DataSourceChanged(object? sender, EventArgs e)
        {
            lblClientAmmount.Text = $"{dgvClients.RowCount} Clients";
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateClientView createClientsView = new CreateClientView();
            frontPageView.PnlContextChange(createClientsView);
        }

        //doubleklik åbn ClientDetails
        private void DgvClients_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ClientUI selectedClient = filteredClients[e.RowIndex] as ClientUI;
                ClientDetails clientDetails = new ClientDetails(frontPageView, currentUser, selectedClient);
                frontPageView.PnlContextChange(clientDetails);
            }
        }

        private void TxtSearchPostal_TextChanged(object? sender, EventArgs e)
        {
            SortDgvData();
        }

        private void TxtSearchPhone_TextChanged(object? sender, EventArgs e)
        {
            SortDgvData();
        }

        //sortere data
        private void SortDgvData()
        {
            filteredClients = new List<ClientUI>(originalClientsList);


            if (!string.IsNullOrEmpty(txtSearchPhone.Text) && int.TryParse(txtSearchPhone.Text, out int phonenumber))
            {
                filteredClients = filteredClients.Where(client => client.MainPhone.ToString().StartsWith(phonenumber.ToString())).ToList();
                dgvClients.DataSource = filteredClients;
            }
            if (!string.IsNullOrEmpty(txtSearchPostal.Text) && int.TryParse(txtSearchPostal.Text, out int postalcode))
            {
                filteredClients = filteredClients.Where(client => client.PostalCode.ToString().StartsWith(postalcode.ToString())).ToList();
                dgvClients.DataSource = filteredClients;
            }

            if (ckboxNotSubscribed.Checked && ckboxSubscribed.Checked)
            {
                filteredClients = filteredClients.Where(client => client.IsSubscribed || client.IsSubscribed == false).ToList();
            } 
            else if (ckboxSubscribed.Checked)
            {
                filteredClients = filteredClients.Where(client => client.IsSubscribed).ToList();
            }
            else if (ckboxNotSubscribed.Checked)
            {
                filteredClients = filteredClients.Where(client => client.IsSubscribed == false).ToList();
            }
            

            dgvClients.DataSource = filteredClients;
        }

        //Henter data og sætter DGV data
        private async void ClientsView_Load(object? sender, EventArgs e)
        {
            originalClientsList = await clientBL.GetClientsAsync();
            filteredClients = new List<ClientUI>(originalClientsList);


            DGVSetup();
        }

        //Datagridview setup
        private void DGVSetup()
        {
            dgvClients.DataSource = filteredClients;

            dgvClients.Columns["PersonID"].DisplayIndex = 0;
            dgvClients.Columns["Firstname"].DisplayIndex = 1;
            dgvClients.Columns["Lastname"].DisplayIndex = 2;
            dgvClients.Columns["Email"].DisplayIndex = 3;
            dgvClients.Columns["MainPhone"].DisplayIndex = 4;
            dgvClients.Columns["AddressLine"].DisplayIndex = 5;
            dgvClients.Columns["PostalCode"].DisplayIndex = 6;
            dgvClients.Columns["City"].DisplayIndex = 7;
            dgvClients.Columns["IsSubscribed"].DisplayIndex = 8;
            dgvClients.Columns["LoginDetailsID"].DisplayIndex = 9;

            //dgvClients.Columns["LoginDetailsID"].Visible = false;

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
