namespace EntityModels
{
    public class Client
    {
        public Client()
        {
            this.Formulars = new HashSet<Formular>();
        }
        public int ClientID { get; set; }
        public DateTime CreationDate { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
        public virtual ICollection<Formular> Formulars { get; set; }
        public virtual ICollection<Case> Cases { get; set; }

    }
}
