namespace UIModels
{
    public class ClientUI : PersonUI
    {

        //attributes
        public int MainPhone { get; set; }
        public bool IsSubscribed { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
