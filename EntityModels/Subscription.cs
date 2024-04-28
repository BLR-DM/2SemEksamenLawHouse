using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Subscription
    {
        [Key]
        public int SubscriptionID { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }

        //foreign key

        public virtual ICollection<ClientSubscription> ClientSubscriptions { get; set; }
    }
}
