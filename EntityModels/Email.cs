using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Email
    {
        public int EmailID { get; set; }
        public string EmailAddress { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
    }
}
