using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Form
    {
        public Form() 
        { 
            this.ClientForms = new HashSet<ClientForm>();
        }

        [Key]
        public int FormID { get; set; }

        //attributes
        public string Name { get; set;}
        public string Description { get; set;}
        public float Price { get; set; }

        //foreign key (nav prop??)
        public virtual ICollection<ClientForm> ClientForms { get; set; }
    }
}
