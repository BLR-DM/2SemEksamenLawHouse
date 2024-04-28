using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ClientFormular
    {
        [Key]
        public int ClientFormularID { get; set; }

        //attributes
        public DateTime BuyDate { get; set; }


        //foreign Keys
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int FormularID { get; set; }
        public Formular Formular { get; set; }

    }
}
