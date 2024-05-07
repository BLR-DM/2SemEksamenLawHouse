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
using UI.Toolbox;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class EmployeesView : Form
    {
        LawyerBL lawyerBL;
        List<LawyerUI> lawyerUIs;
        List<LawyerUI> filteredData;
        public EmployeesView()
        {
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();

            InitializeComponent();

            Load += EmployeesView_Load;
        }

        private async void EmployeesView_Load(object? sender, EventArgs e)
        {
            await GetLawyerUIsAsync();
            FilterAndAssignData();
        }

        private async Task GetLawyerUIsAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersAsync();
        }

        private void FilterAndAssignData()
        {
            foreach (LawyerUI lawyer in lawyerUIs)
            {
                LawyerCard lawyerCard = new LawyerCard(lawyer);
                flpnlLawyers.Controls.Add(lawyerCard);
            }

            dgv.DataSource = lawyerUIs;


            //List<LawyerDisplay> filteredData = lawyerUIs.Select(lawyer => new LawyerDisplay 
            //{
            //    Firstname = lawyer.Firstname,
            //    Lastname = lawyer.Lastname,
            //    Title = lawyer.LawyerTitle,
            //    City = lawyer.City,
            //    PhoneNumber = lawyer.PhoneNumber

            //}).ToList();



            //foreach (LawyerDisplay l in filteredData) 
            //{
            //    lblName.Text = 
            //        $"{l.Firstname} {l.Lastname}";
            //    lblDetails.Text = 
            //        $"{l.Title} \u2022 {l.City}\n" +
            //        $"+45 {l.PhoneNumber}";
            //}

            //test = $"{filteredData[0].Firstname} {filteredData[0].Lastname}\n" +
            //    $"{filteredData[0].Title}";

            //lblName.Text = test; 


        }

        private class LawyerDisplay
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Title { get; set; }
            public string City { get; set; }
            public int PhoneNumber { get; set; }
        }
    }
}
