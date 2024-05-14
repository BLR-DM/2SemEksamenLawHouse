﻿using BusinessLogic.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Self_Service
{
    public partial class CalculationsView : Form
    {
        OverallValidator oaValidator;
        public CalculationsView(OverallValidator oaValidator)
        {
            InitializeComponent();

            this.oaValidator = oaValidator;

            lblCalcLoanPayment.MouseHover += LblCalcLoanPayment_MouseHover;
            lblCalcLoanPayment.MouseLeave += LblCalcLoanPayment_MouseLeave;
            lblCalcLoanPayment.Click += LblCalcLoanPayment_Click;
        }

        private void LblCalcLoanPayment_Click(object? sender, EventArgs e)
        {
            CalcLoanPaymentView calcLoanPaymentView = new CalcLoanPaymentView(oaValidator);
            PnlCalcChange(calcLoanPaymentView);
        }

        private void LblCalcLoanPayment_MouseLeave(object? sender, EventArgs e)
        {
            lblCalcLoanPayment.Font = new Font(lblCalcLoanPayment.Font, FontStyle.Regular);
        }

        private void LblCalcLoanPayment_MouseHover(object? sender, EventArgs e)
        {
            lblCalcLoanPayment.Font = new Font(lblCalcLoanPayment.Font, FontStyle.Underline);
        }

        public void PnlCalcChange(Form f)
        {
            //clearer controls fra panelForm
            pnlCalc.Controls.Clear();
            f.TopLevel = false;
            //tilføj form som control til panelet
            pnlCalc.Controls.Add(f);
            f.Show();
            pnlCalc.Show();
        }
    }
}
