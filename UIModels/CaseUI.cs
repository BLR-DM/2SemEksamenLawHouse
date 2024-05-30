namespace UIModels
{
    public class CaseUI
    {
        public int CaseID { get; set; }

        //attributes
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public float EstimatedHours { get; set; }
        public string Status { get; set; }
        public float TotalPrice { get; set; }

        //foreign keys
        public int CaseTypeID { get; set; }
        public int LawyerID { get; set; }
        public int ClientID { get; set; }

        public CaseTypeUI CaseType { get; set; }
        public LawyerUI Lawyer { get; set; }
        public ClientUI Client { get; set; }

        public virtual ICollection<CaseServiceUI> CaseServices { get; set; }

        public async Task<bool> PrintDetailsAsync(string path)
        {
            int casePadding = 20;

            List<string> caseHeader = new List<string>()
            {
                "CaseID", "Title", "Type", "Status", "Creation Date", "End Date", "Est. Hours",
                "Total Price", "Lawyer", "Lawyer Number", "Client", "Client Number"
            };

            List<string> caseData = new List<string>()
            {
                CaseID.ToString(), Title, CaseType.Title, Status.ToString(), CreationDate.ToString("d"), EndDate.ToString("d"),
                EstimatedHours.ToString(), TotalPrice.ToString(), Lawyer.ToString(), Lawyer.PersonID.ToString(),
                Client.ToString(), Client.PersonID.ToString()
            };

            // Padding the headers and caseData to ensure alignment
            for (int i = 0; i < caseHeader.Count; i++)
            {
                if (i == 0 || i == 3 || i == 7)
                {
                    caseHeader[i] = caseHeader[i].PadRight(15).ToUpper();
                    caseData[i] = caseData[i].PadRight(15);
                }
                else if (i == 1)
                {
                    caseHeader[i] = caseHeader[i].PadRight(35).ToUpper();
                    caseData[i] = caseData[i].PadRight(35);
                }
                else
                {
                    caseHeader[i] = caseHeader[i].PadRight(casePadding).ToUpper();
                    caseData[i] = caseData[i].PadRight(casePadding);
                }
            }

            int caseServicePadding = 20;

            List<string> caseServiceHeader = new List<string>()
            {
                "ServiceID", "Name", "Price Type", "Status", "Start Date", "End Date", "Hours Worked",
                "Units", "Price/Unit", "Total Price", "Lawyer", "Lawyer Number"
            };

            List<List<string>> caseServiceData = new List<List<string>>();

            foreach (CaseServiceUI caseService in CaseServices)
            {
                List<string> caseServiceLine = new List<string>()
                {
                    caseService.ServiceID.ToString(), caseService.Service.Name, caseService.Service.PriceType.ToString(), caseService.Status, caseService.StartDate.ToString("d"),
                    caseService.EndDate?.ToString("d") ?? "null", caseService.HoursWorked.ToString(),  caseService.Units.ToString(),
                    caseService.Service.Price.ToString(), caseService.TotalPrice.ToString(), caseService.Lawyer.ToString(), caseService.LawyerID.ToString()
                };

                for (int i = 0; i < caseServiceLine.Count; i++)
                {
                    if (i == 0 || i == 3 || i == 7)
                    {
                        caseServiceHeader[i] = caseServiceHeader[i].PadRight(15).ToUpper().ToString();
                        caseServiceLine[i] = caseServiceLine[i].PadRight(15).ToString();
                    }

                    else if (i == 1)
                    {
                        caseServiceHeader[i] = caseServiceHeader[i].PadRight(35).ToUpper().ToString();
                        caseServiceLine[i] = caseServiceLine[i].PadRight(35).ToString();
                    }

                    else
                    {
                        caseServiceHeader[i] = caseServiceHeader[i].PadRight(caseServicePadding).ToUpper().ToString();
                        caseServiceLine[i] = caseServiceLine[i].PadRight(caseServicePadding).ToString();
                    }
                }
                caseServiceData.Add(caseServiceLine);
            }


            // Combine headers and caseData into lines
            string caseHeaderRow = string.Join("", caseHeader);
            string caseDataRow = string.Join("", caseData);
            string caseServiceHeaderRow = string.Join("", caseServiceHeader);

            // Write to the file
            List<string> rowsToPrint = new List<string>();
            rowsToPrint.Add(caseHeaderRow);
            rowsToPrint.Add(caseDataRow);
            rowsToPrint.Add("");
            rowsToPrint.Add("------------------------------------------------------------------------------------------------------------------------------------------" +
                "------------------------------------------------------------------------------------------------------------------------------------------------------");
            rowsToPrint.Add("");
            rowsToPrint.Add(caseServiceHeaderRow);

            foreach (List<string> serviceLine in caseServiceData)
            {
                rowsToPrint.Add(string.Join("", serviceLine));
            }

            try
            {
                await File.WriteAllLinesAsync(path, rowsToPrint);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        //
        //PRINT EXTRA DETALJERET VERSION
        //
        public async Task<bool> PrintWithExtraDetailsAsync(string path)
        {
            List<string> textToWrite = new List<string>();

            textToWrite = BuildHeader(textToWrite);

            foreach (CaseServiceUI caseService in CaseServices)
            {
                if (caseService.Service.PriceType == "Kilometer")
                {
                    textToWrite = BuildKilometerServiceText(caseService, textToWrite);
                }
                else if (caseService.Service.PriceType == "Hourly")
                {
                    textToWrite = BuildHourlyServiceTextAsync(caseService, textToWrite);
                }
                else if (caseService.Service.PriceType == "Fixed")
                {
                    textToWrite = BuildFixedServiceTextAsync(caseService, textToWrite);
                }
            }

            try
            {
                await File.WriteAllLinesAsync(path, textToWrite);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private List<string> BuildHeader(List<string> textToWrite)
        {

            List<string> header = new List<string>()
            {
                $"Case Number: {CaseID}",
                $"Case Type: {CaseType.Title}",
                $"",
                $"Lawyer: {Lawyer.Firstname} {Lawyer.Lastname}",
                $"Client: {Client.Firstname} {Client.Lastname}",
                $"Client Number: {Client.PersonID}",
                $"",
                $"Title: {Title}",
                $"",
                $"Description: {Description}",
                $"",
                $"Status: {Status}",
                $"",
                $"Start Date: {CreationDate.ToString("d")}",
                $"End Date  : {EndDate.ToString("d")}",
                $"",
                $"Total Price: {TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            foreach (string txt in header)
            {
                textToWrite.Add(txt);
            }

            return textToWrite;
        }

        private List<string> BuildKilometerServiceText(CaseServiceUI caseService, List<string> textToWrite)
        {

            List<string> kilometerServiceText = new List<string>()
            {
                $"",
                $"Service number: {caseService.ServiceID}",
                $"Service name  : {caseService.Service.Name}",
                $"",
                $"Lawyer: {caseService.Lawyer.Firstname} {caseService.Lawyer.Lastname}",
                $"",
                $"Description: {caseService.Description}",
                $"",
                $"Date: {caseService.EndDate?.ToString("d")}",
                $"",
                $"Total Hours: {caseService.HoursWorked}",
                $"",
                $"Kilometers : {caseService.Units}",
                $"Price pr km: {caseService.Service.Price}",
                $"Total price: {caseService.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            //tilfoojer hele HourlyService teksten til listen den skal udskrive til txt
            foreach (string txt in kilometerServiceText)
            {
                textToWrite.Add(txt);
            }

            return textToWrite;

        }

        private List<string> BuildHourlyServiceTextAsync(CaseServiceUI caseService, List<string> textToWrite)
        {

            List<string> hourlyServiceText = new List<string>()
            {
                $"",
                $"Service number: {caseService.ServiceID}",
                $"Service name  : {caseService.Service.Name}",
                $"",
                $"Lawyer: {caseService.Lawyer.Firstname} {caseService.Lawyer.Lastname}",
                $"",
                $"Description: {caseService.Description}",
                $"",
                $"Start Date: {caseService.StartDate.ToString("d")}",
                $"End Date  : {caseService.EndDate?.ToString("d")}",
                $"",
                $"Entries:",
            };



            //tilføjer entries til Service text
            foreach (ServiceEntryUI entry in caseService.ServiceEntries)
            {
                hourlyServiceText.Add($"{entry.Date.ToString("d")}: {entry.HoursWorked} Hours");
            }

            //text der skal staa under entries
            List<string> hourlyServiceBottomText = new List<string>()
            {
                $"",
                $"Price pr hour: {caseService.Service.Price}",
                $"Total Hours: {caseService.HoursWorked}",
                $"Total Price: {caseService.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            //tilfoojer teksten efter entries til hovedteksten for HourlyService
            foreach (string txt in hourlyServiceBottomText)
            {
                hourlyServiceText.Add(txt);
            }

            //tilfoojer hele HourlyService teksten til listen den skal udskrive til txt
            foreach (string txt in hourlyServiceText)
            {
                textToWrite.Add(txt);
            }

            return textToWrite;
        }

        private List<string> BuildFixedServiceTextAsync(CaseServiceUI caseService, List<string> textToWrite)
        {

            List<string> fixedServiceText = new List<string>()
            {
                $"",
                $"Service number: {caseService.ServiceID}",
                $"Service name  : {caseService.Service.Name}",
                $"",
                $"Lawyer: {caseService.Lawyer.Firstname} {caseService.Lawyer.Lastname}",
                $"",
                $"Description: {caseService.Description}",
                $"",
                $"Start Date: {caseService.StartDate.ToString("d")}",
                $"End Date  : {caseService.EndDate?.ToString("d")}",
                $"",
                $"Entries:",
            };

            //tilføjer entries til Service text
            foreach (ServiceEntryUI entry in caseService.ServiceEntries)
            {
                fixedServiceText.Add($"{entry.Date.ToString("d")}: {entry.HoursWorked} Hours");
            }

            //text der skal staa under entries
            List<string> fixedServiceBottomText = new List<string>()
            {
                $"",
                $"Total Hours: {caseService.HoursWorked}",
                $"",
                $"FixedPrice: {caseService.Service.Price}",
                $"Agreed Price: {caseService.TotalPrice}",
                $"",
                $"---------------------------------------------------------------------------",
            };

            //tilfoojer teksten efter entries til hovedteksten for HourlyService
            foreach (string txt in fixedServiceBottomText)
            {
                fixedServiceText.Add(txt);
            }

            //tilfoojer hele HourlyService teksten til listen den skal udskrive til txt
            foreach (string txt in fixedServiceText)
            {
                textToWrite.Add(txt);
            }

            return textToWrite;
        }
    }
}
