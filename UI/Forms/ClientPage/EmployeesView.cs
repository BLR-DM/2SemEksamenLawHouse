﻿using BusinessLogic;
using EntityModels;
using UI.Toolbox;
using UIModels;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UI.Forms.ClientPage
{
    public partial class EmployeesView : System.Windows.Forms.Form
    {
        LawyerBL lawyerBL;
        SpecialityBL specialityBL;
        List<LawyerUI> lawyerUIs;
        List<LawyerSpecialityUI> lawyerSpecialityUIs;
        readonly List<LawyerCard> OriginalLawyerControls;
        public EmployeesView()
        {
            specialityBL = new SpecialityBL();
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();
            lawyerSpecialityUIs = new List<LawyerSpecialityUI>();
            OriginalLawyerControls = new List<LawyerCard>();

            InitializeComponent();

            Load += EmployeesView_Load;

            cboxSpecialities.SelectionChangeCommitted += CboxSpecialities_SelectionChangeCommitted;
            cboxSort.SelectionChangeCommitted += CboxSort_SelectionChangeCommitted;
            
        }
        private async void EmployeesView_Load(object? sender, EventArgs e)
        {
            await GetLawyersUIsAsync();
            await GetSpecialityUIsAsync();
            FillComboBoxes();
            SetupPanelContent();
        }

        private void CboxSort_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            // Fjern fokus fra valgte item
            lblFilterSpeciality.Focus();
            
            SortAndUpdateFlowLayoutPanel();
        }
        private void CboxSpecialities_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            // Fjern fokus fra valgte item
            lblFilterSpeciality.Focus();

            FilterLawyerControls();
        }

        private void SortAndUpdateFlowLayoutPanel()
        {
            List<LawyerCard> visibleControls = OriginalLawyerControls.Where(c => c.Visible).ToList();

            switch (cboxSort.SelectedItem)
            {
                case "":
                    visibleControls = OriginalLawyerControls.Where((c) => c.Visible).ToList();
                    break;

                case "Name":
                    visibleControls = visibleControls.OrderBy(c => c.Name).ToList();
                    break;
                case "City":
                    visibleControls = visibleControls.OrderBy(c => c.City).ToList();
                    break;
            }

            flpnlLawyers.Controls.Clear();
            foreach (Control c in visibleControls)
            {
                flpnlLawyers.Controls.Add(c);
            }
        }

        private void FilterLawyerControls()
        {
            switch (cboxSpecialities.SelectedIndex)
            {
                case 0:
                    foreach (Control control in OriginalLawyerControls)
                    {
                        control.Show();
                    }
                    break;
                default:
                    string selectedSpeciality = cboxSpecialities.SelectedItem.ToString();

                    List<int> matchingLawyerIDs = new List<int>();

                    matchingLawyerIDs = lawyerSpecialityUIs
                            .Where(x => x.SpecialityName == selectedSpeciality)
                            .Select(x => x.LawyerID).ToList();

                    foreach (LawyerCard lawyerControl in OriginalLawyerControls)
                    {
                        if (matchingLawyerIDs.Contains(lawyerControl.LawyerID))
                            lawyerControl.Show();
                        else
                            lawyerControl.Hide();
                    }
                    break;
            }

            if (cboxSort.SelectedItem != null)
            {
                SortAndUpdateFlowLayoutPanel();
            }
        }

        private async Task GetLawyersUIsAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersWithCollectionsAsync();
        }

        private async Task GetSpecialityUIsAsync()
        {
            lawyerSpecialityUIs = await specialityBL.GetLawyerSpecialitiesAsync();
        }

        private void FillComboBoxes()
        {
            if (lawyerSpecialityUIs.Count > 0)
            {
                // Filtrering combobox
                cboxSpecialities.Items.Insert(0, "");

                // Distinct tilknyttede specialiteter
                foreach (string s in lawyerSpecialityUIs.Select(s => s.SpecialityName).Distinct())
                {
                    cboxSpecialities.Items.Add(s);
                }
                cboxSpecialities.SelectedIndex = 0;


                // Sorting combobox
                cboxSort.Items.Insert(0, "");
                cboxSort.Items.Add("Name");
                cboxSort.Items.Add("City");
                cboxSort.SelectedIndex = 0;
            }
        }

        private void SetupPanelContent()
        {
            foreach (LawyerUI lawyer in lawyerUIs)
            {
                LawyerCard lawyerCard = new LawyerCard(lawyer);

                // For hver child lawyerControl i LawyerCard lawyerControl, tilknyt klik event
                foreach (Control control in lawyerCard.Controls)
                {
                    control.Click += (sender, e) => LawyerCard_Click(lawyerCard, e);
                }

                lawyerCard.Margin = new Padding(23);
                flpnlLawyers.Controls.Add(lawyerCard);
                OriginalLawyerControls.Add(lawyerCard);
            }
        }

        private void LawyerCard_Click(object? sender, EventArgs e)
        {
            if (sender is LawyerCard lawyerCard)
            {
                if (lawyerCard != null)
                {
                    pnlLawyerDetails.Controls.Clear();
                    pnlLawyerDetails.Controls
                        .Add(new EmployeeCardDisplay(lawyerUIs.SingleOrDefault(x => x.PersonID == lawyerCard.LawyerID))); 
                }
            }
        }

    }
}
