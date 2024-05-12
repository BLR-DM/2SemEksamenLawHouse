using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UI.Forms.EmployeePage
{
    public partial class MyPageLawyerView : Form
    {
        LawyerUI lawyer;
        public MyPageLawyerView(LawyerUI lawyer)
        {
            this.lawyer = lawyer;

            InitializeComponent();

            Load += MyPageLawyerView_Load;
        }

        private void MyPageLawyerView_Load(object? sender, EventArgs e)
        {
            if (lawyer != null)
            {
                lblFullname.Text = string.Join(" ", lawyer.Firstname, lawyer.Lastname);
                lblLawyerTitle.Text = lawyer.LawyerTitle;
                lblCity.Text = lawyer.City;
                lblPhone.Text = lawyer.PhoneNumber.ToString();
                lblEmail.Text = lawyer.Email;
            }
        }
    }
}
