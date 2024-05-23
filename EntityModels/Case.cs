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
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300), MinLength(4)]
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public float EstimatedHours { get; set; }
        [MaxLength(10),  MinLength(2)]
        public string Status { get; set; }
        public float TotalPrice { get; set; }


        //Foreign keys
        public int CaseTypeID { get; set; }
        public int LawyerID { get; set; }
        public int ClientID { get; set; }

        //Nav Prop
        public CaseType CaseType { get; set; }
        public Lawyer Lawyer { get; set; }
        public Client Client { get; set; }

        public virtual ICollection<CaseService> CaseServices { get; set; }
    }

}
