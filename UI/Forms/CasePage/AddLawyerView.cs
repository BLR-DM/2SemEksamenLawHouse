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
    public partial class AddLawyerView : Form
    {
        LawyerBL lawyerBL;
        List<LawyerUI> originalLawyerList;
        public event EventHandler<LawyerUI> LawyerSelected;
        public AddLawyerView()
        {
            InitializeComponent();
            lawyerBL = new LawyerBL();
            dgvLawyerView.CellDoubleClick += DgvLawyerView_CellDoubleClick;

            SetDgv();
        }

        private void DgvLawyerView_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dgvLawyerView.Rows[e.RowIndex];
                if (dataGridViewRow.Cells["PersonID"].Value != null)
                {
                    if (int.TryParse(dataGridViewRow.Cells["PersonID"].Value.ToString(), out int id))
                    {
                        LawyerUI selectedLawyer = originalLawyerList.FirstOrDefault(l => l.PersonID == id);
                        LawyerSelected?.Invoke(this, selectedLawyer);
                        this.Close();
                    }
                }
            }
        }

        public async Task SetDgv()
        {
            originalLawyerList = await lawyerBL.GetLawyersAsync();
            dgvLawyerView.DataSource = originalLawyerList;

            dgvLawyerView.Columns["PersonID"].DisplayIndex = 0;
            dgvLawyerView.Columns["Firstname"].DisplayIndex = 1;
            dgvLawyerView.Columns["Lastname"].DisplayIndex = 2;
            dgvLawyerView.Columns["LawyerTitle"].DisplayIndex = 3;
            dgvLawyerView.Columns["Email"].DisplayIndex = 4;
            dgvLawyerView.Columns["AddressLine"].DisplayIndex = 5;
            dgvLawyerView.Columns["PostalCode"].DisplayIndex = 6;
            dgvLawyerView.Columns["City"].DisplayIndex = 7;



            dgvLawyerView.Columns["PersonID"].Visible = false;
            dgvLawyerView.Columns["LoginDetailsID"].Visible = false;
            dgvLawyerView.Columns["LawyerTitleID"].Visible = false;
            dgvLawyerView.Columns["HireDate"].Visible = false;

            dgvLawyerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLawyerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
