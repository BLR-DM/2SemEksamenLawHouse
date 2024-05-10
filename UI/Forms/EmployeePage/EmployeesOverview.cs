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
        List<EmployeeUI> employeeUIs;
        public EmployeesOverview()
        {
            employeeBL = new EmployeeBL();
            employeeUIs = new List<EmployeeUI>();

            InitializeComponent();

            Load += EmployeesOverview_Load;
        }

        private async void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            employeeUIs = await GetEmployeesAsync();

            SetupDgv();
        }

        private void SetupDgv()
        {
            dgvEmployees.DataSource = employeeUIs;

            if (employeeUIs != null)
            {                
                dgvEmployees.Columns["LawyerTitleID"].Visible = false;
                dgvEmployees.Columns["LoginDetailsID"].Visible = false;

                
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

                // Cases column to show cases count/employee?

                dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private async Task<List<EmployeeUI>> GetEmployeesAsync()
        {
            return await employeeBL.GetEmployeesAsync();
        }
    }
}
