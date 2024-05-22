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
            int headerSize = 20;

            List<string> caseHeader = new List<string>()
            {
                "CaseID", "Title", "Case Type", "Creation Date", "End Date", "Hours", "Status",
                "Total Price", "Lawyer", "Client"
            };

            

            List<string> data = new List<string>()
            {
                CaseID.ToString(), Title, "Family Law Case", CreationDate.ToString("d"), EndDate.ToString("d"),
                EstimatedHours.ToString(), Status.ToString(), TotalPrice.ToString(), "Ramus Seebach", "Lucas Podolski"
            };



            // Padding the headers and data to ensure alignment
            for (int i = 0, count = caseHeader.Count; i < count; i++)
            {
                caseHeader[i] = caseHeader[i].PadRight(headerSize);
                data[i] = data[i].PadRight(headerSize);
            }



            // Combine headers and data into lines
            string header = string.Join("", caseHeader);
            string dataLine = string.Join("", data);

            // Write to the file
            List<string> list = new List<string> { header, dataLine };
            File.WriteAllLines(path, list);



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
