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
    public partial class LawyerDetailsView : Form
    {
        LawyerUI lawyer;
        public LawyerDetailsView(LawyerUI lawyer)
        {
            this.lawyer = lawyer;

            InitializeComponent();

            Load += LawyerDetailsView_Load;
        }

        private void LawyerDetailsView_Load(object? sender, EventArgs e)
        {
            MessageBox.Show(lawyer.Firstname);

            dgv.DataSource = lawyer.Cases;
        }
    }
}
