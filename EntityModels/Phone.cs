using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public int PhoneNumber { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
    }
}
