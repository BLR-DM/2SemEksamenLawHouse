using Calculations;
using BusinessLogic.Validation;
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

namespace UI.Forms.Self_Service
{
    public partial class CalculationsView : Form
    {
        OverallValidator oaValidator;
        ClientUI client;
        public CalculationsView(OverallValidator oaValidator, ClientUI client)
        {
            InitializeComponent();

            this.oaValidator = oaValidator;
            this.client = client;

            lblCalcLoanPayment.MouseHover += LblCalcLoanPayment_MouseHover;
            lblCalcLoanPayment.MouseLeave += LblCalcLoanPayment_MouseLeave;
            lblCalcLoanPayment.Click += LblCalcLoanPayment_Click;

            lblCalcROI.MouseHover += LblCalcROI_MouseHover;
            lblCalcROI.MouseLeave += LblCalcROI_MouseLeave;
            lblCalcROI.Click += LblCalcROI_Click;

            lblCalcRemainingBalanceOnLoan.MouseHover += LblCalcRemainingBalanceOnLoan_MouseHover;
            lblCalcRemainingBalanceOnLoan.MouseLeave += LblCalcRemainingBalanceOnLoan_MouseLeave;
            lblCalcRemainingBalanceOnLoan.Click += LblCalcRemainingBalanceOnLoan_Click;
        }

        private void LblCalcRemainingBalanceOnLoan_Click(object? sender, EventArgs e)
        {
            lblCalcRemainingBalanceOnLoan.Font = new Font(lblCalcRemainingBalanceOnLoan.Font, FontStyle.Underline);
        }

        private void LblCalcRemainingBalanceOnLoan_MouseLeave(object? sender, EventArgs e)
        {
            lblCalcRemainingBalanceOnLoan.Font = new Font(lblCalcRemainingBalanceOnLoan.Font, FontStyle.Regular);
        }

        private void LblCalcRemainingBalanceOnLoan_MouseHover(object? sender, EventArgs e)
        {
            CalcRemainingBalanceOnLoanView calcRemainingBalanceOnLoanView = new CalcRemainingBalanceOnLoanView(oaValidator, client);
            PnlCalcChange(calcRemainingBalanceOnLoanView);

        }

        private void LblCalcROI_Click(object? sender, EventArgs e)
        {
            CalcROIView calcROIView = new CalcROIView(oaValidator, client);
            PnlCalcChange(calcROIView);
        }

        private void LblCalcROI_MouseLeave(object? sender, EventArgs e)
        {
            lblCalcROI.Font = new Font(lblCalcROI.Font, FontStyle.Regular);
        }

        private void LblCalcROI_MouseHover(object? sender, EventArgs e)
        {
            lblCalcROI.Font = new Font(lblCalcROI.Font, FontStyle.Underline);
        }

        private void LblCalcLoanPayment_Click(object? sender, EventArgs e)
        {
            CalcLoanPaymentView calcLoanPaymentView = new CalcLoanPaymentView(oaValidator, client);
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
