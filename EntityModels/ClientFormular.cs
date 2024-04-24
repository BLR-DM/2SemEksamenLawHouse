using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ClientFormular
    {
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int FormularID { get; set; }
        public virtual Formular Formular { get; set; }
        public DateTime BuyDate { get; set; }

    }
}
