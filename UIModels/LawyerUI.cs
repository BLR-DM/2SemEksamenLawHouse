using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class LawyerUI
    {
        public int LawyerID { get; set; }

        //attributes
        public LawyerTitleUI Title { get; set; }

        //employee Attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public int PostalCode { get; set; }
        public DateTime HireDate { get; set; }

        //foriegn keys
        public int UserID { get; set; }
    }

    public enum LawyerTitleUI
    {
        type1,
        type2,
        type3
    }
}
