using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class LawyerUI : EmployeeUI
    {
        public int? OpenCases => Cases?.Count(c => c.Status == "Active");
        public int? ClosedCases => Cases?.Count(c => c.Status == "Finished");

        public virtual ICollection<CaseUI> Cases { get; set; }

        public virtual ICollection<CaseServiceUI> CaseServices { get; set; }
    }
}
