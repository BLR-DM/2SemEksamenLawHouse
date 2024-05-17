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
        int personID;

        EmployeeUI currentUser;
        EmployeeUI displayedEmployee;
        bool isMyPage;
        bool isAdmin;
        public EmployeeDetailsView(EmployeeUI displayedEmployee, bool isMyPage, EmployeeUI currentUser)
        {
            employeeBL = new EmployeeBL();
            this.isMyPage = isMyPage;
            this.displayedEmployee = displayedEmployee;

            if (currentUser is LawyerUI lawyerUI)
            {
                this.isAdmin = lawyerUI.Admin;
            }
            else
                this.currentUser = currentUser;
            

            InitializeComponent();

            btnCancel.Visible = false;            

            btnEditDetails.Click += BtnEditDetails_Click;
            btnEditDetails.EnabledChanged += BtnEditDetails_EnabledChanged;
            btnCancel.Click += BtnCancel_Click;
            
            SetupView(isMyPage, currentUser);
            GetAndDisplayEmployeeAsync();
        }

        private void BtnEditDetails_EnabledChanged(object? sender, EventArgs e)
        {
            btnCancel.Visible = !btnEditDetails.Enabled;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            GetAndDisplayEmployeeAsync();
        }

        private async Task GetAndDisplayEmployeeAsync()
        {
            if (displayedEmployee != null)
            {
                pnlEmployeeDetails.Controls.Clear();
                pnlEmployeeDetails.Controls.Add(new EmployeeCardDisplay(displayedEmployee));
                btnEditDetails.Enabled = true;
            }
        }

        private void BtnEditDetails_Click(object? sender, EventArgs e)
        {
            btnEditDetails.Enabled = false;
            pnlEmployeeDetails.Controls.Clear();
            pnlEmployeeDetails.Controls.Add(new EmployeeCardEdit(displayedEmployee, isAdmin));
        }


        private void SetupView(bool isMyPage, EmployeeUI currentUser)
        {
            if (!isMyPage)
            {
                //btnEditDetails.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(350, 613);
            }

            if (isMyPage || isAdmin)
                btnEditDetails.Visible = true;
            else
                btnEditDetails.Visible = false;
        }
    }
}
