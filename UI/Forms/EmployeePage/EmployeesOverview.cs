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
using System.Windows.Controls;
using EntityModels;
using BusinessLogic.Validation;


namespace UI.Forms.EmployeePage
{
    public partial class EmployeesOverview : Form
    {
        LawyerBL lawyerBL;
        EmployeeBL employeeBL;
        SecretaryBL secretaryBL;
        SpecialityBL specialityBL;
        EmployeeUI employeeUI;

        List<LawyerSpecialityUI> lawyerSpecialites;
        List<EmployeeUI> employees;
        List<LawyerUI> lawyers;
        List<SecretaryUI> secretaries;

        List<string> selectedFilters;
        List<LawyerUI> filteredLawyers;
        List<EmployeeUI> filteredEmployees;
        List<SecretaryUI> filteredSecretaries;

        int sortByNameCount, sortByCaseCount, sortByServiceCount, 
            sortBySpecialityCount, sortByHireDate;

        public EmployeesOverview(int userID, EmployeeUI currentUser)
        {
            lawyerBL = new LawyerBL();
            employeeBL = new EmployeeBL();
            secretaryBL = new SecretaryBL();
            specialityBL = new SpecialityBL();

            this.employeeUI = currentUser;
            selectedFilters = new List<string>();

            InitializeComponent();

            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            
            sortByNameCount = sortByCaseCount = sortByServiceCount = 
                sortBySpecialityCount = sortByHireDate = 0;

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
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnRefresh.Click += BtnRefresh_Click;
        }

        private async void BtnRefresh_Click(object? sender, EventArgs e)
        {
            await RefreshDvgDataAsync();
            SortDgv();
        }

        private async void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            SetDgvStyle();

            await GetEmployeesAsync();
            filteredEmployees = new List<EmployeeUI>(employees);
            SetupDgvWithEmployees();

            await GetLawyersWithCollectionsAsync();
            filteredLawyers = new List<LawyerUI>(lawyers);

            await GetSecretariesAsync();
            secretaries = new List<SecretaryUI>(secretaries);
            await GetSpecialityUIsAsync();

            // Visnings combobox
            cboxShow.Items.Insert(0, "Employees");
            cboxShow.Items.Add("  Lawyers");
            cboxShow.Items.Add("  Secretaries");
            cboxShow.SelectedIndex = 0;
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

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
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
            cboxFilter.SelectedItem = null;

            SortDgv();
        }

        private void ResetSorts()
        {
            sortByNameCount = sortByCaseCount = sortByServiceCount = sortBySpecialityCount = sortByHireDate = 0;
            cboxSort.SelectedItem = null;
            btnTrashSort.Visible = false;
        }

        private void SortDgv()
        {
            if (cboxShow.SelectedItem == "Employees")
            {
                SortEmployees();

                dgvEmployees.CurrentCell = null;
                SetupDgvWithEmployees();
            }
            else if (cboxShow.SelectedItem == "  Secretaries")
            {
                SortSecretaries();

                dgvEmployees.CurrentCell = null;
                SetupDgvWithSecretaries();
            }
            else if (cboxShow.SelectedItem == "  Lawyers")
            {

                filteredLawyers = new List<LawyerUI>(lawyers);

                string search = txtSearch.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(search))
                {
                    filteredLawyers = filteredLawyers
                        .Where(lawyer =>
                        lawyer.PhoneNumber.ToString().Contains(search) ||
                        lawyer.LawyerTitle.ToLower().Contains(search) ||
                        lawyer.PostalCode.ToString().Contains(search) ||
                        lawyer.Firstname.ToLower().Contains(search) ||
                        lawyer.Lastname.ToLower().Contains(search) ||
                        lawyer.Email.ToLower().Contains(search))
                        .ToList();
                }

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
                            if (sortByServiceCount % 2 == 1)
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
                    }
                }
                dgvEmployees.CurrentCell = null;
                btnTrashFilter.Visible = flpnlFilters.Controls.Count > 0;
                SetupDgvWithLawyers();
            }
        }

        private void SortEmployees()
        {
            filteredEmployees = new List<EmployeeUI>(employees);

            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                filteredEmployees = filteredEmployees
                    .Where(employee =>
                    employee.PhoneNumber.ToString().Contains(search) ||
                    employee.AddressLine.ToLower().Contains(search) ||
                    employee.PostalCode.ToString().Contains(search) ||
                    employee.Firstname.ToLower().Contains(search) ||
                    employee.Lastname.ToLower().Contains(search) ||
                    employee.HireDate.ToString().Contains(search) ||
                    employee.Email.ToLower().Contains(search))
                    .ToList();
            }

            if (cboxSort.SelectedItem != null)
            {
                switch (cboxSort.SelectedItem)
                {
                    case "Name":
                        sortByNameCount++;
                        if (sortByNameCount % 2 == 1)
                        {
                            filteredEmployees = filteredEmployees
                                .OrderBy(employee => employee.Firstname)
                                .ThenBy(employee => employee.Lastname)
                                .ToList();
                        }
                        else
                        {
                            filteredEmployees = filteredEmployees
                                .OrderByDescending(employee => employee.Firstname)
                                .ThenByDescending(employee => employee.Lastname)
                                .ToList();
                        }
                        break;

                    case "Hire date":
                        sortByHireDate++;
                        if (sortByHireDate % 2 == 1)
                        {
                            filteredEmployees = filteredEmployees
                                .OrderBy(employee => employee.HireDate)
                                .ToList();
                        }
                        else
                        {
                            filteredEmployees = filteredEmployees
                                .OrderByDescending(employee => employee.HireDate)
                                .ToList();
                        }
                        break;
                }
            }
        }

        private void SortSecretaries()
        {
            filteredSecretaries = new List<SecretaryUI>(secretaries);

            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                filteredSecretaries = filteredSecretaries
                    .Where(employee =>
                    employee.PhoneNumber.ToString().Contains(search) ||
                    employee.AddressLine.ToLower().Contains(search) ||
                    employee.PostalCode.ToString().Contains(search) ||
                    employee.Firstname.ToLower().Contains(search) ||
                    employee.Lastname.ToLower().Contains(search) ||
                    employee.HireDate.ToString().Contains(search) ||
                    employee.Email.ToLower().Contains(search))
                    .ToList();
            }

            if (cboxSort.SelectedItem != null)
            {
                switch (cboxSort.SelectedItem)
                {
                    case "Name":
                        sortByNameCount++;
                        if (sortByNameCount % 2 == 1)
                        {
                            filteredSecretaries = filteredSecretaries
                                .OrderBy(employee => employee.Firstname)
                                .ThenBy(employee => employee.Lastname)
                                .ToList();
                        }
                        else
                        {
                            filteredSecretaries = filteredSecretaries
                                .OrderByDescending(employee => employee.Firstname)
                                .ThenByDescending(employee => employee.Lastname)
                                .ToList();
                        }
                        break;

                    case "Hire date":
                        sortByHireDate++;
                        if (sortByHireDate % 2 == 1)
                        {
                            filteredSecretaries = filteredSecretaries
                                .OrderBy(employee => employee.HireDate)
                                .ToList();
                        }
                        else
                        {
                            filteredSecretaries = filteredSecretaries
                                .OrderByDescending(employee => employee.HireDate)
                                .ToList();
                        }
                        break;
                }
            }
        }

        private void CboxShowEmployees_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblShow.Focus();
            lblTotalEmployees.Text = "Loading...";

            ResetFilters();
            ResetSorts();

            switch (cboxShow.SelectedItem)
            {
                case "Employees":
                    FillComboBoxesForEmployees();
                    SetupDgvWithEmployees();
                    lblTotalEmployees.Text = $"{filteredEmployees.Count} Employees";
                    break;
                case "  Lawyers":
                    FillComboBoxesForLawyers();
                    SetupDgvWithLawyers();
                    lblTotalEmployees.Text = $"{filteredLawyers.Count} Lawyers";
                    break;
                case "  Secretaries":
                    FillComboBoxesForEmployees();
                    SetupDgvWithSecretaries();
                    lblTotalEmployees.Text = $"{filteredSecretaries.Count} Secretaries";
                    break;
            }
        }

        private void FillComboBoxesForEmployees()
        {
            // Sorterings combobox
            cboxSort.Items.Clear();
            cboxSort.Items.Add("Name");
            cboxSort.Items.Add("Hire date");

            cboxFilter.Items.Clear();
        }

        private void FillComboBoxesForLawyers()
        {
            // Sorterings combobox
            cboxSort.Items.Clear();
            cboxSort.Items.Add("Name");
            cboxSort.Items.Add("Speciality");
            cboxSort.Items.Add("Open Cases");
            cboxSort.Items.Add("Open Services");

            // Sepciale combobox
            cboxFilter.Items.Clear();
            foreach (string ls in lawyerSpecialites.Select(ls => ls.SpecialityName).Distinct())
            {
                cboxFilter.Items.Add(ls);
            }
        }


        private void DgvEmployees_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (cboxShow.SelectedItem)
                {
                    case "Employees":
                        if (dgvEmployees.Rows[e.RowIndex].DataBoundItem is EmployeeUI employee)
                            new EmployeeDetailsView(employee.PersonID, false, employeeUI).ShowDialog();
                        break;

                    case "  Lawyers":
                        if (dgvEmployees.Rows[e.RowIndex].DataBoundItem is LawyerUI lawyer)
                            new LawyerDetailsView(lawyer.PersonID, false, employeeUI).ShowDialog();
                        break;

                    case "  Secretaries":
                        if (dgvEmployees.Rows[e.RowIndex].DataBoundItem is SecretaryUI secretary)
                            new EmployeeDetailsView(secretary.PersonID, false, employeeUI).ShowDialog();
                        break;
                }
            }
        }


        private void SetupDgvWithEmployees()
        {
            dgvEmployees.DataSource = filteredEmployees;

            cboxFilter.Enabled = false;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;
            dgvEmployees.Columns["LawyerTitle"].Visible = false;

            dgvEmployees.Columns["AddressLine"].Visible = true;
            dgvEmployees.Columns["City"].Visible = true;
            dgvEmployees.Columns["HireDate"].Visible = true;

            dgvEmployees.Columns["HireDate"].DefaultCellStyle.Format = "d";
            dgvEmployees.Columns["PersonID"].HeaderText = "EmployeeID";
            dgvEmployees.Columns["LawyerTitle"].HeaderText = "Title";
            dgvEmployees.Columns["PhoneNumber"].HeaderText = "Phone";
            dgvEmployees.Columns["PostalCode"].HeaderText = "Zip";

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["Firstname"].DisplayIndex = 1;
            dgvEmployees.Columns["Lastname"].DisplayIndex = 2;
            dgvEmployees.Columns["Email"].DisplayIndex = 3;
            dgvEmployees.Columns["PhoneNumber"].DisplayIndex = 4;
            dgvEmployees.Columns["AddressLine"].DisplayIndex = 5;
            dgvEmployees.Columns["PostalCode"].DisplayIndex = 6;
            dgvEmployees.Columns["City"].DisplayIndex = 7;
            dgvEmployees.Columns["HireDate"].DisplayIndex = 8;
        }

        private void SetupDgvWithLawyers()
        {
            dgvEmployees.DataSource = filteredLawyers;

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
            
            dgvEmployees.Columns["OpenCaseServices"].HeaderText = "OpenServices"; //
            dgvEmployees.Columns["SpecialityCount"].HeaderText = "Specialities";            

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
        }

        private void SetupDgvWithSecretaries()
        {
            dgvEmployees.DataSource = secretaries;

            cboxFilter.Enabled = false;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;

            dgvEmployees.Columns["LawyerTitle"].Visible = true;
            dgvEmployees.Columns["AddressLine"].Visible = true;
            dgvEmployees.Columns["City"].Visible = true;
            dgvEmployees.Columns["HireDate"].Visible = true;

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
        }

        private void SetDgvStyle()
        {
            dgvEmployees.EnableHeadersVisualStyles = false;

            dgvEmployees.RowHeadersVisible = false;

            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvEmployees.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            dgvEmployees.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvEmployees.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async Task RefreshDvgDataAsync() // Hvis der skal opdateres efter ændring - CUD
        {
            await GetEmployeesAsync();
            await GetLawyersWithCollectionsAsync();
            await GetSecretariesAsync();
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

        private void DgvEmployees_DataSourceChanged(object? sender, EventArgs e)
        {
            dgvEmployees.CurrentCell = null;
        }
    }
}
