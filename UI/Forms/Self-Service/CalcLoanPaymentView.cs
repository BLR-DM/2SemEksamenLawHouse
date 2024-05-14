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

namespace UI.Forms.Self_Service
{
    public partial class CalcLoanPaymentView : Form
    {
        OverallValidator oaValidator;
        Color validFormat;
        Color invalidFormat;
        public CalcLoanPaymentView(OverallValidator oaValidator)
        {
            InitializeComponent();
            this.oaValidator = oaValidator;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            Load += CalcLoanPaymentView_Load;

            txtLoanAmount.TextChanged += TxtLoanAmount_TextChanged;
            txtAnnualInterestRate.TextChanged += TxtAnnualInterestRate_TextChanged;
            txtPaymentsPrYear.TextChanged += TxtPaymentsPrYear_TextChanged;
            txtAmountOfYears.TextChanged += TxtAmountOfYears_TextChanged;
        }

        private void TxtAmountOfYears_TextChanged(object? sender, EventArgs e)
        {
            txtAmountOfYears.ForeColor = oaValidator.ValidDigit(txtAmountOfYears.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void TxtPaymentsPrYear_TextChanged(object? sender, EventArgs e)
        {
            txtPaymentsPrYear.ForeColor = oaValidator.ValidDigit(txtPaymentsPrYear.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void TxtAnnualInterestRate_TextChanged(object? sender, EventArgs e)
        {
            txtAnnualInterestRate.ForeColor = oaValidator.ValidDigit(txtAnnualInterestRate.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void TxtLoanAmount_TextChanged(object? sender, EventArgs e)
        {
            txtLoanAmount.ForeColor = oaValidator.ValidDigit(txtLoanAmount.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void BtnCalculateEnabled()
        {
            btnCalculate.Enabled =
                txtLoanAmount.ForeColor == validFormat &&
                txtAmountOfYears.ForeColor == validFormat &&
                txtAnnualInterestRate.ForeColor == validFormat &&
                txtPaymentsPrYear.ForeColor == validFormat
                ? true : false;
        }

        private void CalcLoanPaymentView_Load(object? sender, EventArgs e)
        {
            lblAmountPrPayment.Text = string.Empty;
            lblPaymentPrYear.Text = string.Empty;

            btnCalculate.Enabled = false;
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {

            //lånets størrelse
            double loanAmount = double.Parse(txtLoanAmount.Text);
            //rentefod p.a
            double interestRate = double.Parse(txtAnnualInterestRate.Text)/100;
            //antal aar
            double amountOfYears = double.Parse(txtAmountOfYears.Text);

            //udregning at betaling pr aar
            double paymentPrYear = loanAmount * ((interestRate) / (1 - Math.Pow(1 + interestRate, -amountOfYears)));
            //afrunder svar til 2 decimaler
            double roundedPaymentPrYear = Math.Round(paymentPrYear, 2);
            //udskriver beløb i kroner
            lblPaymentPrYear.Text = roundedPaymentPrYear.ToString("C", new CultureInfo("da-DK"));


            //antal ydelser pr aar
            double paymentsPrYear = double.Parse(txtPaymentsPrYear.Text);
            //tager betaling pr aar og deler ud i antal ydelser pa aaret
            double prPayment = paymentPrYear / paymentsPrYear;
            //afrunde til 2 decimaler
            double roundedPrPayment = Math.Round(prPayment, 2);
            //udskriver beløb i kroner
            lblAmountPrPayment.Text = roundedPrPayment.ToString("C", new CultureInfo("da-DK"));
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtLoanAmount.Text = string.Empty;
            txtAnnualInterestRate.Text = string.Empty;
            txtPaymentsPrYear.Text = string.Empty;
            txtAmountOfYears.Text = string.Empty;

            lblAmountPrPayment.Text = string.Empty;
            lblPaymentPrYear.Text = string.Empty;
        }
    }
}
