﻿namespace EntityModels
{
    public class Client : Person
    {

        //attributes


        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<ClientFormDocument> ClientForms { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        
        public ICollection<ClientSubscription> ClientSubscriptions { get; set; }

    }
}
