namespace Calculations
{
    public static class LoanPaymentCalculator
    {
        public static (double TotalPerYear, double AmountPerPayment, double TotalAmountPaid) CalcLoanPayment (
            double loanAmount, double interestRate, double amountOfYears, double paymentsPerYear)
        {
            //udregning at betaling pr aar
            double totalPerYear = loanAmount * ((interestRate) / (1 - Math.Pow(1 + interestRate, -amountOfYears)));
            //afrunder svar til 2 decimaler
            double roundedTotalPerYear = Math.Round(totalPerYear, 2);


            //tager betaling pr aar og deler ud i antal ydelser pa aaret
            double amountPerPayment = totalPerYear / paymentsPerYear;
            //afrunde til 2 decimaler
            double roundedAmountPerPayment = Math.Round(amountPerPayment, 2);

            //berening af samlet betalt belob
            double totalAmountPaid = totalPerYear * amountOfYears;
            //afrund til 2 decimaler
            double roundedTotalAmountPaid = Math.Round(totalAmountPaid, 2);


            return (roundedTotalPerYear, roundedAmountPerPayment, roundedTotalAmountPaid);
        }

        public static (double RemainingBalance, double PaymentAmount) CalcRemainingBalanceOnLoan (
            double totalLoanAmount, double annualInterestRate, double paymentsPerYear, double totalYears, double paymentsMade)
        {
            // Rente pr betaling
            double interestRatePerPayment = annualInterestRate / paymentsPerYear / 100;

            // Total antal betalinger
            double totalPayments = paymentsPerYear * totalYears;

            // Betalingsværdi
            double paymentAmount = totalLoanAmount * (interestRatePerPayment * Math.Pow(1 + interestRatePerPayment, totalPayments)) /
                (Math.Pow(1 + interestRatePerPayment, totalPayments) - 1);

            // Resterende balance på lånet
            double remainingBalance = totalLoanAmount * Math.Pow(1 + interestRatePerPayment, paymentsMade) - paymentAmount * 
                (Math.Pow(1 + interestRatePerPayment, paymentsMade) - 1) / interestRatePerPayment;

            return (remainingBalance, paymentAmount);
        }

    }
}
