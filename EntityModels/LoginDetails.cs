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
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }

        //nav prop
        public Person Person { get; set; }
    }

}
