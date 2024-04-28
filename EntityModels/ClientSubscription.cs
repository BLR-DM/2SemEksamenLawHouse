using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ClientSubscription
    {
        [Key]
        public int ClientSubscriptionID { get; set; }

        //Attributes
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Foreign keys

        public int ClientID { get; set; }
        public Client Client { get; set; }

        public int SubscriptionID { get; set; }
        public Subscription Subscription { get; set; }
    }
}
