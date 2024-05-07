using System.Windows.Forms;
using UIModels;

namespace UI.Toolbox
{
    public partial class LawyerCard : UserControl
    {
        public LawyerCard(LawyerUI lawyer)
        {
            InitializeComponent();
            SetDetails(lawyer);
        }

        private void SetDetails(LawyerUI lawyer)
        {
            lblName.Text = $"{lawyer.Firstname} {lawyer.Lastname}";
            lblDetails.Text = $"{lawyer.LawyerTitle} • {lawyer.City}";
            lblPhoneNumber.Text = $"+45{lawyer.PhoneNumber}";
        }
    }
}
