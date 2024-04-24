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
        public DateTime CreationDate { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
        public virtual ICollection<ClientFormular> ClientFormulars { get; set; }
        public virtual ICollection<Case> Cases { get; set; }

    }
}
