using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class PhoneUI
    {
        public int PhoneID { get; set; }

        //attributes
        public int PhoneNumber { get; set; }

        //foreign Key
        public int ClientID { get; set; }
    }
}
