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
        public EmployeesView()
        {
            specialityBL = new SpecialityBL();
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();
            lawyerSpecialityUIs = new List<LawyerSpecialityUI>();

            InitializeComponent();

            Load += EmployeesView_Load;
        }        

        private async void EmployeesView_Load(object? sender, EventArgs e)
        {
            await GetLawyerUIsAsync();
            await GetSpecialityUIsAsync();
            FilterAndDisplayLawyers();
            if (lawyerSpecialityUIs.Count > 0)
            {
                lblAllSpecialties.Text = string.Join(", ", lawyerSpecialityUIs
                    .Select(s => s.SpecialityName)
                    .Distinct());
            }
        }

        private async Task GetLawyerUIsAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersAsync();
        }

        private async Task GetSpecialityUIsAsync()
        {
            lawyerSpecialityUIs = await specialityBL.GetLawyerSpecialitiesAsync();
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
                tboxSelected.Text = string.Join(" ", control.Firstname, control.Lastname);
                lblDetailsTitleValue.Text = control.Title;
                lblDetailsCityValue.Text = control.City;
                lblDetailsPhoneValue.Text = "+45" + control.Phone.ToString();
                lblDetailsEmailValue.Text = control.Email;

                lboxSpecialties.DataSource = lawyerSpecialityUIs
                    .Where(x => x.LawyerID == control.LawyerID)
                    .Select(x => x.SpecialityName)
                    .ToList();
            }
        }

    }
}
