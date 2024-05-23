using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class LawyerTitle
    {
        public int LawyerTitleID { get; set; }
        [Required]
        [MaxLength(50), MinLength(4)]
        public string Title { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
