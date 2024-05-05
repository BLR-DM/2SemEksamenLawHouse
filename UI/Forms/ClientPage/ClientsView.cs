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
        BindingSource ClientsBS;
        List<ClientUI> clients;
        ClientBL clientBL;
        public ClientsView()
        {
            InitializeComponent();
            clientBL = new ClientBL();
            ClientsBS = new BindingSource();
            dgvClients.DataSource = ClientsBS;

            LoadClientsAsync();
        }

        
        public async Task LoadClientsAsync()
        {
            clients = await clientBL.GetClientsAsync();
            ClientsBS.DataSource = clients;

            DGVSetup();

        }
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
