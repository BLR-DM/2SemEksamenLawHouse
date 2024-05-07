using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ClientForm
    {
        [Key]
        public int ClientFormID { get; set; }

        //attributes
        public DateTime BuyDate { get; set; }


        //foreign Keys
        public int ClientID { get; set; }
        public int FormID { get; set; }

        //nav prop
        public Client Client { get; set; }
        public Form Form { get; set; }

    }
}
