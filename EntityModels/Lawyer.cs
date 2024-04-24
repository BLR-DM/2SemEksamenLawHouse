using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Lawyer
    {
        public Lawyer() 
        { 
            this.Specialities = new HashSet<Speciality>();
        }

        public int LawyerID { get; set; }
        public DateTime HireDate { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
        public virtual ICollection<Speciality> Specialities { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
    }
}
