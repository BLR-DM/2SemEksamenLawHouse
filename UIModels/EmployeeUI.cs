using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class EmployeeUI : PersonUI
    {
        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
    }
}
