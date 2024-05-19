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
        List<LawyerUI> filteredLawyers;

        int sortByNameCount, sortByCaseCount, sortByServiceCount, sortBySpecialityCount, sortByPostal;

        public EmployeesOverview(int userID, EmployeeUI currentUser)
        {
            this.employeeUI = currentUser;
            selectedFilters = new List<string>();

            employeeBL = new EmployeeBL();
            lawyerBL = new LawyerBL();
            secretaryBL = new SecretaryBL();
            specialityBL = new SpecialityBL();



            InitializeComponent();

            sortByNameCount = sortByCaseCount = sortByServiceCount = sortBySpecialityCount = sortByPostal = 0;

            btnTrashFilter.Visible = false;
            btnTrashSort.Visible = false;
            cboxFilter.Enabled = false;

            Load += EmployeesOverview_Load;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
            dgvEmployees.DataSourceChanged += DgvEmployees_DataSourceChanged;
            cboxShow.SelectedIndexChanged += CboxShowEmployees_SelectedIndexChanged;
            cboxFilter.SelectedIndexChanged += CboxFilter_SelectedIndexChanged;
            btnTrashFilter.Click += BtnTrashFilter_Click;
            btnTrashSort.Click += BtnTrashSort_Click;
            cboxSort.SelectedIndexChanged += CboxSort_SelectedIndexChanged;
        }

        private void BtnTrashSort_Click(object? sender, EventArgs e)
        {
            btnTrashSort.Visible = false;
            cboxSort.SelectedItem = null;            
        }

        private void BtnTrashFilter_Click(object? sender, EventArgs e)
        {
            btnTrashFilter.Visible = false;
            ResetFilters();
        }

        private void CboxSort_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboxSort.SelectedItem != null)
                btnTrashSort.Visible = true;

            SortDgv();
        }

        private void CboxFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboxFilter.SelectedItem != null)
            {
                btnTrashFilter.Visible = true;

                selectedFilters.Add(cboxFilter.SelectedItem.ToString());
                FilterSpeciality fs = new FilterSpeciality(cboxFilter.SelectedItem.ToString());
                fs.Click += Fs_Click;
                flpnlFilters.Controls.Add(fs);
                cboxFilter.Items.Remove(cboxFilter.SelectedItem);
            }
            SortDgv();
        }

        private void Fs_Click(object? sender, EventArgs e)
        {
            if (sender is FilterSpeciality filter)
            {                
                cboxFilter.Items.Add(filter.BtnText);
                selectedFilters.Remove(filter.BtnText);
                flpnlFilters.Controls.Remove(filter);

                SortDgv();
            }
        }

        private void ResetFilters()
        {
            foreach (FilterSpeciality fs in flpnlFilters.Controls)
            {
                cboxFilter.Items.Add(fs.BtnText);
            }
            flpnlFilters.Controls.Clear();
            selectedFilters.Clear();
            btnTrashFilter.Visible = false;

            SortDgv();
        }

        private void SortDgv()
        {
            filteredLawyers = new List<LawyerUI>(lawyers);

            if (selectedFilters.Count > 0)
            {
                filteredLawyers = lawyers
                    .Where(l => selectedFilters
                    .All(filter => l.LawyerSpecialities
                    .Any(ls => ls.SpecialityName == filter))).ToList();
            }

            if (cboxSort.SelectedItem != null)
            {
                switch (cboxSort.SelectedItem)
                {
                    case "Name":
                        sortByNameCount++;                        
                        if (sortByNameCount % 2 == 1)
                        {
                            filteredLawyers = filteredLawyers
                                .OrderBy(lawyer => lawyer.Firstname)
                                .ThenBy(lawyer => lawyer.Lastname)
                                .ToList();
                        }
                        else
                        {
                            filteredLawyers = filteredLawyers
                                .OrderByDescending(lawyer => lawyer.Firstname)
                                .ThenByDescending(lawyer => lawyer.Lastname)
                                .ToList();
                        }
                        break;

                    case "Open Cases":
                        sortByCaseCount++;
                        if (sortByCaseCount % 2 == 1)
                        {
                            filteredLawyers = filteredLawyers
                                .OrderBy(cases => cases.OpenCases)
                                .ToList();
                        }
                        else
                        {
                            filteredLawyers = filteredLawyers
                                .OrderByDescending(cases => cases.OpenCases)
                                .ToList();
                        }
                        break;

                    case "Open Services":
                        sortByServiceCount++;
                        if (sortByServiceCount  % 2 == 1)
                        {
                            filteredLawyers = filteredLawyers
                                .OrderBy(service => service.OpenCaseServices)
                                .ToList();
                        }
                        else
                        {
                            filteredLawyers = filteredLawyers
                                .OrderByDescending(service => service.OpenCaseServices)
                                .ToList();
                        }
                        break;

                    case "Speciality":
                        sortBySpecialityCount++;
                        if (sortBySpecialityCount % 2 == 1)
                        {
                            filteredLawyers = filteredLawyers
                                .OrderBy(speciality => speciality.SpecialityCount)
                                .ToList();
                        }
                        else
                        {
                            filteredLawyers = filteredLawyers
                                .OrderByDescending(speciality => speciality.SpecialityCount)
                                .ToList();
                        }
                        break;

                    case "PostalCode":
                        sortByPostal++;
                        if (sortByPostal % 2 == 1)
                        {
                            filteredLawyers = filteredLawyers
                                .OrderBy(postal => postal.PostalCode)
                                .ToList();
                        }
                        else
                        {
                            filteredLawyers = filteredLawyers
                                .OrderByDescending(postal => postal.PostalCode)
                                .ToList();
                        }
                        break;
                }
            }
            dgvEmployees.CurrentCell = null;
            btnTrashFilter.Visible = flpnlFilters.Controls.Count > 0;
            dgvEmployees.DataSource = filteredLawyers;
            SetupDgvWithLawyers();
        }

        private async void CboxShowEmployees_SelectedIndexChanged(object? sender, EventArgs e)
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
                    SetupDgvWithEmployees();
                    lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
                    break;
                case "  Lawyers":
                    SetupDgvWithLawyers();
                    lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
                    break;
                case "  Secretaries":
                    SetupDgvWithSecretaries();
                    lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
                    break;
            }
        }



        private async void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            await GetEmployeesAsync();
            SetupDgvWithEmployees();
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

            if (lawyers != null)
                filteredLawyers = new List<LawyerUI>(lawyers);
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


            // Sepciale combobox
            foreach (string ls in lawyerSpecialites.Select(ls => ls.SpecialityName).Distinct())
            {
                cboxFilter.Items.Add(ls);
            }

            // Sorterings combobox
            cboxSort.Items.Add("Name");
            cboxSort.Items.Add("Speciality");
            cboxSort.Items.Add("Open Cases");
            cboxSort.Items.Add("Open Services");
            cboxSort.Items.Add("PostalCode");
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

        private void SetupDgvWithEmployees()
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

        private void SetupDgvWithLawyers()
        {
            cboxFilter.Enabled = true;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;
            dgvEmployees.Columns["Cases"].Visible = false;
            dgvEmployees.Columns["AddressLine"].Visible = false;
            dgvEmployees.Columns["City"].Visible = false;
            dgvEmployees.Columns["HireDate"].Visible = false;
            dgvEmployees.Columns["LawyerSpecialities"].Visible = false;
            dgvEmployees.Columns["CaseServices"].Visible = false;

            dgvEmployees.Columns["LawyerTitle"].Visible = true;

            dgvEmployees.Columns["PersonID"].HeaderText = "LawyerID";
            dgvEmployees.Columns["LawyerTitle"].HeaderText = "Title";

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["LawyerTitle"].DisplayIndex = 1;
            dgvEmployees.Columns["Firstname"].DisplayIndex = 2;
            dgvEmployees.Columns["Lastname"].DisplayIndex = 3;
            dgvEmployees.Columns["OpenCases"].DisplayIndex = 4;
            dgvEmployees.Columns["OpenCaseServices"].DisplayIndex = 5;
            dgvEmployees.Columns["SpecialityCount"].DisplayIndex = 6;
            dgvEmployees.Columns["PhoneNumber"].DisplayIndex = 7;
            dgvEmployees.Columns["Email"].DisplayIndex = 8;
            dgvEmployees.Columns["PostalCode"].DisplayIndex = 9;
            dgvEmployees.Columns["ClosedCases"].DisplayIndex = 10;
            dgvEmployees.Columns["ClosedCaseServices"].DisplayIndex = 11;
            dgvEmployees.Columns["Admin"].DisplayIndex = 12;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void SetupDgvWithSecretaries()
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
