using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void PrintDetails(string path)
        {
            int casePadding = 25;

            List<string> caseHeader = new List<string>()
            {
                "CaseID", "Title", "Type", "Status", "Creation Date", "End Date", "Hours", 
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
                caseHeader[i] = caseHeader[i].PadRight(casePadding);
                caseData[i] = caseData[i].PadRight(casePadding);
            }


            int caseServicePadding = 25;


            List<string> caseServiceHeader = new List<string>()
            {
                "ServiceID", "Name", "Price Type", "Status", "Start Date", "End Date", "Hours Worked", 
                "Units", "Price/Unit", "Total Price", "Lawyer", "Lawyer Number"
            };

            for (int i = 0; i < caseServiceHeader.Count; i++)
            {
                caseServiceHeader[i] = caseServiceHeader[i].PadRight(caseServicePadding).ToString();
            }


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
                    caseServiceLine[i] = caseServiceLine[i].PadRight(caseServicePadding).ToString();
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


            File.WriteAllLines(path, rowsToPrint);



            //string test =
            //    $"Case Number: {CaseID}"
            //    $"Case Number: {caseUI.CaseID}",
            //    $"Case Type: {caseType}",
            //    $"",
            //    $"Lawyer: {lawyer.Firstname} {lawyer.Lastname}",
            //    $"Client: {client.Firstname} {client.Lastname}",
            //    $"Client Number: {client.PersonID}",
            //    $"",
            //    $"Title: {caseUI.Title}",
            //    $"",
            //    $"Description: {caseUI.Description}",
            //    $"",
            //    $"Status: {caseUI.Status}",
            //    $"",
            //    $"Start Date: {caseUI.CreationDate.ToString("d")}",
            //    $"End Date  : {caseUI.EndDate.ToString("d")}",
            //    $"",
            //    $"Total Price: {caseUI.TotalPrice}",
            //    $"",
            //    $"---------------------------------------------------------------------------";
        }
    }
}
