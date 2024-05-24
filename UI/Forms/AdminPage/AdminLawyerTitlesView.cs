using BusinessLogic;
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

namespace UI.Forms.AdminPage
{
    public partial class AdminLawyerTitlesView : Form
    {
        LawyerTitleBL lawyerTitleBL;
        List<LawyerTitleUI> lawyerTitleUIs;
        public AdminLawyerTitlesView()
        {
            lawyerTitleBL = new LawyerTitleBL();

            InitializeComponent();

            Load += AdminLawyerTitlesView_Load;
            dgvTitles.CellDoubleClick += DgvTitles_CellDoubleClick;
        }

        private void DgvTitles_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LawyerTitleUI selectedTitle = lawyerTitleUIs[e.RowIndex] as LawyerTitleUI;
                if (selectedTitle != null)
                {
                    new AdminCUDLawyerTitle(selectedTitle).ShowDialog();
                }
            }
        }

        private async void AdminLawyerTitlesView_Load(object? sender, EventArgs e)
        {
            await SetDgvTitles();
            SetDgvStyle();
        }
        private void SetDgvStyle()
        {
            dgvTitles.EnableHeadersVisualStyles = false;
            dgvTitles.RowHeadersVisible = false;
            dgvTitles.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 209, 234);
            dgvTitles.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvTitles.DefaultCellStyle.SelectionBackColor = Color.FromArgb(215, 228, 242);
            dgvTitles.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async Task SetDgvTitles()
        {
            lawyerTitleUIs = await lawyerTitleBL.GetLawyerTitles();
            if (lawyerTitleUIs != null)
            {
                dgvTitles.DataSource = lawyerTitleUIs; 

                dgvTitles.Columns["LawyerTitleID"].Visible = false;

                dgvTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTitles.ReadOnly = true;
                dgvTitles.RowHeadersVisible = false;
                dgvTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
