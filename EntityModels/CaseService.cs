using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class CaseService
    {
        public int CaseID { get; set; }
        public virtual Case Case { get; set; }
        public int ServiceID { get; set; }
        public virtual Service Service { get; set; }
        public float HoursWorkedOn { get; set; }
        public float KilometersDriven { get; set; }
    }
}
