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
    public partial class EmployeeDetailsView : Form
    {
        EmployeeBL employeeBL;
        EmployeeUI displayedEmployee;
        public EmployeeDetailsView(EmployeeUI displayedEmployee, bool isMyPage, EmployeeUI currentUser)
        {
            employeeBL = new EmployeeBL();
            this.displayedEmployee = displayedEmployee;

            InitializeComponent();
            
            SetupView(isMyPage, currentUser);
        }

        private async Task GetUser(int user)
        {
            displayedEmployee = await employeeBL.GetEmployeeAsync(user);
        }

        private void SetupView(bool isMyPage, EmployeeUI currentUser)
        {
            if (!isMyPage)
            {
                //btnEditDetails.Visible = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                StartPosition = FormStartPosition.CenterScreen;
            }
            pnlEmployeeDetails.Controls.Add(new EmployeeCardDisplay(displayedEmployee));
        }
    }
}
