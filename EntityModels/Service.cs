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

        //attributes
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Name { get; set; }
        [Required]
        [MaxLength(300), MinLength(4)]
        public string Description { get; set; }
        public float Price { get; set; }

        //foreign key
        public int ServicePriceTypeID { get; set; }

        //foreign key (nav prop???)
        public ServicePriceType ServicePriceType { get; set; }
        public virtual ICollection<CaseService> CaseServices { get; set; }

    }
}
