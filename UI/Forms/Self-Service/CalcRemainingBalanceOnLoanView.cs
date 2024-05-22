using BusinessLogic.Validation;
using Calculations;
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
    public partial class CalcRemainingBalanceOnLoanView : Form
    {
        OverallValidator oaValidator;
        ClientUI client;
        Color validFormat;
        Color invalidFormat;

        public CalcRemainingBalanceOnLoanView(ClientUI client)
        {
            InitializeComponent();

            oaValidator = new OverallValidator();
            this.client = client;

            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;

            Load += CalcRemainingBalanceOnLoanView_Load;

            txtTotalLoanAmount.TextChanged += TxtTotalLoanAmount_TextChanged;
            txtAnnualInterestRate.TextChanged += TxtAnnualInterestRate_TextChanged;
            txtPaymentsPrYear.TextChanged += TxtPaymentsPrYear_TextChanged;
            txtTotalYears.TextChanged += TxtTotalYears_TextChanged;
            txtPaymentsMade.TextChanged += TxtPaymentsMade_TextChanged;
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {

            if (client.IsSubscribed)
            {
                //laanets totale størrelse
                double totalLoanAmount = double.Parse(txtTotalLoanAmount.Text);

                //rente pr aar
                double annualInterestRate = double.Parse(txtAnnualInterestRate.Text);

                //antal betalinger pr aar
                double paymentsPrYear = double.Parse(txtPaymentsPrYear.Text);

                //antal aar lånet forløber over
                double totalYears = double.Parse(txtTotalYears.Text);

                //antal betalinger lavet
                double paymentsMade = double.Parse(txtPaymentsMade.Text);

                (double RemainingBalance, double PaymentAmount) result = LoanPaymentCalculator
                    .CalcRemainingBalanceOnLoan(totalLoanAmount, annualInterestRate, paymentsPrYear, totalYears, paymentsMade);

                lblRemainingBalance.Text = result.RemainingBalance.ToString("C", new CultureInfo("da-DK"));
                lblAmountPrPayment.Text = result.PaymentAmount.ToString("C", new CultureInfo("da-DK")); 
            }
            else
            {
                MessageBox.Show("You must be subscribed to use calculations");
            }
        }

        private void CalcRemainingBalanceOnLoanView_Load(object? sender, EventArgs e)
        {
            lblRemainingBalance.Text = string.Empty;
            lblAmountPrPayment.Text = string.Empty;
            btnCalculate.Enabled = false;
        }
        
        private void BtnCalculateEnabled()
        {
            btnCalculate.Enabled =
                txtTotalLoanAmount.ForeColor == validFormat &&
                txtAnnualInterestRate.ForeColor == validFormat &&
                txtPaymentsPrYear.ForeColor == validFormat &&
                txtTotalYears.ForeColor == validFormat &&
                txtPaymentsMade.ForeColor == validFormat
                ? true : false;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtTotalLoanAmount.Text = string.Empty;
            txtAnnualInterestRate.Text = string.Empty;
            txtPaymentsPrYear.Text = string.Empty;
            txtTotalYears.Text = string.Empty;
            txtPaymentsMade.Text = string.Empty;

            lblRemainingBalance.Text = string.Empty;
            lblAmountPrPayment.Text = string.Empty;
        }

        private void TxtPaymentsMade_TextChanged(object? sender, EventArgs e)
        {
            txtPaymentsMade.ForeColor = oaValidator.ValidDigit(txtPaymentsMade.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }

        private void TxtTotalYears_TextChanged(object? sender, EventArgs e)
        {
            txtTotalYears.ForeColor = oaValidator.ValidDigit(txtTotalYears.Text) ? validFormat : invalidFormat;
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

        private void TxtTotalLoanAmount_TextChanged(object? sender, EventArgs e)
        {
            txtTotalLoanAmount.ForeColor = oaValidator.ValidDigit(txtTotalLoanAmount.Text) ? validFormat : invalidFormat;
            BtnCalculateEnabled();
        }


    }
}
