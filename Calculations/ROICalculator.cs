using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class ROICalculator
    {
        public double ReturnOnInvestment { get; set; }

        public ROICalculator CalcROI(double investment, double interestRate, double amountOfYears)
        {
            //udregner renteafkast
            double returnOnInvestment = investment * (1 + interestRate * amountOfYears);

            //afrunder svar til 2 decimaler
            double roundedReturnOnInvestment = Math.Round(returnOnInvestment, 2);
            ReturnOnInvestment = roundedReturnOnInvestment;


            return this;
        }
    }
}
