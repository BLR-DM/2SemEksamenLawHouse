using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class CaseServiceUI
    {
        public int CaseServiceID { get; set; }

        //Attributes
        public string Status { get; set; }
        public string Description { get; set; }
        public float HoursWorked { get; set; }
        public float Units { get; set; }
        public float TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Date { get; set; }


        //Kun i UI
        public string? ServiceName { get; set; }
        public string? PriceType { get; set; }


        //Foreign Keys
        public int CaseID { get; set; }
        public int ServiceID { get; set; }
        public int LawyerID { get; set; }
    }
}
