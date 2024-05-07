using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class ClientFormUI
    {
        public int ClientFormID { get; set; }

        //attributes
        public DateTime BuyDate { get; set; }


        //foreign Keys
        public int ClientID { get; set; }
        public int FormID { get; set; }
    }
}
