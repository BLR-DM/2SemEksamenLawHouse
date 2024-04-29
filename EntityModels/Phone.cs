﻿using System;
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
        public int PhoneNumber { get; set; }

        //foreign Key
        public int ClientID { get; set; }
        public Client Client { get; set; }
    }
}