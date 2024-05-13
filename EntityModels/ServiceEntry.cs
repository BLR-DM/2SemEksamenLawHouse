using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ServiceEntry
    {
        public int ServiceEntryID { get; set; }
        public DateTime Date { get; set; }
        public float HoursWorked { get; set; }


        //foreign key
        public int CaseServiceID { get; set; }

        //nav prop
        public CaseService CaseService { get; set; }
    }
}
