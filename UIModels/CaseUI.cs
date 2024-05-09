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

        //public string CaseType { get; set; }

        //foreign keys
        public int CaseTypeID { get; set; }
        public int LawyerID { get; set; }
        public int ClientID { get; set; }

    }

}
