using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class ServicePriceType
    {
        public int ServicePriceTypeID { get; set; }
        [Required]
        [MaxLength(50), MinLength(4)]
        public string PriceType { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
