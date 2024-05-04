using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public  class LoginDetailsUI
    {
        public int LoginDetailsID { get; set; }

        //attributes
        public string Username { get; set; }
        public string Password { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
