﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Lawyer : Employee
    {
        public Lawyer() 
        { 
            this.LawyerSpecialities = new HashSet<LawyerSpeciality>();
        }

        // attributter
        public bool Admin { get; set; }

        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<CaseService> CaseServices { get; set; }
    }

}
