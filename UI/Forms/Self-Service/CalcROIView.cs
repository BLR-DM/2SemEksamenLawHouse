using BusinessLogic.Calculations;
using BusinessLogic.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UI.Forms.Self_Service
{
    public partial class CalcROIView : Form
    {
        OverallValidator oaValidator;
        ClientUI client;
        Color validFormat;
        Color invalidFormat;
        ROICalculator rOICalculator;

        public CalcROIView(OverallValidator oaValidator, ClientUI client)
        {
            InitializeComponent();

            this.oaValidator = oaValidator;
            this.client = client;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            rOICalculator = new ROICalculator();

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            Load += CalcROIView_Load;

            txtInvestment.TextChanged += TxtInvestment_TextChanged;
            txtInterestRate.TextChanged += TxtInterestRate_TextChanged;
            txtAmountOfYears.TextChanged += TxtAmountOfYears_TextChanged;
        }


        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            if (client.IsSubscribed)
            {
                //invistering
                double investment = double.Parse(txtInvestment.Text);
                //rentefod p.a
                double interestRate = double.Parse(txtInterestRate.Text) / 100;
                //antal aar
                double amountOfYears = double.Parse(txtAmountOfYears.Text);

                ROICalculator result = rOICalculator.CalcROI(investment, interestRate, amountOfYears);
                //udskriver total betaling pr aar i kroner
                lblReturnOnInvestment.Text = result.ReturnOnInvestment.ToString("C", new CultureInfo("da-DK"));

            }
            else
            {
                MessageBox.Show("You must be subscribed to use calculations");
            }
        }

        private void CalcROIView_Load(object? sender, EventArgs e)
        {
            lblReturnOnInvestment.Text = string.Empty;
            btnCalculate.Enabled = false;
        }

        private void BtnCalculateEnabled()
        {
            btnCalculate.Enabled =
                txtInvestment.ForeColor == validFormat &&
                txtAmountOfYears.ForeColor == validFormat &&
                txtInterestRate.ForeColor == validFormat
                ? true : false;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtInvestment.Text = string.Empty;
            txtInterestRate.Text = string.Empty;
            txtAmountOfYears.Text = string.Empty;
            lblReturnOnInvestment.Text = string.Empty;
        }

        private void TxtAmountOfYears_TextChanged(object? sender, EventArgs e)
        {
            txtAmountOfYears.ForeColor = oaValidator.ValidDigit(txtAmountOfYears.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void TxtInterestRate_TextChanged(object? sender, EventArgs e)
        {
            txtInterestRate.ForeColor = oaValidator.ValidDigit(txtInterestRate.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void TxtInvestment_TextChanged(object? sender, EventArgs e)
        {
            txtInvestment.ForeColor = oaValidator.ValidDigit(txtInvestment.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }
    }
}
