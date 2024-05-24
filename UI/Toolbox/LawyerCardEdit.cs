using BusinessLogic;
using BusinessLogic.HelpServices;
using BusinessLogic.Validation;
using EntityModels;
using System.Data;
using System.Windows.Navigation;
using UI.Forms.EmployeePage;
using UIModels;

namespace UI.Toolbox
{
    public partial class LawyerCardEdit : UserControl
    {
        Color validFormat;
        Color invalidFormat;

        LawyerUI lawyerUI;
        LawyerTitleBL lawyerTitleBL;
        LawyerBL lawyerBL;
        SpecialityBL specialityBL;
        PersonValidator pValidator;
        List<LawyerTitleUI> lawyerTitles;
        List<SpecialityUI> specialities;
        List<LawyerSpecialityUI> updatedLawyerSpecialities;

        LawyerDetailsView lawyerDetailsForm;

        bool isAdmin;
        public LawyerCardEdit(LawyerDetailsView lawyerDetailsForm, LawyerUI lawyerUI, bool isAdmin)
        {
            this.isAdmin = isAdmin;
            this.lawyerUI = lawyerUI;

            lawyerBL = new LawyerBL();
            lawyerTitleBL = new LawyerTitleBL();
            specialityBL = new SpecialityBL();
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            updatedLawyerSpecialities = new List<LawyerSpecialityUI>();

            this.lawyerDetailsForm = lawyerDetailsForm;

            InitializeComponent();

            DisplayInformationLawyer();

            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;
            btnUpdate.Click += BtnUpdate_Click;
            cboxSpecialities.SelectionChangeCommitted += CboxSpecialities_SelectionChangeCommitted;
            lboxSpecialities.SelectedIndexChanged += LboxSpecialities_SelectedIndexChanged;
            btnAddSpeciality.Click += BtnAddSpeciality_Click;
            btnRemoveSpeciality.Click += BtnRemoveSpeciality_Click;
        }

        private void BtnAddSpeciality_Click(object? sender, EventArgs e)
        {
            if (cboxSpecialities.SelectedItem != null)
            {
                lboxSpecialities.Items.Add(cboxSpecialities.SelectedItem);
                cboxSpecialities.Items.Remove(cboxSpecialities.SelectedItem);
                if (cboxSpecialities.Items.Count > 0)
                {
                    cboxSpecialities.SelectedIndex = cboxSpecialities.SelectedIndex + 1;
                }
                else btnAddSpeciality.Enabled = false;
            }
            btnUpdateEnabled();
            UpdateLabelCount();
        }

        private void BtnRemoveSpeciality_Click(object? sender, EventArgs e)
        {
            if (lboxSpecialities.SelectedItem != null)
            {
                cboxSpecialities.Items.Add(lboxSpecialities.SelectedItem);
                lboxSpecialities.Items.Remove(lboxSpecialities.SelectedItem);
                if (lboxSpecialities.Items.Count > 0)
                {
                    lboxSpecialities.SelectedIndex = lboxSpecialities.SelectedIndex + 1;
                }
                else btnRemoveSpeciality.Enabled = false;
            }
            btnUpdateEnabled();
            UpdateLabelCount();
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to update the Lawyer details?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                btnUpdate.Enabled = false;

                lawyerUI.Firstname = txtFirstname.Text;
                lawyerUI.Lastname = txtLastname.Text;
                lawyerUI.PhoneNumber = int.Parse(txtPhone.Text);
                lawyerUI.Email = txtEmail.Text;
                lawyerUI.AddressLine = txtAddress.Text;
                lawyerUI.PostalCode = int.Parse(txtPostal.Text);
                lawyerUI.City = txtCity.Text;

                lawyerUI.LawyerTitleID = lawyerTitles.FirstOrDefault(lt => lt.Title == cboxTitles.SelectedItem).LawyerTitleID;

                // if admin
                if (isAdmin)
                {
                    updatedLawyerSpecialities.Clear();
                    foreach (string lawyerSpeciality in lboxSpecialities.Items)
                    {
                        LawyerSpecialityUI lawyerSpecialityUI = new LawyerSpecialityUI()
                        {
                            LawyerID = lawyerUI.PersonID,
                            SpecialityID = specialities.FirstOrDefault(s => s.SpecialityName == lawyerSpeciality).SpecialityID
                        };
                        updatedLawyerSpecialities.Add(lawyerSpecialityUI);
                    }

                    bool deleted = await lawyerBL.DeleteLawyerSpecialitiesAsync(lawyerUI.LawyerSpecialities as List<LawyerSpecialityUI>);
                    if (!deleted)
                    {
                        MessageBox.Show("Failed to delete Lawyer Speciality!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bool added = await lawyerBL.UpdateLawyerSpecialitiesAsync(updatedLawyerSpecialities);
                    if (!added)
                    {
                        MessageBox.Show("Failed to add Lawyer Speciality!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                bool result = await lawyerBL.UpdateLawyerAsync(lawyerUI);
                btnUpdate.Enabled = true;

                if (result)
                {
                    MessageBox.Show($"Lawyer details has been updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await lawyerDetailsForm.SetupView(lawyerUI.PersonID);
                }
                else
                    MessageBox.Show("Failed to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DisplayInformationLawyer()
        {
            if (lawyerUI != null)
            {
                txtFirstname.Text = lawyerUI.Firstname;
                txtLastname.Text = lawyerUI.Lastname;
                
                txtPhone.Text = lawyerUI.PhoneNumber.ToString();
                txtEmail.Text = lawyerUI.Email;
                txtAddress.Text = lawyerUI.AddressLine;
                txtPostal.Text = lawyerUI.PostalCode.ToString();
                txtCity.Text = lawyerUI.City;

                FillSpecialityListBox();
                FillTitleComboBoxAsync();
                FillSpecialityComboBox();
                UpdateLabelCount();

                if (!isAdmin)
                {
                    txtEmail.Enabled = false;
                    btnAddSpeciality.Visible = false;
                    btnRemoveSpeciality.Visible = false;
                    cboxTitles.Enabled = false;
                    lboxSpecialities.Enabled = false;
                    cboxSpecialities.Enabled = false;
                }
            }            
        }

        private void UpdateLabelCount()
        {
            lblCount.Text = $"Count: {lboxSpecialities.Items.Count}";
        }

        private void FillSpecialityListBox()
        {
            foreach(LawyerSpecialityUI lawyerSpeciality in lawyerUI.LawyerSpecialities)
            {
                lboxSpecialities.Items.Add(lawyerSpeciality.SpecialityName);
            }
        }

        private async Task FillTitleComboBoxAsync()
        {
            lawyerTitles = await lawyerTitleBL.GetLawyerTitles();

            foreach (LawyerTitleUI title in lawyerTitles)
            {
                cboxTitles.Items.Add(title.Title);
            }
            cboxTitles.SelectedItem = lawyerUI.LawyerTitle;
        }
        private async Task FillSpecialityComboBox()
        {
            specialities = await specialityBL.GetSpecialitiesAsync();

            foreach (SpecialityUI speciality in specialities) //Where(x => x.SpecialityName != speciality.SpecialityName
            {
                if (!lawyerUI.LawyerSpecialities.Where(x => x.SpecialityID == speciality.SpecialityID).Any())
                {
                    cboxSpecialities.Items.Add(speciality.SpecialityName); 
                }
            }
        }
        private void CboxSpecialities_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            btnAddSpeciality.Enabled = true;
        }

        private void LboxSpecialities_SelectedIndexChanged(object? sender, EventArgs e)
        {
            btnRemoveSpeciality.Enabled = true;
        }

        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            txtCity.Text = GetCityFromPostalCode.SetCityFromPostalCode(txtPostal.Text);

            btnUpdateEnabled();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtEmail_TextChanged(object? sender, EventArgs e)
        {
            txtEmail.ForeColor = pValidator.ValidEmail(txtEmail.Text) ? validFormat : invalidFormat;
        }

        private void TxtPhone_TextChanged(object? sender, EventArgs e)
        {
            txtPhone.ForeColor = pValidator.ValidPhone(txtPhone.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void btnUpdateEnabled()
        {
            btnUpdate.Enabled =
                    txtFirstname.ForeColor != invalidFormat &&
                    txtLastname.ForeColor != invalidFormat &&
                    txtAddress.ForeColor != invalidFormat &&
                    txtPostal.ForeColor != invalidFormat &&
                    txtPhone.ForeColor != invalidFormat &&
                    txtEmail.ForeColor != invalidFormat &&
                    txtCity.ForeColor != invalidFormat &&
                    lboxSpecialities.Items.Count > 0 &&
                    cboxTitles.SelectedItem != null;
        }
    }
}
