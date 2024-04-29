using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIModels
{
    public class SecretaryUI
    {
        public int SecretaryID { get; set; }

        //foreign key
        public int UserID { get; set; }
    }
}
