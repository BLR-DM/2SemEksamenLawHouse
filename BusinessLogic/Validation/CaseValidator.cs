using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic.Validation
{
    public class CaseValidator
    {
        Regex vUnit;
        public CaseValidator() 
        {
            vUnit = new Regex("^[0-9]+$");

        }

        public bool ValidUnits(string units)
        {
            return !string.IsNullOrEmpty(units)
                && int.TryParse(units, out int unit) 
                && unit > 0
                && vUnit.IsMatch(units);
        }

        public bool ValidDescription(string description)
        {
            return !string.IsNullOrEmpty(description)
                && description.Length > 2
                && description.Length < 300;
        }

        public bool ValidTitle(string title)
        {
            return !string.IsNullOrEmpty(title)
                && title.Length > 2
                && title.Length < 50;
        }

        public bool ValidEstimatedHours(string estimatedHours)
        {
            return !string.IsNullOrEmpty(estimatedHours)
                && int.TryParse(estimatedHours, out int hours)
                && hours > 0
                && vUnit.IsMatch(estimatedHours);
        }

        public bool ValidEndDate(DateTime dateTime)
        {
            return dateTime > DateTime.Now;
        }
    }
}
