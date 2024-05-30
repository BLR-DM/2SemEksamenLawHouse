namespace UIModels
{
    public class LawyerSpecialityUI
    {
        //Composite key - Lawyer, Speciality

        public int LawyerID { get; set; }
        public int SpecialityID { get; set; }

        // Kun i UI
        public string? SpecialityName { get; set; }
    }
}
