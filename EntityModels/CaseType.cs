using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class CaseType
    {
        public int CaseTypeID { get; set; }
        public string Title { get; set; }

        //nav prop
        public virtual ICollection<Case> Cases { get; set; }
    }
}
