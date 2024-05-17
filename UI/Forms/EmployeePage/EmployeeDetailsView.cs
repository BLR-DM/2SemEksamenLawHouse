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
        public EmployeeDetailsView(int personID, bool isMyPage, EmployeeUI currentUser)
        {
            employeeBL = new EmployeeBL();
            displayedEmployee = new EmployeeUI();

            this.personID = personID;
            this.isMyPage = isMyPage;

            if (currentUser is LawyerUI lawyerUI)
            {
                this.isAdmin = lawyerUI.Admin;
            }
            else
                this.currentUser = currentUser;
            

            InitializeComponent();

            pnlEdit.Visible = false;
            btnCancel.Visible = false;            

            btnEditDetails.Click += BtnEditDetails_Click;
            pnlEdit.VisibleChanged += PnlEdit_VisibleChanged;
            btnCancel.Click += BtnCancel_Click;
            
            SetupView(isMyPage, currentUser);
            GetAndDisplayEmployeeAsync();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            pnlEdit.Visible = false;
            //DisplayEmployee();
        }


        private async Task GetAndDisplayEmployeeAsync()
        {
            displayedEmployee = await employeeBL.GetEmployeeAsync(personID);
            if (displayedEmployee != null)
            {
                pnlEmployeeDetails.Controls.Clear();
                pnlEmployeeDetails.Controls.Add(new EmployeeCardDisplay(displayedEmployee));
            }
            //pnlEmployeeDetails.Visible = false;
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

        private void BtnEditDetails_Click(object? sender, EventArgs e)
        {
            btnEditDetails.Enabled = false;

            pnlEdit.Controls.Clear();
            pnlEdit.Controls.Add(new EmployeeCardEdit(displayedEmployee, isAdmin));
            pnlEdit.Visible = true;
        }


        private void SetupView(bool isMyPage, EmployeeUI currentUser)
        {
            if (!isMyPage)
            {
                //btnEditDetails.Visible = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                StartPosition = FormStartPosition.CenterScreen;
                Size = new Size(350, 613);
            }

            if (isMyPage || isAdmin)
            {
                btnEditDetails.Visible = true;
            }
            else
                btnEditDetails.Visible = false;
        }
    }
}
