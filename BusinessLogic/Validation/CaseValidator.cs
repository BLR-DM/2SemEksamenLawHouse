using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using UIModels;

namespace BusinessLogic.Validation
{
    public class CaseValidator
    {
        Regex vUnit;
        Regex vAddress;
        public CaseValidator() 
        {
            vUnit = new Regex("^[0-9,.]+$");
            vAddress = new Regex("^[A-Za-zÆØÅæøå0-9\\s-,.]+$");
        }

        public bool ValidUnits(string units)
        {
            return !string.IsNullOrEmpty(units)
                && float.TryParse(units, out float unit) 
                && unit >= 0
                && vUnit.IsMatch(units);
        }

        public bool ValidEntrys(string entrys)
        {
            return !string.IsNullOrEmpty(entrys)
                && float.TryParse(entrys, out float entry)
                && entry > 0
                && vUnit.IsMatch(entrys);
        }

        public bool ValidDescription(string description)
        {
            return !string.IsNullOrEmpty(description)
                && description.Length >= 4
                && description.Length <= 300;
        }

        public bool ValidTitle(string title)
        {
            return !string.IsNullOrEmpty(title)
                && title.Length >= 4
                && title.Length <= 50;
        }

        public bool ValidEstimatedHours(string estimatedHours)
        {
            return !string.IsNullOrEmpty(estimatedHours)
                && float.TryParse(estimatedHours, out float hours)
                && hours >= 0

                && vUnit.IsMatch(estimatedHours);
        }

        public bool ValidEndDate(DateTime date)
        {
            return date > DateTime.Now;
        }

        public bool ValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address)
                && address.Length >= 3 && address.Length <= 50
                && vAddress.IsMatch(address);
        }

        public bool ValidateCase(CaseUI caseUI)
        {
            return ValidTitle(caseUI.Title) &&
                ValidDescription(caseUI.Description) &&
                ValidEstimatedHours(caseUI.EstimatedHours.ToString());

        }

        public bool ValidateCaseService(CaseServiceUI caseServiceUI)
        {
            return ValidDescription(caseServiceUI.Description) &&
                ValidEstimatedHours(caseServiceUI.HoursWorked.ToString()) &&
                ValidUnits(caseServiceUI.HoursWorked.ToString()) &&
                ValidUnits(caseServiceUI.TotalPrice.ToString());
        }

        public bool ValidateServiceEntries(ServiceEntryUI serviceEntryUI)
        {
            return ValidEntrys(serviceEntryUI.HoursWorked.ToString());
        }
    }
}
