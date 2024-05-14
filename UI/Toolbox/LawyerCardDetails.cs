using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UI.Toolbox
{
    public partial class LawyerCardDetails : UserControl
    {
        LawyerUI lawyerUI;
        public LawyerCardDetails(LawyerUI lawyer)
        {
            this.lawyerUI = lawyer;
            InitializeComponent();
            InitializePropertiesAndControls();
        }

        private void InitializePropertiesAndControls()
        {
            if (lawyerUI != null)
            {
                pboxDetails.IconColor = Color.Black;
                pboxDetails.IconChar = lawyerUI.PersonID == 5 ? FontAwesome.Sharp.IconChar.PiedPiperAlt : FontAwesome.Sharp.IconChar.PersonMilitaryPointing;

                // Attributter
                lblFullname.Text = string.Join(" ", lawyerUI.Firstname, lawyerUI.Lastname);
                lblDetailsTitleValue.Text = lawyerUI.LawyerTitle;
                lblDetailsCityValue.Text = lawyerUI.City;
                lblDetailsPhoneValue.Text = "+45" + lawyerUI.PhoneNumber.ToString();
                lblDetailsEmailValue.Text = lawyerUI.Email;

                // Specialer i listbox
                lboxSpecialties.DataSource = lawyerUI.LawyerSpecialities.Select(ls => ls.SpecialityName).ToList();
            }
        }
    }
}
