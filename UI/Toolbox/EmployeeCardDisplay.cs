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
                if (employeeUI is LawyerUI lawyerUI)
                {
                    SetupDisplayLawyer(lawyerUI);
                }
                else
                {
                    SetupDisplayEmployee(employeeUI);
                }

                //switch (currentUser)
                //{
                //    case LawyerUI lawyerUI:
                //        SetupDisplayLawyer(lawyerUI);
                //        break;
                //    default:
                //        SetupDisplayEmployee(currentUser);
                //        break;
                //} 
            }
        }

        private void SetupDisplayLawyer(LawyerUI lawyerUI)
        {
            pboxDetails.IconColor = Color.Black;
            //pboxDetails.IconChar = lawyerUI.PersonID == 5 ? FontAwesome.Sharp.IconChar.PiedPiperAlt : FontAwesome.Sharp.IconChar.PersonMilitaryPointing;

            // Attributter
            lblFullname.Text = $"{lawyerUI.Firstname} {lawyerUI.Lastname}";
            lblDetailsTitleValue.Text = lawyerUI.LawyerTitle;
            lblDetailsCityValue.Text = lawyerUI.City;
            lblDetailsPhoneValue.Text = $"+45{lawyerUI.PhoneNumber}";
            lblDetailsEmailValue.Text = lawyerUI.Email;

            // Specialer i listbox
            lboxSpecialties.DataSource = lawyerUI.LawyerSpecialities.Select(ls => ls.SpecialityName).ToList();

            lblHireDate.Visible = false;
        }

        private void SetupDisplayEmployee(EmployeeUI employeeUI)
        {
            pboxDetails.IconColor = Color.Black;

            // Attributter
            lblFullname.Text = $"{employeeUI.Firstname} {employeeUI.Lastname}";
            lblDetailsTitleValue.Text = employeeUI.LawyerTitle;
            lblDetailsCityValue.Text = employeeUI.City;
            lblDetailsPhoneValue.Text = $"+45{employeeUI.PhoneNumber}";
            lblDetailsEmailValue.Text = employeeUI.Email;
            lblSpecialities.Text = "Hire Date:";
            lblHireDate.Text = employeeUI.HireDate.ToString("d");            
            
            lboxSpecialties.Visible = false;
        }
    }
}
