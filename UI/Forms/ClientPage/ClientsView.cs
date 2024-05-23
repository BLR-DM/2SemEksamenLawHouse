
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

        List<ClientUI> originalClientsList;
        List<ClientUI> filteredClients;

        public ClientsView(FrontPageView frontPageView, PersonUI currentUser)
        {
            InitializeComponent();
            
            this.frontPageView = frontPageView;
            this.currentUser = currentUser;

            clientBL = new ClientBL();

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

        private void DgvClients_DataSourceChanged(object? sender, EventArgs e)
        {
            //saetter lbl for antal af clients til antallet af rækker i dgv
            lblClientAmmount.Text = $"{dgvClients.RowCount} Clients";
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            //aabner create clientview
            CreateClientView createClientsView = new CreateClientView(frontPageView, currentUser);
            frontPageView.PnlContextChange(createClientsView);
        }

        //doubleklik åbn ClientDetails
        private void DgvClients_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                //tager den valgte client fra dgv
                ClientUI selectedClient = filteredClients[e.RowIndex];

                //aabner clientdetails view for valgte client
                ClientDetails clientDetails = new ClientDetails(frontPageView, currentUser, selectedClient);
                frontPageView.PnlContextChange(clientDetails);
            }
        }


        //sortere data
        private void SortDgvData()
        {
            //satter filtreret clients til original liste før den filtrerer
            filteredClients = new List<ClientUI>(originalClientsList);

            //hvis der er text i "searchphone" og kan parses til int
            if (!string.IsNullOrEmpty(txtSearchPhone.Text) && int.TryParse(txtSearchPhone.Text, out int phonenumber))
            {
                //filtrerer liste til hvor tlf starter med txtsearchphone
                filteredClients = filteredClients.Where(client => client.MainPhone.ToString().StartsWith(phonenumber.ToString())).ToList();
                dgvClients.DataSource = filteredClients;
            }
            //hvis der er text i "searchpostal" og kan parses til int
            if (!string.IsNullOrEmpty(txtSearchPostal.Text) && int.TryParse(txtSearchPostal.Text, out int postalcode))
            {
                //filtrerer liste til hvor tlf starter med txtsearchpostal
                filteredClients = filteredClients.Where(client => client.PostalCode.ToString().StartsWith(postalcode.ToString())).ToList();
                dgvClients.DataSource = filteredClients;
            }

            //hvis subscribed og notsubscribed er checked
            if (ckboxNotSubscribed.Checked && ckboxSubscribed.Checked)
            {
                //tager alle clienter som er subscribed og ikke er
                filteredClients = filteredClients.Where(client => client.IsSubscribed || client.IsSubscribed == false).ToList();
            } 
            else if (ckboxSubscribed.Checked) //hvis kun subscribed er checked
            {
                //saetter filtered clients til clienter som er subscribed
                filteredClients = filteredClients.Where(client => client.IsSubscribed).ToList();
            }
            else if (ckboxNotSubscribed.Checked) //hvis kun notsubscribed er checked
            {
                //saetter filtered clients til clienter som ikke er subscribed
                filteredClients = filteredClients.Where(client => client.IsSubscribed == false).ToList();
            }
            
            //saetter dgv datasource til den filtreret liste
            dgvClients.DataSource = filteredClients;
        }

        private void CkboxNotSubscribed_CheckedChanged(object? sender, EventArgs e)
        {
            //kalder metoden til at sortere data
            SortDgvData();
        }

        private void CkboxSubscribed_CheckedChanged(object? sender, EventArgs e)
        {
            //kalder metoden til at sortere data
            SortDgvData();
        }

        private void TxtSearchPostal_TextChanged(object? sender, EventArgs e)
        {
            //kalder metoden til at sortere data
            SortDgvData();
        }

        private void TxtSearchPhone_TextChanged(object? sender, EventArgs e)
        {
            //kalder metoden til at sortere data
            SortDgvData();
        }

        //Henter data og sætter DGV data
        private async void ClientsView_Load(object? sender, EventArgs e)
        {
            //henter liste af alle clienter
            originalClientsList = await clientBL.GetClientsAsync();

            //opretter liste til filtreret clients
            filteredClients = new List<ClientUI>(originalClientsList);


            DGVSetup();
        }

        //Datagridview setup
        private void DGVSetup()
        {
            //saetter data til dgv
            dgvClients.DataSource = filteredClients;
            
            //satter rækkefølge for kolonner
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

            //fylder dgv ud med kolonnerne
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //vaelg hele rækken
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.ReadOnly = true;
            dgvClients.MultiSelect = false;

            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.RowHeadersVisible = false;

            dgvClients.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvClients.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvClients.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvClients.DefaultCellStyle.SelectionForeColor = Color.Black;

        }
    }
}
