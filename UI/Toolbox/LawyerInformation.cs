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

namespace UI.Toolbox
{
    public partial class LawyerInformation : UserControl
    {
        LawyerUI lawyer;
        public LawyerInformation(LawyerUI lawyer)
        {
            this.lawyer = lawyer;
            InitializeComponent();

            Load += LawyerInformation_Load;
        }

        private void LawyerInformation_Load(object? sender, EventArgs e)
        {
            txtFirstname.Text = lawyer.Firstname;
            txtLastname.Text = lawyer.Lastname;
            txtPhone.Text = lawyer.PhoneNumber.ToString();
        }

        public LawyerInformation()
        {
            InitializeComponent();

            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

    }
}
