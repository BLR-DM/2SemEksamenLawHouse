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
            pboxDetails.IconColor = Color.Black;

            // Attributter
            lblFullname.Text = $"{employeeUI.Firstname} {employeeUI.Lastname}";
            lblDetailsTitleValue.Text = employeeUI.LawyerTitle;
            lblAddressValue.Text = employeeUI.AddressLine;
            lblPostalCodeValue.Text = employeeUI.PostalCode.ToString();
            lblDetailsCityValue.Text = employeeUI.City;
            lblDetailsPhoneValue.Text = $"+45{employeeUI.PhoneNumber}";
            lblDetailsEmailValue.Text = employeeUI.Email;
            lblHireDateValue.Text = employeeUI.HireDate.ToString("d");
        }
    }
}
