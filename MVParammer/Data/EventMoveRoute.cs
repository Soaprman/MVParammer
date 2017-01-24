namespace MVParammer.Data
{
    public class EventMoveRoute
    {
        public EventCommand[] list { get; set; }
        public bool repeat { get; set; }
        public bool skippable { get; set; }
        public bool wait { get; set; }
    }
}
