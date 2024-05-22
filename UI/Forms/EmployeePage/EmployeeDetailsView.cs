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

        EmployeeUI currentUser;
        EmployeeUI displayedEmployee;

        int employeeID;
        bool isMyPage;
        bool isAdmin;
        public EmployeeDetailsView(int employeeID, bool isMyPage, EmployeeUI currentUser)
        {
            employeeBL = new EmployeeBL();
            this.employeeID = employeeID;
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
            pnlEdit.Visible = false;

            Load += EmployeeDetailsView_Load;
            btnEditDetails.Click += BtnEditDetails_Click;
            btnCancel.Click += BtnCancel_Click;
            pnlEdit.VisibleChanged += PnlEdit_VisibleChanged;
            
            CheckUser(isMyPage, currentUser);
            
        }

        private async void EmployeeDetailsView_Load(object? sender, EventArgs e)
        {
            await SetupView(employeeID);
        }

        private void PnlEdit_VisibleChanged(object? sender, EventArgs e)
        {
            if (!pnlEdit.Visible)
            {
                btnCancel.Visible = false;
                btnEditDetails.Enabled = true;
            }
            else
                btnCancel.Visible = true;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        public async Task SetupView(int id)
        {
            displayedEmployee = await employeeBL.GetEmployeeAsync(id);

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
            pnlEdit.Controls.Clear();
            pnlEdit.Controls.Add(new EmployeeCardEdit(this, displayedEmployee, isAdmin));
            pnlEdit.Visible = true;
        }


        private void CheckUser(bool isMyPage, EmployeeUI currentUser)
        {
            if (!isMyPage)
            {
                //btnEditDetails.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.Size = new Size(350, 613);
            }
            btnEditDetails.Visible = isMyPage || isAdmin;
        }
    }
}
