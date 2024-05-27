using BusinessLogic;
using BusinessLogic.HelpServices;
using EntityModels;
using Microsoft.Extensions.Logging;
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
    public partial class AddClientView : Form
    {
        ClientBL clientBL;

        List<ClientUI> originalClientList;
        //Event der udløses, når en klient vælges
        public event EventHandler<ClientUI> ClientSelected;
        public AddClientView()
        {
            InitializeComponent();
            clientBL = new ClientBL();
            originalClientList = new List<ClientUI>();
            dgvClientView.CellDoubleClick += DgvClientView_CellDoubleClick;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lblHelp.Click += LblHelp_Click;

            SetDgvStyle();
            SetDgv();
        }

        
        private void LblHelp_Click(object? sender, EventArgs e)
        {
            //Åbner hjælpeformen
            OpenPDF.ShowPDF("AddClientsViewHelp");
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            //Kalder sorteringsmetoden når søgeteksten ændres
            SortData();
        }

        private void SortData()
        {
            // Opretter en ny liste til sortering baseret på den originale liste
            List<ClientUI> sortedClientList = new List<ClientUI>(originalClientList);

            //tester på input i txtSearch
            if(!string.IsNullOrEmpty(txtSearch.Text) && int.TryParse(txtSearch.Text, out int phone))
            {
                //Sorterer listen hvor inputet matcher med client telefon
                sortedClientList = sortedClientList.Where(client => client.MainPhone.ToString().StartsWith(phone.ToString())).ToList();

            }
            //Sætter dgv'et til den sorterede liste
            dgvClientView.DataSource = sortedClientList;
        }

        private void DgvClientView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Sikrer at række og kolonne indekser er gyldige
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dgvClientView.Rows[e.RowIndex];
                if (dataGridViewRow.Cells["PersonID"].Value != null)
                {
                    // Forsøger at parse PersonID cellens værdi
                    if (int.TryParse(dataGridViewRow.Cells["PersonID"].Value.ToString(), out int id))
                    {
                        // Finder den valgte klient baseret på PersonID
                        ClientUI selectedClient = originalClientList.FirstOrDefault(c => c.PersonID == id);
                        // Udløser ClientSelected eventen
                        ClientSelected?.Invoke(this, selectedClient);
                        this.Close();
                    }
                }
            }
        }

        private async Task SetDgv()
        {
            originalClientList = await clientBL.GetClientsAsync();
            dgvClientView.DataSource = originalClientList;

            //Indstiller rækkefølge på hvordan infoen vises i dgv
            dgvClientView.Columns["PersonID"].DisplayIndex = 0;
            dgvClientView.Columns["Firstname"].DisplayIndex = 1;
            dgvClientView.Columns["Lastname"].DisplayIndex = 2;
            dgvClientView.Columns["Email"].DisplayIndex = 3;
            dgvClientView.Columns["MainPhone"].DisplayIndex = 4;
            dgvClientView.Columns["AddressLine"].DisplayIndex = 5;
            dgvClientView.Columns["PostalCode"].DisplayIndex = 6;
            dgvClientView.Columns["City"].DisplayIndex = 7;
            dgvClientView.Columns["IsSubscribed"].DisplayIndex = 8;
            dgvClientView.Columns["LoginDetailsID"].DisplayIndex = 9;

            //Skjuler unødvendige kolonner
            dgvClientView.Columns["PersonID"].Visible = false;
            dgvClientView.Columns["IsSubscribed"].Visible = false;
            dgvClientView.Columns["LoginDetailsID"].Visible = false;
        }
        private void SetDgvStyle()
        {
            dgvClientView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvClientView.EnableHeadersVisualStyles = false;

            dgvClientView.RowHeadersVisible = false;

            dgvClientView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvClientView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvClientView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvClientView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
