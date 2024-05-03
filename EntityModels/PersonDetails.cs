using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class PersonDetails
    {

        public virtual int PersonDetailsID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public int PostalCode { get; set; }

        //foreign key
        public int LoginDetailsID { get; set; }

        //nav prop 
        public LoginDetails LoginDetails { get; set; }
    }
}
