using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        //attributes
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Type { get; set; }
    }
}
