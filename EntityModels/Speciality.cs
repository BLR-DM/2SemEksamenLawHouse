using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Speciality
    {
        public Speciality() 
        {
            this.Lawyers = new HashSet<Lawyer>();
        }

        public int SpecialityID { get; set; }
        public string SpecialityName { get; set;}
        public virtual ICollection<Lawyer> Lawyers { get; set;}

    }
}
