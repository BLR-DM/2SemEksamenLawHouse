using Calculations;
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
using BusinessLogic.HelpServices;

namespace UI.Forms.Self_Service
{
    public partial class CalcROIView : Form
    {
        OverallValidator oaValidator;
        ClientUI client;
        Color validFormat;
        Color invalidFormat;

        public CalcROIView(ClientUI client)
        {
            InitializeComponent();

            oaValidator = new OverallValidator();
            this.client = client;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            Load += CalcROIView_Load;
            lblHelp.Click += LblHelp_Click;

            txtInvestment.TextChanged += TxtInvestment_TextChanged;
            txtInterestRate.TextChanged += TxtInterestRate_TextChanged;
            txtAmountOfYears.TextChanged += TxtAmountOfYears_TextChanged;
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("CalculateROIHelp");
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

                //kalder beregner med inputs
                double returnOfInvestment = ROICalculator.CalcROI(investment, interestRate, amountOfYears);

                //udskriver total betaling pr aar i kroner
                lblROIResult.Text = returnOfInvestment.ToString("C", new CultureInfo("da-DK"));
                // Udskriver overskud/underskud
                lblProfitResult.Text = (returnOfInvestment - investment).ToString("C", new CultureInfo("da-DK"));

            }
            else
            {
                MessageBox.Show("You must be subscribed to use calculations");
            }
        }

        private void CalcROIView_Load(object? sender, EventArgs e)
        {
            lblROIResult.Text = string.Empty;
            lblProfitResult.Text = string.Empty;
            btnCalculate.Enabled = false;
        }

        //validerer inputs og enabler/disabler knap
        private void BtnCalculateEnabled()
        {
            btnCalculate.Enabled =
                txtInvestment.ForeColor == validFormat &&
                txtAmountOfYears.ForeColor == validFormat &&
                txtInterestRate.ForeColor == validFormat
                ? true : false;
        }

        //slet tekst fra alle txtfelter
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtInvestment.Text = string.Empty;
            txtInterestRate.Text = string.Empty;
            txtAmountOfYears.Text = string.Empty;
            lblROIResult.Text = string.Empty;
            lblProfitResult.Text = string.Empty;
        }

        //validerer
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
