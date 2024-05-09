using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class EmployeeUI : PersonUI
    {
        //attributes
        public string LawyerTitle { get; set; }

        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        //foreign key
        public int LawyerTitleID { get; set; }

    }
}
