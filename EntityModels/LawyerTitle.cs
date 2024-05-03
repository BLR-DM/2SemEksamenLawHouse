using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class LawyerTitle
    {
        public int LawyerTitleID { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Lawyer> Lawyers { get; set; }
    }
}
