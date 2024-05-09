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
        ModelConverter modelConverter;
        List<EmployeeUI> employeeUIList;
        public EmployeesOverview()
        {
            employeeBL = new EmployeeBL();

            InitializeComponent();

            Load += EmployeesOverview_Load;
        }

        private void EmployeesOverview_Load(object? sender, EventArgs e)
        {
            UpdateDgvData();
        }

        private async Task UpdateDgvData()
        {
            employeeUIList = new List<EmployeeUI>();
            employeeBL.GetEmployeesAsync();
            dgvEmployees.DataSource = employeeUIList;
        }
    }
}
