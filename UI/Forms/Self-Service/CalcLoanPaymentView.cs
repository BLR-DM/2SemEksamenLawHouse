﻿using Calculations;
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
    public partial class CalcLoanPaymentView : Form
    {
        OverallValidator oaValidator;
        ClientUI client;
        Color validFormat;
        Color invalidFormat;
        public CalcLoanPaymentView(ClientUI client)
        {
            InitializeComponent();
            oaValidator = new OverallValidator();
            this.client = client;


            validFormat = Color.Black;
            invalidFormat = Color.OrangeRed;

            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            Load += CalcLoanPaymentView_Load;
            lblHelp.Click += LblHelp_Click;

            txtLoanAmount.TextChanged += TxtLoanAmount_TextChanged;
            txtAnnualInterestRate.TextChanged += TxtAnnualInterestRate_TextChanged;
            txtPaymentsPrYear.TextChanged += TxtPaymentsPrYear_TextChanged;
            txtAmountOfYears.TextChanged += TxtAmountOfYears_TextChanged;
        }

        private void LblHelp_Click(object? sender, EventArgs e)
        {
            OpenPDF.ShowPDF("CalculatePaymentOnLoanHelp");
        }

        private void CalcLoanPaymentView_Load(object? sender, EventArgs e)
        {
            lblAmountPrPayment.Text = string.Empty;
            lblTotalPrYear.Text = string.Empty;
            btnCalculate.Enabled = false;
            lblTotalAmountPaid.Text = string.Empty;
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            
            if (client.IsSubscribed)
            {
                //lånets størrelse
                double loanAmount = double.Parse(txtLoanAmount.Text);
                //rentefod p.a
                double interestRate = double.Parse(txtAnnualInterestRate.Text) / 100;
                //antal aar
                double amountOfYears = double.Parse(txtAmountOfYears.Text);
                //antal ydelser pr aar
                double paymentsPrYear = double.Parse(txtPaymentsPrYear.Text);

                //kalder beregner med inputs
                (double totalPrYear, double amountPrPayment, double totalAmountPaid) result = LoanPaymentCalculator
                    .CalcLoanPayment(loanAmount, interestRate, amountOfYears, paymentsPrYear);

                //udskriver total betaling pr aar i kroner
                lblTotalPrYear.Text = result.totalPrYear.ToString("C", new CultureInfo("da-DK"));

                //udskriver beløb pr betaling i kroner
                lblAmountPrPayment.Text = result.amountPrPayment.ToString("C", new CultureInfo("da-DK"));

                //udskriver total belob betalt nar lan er betalt ud
                lblTotalAmountPaid.Text = result.totalAmountPaid.ToString("C", new CultureInfo("da-DK"));


            }
            else
            {
                MessageBox.Show("You must be subscribed to use calculations");
            }
        }

        //tester på inputs og enabler calc knap
        private void BtnCalculateEnabled()
        {
            btnCalculate.Enabled =
                txtLoanAmount.ForeColor == validFormat &&
                txtAmountOfYears.ForeColor == validFormat &&
                txtAnnualInterestRate.ForeColor == validFormat &&
                txtPaymentsPrYear.ForeColor == validFormat
                ? true : false;
        }

        //sletter txt fra alle txtfelter
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtLoanAmount.Text = string.Empty;
            txtAnnualInterestRate.Text = string.Empty;
            txtPaymentsPrYear.Text = string.Empty;
            txtAmountOfYears.Text = string.Empty;

            lblAmountPrPayment.Text = string.Empty;
            lblTotalPrYear.Text = string.Empty;
            lblTotalAmountPaid.Text = string.Empty;
        }

        //validere inputs
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
    }
}
