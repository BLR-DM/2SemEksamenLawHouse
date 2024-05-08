using BusinessLogic;
using UI.Toolbox;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class EmployeesView : Form
    {
        LawyerBL lawyerBL;
        SpecialityBL specialityBL;
        List<LawyerUI> lawyerUIs;
        List<LawyerSpecialityUI> lawyerSpecialityUIs;
        public EmployeesView()
        {
            specialityBL = new SpecialityBL();
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();
            lawyerSpecialityUIs = new List<LawyerSpecialityUI>();

            InitializeComponent();

            Load += EmployeesView_Load;
        }        

        private async void EmployeesView_Load(object? sender, EventArgs e)
        {
            await GetLawyerUIsAsync();
            await GetSpecialityUIsAsync();
            FilterAndDisplayLawyers();
            if (lawyerSpecialityUIs.Count > 0)
            {
                lblSpecialties.Text = string.Join(", ", lawyerSpecialityUIs
                    .Select(s => s.SpecialityName)
                    .Distinct());
            }
        }

        private async Task GetLawyerUIsAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersAsync();
        }

        private async Task GetSpecialityUIsAsync()
        {
            lawyerSpecialityUIs = await specialityBL.GetLawyerSpecialitiesAsync();
        }

        private void FilterAndDisplayLawyers()
        {
            foreach (LawyerUI lawyer in lawyerUIs)
            {
                LawyerCard lawyerCard = new LawyerCard(lawyer);
                

                lawyerCard.Click += LawyerCard_Click;

                foreach (Control control in lawyerCard.Controls)
                {
                    control.Click += (sender, e) => LawyerCard_Click(lawyerCard, e);
                }
                lawyerCard.Margin = new Padding(23);
                flpnlLawyers.Controls.Add(lawyerCard);
            }
        }

        private void LawyerCard_Click(object? sender, EventArgs e)
        {
            LawyerCard control = (LawyerCard)sender;
            

            if (control != null)
            {
                tboxSelected.Text = string.Join(" ", control.Firstname, control.Lastname);
                lblSpeciality.Text = string.Join(", ", lawyerSpecialityUIs.Select(x => x.LawyerID == control.LawyerID));
            }
        }       

    }
}
