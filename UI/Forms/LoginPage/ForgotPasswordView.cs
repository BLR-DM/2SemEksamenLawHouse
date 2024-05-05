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
using UIModels;


namespace UI.Forms.LoginPage
{
    public partial class ForgotPasswordView : Form
    {
        LoginBL loginBL;
        public ForgotPasswordView(LoginBL loginBL)
        {
            this.loginBL = loginBL;

            InitializeComponent();

            lblCancel.MouseHover += LblCancel_MouseHover;
            lblCancel.MouseLeave += LblCancel_MouseLeave;
            lblCancel.Click += LblCancel_Click;
            btnRetrievePassword.Click += BtnRetrievePassword_Click;
        }

        private async void BtnRetrievePassword_Click(object? sender, EventArgs e)
        {
            // Valider først email format
            btnRetrievePassword.Enabled = false;
            MessageBox.Show("A link to reset your password has been sent to" +
                " your email. Please check your email to complete the process.",
                "Email Sent");

            bool validEmail = await loginBL.CheckUsernameAsync(txtEmail.Text);

            if (validEmail)
            {
                DialogResult result = MessageBox.Show("Would you like to display your" +
                " password?", "Show Password", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string password = await loginBL.RetrievePasswordAsync(txtEmail.Text);
                    MessageBox.Show($"Your password is: {password}");
                }
            }
            btnRetrievePassword.Enabled = true;
        }

        private void LblCancel_MouseHover(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Underline);
        }

        private void LblCancel_MouseLeave(object? sender, EventArgs e)
        {
            lblCancel.Font = new Font(lblCancel.Font, FontStyle.Regular);
        }

        private void LblCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
