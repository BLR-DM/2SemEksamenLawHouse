using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Lawyer : Employee
    {
        public Lawyer() 
        { 
            this.LawyerSpecialities = new HashSet<LawyerSpeciality>();
        }

        [Key]
        public int LawyerID { get; set; }

        //attributes
        public LawyerTitle Title { get; set; }

        //foriegn keys
        public int UserID { get; set; }
        public User User { get; set; }
        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
    }

    public enum LawyerTitle
    {
        type1,
        type2,
        type3
    }
}
