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
    public partial class AddClientView : Form
    {
        ClientBL clientBL;

        List<ClientUI> originalClientList;
        public event EventHandler<ClientUI> ClientSelected;
        public AddClientView(ClientBL clientBL)
        {
            InitializeComponent();
            this.clientBL = clientBL;
            originalClientList = new List<ClientUI>();
            dgvClientView.CellDoubleClick += DgvClientView_CellDoubleClick;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            SetDgv();

        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            SortData();
        }

        public void SortData()
        {
            List<ClientUI> sortedClientList = new List<ClientUI>(originalClientList);
            if(!string.IsNullOrEmpty(txtSearch.Text) && int.TryParse(txtSearch.Text, out int phone))
            {
                sortedClientList = sortedClientList.Where(client => client.MainPhone.ToString().StartsWith(phone.ToString())).ToList();

            }

            dgvClientView.DataSource = sortedClientList;
        }

        private void DgvClientView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dgvClientView.Rows[e.RowIndex];
                if (dataGridViewRow.Cells["PersonID"].Value != null)
                {
                    if(int.TryParse(dataGridViewRow.Cells["PersonID"].Value.ToString(), out int id))
                    {
                        ClientUI selectedClient = originalClientList.FirstOrDefault(c => c.PersonID == id);
                        ClientSelected?.Invoke(this, selectedClient);
                        this.Close();
                    }
                }
            }
        }

        public async Task SetDgv()
        {
            originalClientList = await clientBL.GetClientsAsync();
            dgvClientView.DataSource = originalClientList;

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

            dgvClientView.Columns["PersonID"].Visible = false;
            dgvClientView.Columns["IsSubscribed"].Visible = false;
            dgvClientView.Columns["LoginDetailsID"].Visible = false;

            dgvClientView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



    }
}
