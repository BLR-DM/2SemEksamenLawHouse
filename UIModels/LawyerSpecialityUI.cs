﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class LawyerSpecialityUI
    {
        //Composite key - Lawyer, Speciality

        public int LawyerID { get; set; }
        public int SpecialityID { get; set; }
    }
}