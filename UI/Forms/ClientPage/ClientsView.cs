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

namespace UI.Forms.ClientPage
{
    public partial class ClientsView : Form
    {
        List<ClientUI> originalClientsList;
        List<ClientUI> filteredClients;
        ClientBL clientBL;
        int count;
        public ClientsView()
        {
            InitializeComponent();
            clientBL = new ClientBL();

            Load += ClientsView_Load;
            txtSearchPhone.TextChanged += TxtSearchPhone_TextChanged;
            txtSearchPostal.TextChanged += TxtSearchPostal_TextChanged;
        }

        private void TxtSearchPostal_TextChanged(object? sender, EventArgs e)
        {
            SortData();
        }

        private void TxtSearchPhone_TextChanged(object? sender, EventArgs e)
        {
            SortData();
        }

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

        private async void ClientsView_Load(object? sender, EventArgs e)
        {
            originalClientsList = await clientBL.GetClientsAsync();
            filteredClients = new List<ClientUI>(originalClientsList);
            dgvClients.DataSource = filteredClients;
            count = filteredClients.Count;
            lblClientAmmount.Text = count.ToString() + " Clients";


            DGVSetup();
            //LoadClientsAsync();
        }

        //public async Task LoadClientsAsync()
        //{
        //    clients = await clientBL.GetClientsAsync();
        //    ClientsBS.DataSource = clients;
        //    filteredClients = new List<ClientUI>(clients);

        //    DGVSetup();

        //}
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
