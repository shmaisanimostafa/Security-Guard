namespace Security_Guard_API.Models
{
    public class Message
    {
        public int? Id { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public bool IsAi { get; set; }
        public DateTime Time { get; set; }

        


    }
}
