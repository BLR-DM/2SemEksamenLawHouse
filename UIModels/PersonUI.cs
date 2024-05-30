namespace UIModels
{
    public class PersonUI
    {
        public virtual int PersonID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string AddressLine { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }

        //foreign key
        public int LoginDetailsID { get; set; }
    }
}
