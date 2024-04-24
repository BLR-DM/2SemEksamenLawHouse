using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Formular
    {
        public Formular() 
        { 
            this.Clients = new HashSet<Client>();
        }

        public int FormularID { get; set; }
        public string Name { get; set;}
        public string Description { get; set;}
        public float Price { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
