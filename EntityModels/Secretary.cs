using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Secretary : Employee
    {
        [Key]
        public int SecretaryID { get; set; }

        //foreign key
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
