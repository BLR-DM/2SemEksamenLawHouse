﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

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
                && int.TryParse(units, out int unit) 
                && unit > 0
                && vUnit.IsMatch(units);
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
                && hours > 0

                && vUnit.IsMatch(estimatedHours);
        }

        public bool ValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address)
                && address.Length >= 3 && address.Length <= 50
                && vAddress.IsMatch(address);
        }

        public bool ValidEndDate(DateTime dateTime)
        {
            return dateTime > DateTime.Now;
        }
    }
}
