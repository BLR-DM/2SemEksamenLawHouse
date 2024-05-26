using UIModels;
using BusinessLogic;
using UI.Toolbox;
using UI.Forms.CasePage;
using BusinessLogic.HelpServices;

namespace UI.Forms.EmployeePage
{
    public partial class LawyerDetailsView : Form
    {
        // Denne form kan betragtes som en slags Dashboard, eller en oversigt over advokatens
        // arbejdsopgaver og redigering af advokatoplsyninger
        LawyerBL lawyerBL;
        LawyerUI displayedLawyerUI;
        int lawyerID; // ID af den viste advokat
        bool isMyPage; // For at identificere om formen åbnes i "MyPage" eller andre steder
        bool isAdmin; // Tjek om brugeren som åbner formen er Administrator

        public LawyerDetailsView(int lawyerID, bool isMyPage, EmployeeUI currentUser)
        {
            lawyerBL = new LawyerBL();

            this.lawyerID = lawyerID;
            this.isMyPage = isMyPage;

            // Da formen kan åbnes andre steder og af alle ansatte, tjekkes der for bruger type
            // Kun advokater kan være admin, tjekkes derfor først på om brugeren er advokat
            if (currentUser is LawyerUI lawyerUI)
            {
                isAdmin = lawyerUI.Admin;
            }

            InitializeComponent();

            pnlEdit.Visible = false;
            btnCancel.Visible = false;

            Load += LawyerDetailsView_Load;
            chboxServicesShowAll.CheckedChanged += ChboxClosed_CheckedChanged;
            chboxCasesShowAll.CheckedChanged += ChboxCasesShowAll_CheckedChanged;
            btnEditDetails.Click += BtnEditDetails_Click;
            pnlEdit.VisibleChanged += PnlEdit_VisibleChanged;
            btnCancel.Click += BtnCancel_Click;
            dgvCases.CellDoubleClick += DgvCases_CellDoubleClick;
            dgvServices.CellDoubleClick += DgvServices_CellDoubleClick;
            lblHelp.Click += LblHelp_Click;

            CheckUser();
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            if (isMyPage)
            {
                if (!OpenPDF.ShowPDF("MyPageLawyerHelp"));
                        MessageBox.Show("Could not open pdf"); 
            }
        }

        private void DgvServices_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Double-klik på sagsydelse åbner sagsdetaljer med medbringer nødvendige parametre
            if (e.RowIndex >= 0) // Ignorer header rækken
            {
                if (dgvServices.Rows[e.RowIndex].DataBoundItem is CaseServiceUI caseServiceUI)
                {
                    CaseDetailsView detailsView = new CaseDetailsView(caseServiceUI.CaseID, false, true);
                    detailsView.ShowDialog();
                }
            }
        }

        private void DgvCases_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Double-klik på sag åbner sagsdetaljer med medbringer nødvendige parametre
            if (e.RowIndex >= 0)
            {
                if (dgvCases.Rows[e.RowIndex].DataBoundItem is CaseUI caseUI)
                {
                    CaseDetailsView detailsView = new CaseDetailsView(caseUI.CaseID, false, true);
                    detailsView.ShowDialog();
                }
            }
        }
        private void CheckUser()
        {
            if (!isMyPage) // Hvis formen åbnes andre steder end "MyPage", aktiveres "Sizeable" så den kan evt. kan lukkes
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                StartPosition = FormStartPosition.CenterScreen;
            }
            // Gør det muligt at ændre på oplysninger, hvis brugeren og den viste bruger er ens eller admin
            btnEditDetails.Visible = isMyPage || isAdmin; 
        }
        private async void LawyerDetailsView_Load(object? sender, EventArgs e)
        {
            await SetupView(lawyerID);
        }

        public async Task SetupView(int id)
        {
            // Hent og hvis den advokat der skal vises i formen
            displayedLawyerUI = await lawyerBL.GetLawyerWithCollectionsAsync(id);

            chboxServicesShowAll.Checked = false; // Start med at vise åbne sagsydelser

            if (displayedLawyerUI != null)
            {
                DisplayLawyer(displayedLawyerUI);
                
                SetCasesDgv(chboxCasesShowAll.Checked);
                SetServicesDgv(chboxServicesShowAll.Checked);
                SetupDgvCases();
                SetupDgvCaseServices();
                SetDgvStyle();
            }
        }

        private void DisplayLawyer(LawyerUI lawyer)
        {
            // Tilføj hentede advokat til panel
            pnlLawyerDetails.Controls.Clear();
            // Her bruges en user-control "LawyerCardDisplay" for at standardisere opsætning 
            pnlLawyerDetails.Controls.Add(new LawyerCardDisplay(displayedLawyerUI));
        }

        private void BtnEditDetails_Click(object? sender, EventArgs e)
        {
            btnEditDetails.Enabled = false;

            pnlEdit.Controls.Clear();
            // En user-control til redigering af advokatoplysninger
            pnlEdit.Controls.Add(new LawyerCardEdit(this, displayedLawyerUI, isAdmin));
            pnlEdit.Visible = true;
        }

        private void SetCasesDgv(bool serviceShowAllCheck)
        {
            if (serviceShowAllCheck)
                dgvCases.DataSource = displayedLawyerUI.Cases; // Vis alle sager
            else
                dgvCases.DataSource = displayedLawyerUI.Cases // Vis kun åbne sager
                    .Where(c => c.Status == "Open")
                    .ToList();

            SetupDgvCases();
        }
        private void SetServicesDgv(bool serviceShowAllCheck)
        {
            if (serviceShowAllCheck)
                dgvServices.DataSource = displayedLawyerUI.CaseServices; // Vis alle sagsydelser
            else
                dgvServices.DataSource = displayedLawyerUI.CaseServices // Vis kun åbne sagsydelser
                    .Where(cs => cs.Status == "Open")
                    .ToList();

            SetupDgvCaseServices();
        }

        private void SetupDgvCases()
        {
            // Skjul ikke relevante kolonner
            dgvCases.Columns["LawyerID"].Visible =
            dgvCases.Columns["ClientID"].Visible =
            dgvCases.Columns["Lawyer"].Visible =
            dgvCases.Columns["Client"].Visible =
            dgvCases.Columns["CaseTypeID"].Visible =
            dgvCases.Columns["CaseType"].Visible =
            dgvCases.Columns["CaseServices"].Visible = false;

            dgvCases.Columns["CaseID"].DisplayIndex = 0;
            dgvCases.Columns["Title"].DisplayIndex = 1;
            dgvCases.Columns["Description"].DisplayIndex = 2;
            dgvCases.Columns["CreationDate"].DisplayIndex = 3;
            dgvCases.Columns["EndDate"].DisplayIndex = 4;
            dgvCases.Columns["EstimatedHours"].DisplayIndex = 5;
            dgvCases.Columns["TotalPrice"].DisplayIndex = 6;

        }

        private void SetupDgvCaseServices()
        {
            dgvServices.Columns["Description"].Visible =
            dgvServices.Columns["CaseID"].Visible =
            dgvServices.Columns["ServiceID"].Visible =
            dgvServices.Columns["LawyerID"].Visible =
            dgvServices.Columns["Service"].Visible =
            dgvServices.Columns["Lawyer"].Visible =
            dgvServices.Columns["ServiceEntries"].Visible =
            dgvServices.Columns["EndDate"].Visible = false;

            dgvServices.Columns["ServiceName"].DisplayIndex = 1;
            dgvServices.Columns["StartDate"].DisplayIndex = 2;
            dgvServices.Columns["PriceType"].DisplayIndex = 3;
            dgvServices.Columns["Units"].DisplayIndex = 4;
            dgvServices.Columns["HoursWorked"].DisplayIndex = 5;
            dgvServices.Columns["TotalPrice"].DisplayIndex = 6;
            dgvServices.Columns["Status"].DisplayIndex = 7;

        }

        private void SetDgvStyle()
        {
            // Gør det muligt ændre i DGV stil
            dgvCases.EnableHeadersVisualStyles = dgvServices.EnableHeadersVisualStyles = false;
            dgvCases.RowHeadersVisible = dgvServices.RowHeadersVisible = false;

            // Kolonne farve
            dgvCases.ColumnHeadersDefaultCellStyle.BackColor =
                dgvServices.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);

            // Kolonne farve efter valg af celle
            dgvCases.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                dgvServices.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            // Celle/række farve ved valg
            dgvCases.DefaultCellStyle.SelectionBackColor = dgvServices.
                DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);

            // Tekst-farve af valgte celler/række
            dgvCases.DefaultCellStyle.SelectionForeColor = dgvServices.
                DefaultCellStyle.SelectionForeColor = Color.Black;

            // Tilpas kolonne-bredde
            dgvCases.AutoSizeColumnsMode =
                dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Valg mode sat til række
            dgvCases.SelectionMode = dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void PnlEdit_VisibleChanged(object? sender, EventArgs e)
        {
            if (!pnlEdit.Visible)
            {
                btnCancel.Visible = false; // Skjul "Cancel" knappen, hvis redigering ikke er trykket
                btnEditDetails.Enabled = true;
            }
            else
                btnCancel.Visible = true;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void ChboxCasesShowAll_CheckedChanged(object? sender, EventArgs e)
        {
            SetCasesDgv(chboxCasesShowAll.Checked);
        }

        private void ChboxClosed_CheckedChanged(object? sender, EventArgs e)
        {
            SetServicesDgv(chboxServicesShowAll.Checked);
        }
    }
}
