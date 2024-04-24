using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Lawyer
    {
        public Lawyer() 
        { 
            this.LawyerSpecialities = new HashSet<LawyerSpeciality>();
        }

        [Key]
        public int LawyerID { get; set; }
        public DateTime HireDate { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
    }
}
