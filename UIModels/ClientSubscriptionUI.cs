namespace UIModels
{
    public class ClientSubscriptionUI
    {
        public int ClientSubscriptionID { get; set; }

        //Attributes
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float PaidPrice { get; set; }

        //Foreign keys
        public int ClientID { get; set; }
        public int SubscriptionID { get; set; }
    }
}
