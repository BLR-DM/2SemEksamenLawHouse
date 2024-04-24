using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Case
    {
        public Case() 
        { 
            this.Services = new HashSet<Service>();
        }

        public int CaseID { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int LawyerID { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public float TotalPrice { get; set; }

    }
}
