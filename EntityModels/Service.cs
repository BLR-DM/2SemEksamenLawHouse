using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Service
    {
        public Service() 
        {
            this.Cases = new HashSet<Case>();
        }

        public int ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PriceType { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Case> Cases { get; set; }

    }
}
