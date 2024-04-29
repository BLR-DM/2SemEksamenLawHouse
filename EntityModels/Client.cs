using System.ComponentModel.DataAnnotations;

namespace EntityModels
{
    public class Client
    {
        public Client()
        {
            this.ClientFormulars = new HashSet<ClientFormular>();
        }

        [Key]
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

        //nav prop
        public User User { get; set; }
        public virtual ICollection<ClientFormular> ClientFormulars { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        //0..1 Subscription
        public ClientSubscription ClientSubscription { get; set; }

    }
}
