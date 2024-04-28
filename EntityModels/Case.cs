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

        //attributes
        public string Title { get; set; }
        public CaseType CaseType { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public float EstHours { get; set; }
        public string Status { get; set; }
        public float TotalPrice { get; set; }

        //Foreign keys
        public int LawyerID { get; set; }
        public Lawyer Lawyer { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<CaseService> CaseServices { get; set; }
    }

    public enum CaseType
    {
        test1,
        test2,
        test3
    }
}
