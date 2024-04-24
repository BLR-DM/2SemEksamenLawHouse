using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Case
    {
        public Case() 
        { 
            this.CaseServices = new HashSet<CaseService>();
        }

        [Key]
        public int CaseID { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int LawyerID { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<CaseService> CaseServices { get; set; }

    }
}
