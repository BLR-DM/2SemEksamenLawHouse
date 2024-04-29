using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class ClientUI
    {
        public int ClientID { get; set; }

        //attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public int PostalCode { get; set; }
        public DateTime CreationDate { get; set; }
        public int ClientSub { get; set; } // 1 = True, 0 = False



        //foreign keys
        public int UserID { get; set; }
    }
}
