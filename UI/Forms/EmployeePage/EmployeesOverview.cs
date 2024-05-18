using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using UIModels;
using UI.Toolbox;


namespace UI.Forms.EmployeePage
{
    public partial class EmployeesOverview : Form
    {
        EmployeeBL employeeBL;
        LawyerBL lawyerBL;
        SecretaryBL secretaryBL;
        SpecialityBL specialityBL;

        EmployeeUI employeeUI;

        List<LawyerSpecialityUI> lawyerSpecialites;
        List<EmployeeUI> employees;
        List<LawyerUI> lawyers;
        List<SecretaryUI> secretaries;

        List<string> selectedFilters;

        public EmployeesOverview(int userID, EmployeeUI currentUser)
        {
            this.employeeUI = currentUser;
            selectedFilters = new List<string>();

            employeeBL = new EmployeeBL();
            lawyerBL = new LawyerBL();
            secretaryBL = new SecretaryBL();
            specialityBL = new SpecialityBL();

            InitializeComponent();

            btnTrash.Visible = false;
            cboxFilter.Enabled = false;

            Load += EmployeesOverview_Load;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
            dgvEmployees.DataSourceChanged += DgvEmployees_DataSourceChanged;
            cboxShow.SelectedIndexChanged += CboxFilterEmployees_SelectedIndexChanged;
            cboxFilter.SelectionChangeCommitted += CboxFilter_SelectionChangeCommitted;
            btnTrash.Click += BtnTrash_Click;
        }
        

        private void CboxFilter_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            if (cboxFilter.SelectedItem != null)
            {
                selectedFilters.Add(cboxFilter.SelectedItem.ToString());
                FilterSpeciality fs = new FilterSpeciality(cboxFilter.SelectedItem.ToString());
                fs.Click += Fs_Click;
                flpnlFilters.Controls.Add(fs);
                cboxFilter.Items.Remove(cboxFilter.SelectedItem);
            }
            ShowHideLawyers();
        }

        private void Fs_Click(object? sender, EventArgs e)
        {
            if (sender is FilterSpeciality filter)
            {                
                cboxFilter.Items.Add(filter.BtnText);
                selectedFilters.Remove(filter.BtnText);
                flpnlFilters.Controls.Remove(filter);

                ShowHideLawyers();
            }
        }

        private void ResetFilters()
        {
            if (flpnlFilters.Controls.Count > 0)
            {
                foreach (FilterSpeciality fs in flpnlFilters.Controls)
                {
                    cboxFilter.Items.Add(fs.BtnText);
                }
                flpnlFilters.Controls.Clear();
                selectedFilters.Clear();
            }
            btnTrash.Visible = false;
            ShowHideLawyers();
        }

        private void ShowHideLawyers()
        {
            if (selectedFilters.Count > 0)
            {
                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    if (row.DataBoundItem is LawyerUI lawyer)
                    {
                        bool hasAllSpecialities = selectedFilters.All(filter =>
                            lawyer.LawyerSpecialities.Any(ls => ls.SpecialityName == filter));

                        dgvEmployees.CurrentCell = null; // <-- vigtig, hvis cell er markeret, kan den ikke skjule row
                        row.Visible = hasAllSpecialities;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    row.Visible = true;
                }
            }
            dgvEmployees.CurrentCell = null;

            btnTrash.Visible = flpnlFilters.Controls.Count > 0;
        }

        private void BtnTrash_Click(object? sender, EventArgs e)
        {
            ResetFilters();
        }

        private async void CboxFilterEmployees_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblShow.Focus();
            lblTotalEmployees.Text = "Loading...";

            if (cboxFilter.SelectedItem != "  Lawyers")
            {
                ResetFilters();
            }

            switch (cboxShow.SelectedItem)
            {
                case "Employees":
                    SetupDgvWithEmployeesAsync();
                    lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
                    //ResetFilters();
                    break;
                case "  Lawyers":
                    SetupDgvWithLawyersAsync();
                    lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
                    break;
                case "  Secretaries":
                    SetupDgvWithSecretariesAsync();
                    lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
                    //ResetFilters();
                    break;
            }
        }



        private async void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            await GetEmployeesAsync();
            SetupDgvWithEmployeesAsync();
            await GetLawyersWithCollectionsAsync();
            await GetSecretariesAsync();
            await GetSpecialityUIsAsync();
            FillComboBoxes();
        }

        private async Task GetEmployeesAsync()
        {
            employees = await employeeBL.GetEmployeesAsync();
        }

        private async Task GetLawyersWithCollectionsAsync()
        {
            lawyers = await lawyerBL.GetLawyersWithCollectionsAsync();
        }

        private async Task GetSecretariesAsync()
        {
            secretaries = await secretaryBL.GetSecretariesAsync();
        }

        private async Task GetSpecialityUIsAsync()
        {
            lawyerSpecialites = await specialityBL.GetLawyerSpecialitiesAsync();
        }

        private void FillComboBoxes()
        {
            cboxShow.Items.Clear();

            // Filtrering combobox
            cboxShow.Items.Insert(0, "Employees");
            cboxShow.Items.Add("  Lawyers");
            cboxShow.Items.Add("  Secretaries");
            cboxShow.SelectedIndex = 0;


            // Sorting combobox
            foreach (string ls in lawyerSpecialites.Select(ls => ls.SpecialityName).Distinct())
            {
                cboxFilter.Items.Add(ls);
            }
        }

        private void DgvEmployees_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            switch (cboxShow.SelectedItem)
            {
                case "Employees":
                    if (e.RowIndex >= 0)
                    {
                        EmployeeUI employee = dgvEmployees.Rows[e.RowIndex].DataBoundItem as EmployeeUI;

                        new EmployeeDetailsView(employee, false, employeeUI).ShowDialog();
                    }
                    break;
                case "  Lawyers":
                    if (e.RowIndex >= 0)
                    {
                        LawyerUI lawyer = dgvEmployees.Rows[e.RowIndex].DataBoundItem as LawyerUI;

                        new LawyerDetailsView(lawyer, false, employeeUI).ShowDialog();
                    }
                    break;
                case "  Secretaries":
                    if (e.RowIndex >= 0)
                    {
                        SecretaryUI secretary = dgvEmployees.Rows[e.RowIndex].DataBoundItem as SecretaryUI;

                        new EmployeeDetailsView(secretary, false, employeeUI).ShowDialog();
                    }
                    break;
            }
        }

        private async Task RefreshDvgData() // Hvis der skal opdateres efter ændring - CUD
        {
            await GetEmployeesAsync();
            await GetLawyersWithCollectionsAsync();
            await GetSecretariesAsync();
        }

        private void SetupDgvWithEmployeesAsync()
        {
            cboxFilter.Enabled = false;

            dgvEmployees.DataSource = employees;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;
            dgvEmployees.Columns["LawyerTitle"].Visible = false;

            dgvEmployees.Columns["AddressLine"].Visible = true;
            dgvEmployees.Columns["City"].Visible = true;
            dgvEmployees.Columns["HireDate"].Visible = true;

            dgvEmployees.Columns["HireDate"].DefaultCellStyle.Format = "d";
            dgvEmployees.Columns["PersonID"].HeaderText = "EmployeeID";

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["Firstname"].DisplayIndex = 1;
            dgvEmployees.Columns["Lastname"].DisplayIndex = 2;
            dgvEmployees.Columns["Email"].DisplayIndex = 3;
            dgvEmployees.Columns["PhoneNumber"].DisplayIndex = 4;
            dgvEmployees.Columns["AddressLine"].DisplayIndex = 5;
            dgvEmployees.Columns["PostalCode"].DisplayIndex = 6;
            dgvEmployees.Columns["City"].DisplayIndex = 7;
            dgvEmployees.Columns["HireDate"].DisplayIndex = 8;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetupDgvWithLawyersAsync()
        {
            cboxFilter.Enabled = true;

            dgvEmployees.DataSource = lawyers;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;
            dgvEmployees.Columns["Cases"].Visible = false;
            dgvEmployees.Columns["AddressLine"].Visible = false;
            dgvEmployees.Columns["City"].Visible = false;
            dgvEmployees.Columns["HireDate"].Visible = false;

            dgvEmployees.Columns["LawyerTitle"].Visible = true;

            dgvEmployees.Columns["PersonID"].HeaderText = "LawyerID";

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["LawyerTitle"].DisplayIndex = 1;
            dgvEmployees.Columns["Firstname"].DisplayIndex = 2;
            dgvEmployees.Columns["Lastname"].DisplayIndex = 3;
            dgvEmployees.Columns["OpenCases"].DisplayIndex = 4;
            dgvEmployees.Columns["ClosedCases"].DisplayIndex = 5;
            dgvEmployees.Columns["PhoneNumber"].DisplayIndex = 6;
            dgvEmployees.Columns["Email"].DisplayIndex = 7;
            dgvEmployees.Columns["PostalCode"].DisplayIndex = 8;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void SetupDgvWithSecretariesAsync()
        {
            cboxFilter.Enabled = false;

            dgvEmployees.DataSource = secretaries;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;

            dgvEmployees.Columns["LawyerTitle"].Visible = true;
            dgvEmployees.Columns["AddressLine"].Visible = true;
            dgvEmployees.Columns["City"].Visible = true;
            dgvEmployees.Columns["HireDate"].Visible = true;

            dgvEmployees.Columns["HireDate"].DefaultCellStyle.Format = "d";
            dgvEmployees.Columns["PersonID"].HeaderText = "SecretaryID";

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["LawyerTitle"].DisplayIndex = 1;
            dgvEmployees.Columns["Firstname"].DisplayIndex = 2;
            dgvEmployees.Columns["Lastname"].DisplayIndex = 3;
            dgvEmployees.Columns["Email"].DisplayIndex = 4;
            dgvEmployees.Columns["PhoneNumber"].DisplayIndex = 5;
            dgvEmployees.Columns["AddressLine"].DisplayIndex = 6;
            dgvEmployees.Columns["PostalCode"].DisplayIndex = 7;
            dgvEmployees.Columns["City"].DisplayIndex = 8;
            dgvEmployees.Columns["HireDate"].DisplayIndex = 9;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void DgvEmployees_DataSourceChanged(object? sender, EventArgs e)
        {
            dgvEmployees.CurrentCell = null;            
        }
    }
}
