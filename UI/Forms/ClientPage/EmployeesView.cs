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

namespace UI.Forms.ClientPage
{
    public partial class EmployeesView : Form
    {
        LawyerBL lawyerBL;
        List<LawyerUI> lawyerUIs;
        public EmployeesView()
        {
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();

            InitializeComponent();

            Load += EmployeesView_Load;
        }

        private void EmployeesView_Load(object? sender, EventArgs e)
        {
            GetLawyersAsync();

            if (lawyerUIs.Count > 0)
            {
                MessageBox.Show($"Lawyers: {lawyerUIs.Count}");
            }
        }

        private async Task GetLawyersAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersAsync();
        }
    }
}
