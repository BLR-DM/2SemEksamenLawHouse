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


        public string Name { get; set; }

        private void SetDetails(LawyerUI lawyer)
        {
            lblName.Text = $"{lawyer.Firstname} {lawyer.Lastname}";
            lblDetails.Text = $"{lawyer.LawyerTitle} • {lawyer.City}";
            lblPhoneNumber.Text = $"+45{lawyer.PhoneNumber}";
            Name = lawyer.Firstname;
        }

        //private void Panel1_Paint(object? sender, PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.FromArgb(185, 209, 234), ButtonBorderStyle.Solid);
        //}

        //private void Panel1_Paint(object? sender, PaintEventArgs e)
        //{
        //    // Create a pen with the desired color and width
        //    using (Pen borderPen = new Pen(Color.FromArgb(185, 209, 234), 3))
        //    {
        //        // Draw a rectangle slightly inside to account for the pen width
        //        e.Graphics.DrawRectangle(borderPen, 0, 0, panel1.ClientSize.Width - 2, panel1.ClientSize.Height - 2);
        //    }
        //}
    }
}