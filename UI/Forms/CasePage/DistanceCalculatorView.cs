﻿using BusinessLogic.API;
using BusinessLogic.Validation;
using UIModels;

namespace UI.Forms.CasePage
{
    public partial class DistanceCalculatorView : Form
    {
        DistanceMatrixBL distanceMatrixBL;
        CaseValidator cValidator;
        public event EventHandler<string> saveResult;
        public DistanceCalculatorView(CaseValidator caseValidator)
        {
            distanceMatrixBL = new DistanceMatrixBL();
            cValidator = caseValidator;

            InitializeComponent();

            btnSearch.Enabled = false;
            btnSave.Enabled = false;

            txtOrigin.TextChanged += TxtOrigin_TextChanged;
            txtDestination.TextChanged += TxtDestination_TextChanged;
            btnSearch.Click += BtnSearch_Click;
            btnSave.Click += BtnSave_Click;
            btnSearch.EnabledChanged += BtnSearch_EnabledChanged; ;

        }

        private void BtnSearch_EnabledChanged(object? sender, EventArgs e)
        {
            btnSave.Enabled = btnSearch.Enabled;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string saveDistance = txtResult.Text.Split(' ')[0];
            saveResult?.Invoke(this, saveDistance);
            this.Close();
        }

        private void TxtDestination_TextChanged(object? sender, EventArgs e)
        {
            txtDestination.ForeColor = cValidator.ValidAddress(txtDestination.Text) ? Color.Black : Color.OrangeRed;
            btnSearch.Enabled = txtDestination.ForeColor == Color.Black && txtOrigin.ForeColor == Color.Black;
        }

        private void TxtOrigin_TextChanged(object? sender, EventArgs e)
        {
            txtOrigin.ForeColor = cValidator.ValidAddress(txtOrigin.Text) ? Color.Black : Color.OrangeRed;
            btnSearch.Enabled = txtDestination.ForeColor == Color.Black && txtOrigin.ForeColor == Color.Black;
        }

        private async void BtnSearch_Click(object? sender, EventArgs e)
        {
            DistanceMatrix calcResult = new DistanceMatrix();

            calcResult = await distanceMatrixBL.GetDistance(txtOrigin.Text, txtDestination.Text);

            if (calcResult.rows[0].elements[0].status == "OK")
            {
                txtResult.Text = calcResult.rows[0].elements[0].distance.text;
            }
            else
            {
                MessageBox.Show("Couldn't find address", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;
            }
        }
        
    }
}