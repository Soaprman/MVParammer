namespace MVParammer.Data
{
    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public EventPage[] pages { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
