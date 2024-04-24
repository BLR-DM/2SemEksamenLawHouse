using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class PersonInfo
    {
        public int PersonInfoID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Lawyer> Lawyers { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

    }
}
