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
        [Required]
        [MaxLength(100), MinLength(4)]
        public string Name { get; set;}
        [Required]
        [MaxLength(300), MinLength(4)]
        public string Description { get; set;}
        public float Price { get; set; }

        //foreign key (nav prop??)
        public virtual ICollection<ClientFormDocument> ClientFormDocuments { get; set; }
    }
}
