using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class ClientSubscriptionUI
    {
        public int ClientSubscriptionID { get; set; }

        //Attributes
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Foreign keys
        public int ClientID { get; set; }
        public int SubscriptionID { get; set; }
    }
}
