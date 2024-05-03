using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class LoginDetails
    {
        [Key]
        public int LoginDetailsID { get; set; }

        //attributes
        public string UserName { get; set; }
        public string PassWord { get; set; }
        // public Enums.UserType Type { get; set; } // ?

        public DateTime CreationDate { get; set; }

        //nav prop
        public PersonDetails PersonDetails { get; set; }
    }

}
