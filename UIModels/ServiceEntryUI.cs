using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class ServiceEntryUI
    {
        public int ServiceEntryID { get; set; }
        public DateTime Date { get; set; }
        public float HoursWorked { get; set; }


        //foreign key
        public int CaseServiceID { get; set; }

        //nav prop
        public CaseServiceUI CaseService { get; set; }
    }
}
