using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Employee : PersonDetails
    {

        [Column("Employee")] // <- Name of the primary Key column in the Database
        public override int PersonDetailsID { get; set; }

        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
    }
}
