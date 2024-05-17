using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class RemainingBalanceOnLoanCalculator
    {
        public double RemainingBalance { get; set; }
        public double PaymentAmount {  get; set; }

        public RemainingBalanceOnLoanCalculator CalcRemainingBalance(double totalLoanAmount, double annualInterestRate, double paymentsPrYear, double totalYears, double paymentsMade)
        {
            //rente pr betaling
            double interestRatePrPayment = annualInterestRate / paymentsPrYear / 100;

            //total antal betalinger
            double totalPayments = paymentsPrYear * totalYears;

            //betalingsvaerdi
            double paymentAmount = totalLoanAmount * (interestRatePrPayment * Math.Pow(1 + interestRatePrPayment, totalPayments)) / (Math.Pow(1 + interestRatePrPayment, totalPayments) - 1);

            //resterende balance på lånet
            double remainingBalance = totalLoanAmount * Math.Pow(1+interestRatePrPayment, paymentsMade) - paymentAmount * (Math.Pow(1+interestRatePrPayment, paymentsMade)-1)/ interestRatePrPayment;

            double roundedRemainingBalance = Math.Round(remainingBalance, 2);


            RemainingBalance = roundedRemainingBalance;
            PaymentAmount = paymentAmount;

            return this; 
            
        }
    }
}
