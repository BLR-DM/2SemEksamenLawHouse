using BusinessLogic;
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
        readonly List<Control> OriginalLawyerControls;
        public EmployeesView()
        {
            specialityBL = new SpecialityBL();
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();
            lawyerSpecialityUIs = new List<LawyerSpecialityUI>();
            OriginalLawyerControls = new List<Control>();

            InitializeComponent();

            Load += EmployeesView_Load;

            cboxSpecialities.SelectionChangeCommitted += CboxSpecialities_SelectionChangeCommitted;
            cboxSort.SelectionChangeCommitted += CboxSort_SelectionChangeCommitted;
            
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
            List<Control> visibleControls = OriginalLawyerControls.Where(c => c.Visible).ToList();

            switch (cboxSort.SelectedItem.ToString())
            {
                case "":
                    visibleControls = OriginalLawyerControls.Where((c) => c.Visible).ToList();
                    break;

                case "Name":
                    visibleControls = visibleControls.OrderBy(c => c.Name).ToList();
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

                    foreach (Control control in OriginalLawyerControls)
                    {
                        if (matchingLawyerIDs.Contains((int)control.Tag))
                            control.Show();
                        else
                            control.Hide();
                    }
                    break;
            }

            if (cboxSort.SelectedItem != null)
            {
                SortAndUpdateFlowLayoutPanel();
            }
        }

        private async void EmployeesView_Load(object? sender, EventArgs e)
        {
            await GetLawyerUIsAsync();
            await GetSpecialityUIsAsync();

            FilterAndDisplayLawyers();

            FillComboBoxes();
        }

        private async Task GetLawyerUIsAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersAsync();
        }

        private async Task GetSpecialityUIsAsync()
        {
            lawyerSpecialityUIs = await specialityBL.GetLawyerSpecialitiesAsync();
        }

        private void FillComboBoxes()
        {
            if (lawyerSpecialityUIs.Count > 0)
            {
                cboxSpecialities.Items.Insert(0, "");

                // Distinct tilknyttede specialiteter
                foreach (string s in lawyerSpecialityUIs
                                        .Select(s => s.SpecialityName)
                                        .Distinct())
                {
                    cboxSpecialities.Items.Add(s);
                }
                cboxSpecialities.SelectionStart = 0;
            }

            if (flpnlLawyers.Controls.Count > 0)
            {
                cboxSort.Items.Insert(0, "");
                cboxSort.Items.Add("Name");
                cboxSort.SelectionStart = 0;
            }
        }

        private void FilterAndDisplayLawyers()
        {
            foreach (LawyerUI lawyer in lawyerUIs)
            {
                LawyerCard lawyerCard = new LawyerCard(lawyer);

                // For hver child control i LawyerCard control, tilknyt klik event
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
            if (sender is LawyerCard control)
            {
                DisplayDetails(control);
            }
        }   
        
        private void DisplayDetails(LawyerCard control)
        {
            if (control != null)
            {
                pboxDetails.IconColor = Color.Black;
                pboxDetails.IconChar = control.LawyerID == 5 ? FontAwesome.Sharp.IconChar.PiedPiperAlt : FontAwesome.Sharp.IconChar.PersonMilitaryPointing;

                // Fulde navn
                lblSelected.Text = string.Join(" ", control.Firstname, control.Lastname);

                // Attributter
                lblDetailsTitleValue.Text = control.Title;
                lblDetailsCityValue.Text = control.City;
                lblDetailsPhoneValue.Text = "+45" + control.Phone.ToString();
                lblDetailsEmailValue.Text = control.Email;

                // Specialer i listbox
                lboxSpecialties.DataSource = lawyerSpecialityUIs
                    .Where(x => x.LawyerID == control.LawyerID)
                    .Select(x => x.SpecialityName)
                    .ToList();
            }
        }


    }
}
