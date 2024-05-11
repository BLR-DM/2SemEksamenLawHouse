using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class LawyerUI : EmployeeUI
    {
        public int? ActiveCaseCount { get; set; }

        public virtual ICollection<CaseUI> Cases { get; set; }
    }
}
