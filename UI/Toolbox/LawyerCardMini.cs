using UIModels;

namespace UI.Toolbox
{
    public partial class LawyerCardMini : UserControl
    {
        LawyerUI lawyer;
        public LawyerCardMini(LawyerUI lawyer)
        {
            this.lawyer = lawyer;

            InitializeComponent();
            InitializePropertiesAndControls();
        }

        public string FirstName { get; set; }
        public int LawyerID { get; set; }
        public string City { get; set; }

        private void InitializePropertiesAndControls()
        {
            // Set attributter
            LawyerID = lawyer.PersonID;
            City = lawyer.City;
            FirstName = lawyer.Firstname;

            // Tilføj værdi til UI controls
            lblName.Text = lawyer.ToString();
            lblTitle.Text = lawyer.LawyerTitle;
            lblPhoneNumber.Text = $"+45{lawyer.PhoneNumber}";
        }
    }
}