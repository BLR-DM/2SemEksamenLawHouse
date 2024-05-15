using System.ComponentModel.DataAnnotations;

namespace EntityModels
{
    public class Speciality
    {
        public Speciality() 
        {
            this.LawyerSpecialities = new HashSet<LawyerSpeciality>();
        }

        [Key]
        public int SpecialityID { get; set; }

        //attributes
        public string SpecialityName { get; set;}


        //foreign key (nav prop??)
        public virtual ICollection<LawyerSpeciality> LawyerSpecialities { get; set;}
    }
}
