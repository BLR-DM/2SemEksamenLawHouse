using BusinessLogic;
using UIModels;

namespace UI.Forms.AdminPage
{
    public partial class AdminSpecialityView : Form
    {
        SpecialityBL specialityBL;
        List<SpecialityUI> specialityUIs;
        public AdminSpecialityView()
        {
            specialityBL = new SpecialityBL();

            InitializeComponent();

            Load += AdminSpecialityView_Load;
            dgvSpecialities.CellDoubleClick += DgvTitles_CellDoubleClick;
        }

        private void DgvTitles_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SpecialityUI selectedSpeciality = specialityUIs[e.RowIndex];
                if (selectedSpeciality != null)
                {
                    new AdminCUDSpeciality(selectedSpeciality).ShowDialog();
                }
            }
        }

        private async void AdminSpecialityView_Load(object? sender, EventArgs e)
        {
            await SetDgvTitles();
            SetDgvStyle();
        }

        private void SetDgvStyle()
        {
            dgvSpecialities.EnableHeadersVisualStyles = false;
            dgvSpecialities.RowHeadersVisible = false;
            dgvSpecialities.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvSpecialities.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvSpecialities.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvSpecialities.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSpecialities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSpecialities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async Task SetDgvTitles()
        {
            specialityUIs = await specialityBL.GetSpecialitiesAsync();
            if (specialityUIs != null)
            {
                dgvSpecialities.DataSource = specialityUIs;

                dgvSpecialities.Columns["SpecialityID"].Visible = false;

                dgvSpecialities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSpecialities.ReadOnly = true;
                dgvSpecialities.RowHeadersVisible = false;
                dgvSpecialities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
