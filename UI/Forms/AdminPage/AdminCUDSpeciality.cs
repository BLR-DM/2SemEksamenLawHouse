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
    public partial class AdminCUDSpeciality : Form
    {
        SpecialityBL specialityBL;
        public AdminCUDSpeciality()
        {
            specialityBL = new SpecialityBL();
            InitializeComponent();

            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            btnCreate.Click += BtnCreate_Click;
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            SpecialityUI specialitUI = new SpecialityUI()
            {
                SpecialityName = txtSpeciality.Text
            };

            bool result = await specialityBL.CreateSpecialityAsync(specialitUI);

            if (result)
            {
                MessageBox.Show($"Speciality \"{specialitUI.SpecialityName}\" was created!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        SpecialityUI selectedSpeciality;
        public AdminCUDSpeciality(SpecialityUI specialitUI)
        {
            selectedSpeciality = specialitUI;

            specialityBL = new SpecialityBL();

            InitializeComponent();
            btnCreate.Visible = false;
            btnUpdate.Enabled = false;
            txtSpeciality.Text = specialitUI.SpecialityName;

            txtSpeciality.TextChanged += TxtSpeciality_TextChanged;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to update the speciality to: " +
                $"{txtSpeciality.Text}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                selectedSpeciality.SpecialityName = txtSpeciality.Text;

                bool result = await specialityBL.UpdateSpecialityAsync(selectedSpeciality);

                if (result)
                {
                    MessageBox.Show($"Speciality has been updated to: \"{selectedSpeciality.SpecialityName}\"!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to delete \"{selectedSpeciality.SpecialityName}\"?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                bool result = await specialityBL.DeleteSpecialityAsync(selectedSpeciality);

                if (result)
                {
                    MessageBox.Show($"\"{selectedSpeciality.SpecialityName}\" was succesfully deleted from the system!", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Could not delete the speciality!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSpeciality_TextChanged(object? sender, EventArgs e)
        {
            btnUpdate.Enabled = txtSpeciality.Text != selectedSpeciality.SpecialityName &&
                !string.IsNullOrEmpty(txtSpeciality.Text);
        }
    }
}
