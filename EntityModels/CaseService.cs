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
        public int Units { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }


        //Foreign Keys
        public int CaseID { get; set; }
        public Case Case { get; set; }
        public int ServiceID { get; set; }
        public Service Service { get; set; }
        public int LawyerID { get; set; }
        public Lawyer Lawyer { get; set; }
    }
}
