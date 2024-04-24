using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class LawyerSpeciality
    {
        public int LawyerID { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        public int SpecialityID { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}