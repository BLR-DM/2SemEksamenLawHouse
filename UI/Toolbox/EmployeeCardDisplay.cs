using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using UIModels;

namespace UI.Toolbox
{
    public partial class EmployeeCardDisplay : UserControl
    {
        public EmployeeCardDisplay(EmployeeUI employeeUI)
        {
            InitializeComponent();
            DisplayEmployeeInformation(employeeUI);
        }

        private void DisplayEmployeeInformation(EmployeeUI employeeUI)
        {
            if (employeeUI != null)
            {
                switch (employeeUI)
                {
                    case LawyerUI lawyerUI:
                        InitializePropertiesLawyer(lawyerUI);
                        break;
                    case SecretaryUI secretaryUI:
                        InitializePropertiesSecretary(secretaryUI);
                        break;
                    default:
                        throw new ArgumentException("Unsupported employee type");
                } 
            }
        }

        private void InitializePropertiesLawyer(LawyerUI lawyerUI)
        {
            pboxDetails.IconColor = Color.Black;
            //pboxDetails.IconChar = lawyerUI.PersonID == 5 ? FontAwesome.Sharp.IconChar.PiedPiperAlt : FontAwesome.Sharp.IconChar.PersonMilitaryPointing;

            // Attributter
            lblFullname.Text = string.Join(" ", lawyerUI.Firstname, lawyerUI.Lastname);
            lblDetailsTitleValue.Text = lawyerUI.LawyerTitle;
            lblDetailsCityValue.Text = lawyerUI.City;
            lblDetailsPhoneValue.Text = $"+45{lawyerUI.PhoneNumber}";
            lblDetailsEmailValue.Text = lawyerUI.Email;

            // Specialer i listbox
            lboxSpecialties.DataSource = lawyerUI.LawyerSpecialities.Select(ls => ls.SpecialityName).ToList();
        }

        private void InitializePropertiesSecretary(SecretaryUI secretaryUI)
        {
            pboxDetails.IconColor = Color.Black;

            // Attributter
            lblFullname.Text = string.Join(" ", secretaryUI.Firstname, secretaryUI.Lastname);
            lblDetailsTitleValue.Text = secretaryUI.LawyerTitle;
            lblDetailsCityValue.Text = secretaryUI.City;
            lblDetailsPhoneValue.Text = $"+45{secretaryUI.PhoneNumber}";
            lblDetailsEmailValue.Text = secretaryUI.Email;
        }
    }
}
