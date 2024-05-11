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

        List<EmployeeUI> employeeUIs;
        List<LawyerUI> lawyerUIs;

        public EmployeesOverview()
        {
            employeeBL = new EmployeeBL();
            lawyerBL = new LawyerBL();

            employeeUIs = new List<EmployeeUI>();
            lawyerUIs = new List<LawyerUI>();

            InitializeComponent();

            Load += EmployeesOverview_Load;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
        }

        private void DgvEmployees_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LawyerUI lawyer = dgvEmployees.Rows[e.RowIndex].DataBoundItem as LawyerUI;

                new LawyerDetailsView(lawyer).ShowDialog();
            }
        }

        private async void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            //employeeUIs = await GetEmployeesAsync();
            //lawyerUIs = await GetLawyersAsync();
            lawyerUIs = await GetLawyersWithCollectionsAsync();

            //SetupDgvWithEmployees();
            SetupDgvWithLawyers();
        }

        private async Task<List<LawyerUI>> GetLawyersWithCollectionsAsync()
        {
            return await lawyerBL.GetLawyersWithCollectionsAsync();
        }

        private void SetupDgvWithLawyers()
        {
            dgvEmployees.DataSource = lawyerUIs;

            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;
            dgvEmployees.Columns["Cases"].Visible = false;

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["LawyerTitle"].DisplayIndex = 1;
            dgvEmployees.Columns["Firstname"].DisplayIndex = 2;
            dgvEmployees.Columns["Lastname"].DisplayIndex = 3;
            dgvEmployees.Columns["ActiveCaseCount"].DisplayIndex = 4;
            dgvEmployees.Columns["PhoneNumber"].DisplayIndex = 5;
            dgvEmployees.Columns["Email"].DisplayIndex = 6;
            dgvEmployees.Columns["AddressLine"].DisplayIndex = 7;
            dgvEmployees.Columns["PostalCode"].DisplayIndex = 8;
            dgvEmployees.Columns["City"].DisplayIndex = 9;
            dgvEmployees.Columns["HireDate"].DisplayIndex = 10;

            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetupDgvWithEmployees()
        {
            dgvEmployees.DataSource = employeeUIs;
            
            dgvEmployees.Columns["LawyerTitleID"].Visible = false;
            dgvEmployees.Columns["LoginDetailsID"].Visible = false;

            dgvEmployees.Columns["PersonID"].DisplayIndex = 0;
            dgvEmployees.Columns["LawyerTitle"].DisplayIndex = 1; // Hide?
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

        private async Task<List<EmployeeUI>> GetEmployeesAsync()
        {
            return await employeeBL.GetEmployeesAsync();
        }

        private async Task<List<LawyerUI>> GetLawyersAsync()
        {
            return await lawyerBL.GetLawyersAsync();
        }

    }
}
