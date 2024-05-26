using System.ComponentModel.DataAnnotations;

namespace EntityModels
{
    public class Employee : Person
    {
        [StringLength(8, MinimumLength = 8)]
        public int PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        //foreign key
        public int LawyerTitleID { get; set; }

        //nav props
        public LawyerTitle LawyerTitle { get; set; }
    }
}
