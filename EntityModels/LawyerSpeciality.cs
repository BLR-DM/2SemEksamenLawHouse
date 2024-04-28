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
        //Composite key - Lawyer, Speciality

        public int LawyerID { get; set; }
        public Lawyer Lawyer { get; set; }
        public int SpecialityID { get; set; }
        public Speciality Speciality { get; set; }
    }
}