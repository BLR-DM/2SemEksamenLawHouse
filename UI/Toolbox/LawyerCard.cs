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
        public string City { get; set; }

        private void InitializePropertiesAndControls()
        {
            // Set attributter
            LawyerID = lawyer.PersonID;
            City = lawyer.City;

            // Tilføj værdi til UI controls
            lblName.Text = $"{lawyer.Firstname} {lawyer.Lastname}";
            lblDetails.Text = $"{lawyer.LawyerTitle} • {lawyer.City}";
            lblPhoneNumber.Text = $"+45{lawyer.PhoneNumber}";
        }
    }
}