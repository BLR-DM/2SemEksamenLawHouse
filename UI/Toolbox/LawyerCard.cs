using System.Windows.Forms;
using UIModels;

namespace UI.Toolbox
{
    public partial class LawyerCard : UserControl
    {
        LawyerUI lawyer;
        public LawyerCard(LawyerUI lawyer)
        {
            this.lawyer = lawyer;

            InitializeComponent();
            InitializePropertiesAndControls();
        }

        public int LawyerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        private void InitializePropertiesAndControls()
        {
            // Set attributter
            LawyerID = lawyer.PersonID;
            Firstname = lawyer.Firstname;
            Lastname = lawyer.Lastname;
            Title = lawyer.LawyerTitle;
            City = lawyer.City;
            Phone = lawyer.PhoneNumber;
            Email = lawyer.Email;
            this.Tag = LawyerID;

            // Tilføj værdi til UI controls
            lblName.Text = $"{lawyer.Firstname} {lawyer.Lastname}";
            lblDetails.Text = $"{lawyer.LawyerTitle} • {lawyer.City}";
            lblPhoneNumber.Text = $"+45{lawyer.PhoneNumber}";
        }
    }
}