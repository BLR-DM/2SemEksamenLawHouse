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
using UI.Forms.FrontPage;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class ClientsView : Form
    {
        List<ClientUI> originalClientsList;
        List<ClientUI> filteredClients;
        ClientBL clientBL;
        FrontPageView fpv;
        int count;
        public ClientsView(FrontPageView fpv)
        {
            InitializeComponent();
            clientBL = new ClientBL();
            this.fpv = fpv;

            //Events
            Load += ClientsView_Load;
            txtSearchPhone.TextChanged += TxtSearchPhone_TextChanged;
            txtSearchPostal.TextChanged += TxtSearchPostal_TextChanged;
            dgvClients.CellDoubleClick += DgvClients_CellDoubleClick;
            btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateClientView cCV = new CreateClientView();
            fpv.PnlContextChange(cCV);
        }

        //doubleklik åbn ClientDetails
        private void DgvClients_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ClientUI selectedClient = filteredClients[e.RowIndex] as ClientUI;
                ClientDetails cd = new ClientDetails(selectedClient);
                fpv.PnlContextChange(cd);
            }
        }

        private void TxtSearchPostal_TextChanged(object? sender, EventArgs e)
        {
            SortData();
        }

        private void TxtSearchPhone_TextChanged(object? sender, EventArgs e)
        {
            SortData();
        }

        //sortere data
        private void SortData()
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

            dgvClients.DataSource = filteredClients;

            count = filteredClients.Count;
            lblClientAmmount.Text = count.ToString() + " Clients";
        }

        //Henter data og sætter DGV data
        private async void ClientsView_Load(object? sender, EventArgs e)
        {
            originalClientsList = await clientBL.GetClientsAsync();
            filteredClients = new List<ClientUI>(originalClientsList);
            dgvClients.DataSource = filteredClients;
            count = filteredClients.Count;
            lblClientAmmount.Text = count.ToString() + " Clients";


            DGVSetup();
        }

        //Datagridview setup
        private void DGVSetup()
        {


            dgvClients.Columns["PersonID"].DisplayIndex = 0;
            dgvClients.Columns["Firstname"].DisplayIndex = 1;
            dgvClients.Columns["Lastname"].DisplayIndex = 2;
            dgvClients.Columns["Email"].DisplayIndex = 3;
            dgvClients.Columns["MainPhone"].DisplayIndex = 4;
            dgvClients.Columns["AddressLine"].DisplayIndex = 5;
            dgvClients.Columns["PostalCode"].DisplayIndex = 6;
            dgvClients.Columns["City"].DisplayIndex = 7;
            dgvClients.Columns["ClientSub"].DisplayIndex = 8;
            dgvClients.Columns["LoginDetailsID"].DisplayIndex = 9;

            //dgvClients.Columns["LoginDetailsID"].Visible = false;

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
}
