﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Self_Service;
using UIModels;

namespace UI.Forms.ClientPage
{
    public partial class ClientDetails : Form
    {
        ClientBL clientBL;
        FormBL formBL;
        ClientUI client;
        List<PhoneUI> phoneNumbers;
        List<PhoneUI> deletedNumbers;
        List<FormUI> boughtForms;
        public ClientDetails(ClientUI client)
        {
            InitializeComponent();
            this.client = client;
            formBL = new FormBL();
            clientBL = new ClientBL();
            deletedNumbers = new List<PhoneUI>();

            //Events
            btnUpdate.Click += BtnUpdate_ClickAsync;
            btnAddPhone.Click += BtnAddPhone_Click;
            btnDeletePhone.Click += BtnDeletePhone_Click;
            dgvBoughtForms.CellDoubleClick += DgvBoughtForms_CellDoubleClick;

            SetDetails(client);
            SetBoughtFormsDGVAsync();
        }

        private void DgvBoughtForms_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FormUI selectedForm = boughtForms[e.RowIndex];
                FormDetails fdBought = new FormDetails(selectedForm, client);
                fdBought.ShowDialog();
            }
        }

        private void BtnDeletePhone_Click(object? sender, EventArgs e)
        {

            //sletter det valgte telefonummer og tilføjer til deletedphones
            if (dgvPhoneNumbers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhoneNumbers.SelectedRows[0];
                PhoneUI selectedPhone = selectedRow.DataBoundItem as PhoneUI;

                phoneNumbers.Remove(selectedPhone);
                deletedNumbers.Add(selectedPhone);

                SetPhoneDetails();
            }
        }

        private void BtnAddPhone_Click(object? sender, EventArgs e)
        {
            PhoneUI tempP = new PhoneUI()
            {
                PhoneNumber = int.Parse(txtAddPhone.Text),
            };
            phoneNumbers.Add(tempP);
            txtAddPhone.Clear();
            SetPhoneDetails();
        }

        private async void BtnUpdate_ClickAsync(object? sender, EventArgs e)
        {
            bool numberDeleted = true;
            bool clientUpdated;
            btnUpdate.Enabled = false;
            ClientUI tempC = new ClientUI()
            {
                PersonID = client.PersonID,
                Firstname = txtFirstname.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                AddressLine = txtAddress.Text,
                PostalCode = int.Parse(txtPostal.Text),
                City = lblCity.Text,
                ClientSub = client.ClientSub,
                LoginDetailsID = client.LoginDetailsID,
            };

            clientUpdated = await clientBL.UpdateClientAsync(tempC, phoneNumbers);
            List<PhoneUI> newNumbers = phoneNumbers.Where(p => p.ClientID == 0).ToList();
            if(newNumbers.Count > 0)
            {
                phoneNumbers = await clientBL.GetClientPhonesAsync(client.PersonID);
            }

            if (deletedNumbers.Count > 0)
            {
                numberDeleted = await clientBL.DeletePhoneNumbersAsync(deletedNumbers);
            }

            if (clientUpdated && numberDeleted)
            {
                lblSuccess.ForeColor = Color.Green;
                lblSuccess.Text = "Saved";
            }
            else
            {
                lblSuccess.ForeColor = Color.Red;
                lblSuccess.Text = "Save Failed";
            }
            deletedNumbers = new List<PhoneUI>();
            btnUpdate.Enabled = true;

        }

        private async void SetDetails(ClientUI client)
        {

            txtFirstname.Text = client.Firstname;
            txtLastname.Text = client.Lastname;
            txtEmail.Text = client.Email;
            txtAddress.Text = client.AddressLine;
            txtPostal.Text = client.PostalCode.ToString();
            lblCity.Text = client.City;
            if (client.ClientSub == 0) { lblSubscribed.Text = "No"; }
            else if (client.ClientSub == 1) { lblSubscribed.Text = "Yes"; }
            else { lblSubscribed.Text = "Undefined"; }

            await SetPhoneDetails();
        }

        public async Task SetBoughtFormsDGVAsync()
        {
            boughtForms = await formBL.GetBoughtFormsAsync(client.PersonID);
            dgvBoughtForms.DataSource = boughtForms;
            dgvBoughtForms.Columns["FormID"].Visible = false;
            dgvBoughtForms.Columns["Description"].Visible = false;
            dgvBoughtForms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBoughtForms.ReadOnly = true;
            dgvBoughtForms.RowHeadersVisible = false;
            dgvBoughtForms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task SetPhoneDetails()
        {
            dgvPhoneNumbers.DataSource = null;
            if (phoneNumbers == null)
            {
                phoneNumbers = await clientBL.GetClientPhonesAsync(client.PersonID);
            }

            dgvPhoneNumbers.DataSource = phoneNumbers;
            dgvPhoneNumbers.Columns["PhoneID"].Visible = false;
            dgvPhoneNumbers.Columns["ClientID"].Visible = false;
            dgvPhoneNumbers.ColumnHeadersVisible = false;
            dgvPhoneNumbers.RowHeadersVisible = false;
            dgvPhoneNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
