using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

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
        public Enums.LawyerTitle Title { get; set; }

        //foriegn keys
        public int UserID { get; set; }

        //nav props
        public User User { get; set; }
        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
    }

}
