﻿using BusinessLogic;
using BusinessLogic.Validation;
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

namespace UI.Toolbox
{
    public partial class LawyerCardEdit : UserControl
    {
        Color validFormat;
        Color invalidFormat;

        LawyerUI lawyerUI;
        LawyerTitleBL lawyerTitleBL;
        SpecialityBL specialityBL;
        PersonValidator pValidator;
        List<LawyerTitleUI> lawyerTitles;
        List<SpecialityUI> specialities;
        public LawyerCardEdit(LawyerUI lawyerUI)
        {
            this.lawyerUI = lawyerUI;
            lawyerTitleBL = new LawyerTitleBL();
            specialityBL = new SpecialityBL();
            pValidator = new PersonValidator();

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            InitializeComponent();

            DisplayInformationLawyer(lawyerUI);

            txtFirstname.TextChanged += TxtFirstname_TextChanged;
            txtLastname.TextChanged += TxtLastname_TextChanged;
            txtPhone.TextChanged += TxtPhone_TextChanged;
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

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DisplayInformationLawyer(LawyerUI lawyerUI)
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
                FillTitleComboBox();
                FillSpecialityComboBox();
                UpdateLabelCount();
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

        private async Task FillTitleComboBox()
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
            btnUpdateEnabled();
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            txtAddress.ForeColor = pValidator.ValidAddress(txtAddress.Text) ? validFormat : invalidFormat;
            btnUpdateEnabled();
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
                    txtCity.ForeColor != invalidFormat &&
                    lboxSpecialities.Items.Count > 0 &&
                    cboxTitles.SelectedItem != null;
        }
    }
}