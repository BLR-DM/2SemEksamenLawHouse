using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }

        //attributes
        [StringLength(8, MinimumLength = 8)]
        public int PhoneNumber { get; set; }

        //foreign Key
        public int ClientID { get; set; }

        //nav prop
        public Client Client { get; set; }
    }
}
