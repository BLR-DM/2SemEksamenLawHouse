using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Calculation
    {
        [Key]
        public int CalculationID { get; set; }

        //attributes
        public string Name { get; set; }

    }
}
