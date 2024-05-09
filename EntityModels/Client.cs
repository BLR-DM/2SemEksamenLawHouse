using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModels
{
    public class Client : Person
    {

        //attributes


        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<ClientFormDocument> ClientForms { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        //0..1 Subscription
        public ClientSubscription ClientSubscription { get; set; }

    }
}
