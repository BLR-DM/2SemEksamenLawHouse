using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Person
    {

        public virtual int PersonID { get; set; }
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Lastname { get; set; }
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100), MinLength(4)]
        public string AddressLine { get; set; }
        [StringLength(4, MinimumLength = 4)]
        public int PostalCode { get; set; }
        [Required]
        [MaxLength(50), MinLength(4)]
        public string City { get; set; }
        

        //foreign key
        public int LoginDetailsID { get; set; }

        //nav prop 
        public LoginDetails LoginDetails { get; set; }
    }
}
