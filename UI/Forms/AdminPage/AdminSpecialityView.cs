using BusinessLogic;
using EntityModels;
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
                SpecialityUI selectedSpeciality = specialityUIs[e.RowIndex] as SpecialityUI;
                if (selectedSpeciality != null)
                {
                    new AdminCUDSpeciality(selectedSpeciality).ShowDialog();
                    //this.Close();
                }
            }
        }

        private async void AdminSpecialityView_Load(object? sender, EventArgs e)
        {
            await SetDgvTitles();
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
