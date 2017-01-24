namespace MVParammer.Data
{
    public class EventPage
    {
        public EventPageConditions conditions { get; set; }
        public bool directionFix { get; set; }
        public EventPageImage image { get; set; }
        public int moveFrequency { get; set; }
        public EventMoveRoute moveRoute { get; set; }
        public int moveSpeed { get; set; }
        public int moveType { get; set; }
        public int priorityType { get; set; }
        public bool stepAnime { get; set; }
        public bool through { get; set; }
        public int trigger { get; set; }
        public bool walkAnime { get; set; }
        public EventCommand[] list { get; set; }
    }
}
