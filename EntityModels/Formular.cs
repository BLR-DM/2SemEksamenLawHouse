using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Formular
    {
        public Formular() 
        { 
            this.ClientFormulars = new HashSet<ClientFormular>();
        }

        [Key]
        public int FormularID { get; set; }

        //attributes
        public string Name { get; set;}
        public string Description { get; set;}
        public float Price { get; set; }

        //foreign key
        public virtual ICollection<ClientFormular> ClientFormulars { get; set; }
    }
}
