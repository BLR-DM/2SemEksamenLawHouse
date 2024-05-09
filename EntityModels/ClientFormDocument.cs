using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ClientFormDocument
    {
        [Key]
        public int ClientFormDocumentID { get; set; }

        //attributes
        public DateTime BuyDate { get; set; }


        //foreign Keys
        public int ClientID { get; set; }
        public int FormDocumentID { get; set; }

        //nav prop
        public Client Client { get; set; }
        public FormDocument FormDocument { get; set; }

    }
}
