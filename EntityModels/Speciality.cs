using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Speciality
    {
        public Speciality() 
        {
            this.LawyerSpecialities = new HashSet<LawyerSpeciality>();
        }

        [Key]
        public int SpecialityID { get; set; }

        //attributes
        public string SpecialityName { get; set;}


        //foreign key
        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set;}

    }
}
