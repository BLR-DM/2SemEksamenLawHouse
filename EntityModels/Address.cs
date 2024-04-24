using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Address
    {
        public int AddressID { get; set; }
        public string AdressLine { get; set; }
        public int PostalCode { get; set; }
        public int PersonInfoID { get; set; }
        public virtual PersonInfo PersonInfo { get; set; }
    }
}
