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
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Title { get; set; }
        public float Price { get; set; }

        //foreign key (nav prop???)

        public virtual ICollection<ClientSubscription> ClientSubscriptions { get; set; }
    }
}
