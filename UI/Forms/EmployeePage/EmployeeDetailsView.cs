using BusinessLogic;
using UIModels;
using UI.Toolbox;
using BusinessLogic.HelpServices;

namespace UI.Forms.EmployeePage
{
    public partial class EmployeeDetailsView : Form
    {
        EmployeeBL employeeBL;
        EmployeeUI displayedEmployee;

        int employeeID;
        bool isAdmin;
        string pdfName;
        public EmployeeDetailsView(int employeeID, bool isMyPage, EmployeeUI currentUser)
        {
            employeeBL = new EmployeeBL();
            this.employeeID = employeeID;

            if (currentUser is LawyerUI lawyerUI)
            {
                isAdmin = lawyerUI.Admin;
            }

            InitializeComponent();

            btnCancel.Visible = false;
            pnlEdit.Visible = false;

            Load += EmployeeDetailsView_Load;
            btnEditDetails.Click += BtnEditDetails_Click;
            btnCancel.Click += BtnCancel_Click;
            pnlEdit.VisibleChanged += PnlEdit_VisibleChanged;
            lblHelp.Click += LblHelp_Click;
            
            CheckUser(isMyPage); // Tjek om formen åbnes i "MyPage" eller andre steder
            
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            if (!OpenPDF.ShowPDF("MyPageEmployeeViewHelp"))
                MessageBox.Show("Could not open pdf");
        }

        private async void EmployeeDetailsView_Load(object? sender, EventArgs e)
        {
            await SetupView(employeeID); // Hent og vis ansat
        }

        private void PnlEdit_VisibleChanged(object? sender, EventArgs e)
        {
            if (!pnlEdit.Visible)
            {
                btnCancel.Visible = false;
                btnEditDetails.Enabled = true;
            }
            else
                btnCancel.Visible = true;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        public async Task SetupView(int id)
        {
            displayedEmployee = await employeeBL.GetEmployeeAsync(id);

            if (displayedEmployee != null)
            {
                // Brug EmployeeCardDisplay user-control med hentet ansat
                pnlEmployeeDetails.Controls.Clear();
                pnlEmployeeDetails.Controls.Add(new EmployeeCardDisplay(displayedEmployee));
                btnEditDetails.Enabled = true;
            }
        }

        private void BtnEditDetails_Click(object? sender, EventArgs e)
        {
            // Åbn EmployeeCardEdit user-control for at redigere oplysninger
            btnEditDetails.Enabled = false;
            pnlEdit.Controls.Clear();
            pnlEdit.Controls.Add(new EmployeeCardEdit(this, displayedEmployee, isAdmin));
            pnlEdit.Visible = true;
        }


        private void CheckUser(bool isMyPage)
        {
            // Hvis formen ikke åbnes i "MyPage", tilføj Sizeable så den kan lukkes
            if (!isMyPage)
            {
                //btnEditDetails.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.StartPosition = FormStartPosition.CenterScreen;
                lblHelp.Location = new Point(260, 545);
                this.Size = new Size(350, 613); // Skjul unødvendig tom plads
            }
            // Gør ændring af oplysninger muligt, hvis det er "MyPage" eller admin
            btnEditDetails.Visible = isMyPage || isAdmin;

            pdfName = "MyPageEmployeeViewHelp";
        }
    }
}
