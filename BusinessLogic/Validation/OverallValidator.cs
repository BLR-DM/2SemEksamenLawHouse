using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic.Validation
{
    public class OverallValidator
    {
        Regex vDouble;
        public OverallValidator()
        {
            // Allows digits
            vDouble = new Regex("^[0-9]+(\\,[0-9]+)?$");

        }

        public bool ValidDigit(string digit)                    
        {
            return !string.IsNullOrEmpty(digit)                    // Length
                && vDouble.IsMatch(digit);                       // Pattern
        }




    }
}
