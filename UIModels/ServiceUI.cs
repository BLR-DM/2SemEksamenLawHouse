using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace UIModels
{
    public class ServiceUI
    {
        public int ServiceID { get; set; }

        //attributes
        public string Name { get; set; }
        public string Description { get; set; }
        public Enums.PriceType PriceType { get; set; }
        public float Price { get; set; }
    }
}
