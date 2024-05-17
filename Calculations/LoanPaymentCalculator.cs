namespace Calculations
{
    public static class LoanPaymentCalculator
    {
        public static (double TotalPerYear, double AmountPerPayment) CalcPayment(double loanAmount, double interestRate, double amountOfYears, double paymentsPerYear)
        {
            //udregning at betaling pr aar
            double totalPerYear = loanAmount * ((interestRate) / (1 - Math.Pow(1 + interestRate, -amountOfYears)));
            //afrunder svar til 2 decimaler
            double roundedTotalPerYear = Math.Round(totalPerYear, 2);


            //tager betaling pr aar og deler ud i antal ydelser pa aaret
            double amountPerPayment = totalPerYear / paymentsPerYear;
            //afrunde til 2 decimaler
            double roundedAmountPerPayment = Math.Round(amountPerPayment, 2);

            return (roundedTotalPerYear, roundedAmountPerPayment);
        }

    }
}
