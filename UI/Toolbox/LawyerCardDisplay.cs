using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using UIModels;

namespace UI.Toolbox
{
    public partial class LawyerCardDisplay : UserControl
    {
        public LawyerCardDisplay(LawyerUI lawyerUI)
        {
            InitializeComponent();
            DisplayEmployeeInformation(lawyerUI);
        }

        private void DisplayEmployeeInformation(LawyerUI lawyerUI)
        {
            pboxDetails.IconColor = Color.Black;

            // Attributter
            lblFullname.Text = lawyerUI.ToString();
            lblDetailsTitleValue.Text = lawyerUI.LawyerTitle;
            lblDetailsCityValue.Text = lawyerUI.City;
            lblDetailsPhoneValue.Text = $"+45{lawyerUI.PhoneNumber}";
            lblDetailsEmailValue.Text = lawyerUI.Email;

            // Specialer i listbox
            lboxSpecialties.DataSource = lawyerUI.LawyerSpecialities.Select(ls => ls.SpecialityName).ToList();

        }
    }
}
