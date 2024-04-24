using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Service
    {
        public Service() 
        {
            this.CaseServices = new HashSet<CaseService>();
        }

        [Key]
        public int ServiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PriceType { get; set; }
        public float Price { get; set; }
        public virtual ICollection<CaseService> CaseServices { get; set; }

    }
}
