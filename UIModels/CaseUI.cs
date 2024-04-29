﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class CaseUI
    {
        public int CaseID { get; set; }

        //attributes
        public CaseTypeUI CaseTypeUI { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public float EstHours { get; set; }
        public string Status { get; set; }
        public float TotalPrice { get; set; }

        //foreign keys
        public int LawyerID { get; set; }
        public int ClientID { get; set; }
    }

    public enum CaseTypeUI
    {
        test1,
        test2,
        test3
    }
}