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


namespace UI.Forms.EmployeePage
{
    public partial class EmployeesOverview : Form
    {
        EmployeeBL employeeBL;
        LawyerBL lawyerBL;
        SecretaryBL secretaryBL;

        EmployeeUI employeeUI;

        public EmployeesOverview(int userID, EmployeeUI currentUser)
        {
            this.employeeUI = currentUser;

            employeeBL = new EmployeeBL();
            lawyerBL = new LawyerBL();
            secretaryBL = new SecretaryBL();

            InitializeComponent();

            Load += EmployeesOverview_Load;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
            dgvEmployees.DataSourceChanged += DgvEmployees_DataSourceChanged;
            cboxShow.SelectionChangeCommitted += CboxFilterEmployees_SelectionChangeCommitted;
        }

        private void DgvEmployees_DataSourceChanged(object? sender, EventArgs e)
        {
            dgvEmployees.CurrentCell = null;
        }

        private async void CboxFilterEmployees_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            lblShow.Focus();
            lblTotalEmployees.Text = "Loading...";
            switch (cboxShow.SelectedItem)
            {
                case "Employees":
                    await SetupDgvWithEmployeesAsync();
                    break;
                case "  Lawyers":
                    await SetupDgvWithLawyersAsync();
                    break;
                case "  Secretaries":
                    await SetupDgvWithSecretariesAsync();
                    break;
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

        private async void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            FillComboBoxes();
            await SetupDgvWithEmployeesAsync();
        }

        private void FillComboBoxes()
        {
            cboxShow.Items.Clear();

            // Filtrering combobox
            cboxShow.Items.Insert(0, "Employees");
            cboxShow.Items.Add("  Lawyers");
            cboxShow.Items.Add("  Secretaries");
            cboxShow.SelectedIndex = 0;


            //// Sorting combobox
            //cboxSort.Items.Insert(0, "");
            //cboxSort.Items.Add("Name");
            //cboxSort.Items.Add("City");
            //cboxSort.SelectionStart = 0;
        }

        private async Task SetupDgvWithLawyersAsync()
        {
            dgvEmployees.DataSource = await lawyerBL.GetLawyersWithCollectionsAsync();

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

            lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
        }

        private async Task SetupDgvWithEmployeesAsync()
        {
            dgvEmployees.DataSource = await employeeBL.GetEmployeesAsync();

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

            lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
        }

        private async Task SetupDgvWithSecretariesAsync()
        {
            dgvEmployees.DataSource = await secretaryBL.GetSecretariesAsync();

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

            lblTotalEmployees.Text = $"{dgvEmployees.RowCount} {cboxShow.Text.TrimStart()}";
        }
        //private async Task<List<LawyerUI>> GetLawyersAsync()
        //{
        //    return await lawyerBL.GetLawyersAsync();
        //}

    }
}
