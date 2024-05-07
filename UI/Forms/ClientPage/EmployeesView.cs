using BusinessLogic;
using UI.Toolbox;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class EmployeesView : Form
    {
        LawyerBL lawyerBL;
        List<LawyerUI> lawyerUIs;
        public EmployeesView()
        {
            lawyerBL = new LawyerBL();
            lawyerUIs = new List<LawyerUI>();

            InitializeComponent();

            Load += EmployeesView_Load;
        }        

        private async void EmployeesView_Load(object? sender, EventArgs e)
        {
            await GetLawyerUIsAsync();
            FilterAndDisplayLawyers();
        }

        private async Task GetLawyerUIsAsync()
        {
            lawyerUIs = await lawyerBL.GetLawyersAsync();
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
                flpnlLawyers.Controls.Add(lawyerCard);
            }
        }

        private void LawyerCard_Click(object? sender, EventArgs e)
        {
            LawyerCard control = (LawyerCard)sender;

            if (control != null)
            {
                tboxSelected.Text = string.Join(" ", control.Firstname, control.Lastname);
            }
        }       

    }
}
