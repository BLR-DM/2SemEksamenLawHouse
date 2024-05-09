using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class FormDocument
    {
        public FormDocument() 
        { 
            this.ClientFormDocuments = new HashSet<ClientFormDocument>();
        }

        [Key]
        public int FormDocumentID { get; set; }

        //attributes
        public string Name { get; set;}
        public string Description { get; set;}
        public float Price { get; set; }

        //foreign key (nav prop??)
        public virtual ICollection<ClientFormDocument> ClientFormDocuments { get; set; }
    }
}
