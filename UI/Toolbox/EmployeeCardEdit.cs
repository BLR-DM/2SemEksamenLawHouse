using BusinessLogic;
using BusinessLogic.Validation;
using UI.Forms.EmployeePage;
using UIModels;

namespace UI.Toolbox
{
    public partial class EmployeeCardEdit : UserControl
    {
        Color validFormat;
        Color invalidFormat;

        EmployeeUI employee;
        bool isAdmin;

        EmployeeBL employeeBL;
        LawyerTitleBL lawyerTitleBL;
        List<LawyerTitleUI> lawyerTitles;
        PersonValidator pValidator;

        EmployeeDetailsView employeeDetailsForm;
        public EmployeeCardEdit(EmployeeDetailsView employeeDetailsForm,EmployeeUI employee, bool isAdmin)
        {
            employeeBL = new EmployeeBL();
            lawyerTitleBL = new LawyerTitleBL();
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            this.employee = employee;
            this.isAdmin = isAdmin;
            this.employeeDetailsForm = employeeDetailsForm;

            InitializeComponent();

            DisplayInformationEmployee();

            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtEmail.TextChanged += TxtEmail_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private async void BtnUpdate_Click(object? sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure, that you want to update the Employee details?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                btnUpdate.Enabled = false;

                employee.Firstname = txtFirstname.Text;
                employee.Lastname = txtLastname.Text;
                employee.PhoneNumber = int.Parse(txtPhone.Text);
                employee.Email = txtEmail.Text;
                employee.AddressLine = txtAddress.Text;
                employee.PostalCode = int.Parse(txtPostal.Text);
                employee.City = txtCity.Text;

                employee.LawyerTitleID = lawyerTitles.FirstOrDefault(lt => lt.Title == cboxTitles.SelectedItem).LawyerTitleID;

                bool result = await employeeBL.UpdateEmployeeAsync(employee);
                btnUpdate.Enabled = true;

                if (result)
                {
                    MessageBox.Show($"Employee details has been updated!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    employeeDetailsForm.SetupView(employee.PersonID);
                }
                else
                    MessageBox.Show("Failed to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInformationEmployee()
        {
            if (employee != null)
            {
                txtFirstname.Text = employee.Firstname;
                txtLastname.Text = employee.Lastname;

                txtPhone.Text = employee.PhoneNumber.ToString();
                txtEmail.Text = employee.Email;
                txtAddress.Text = employee.AddressLine;
                txtPostal.Text = employee.PostalCode.ToString();
                txtCity.Text = employee.City;

                FillTitleComboBoxAsync();

                if (!isAdmin)
                {
                    txtEmail.Enabled = false;
                    cboxTitles.Enabled = false;
                }
            }
        }

        private async Task FillTitleComboBoxAsync()
        {
            lawyerTitles = await lawyerTitleBL.GetLawyerTitles();

            foreach (LawyerTitleUI title in lawyerTitles)
            {
                cboxTitles.Items.Add(title.Title);
            }
            cboxTitles.SelectedItem = employee.LawyerTitle;
        }

        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
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
                    txtCity.ForeColor != invalidFormat;
        }
    }
}
