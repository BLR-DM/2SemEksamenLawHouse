﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Employee : Person
    {
        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
    }
}