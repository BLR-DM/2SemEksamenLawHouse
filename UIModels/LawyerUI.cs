using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace UIModels
{
    public class LawyerUI : Employee
    {
        public int LawyerID { get; set; }

        //attributes
        public Enums.LawyerTitle Title { get; set; }

        //foriegn keys
        public int UserID { get; set; }
    }

}
