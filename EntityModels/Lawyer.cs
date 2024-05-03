using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        //foreign key
        public int LawyerTitleID { get; set; }

        //nav props
        public LawyerTitle LawyerTitle { get; set; }

        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
    }

}
