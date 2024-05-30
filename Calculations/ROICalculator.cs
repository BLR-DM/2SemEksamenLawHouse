namespace Calculations
{
    public static class ROICalculator
    {
        public static double CalcROI (double investment, double interestRate, double amountOfYears)
        {
            // Udregner renteafkast
            double returnOnInvestment = investment * Math.Pow((1 + interestRate), amountOfYears);

            // Arfunder resultat til 2 decimaler
            return Math.Round(returnOnInvestment, 2);
        }
    }
}
