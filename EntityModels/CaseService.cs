using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class CaseService
    {
        [Key]
        public int CaseServiceID { get; set; }

        //Attributes
        public string Status { get; set; }
        public string Description { get; set; }
        public float HoursWorked { get; set; }
        public float Units { get; set; }
        public float TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        //Foreign Keys
        public int CaseID { get; set; }
        public int ServiceID { get; set; }
        public int LawyerID { get; set; }

        //nav props
        public Case Case { get; set; }
        public Service Service { get; set; }
        public Lawyer Lawyer { get; set; }
        public ICollection<ServiceEntry> ServiceEntries { get; set; }
    }
}
