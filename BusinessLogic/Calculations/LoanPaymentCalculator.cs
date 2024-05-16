using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Calculations
{
    public class LoanPaymentCalculator
    {
        public double TotalPrYear { get; set; }
        public double AmountPrPayment { get; set; }

        public LoanPaymentCalculator CalcPayment(double loanAmount, double interestRate, double amountOfYears, double paymentsPrYear)
        {

            //udregning at betaling pr aar
            double totalPrYear = loanAmount * ((interestRate) / (1 - Math.Pow(1 + interestRate, -amountOfYears)));
            //afrunder svar til 2 decimaler
            double roundedTotalPrYear = Math.Round(totalPrYear, 2);



            //tager betaling pr aar og deler ud i antal ydelser pa aaret
            double amountPrPayment = totalPrYear / paymentsPrYear;
            //afrunde til 2 decimaler
            double roundedAmountPrPayment = Math.Round(amountPrPayment, 2);



            return new LoanPaymentCalculator
            {
                TotalPrYear = roundedTotalPrYear,
                AmountPrPayment = roundedAmountPrPayment,
            };
        }
    }
}
