using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace UIModels
{
    public class UserUI
    {
        public int UserID { get; set; }

        //attributes
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string? ConfirmPassWord { get; set; }//kun i ui for at tjek match
        public Enums.UserType Type { get; set; } //kun måske i ui??

    }
}
