namespace UIModels
{
    public class ClientFormDocumentUI
    {
        public int ClientFormDocumentID { get; set; }

        //attributes
        public DateTime BuyDate { get; set; }


        //foreign Keys
        public int ClientID { get; set; }
        public int FormDocumentID { get; set; }
    }
}
