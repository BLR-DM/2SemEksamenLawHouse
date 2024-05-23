using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Employee : Person
    {
        [StringLength(8, MinimumLength = 8)]
        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        //foreign key
        public int LawyerTitleID { get; set; }

        //nav props
        public LawyerTitle LawyerTitle { get; set; }
    }
}
