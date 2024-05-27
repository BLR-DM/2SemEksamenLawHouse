using BusinessLogic;
using BusinessLogic.HelpServices;
using EntityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class AddLawyerView : System.Windows.Forms.Form
    {
        LawyerBL lawyerBL;
        SpecialityBL specialityBL;


        List<LawyerUI> originalLawyerList;
        List<SpecialityUI> specialityList;
        List<LawyerSpecialityUI> lawyerSpecialityList;
        public event EventHandler<LawyerUI> LawyerSelected;
        public AddLawyerView()
        {
            InitializeComponent();
            lawyerBL = new LawyerBL();
            specialityBL = new SpecialityBL();

            dgvLawyerView.CellDoubleClick += DgvLawyerView_CellDoubleClick;
            specialityList = new List<SpecialityUI>();

            cboSpecialities.SelectedIndexChanged += CboSpecialities_SelectedIndexChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lblHelp.Click += LblHelp_Click;

            SetDgvStyle();
            _ = SetDgv();
            SetComboBox();
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("AddLawyerViewHelp");
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            SortData();
        }

        private void CboSpecialities_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SortData();
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
                        //henter den selected lawyer fra listen som matcher på id, ud fra den lawyer der er blevet dobbeltklikket på
                        LawyerUI selectedLawyer = originalLawyerList.FirstOrDefault(l => l.PersonID == id);

                        //Udfører hændelsen LawyerSelected
                        LawyerSelected?.Invoke(this, selectedLawyer);
                        this.Close();
                    }
                }
            }
        }

        private async void SortData()
        {
            lawyerSpecialityList = await specialityBL.GetLawyerSpecialitiesAsync();
            List<LawyerUI> filteredLawyers = new List<LawyerUI>();

            SpecialityUI selectedSpeciality = (SpecialityUI)cboSpecialities.SelectedItem;
            if (selectedSpeciality != null)
            {
                foreach (LawyerUI lawyer in originalLawyerList)
                {
                    //Tjekker om LawyerID og SpecialityID matcher de tilsvarende værdier for advokater og viser alle de advokater som har det valgte speciale
                    if (lawyerSpecialityList.Any(ls => ls.LawyerID == lawyer.PersonID && ls.SpecialityID == selectedSpeciality.SpecialityID))
                    {
                        filteredLawyers.Add(lawyer);
                    }
                }
            }
            else
            {
                //Hvis der ikke er valgt noget speciale, så bruger den hele listen
                filteredLawyers.AddRange(originalLawyerList);
            }

            if (!string.IsNullOrEmpty(txtSearch.Text) && int.TryParse(txtSearch.Text, out int phone))
            {
                filteredLawyers = filteredLawyers.Where(l => l.PhoneNumber.ToString().StartsWith(phone.ToString())).ToList();

            }

            dgvLawyerView.DataSource = filteredLawyers;
        }

        private async Task SetComboBox()
        {
            //henter specialities
            specialityList = await specialityBL.GetSpecialitiesAsync();

            //viser specialityname attributten i comboboxen
            cboSpecialities.DisplayMember = "SpecialityName";

            //For hver speciality i listen tilføjes de til comboboxen
            foreach(SpecialityUI speciality in specialityList)
            {
                cboSpecialities.Items.Add(speciality);
            }
        }
        private async Task SetDgv()
        {
            originalLawyerList = await lawyerBL.GetLawyersAsync();
            dgvLawyerView.DataSource = originalLawyerList;

            SetDgvColumns();
        }

        private void SetDgvColumns()
        {
            //Dgv indstillinger
            dgvLawyerView.Columns["PersonID"].DisplayIndex = 0;
            dgvLawyerView.Columns["Firstname"].DisplayIndex = 1;
            dgvLawyerView.Columns["Lastname"].DisplayIndex = 2;
            dgvLawyerView.Columns["LawyerTitle"].DisplayIndex = 3;
            dgvLawyerView.Columns["Email"].DisplayIndex = 4;
            dgvLawyerView.Columns["AddressLine"].DisplayIndex = 5;
            dgvLawyerView.Columns["PostalCode"].DisplayIndex = 6;
            dgvLawyerView.Columns["City"].DisplayIndex = 7;



            //Skjuler infomrmation da det er unødvendigt i dette tilfælde
            dgvLawyerView.Columns["PersonID"].Visible = false;
            dgvLawyerView.Columns["LoginDetailsID"].Visible = false;
            dgvLawyerView.Columns["LawyerTitleID"].Visible = false;
            dgvLawyerView.Columns["HireDate"].Visible = false;
            dgvLawyerView.Columns["OpenCases"].Visible = false;
            dgvLawyerView.Columns["ClosedCases"].Visible = false;
            dgvLawyerView.Columns["SpecialityCount"].Visible = false;
            dgvLawyerView.Columns["OpenCaseServices"].Visible = false;
            dgvLawyerView.Columns["ClosedCaseServices"].Visible = false;
            dgvLawyerView.Columns["LawyerSpecialities"].Visible = false;
            dgvLawyerView.Columns["CaseServices"].Visible = false;
            dgvLawyerView.Columns["Cases"].Visible = false;
        }

        private void SetDgvStyle()
        {
            dgvLawyerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLawyerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvLawyerView.EnableHeadersVisualStyles = false;

            dgvLawyerView.RowHeadersVisible = false;

            dgvLawyerView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvLawyerView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvLawyerView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvLawyerView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
