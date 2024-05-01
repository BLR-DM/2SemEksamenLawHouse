using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace UIModels
{
    public class SecretaryUI : Employee
    {
        public int SecretaryID { get; set; }

        //foreign key
        public int UserID { get; set; }
    }
}
