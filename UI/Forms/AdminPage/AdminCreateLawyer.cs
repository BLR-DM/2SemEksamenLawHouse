﻿using BusinessLogic;
using BusinessLogic.Validation;
using UIModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.AdminPage
{
    public partial class AdminCreateLawyer : Form
    {
        Color validFormat;
        Color invalidFormat;
        LawyerBL lawyerBL;
        LawyerTitleBL lawyerTitleBL;
        SpecialityBL specialityBL;
        PersonValidator pValidator;

        List<LawyerTitleUI> lawyerTitles;
        List<SpecialityUI> specialities;

        List<LawyerSpecialityUI> lawyerSpecialityUIs;
        string emailDomain;

        public AdminCreateLawyer()
        {
            lawyerBL = new LawyerBL();
            lawyerTitleBL = new LawyerTitleBL();
            specialityBL = new SpecialityBL();
            pValidator = new PersonValidator();
            lawyerSpecialityUIs = new List<LawyerSpecialityUI>();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            emailDomain = "@lawhouse.com";

            InitializeComponent();

            Load += AdminCUDLawyer_Load;

            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
            txtAddress.TextChanged += TxtAddress_TextChanged;
            txtPostal.TextChanged += TxtPostal_TextChanged;
            txtCity.TextChanged += TxtCity_TextChanged;            
            dtpHireDate.ValueChanged += DtpHireDate_ValueChanged;
            btnToday.Click += BtnToday_Click;
            btnCreate.Click += BtnCreate_Click;
            cboxSpecialities.SelectionChangeCommitted += CboxSpecialities_SelectionChangeCommitted;
            lboxSpecialities.SelectedIndexChanged += LboxSpecialities_SelectedIndexChanged;
            btnAddSpeciality.Click += BtnAddSpeciality_Click;
            btnRemoveSpeciality.Click += BtnRemoveSpeciality_Click;
        }

        private void LboxSpecialities_SelectedIndexChanged(object? sender, EventArgs e)
        {
            btnRemoveSpeciality.Enabled = true;
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
            btnCreateEnabled();
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
            btnCreateEnabled();
        }

        private void CboxSpecialities_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            btnAddSpeciality.Enabled = true;
        }

        private async void AdminCUDLawyer_Load(object? sender, EventArgs e)
        {
            lblInvalidDate.Hide();
            btnCreate.Enabled = false;
            btnAddSpeciality.Enabled = false;
            btnRemoveSpeciality.Enabled = false;
            txtPassword.Text = "0000";
            

            await FillTitleComboBox();
            await FillSpecialityComboBox();
        }

        private async Task FillTitleComboBox()
        {
            lawyerTitles = await lawyerTitleBL.GetLawyerTitles();

            foreach (LawyerTitleUI title in lawyerTitles)
            {
                cboxTitles.Items.Add(title.Title);
            }
        }

        private async Task FillSpecialityComboBox()
        {
            specialities = await specialityBL.GetSpecialitiesAsync();

            foreach (SpecialityUI speciality in specialities)
            {
                cboxSpecialities.Items.Add(speciality.SpecialityName);
            }
        }

        private void SetEmail()
        {
            if (txtFirstname.ForeColor == validFormat &&
                txtLastname.ForeColor == validFormat &&
                txtPhone.ForeColor == validFormat)
            {
                string email =
                    ($"{txtFirstname.Text.Substring(0, 2)}" +
                    $"{txtLastname.Text.Substring(0, 2)}" +
                    $"{txtPhone.Text.Substring(0, 4)}" +
                    $"{emailDomain}").ToLower();

                if (pValidator.ValidEmail(email))
                {
                    txtEmail.Text = email;
                    txtEmailLogin.Text = txtEmail.Text;
                }
            }
            else
            {
                txtEmail.Text = string.Empty;
            }
            btnCreateEnabled();
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            btnCreate.Enabled = false;

            LawyerUI lawyerUI = new LawyerUI()
            {
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                PhoneNumber = int.Parse(txtPhone.Text),
                Email = txtEmailLogin.Text,
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = txtCity.Text,
                LawyerTitleID = lawyerTitles.FirstOrDefault(x => x.Title == cboxTitles.SelectedItem).LawyerTitleID,
                HireDate = dtpHireDate.Value
            };

            lawyerSpecialityUIs = new List<LawyerSpecialityUI>();

            foreach (string item in lboxSpecialities.Items)
            {
                LawyerSpecialityUI lawyerSpecialityUIs = new LawyerSpecialityUI()
                {
                    SpecialityID = specialities.FirstOrDefault(s => s.SpecialityName == item).SpecialityID,
                };
                this.lawyerSpecialityUIs.Add(lawyerSpecialityUIs);
            }

            LoginDetailsUI loginDetailsUI = new LoginDetailsUI()
            {
                Username = txtEmailLogin.Text,
                Password = txtPassword.Text,
                CreationDate = DateTime.Now,
            };


            bool test = await lawyerBL.CreateLawyerAsync(lawyerUI, lawyerSpecialityUIs, loginDetailsUI);
            btnCreate.Enabled = true;

            if (test)
                MessageBox.Show("Lawyer Created!");
            else
                MessageBox.Show("Failed!");
        }

        private void BtnToday_Click(object? sender, EventArgs e)
        {
            dtpHireDate.Value = DateTime.Now;
        }

        private void DtpHireDate_ValueChanged(object? sender, EventArgs e)
        {
            if (dtpHireDate.Value > DateTime.Now)
                lblInvalidDate.Show();
            else
                lblInvalidDate.Hide();
            btnCreateEnabled();
        }

        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            txtCity.ForeColor = pValidator.ValidName(txtCity.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtPostal_TextChanged(object? sender, EventArgs e)
        {
            txtPostal.ForeColor = pValidator.ValidPostalCode(txtPostal.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            btnCreateEnabled();
        }

        private void TxtPhone_TextChanged(object? sender, EventArgs e)
        {
            txtPhone.ForeColor = pValidator.ValidPhone(txtPhone.Text) ? validFormat : invalidFormat;
            SetEmail();
            btnCreateEnabled();
        }

        private void TxtLastname_TextChanged(object? sender, EventArgs e)
        {
            txtLastname.ForeColor = pValidator.ValidName(txtLastname.Text) ? validFormat : invalidFormat;
            SetEmail();
            btnCreateEnabled();
        }

        private void TxtFirstname_TextChanged(object? sender, EventArgs e)
        {
            txtFirstname.ForeColor = pValidator.ValidName(txtFirstname.Text) ? validFormat : invalidFormat;
            SetEmail();
            btnCreateEnabled();
        }

        private void btnCreateEnabled()
        {
            btnCreate.Enabled =
                    txtFirstname.ForeColor != invalidFormat &&
                    txtLastname.ForeColor != invalidFormat &&
                    txtAddress.ForeColor != invalidFormat &&
                    txtPostal.ForeColor != invalidFormat &&
                    txtPhone.ForeColor != invalidFormat &&
                    txtCity.ForeColor != invalidFormat &&
                    lboxSpecialities.Items.Count > 0 &&
                    cboxTitles.SelectedItem != null &&
                    lblInvalidDate.Visible == false;
        }
    }
}